Imports System.Data.SqlClient
Public Class DBHTitular

    Public Shared Function getTitulares() As DataTable
        Dim p As New QB.QueryBuilder
        p.table("Titulares").seleccionar()
        Return DBConn.executeSQL(p.build)
    End Function

    Public Shared Function getMaxID() As Integer
        Dim str As String
        Dim table As DataTable
        Dim id As Integer
        str = "select MAX(id_titular) FROM Titulares"

        table = DBConn.executeSQL(str)

        For Each row In table.Rows
            id = Convert.ToInt32((row.item(0).ToString))
        Next
        Return id
    End Function

    Public Shared Function addTitular(nombre As String, apellido As String, cuit As Long, direccion As String) As Boolean
        Dim q As New QB.QueryBuilder
        q.table("Titulares").insert({
                                    {"nombre", nombre},
                                    {"apellido", apellido},
                                    {"cuit", cuit},
                                    {"direccion", direccion}
                                })
        Return DBConn.executeOnlySQL(q.build)
    End Function

End Class
