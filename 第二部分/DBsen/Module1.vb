Imports System
Imports System.Data
Module Module1
    '数据库链接参数
    Private Const strConnection As String = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=NHMFDServerDB;Data Source=(local)"
    '写入操作
    Private Function InsertInto(ByVal Connection As OleDb.OleDbConnection, ByVal strSql As String) As Integer
        Dim nRet As Integer
        If Connection.State = ConnectionState.Open Then
            Dim cmdDB As New OleDb.OleDbCommand(strSql, Connection)
            Try
                cmdDB.ExecuteNonQuery()
                nRet = 1
            Catch ex As System.Exception
                Console.WriteLine(ex.Message)
                Console.ReadLine()
                nRet = 2
            End Try
        Else
            nRet = 99
        End If
        Return nRet
    End Function
    '获取数据
    Private Function GetVal(ByVal Connection As OleDb.OleDbConnection, ByVal strSql As String,
                            ByRef objRead As OleDb.OleDbDataReader) As Integer
        Dim nRet As Integer
        If Connection.State = ConnectionState.Open Then
            Dim cmdDB As New OleDb.OleDbCommand(strSql, Connection)
            Try
                objRead = cmdDB.ExecuteReader()
                Do While objRead.Read()
                    Console.WriteLine("{0},{1},{2}", objRead.GetInt32(0), objRead.GetString(1), objRead.GetString(2))
                Loop
                Console.ReadLine()
                nRet = 1
            Catch ex As system.Exception
                Console.WriteLine(ex.Message)
                Console.ReadLine()
                nRet = 2
            End Try
        Else
            nRet = 99
        End If
        Return nRet
    End Function
    Sub Main()
        '打开数据库
        Dim objConn As New OleDb.OleDbConnection(strConnection)
        Dim bIsOpenConn As Boolean = False
        Try
            objConn.Open()
            bIsOpenConn = True
        Catch ex As System.Exception
            Console.WriteLine(ex.Message)
        End Try

        Dim strSql As String
        strSql = "INSERT INTO Veh_UsePhase (Code, Name)" &
            "VALUES ('100', 'CS')"

        'Console.Write("数据库语句为：{0}", strSql)
        'Console.ReadLine()

        'If bIsOpenConn Then
        '    If InsertInto(objConn, strSql) = 1 Then
        '        Console.WriteLine("{0}", "插入数据成功")
        '    End If
        'End If
        strSql = "select AutoID, Code, Name from Veh_UsePhase"
        Console.Write("数据库语句为：{0}", strSql)
        Console.ReadLine()

        If bIsOpenConn Then
            Dim objRead As OleDb.OleDbDataReader
            GetVal(objConn, strSql, objRead)
        End If

        Console.ReadLine()

    End Sub

End Module
