'DB需要的系统库
Imports System
Imports System.Data

Module DB

    Sub Main()
        '
        Dim sConnectionStr, strSql As String
        '链接数据库操作语句
        sConnectionStr = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=NHMFDServerDB;Data Source=(local)"
        '查询DetLog表语句
        strSql = "select * from DetLog order by AutoID asc"
        ''链接数据库
        'Dim connDB As New OleDb.OleDbConnection(sConnectionStr)
        ''查询语句，默认在数据库链接成功
        'Dim cmdDB As New OleDb.OleDbCommand(strSql, connDB)
        ''获取查询信息
        'Dim drCD As OleDb.OleDbDataReader
        'connDB.Open()
        'drCD = cmdDB.ExecuteReader()
        ''显示查询的信息
        'Do While drCD.Read()
        '    Console.WriteLine(drCD.Item("RunningNumber"))
        'Loop
        Dim con As New OleDb.OleDbConnection(sConnectionStr)

        con.Open()
        Dim objDetLog As DetLogService
        objDetLog = New DetLogService()
        'Dim strRunningNum As String = ""
        'If objDetLog.GetDetLog(con, strSql, strRunningNum) = 1 Then
        '    Console.WriteLine(strRunningNum)
        'End If

        Dim AListRunNum As New ArrayList
        If objDetLog.GetDetLog(con, strSql, AListRunNum) = 1 Then
            If AListRunNum.Count >= 1 Then
                Dim n As Integer = 0
                Do While n < AListRunNum.Count
                    Console.WriteLine(AListRunNum.Item(n))
                    n += 1
                Loop
            End If

        End If

            'drCD.Close()
            con.Close()
        Console.ReadLine()

    End Sub

End Module
