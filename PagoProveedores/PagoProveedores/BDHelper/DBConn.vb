Imports System.Data.SqlClient
Public Class DBConn
    Public Shared constr As String = "Data Source=WIN-J4TA2HCGCTF\SQLEXPRESS;Initial Catalog=MILMETALDB;Persist Security Info=True;User ID=usuario;Password=pass"
    Public Shared lastex As Exception

    Public Shared Function executeSQL(SQL As String) As DataTable
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim table As New DataTable
        Try
            con.ConnectionString = constr
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SQL

            table.Load(cmd.ExecuteReader)
            Return table
        Catch ex As Exception
            MsgBox(ex.Message)
            lastex = ex
        Finally
            con.Close()

        End Try
        Return Nothing

    End Function

    Public Shared Function executeOnlySQL(sql As String) As Boolean
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = constr
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql

            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            lastex = ex
        Finally
            con.Close()

        End Try
        Return False
    End Function

    Public Shared Function executeTransaction(sqls As String()) As Boolean
        Dim final_command As String = ""
        For Each c As String In sqls
            If c <> "" Then final_command &= c & "; " & vbCrLf
        Next
        Dim connection As New SqlConnection(constr)
        Dim transaction As SqlTransaction
        connection.Open()
        Dim command As SqlCommand = connection.CreateCommand

        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted)
        command.Connection = connection
        command.Transaction = transaction
        command.CommandType = CommandType.Text
        Try
            command.CommandText = final_command
            command.ExecuteNonQuery()
            transaction.Commit()
            Return True
        Catch ex As Exception
            transaction.Rollback()
            lastex = ex
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Sub llenarTabla(sql As String, tabla As DataTable)
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = constr
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            tabla.Load(cmd.ExecuteReader)
            Return
        Catch ex As Exception
            MsgBox(ex.Message)
            lastex = ex
        Finally
            con.Close()

        End Try
        Return
    End Sub

End Class
