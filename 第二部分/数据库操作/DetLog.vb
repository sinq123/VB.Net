Imports System
Imports System.Data

Public Class DetLogService
    Public Function GetDetLog(ByVal Con As OleDb.OleDbConnection, ByVal strSql As String,
                              ByRef strRunningNumber As String) As Integer
        Dim iRetutn As Integer = 0
        Try
            Dim cmdDB As New OleDb.OleDbCommand(strSql, Con)
            Dim drCD As OleDb.OleDbDataReader
            drCD = cmdDB.ExecuteReader()
            If drCD.Read() Then
                strRunningNumber = drCD.Item("RunningNumber")
                iRetutn = 1
            Else
                iRetutn = 2
            End If
        Catch ex As Exception
            iRetutn = 3
        End Try

        Return iRetutn
    End Function

    Public Function GetDetLog(ByVal Con As OleDb.OleDbConnection, ByVal strSql As String,
                              ByRef AListRunNum As ArrayList) As Integer
        Dim iRetutn As Integer = 0
        Try
            Dim cmdDB As New OleDb.OleDbCommand(strSql, Con)
            Dim drCD As OleDb.OleDbDataReader
            drCD = cmdDB.ExecuteReader()
            Do While drCD.Read()
                AListRunNum.Add(drCD.Item("RunningNumber"))
                iRetutn = 1
            Loop
        Catch ex As Exception
            iRetutn = 3
        End Try

        Return iRetutn
    End Function

End Class
