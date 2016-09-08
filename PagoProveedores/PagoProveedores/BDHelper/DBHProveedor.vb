Public Class DBHProveedor
    Public Shared Function getProveedores() As DataTable
        Dim p As New QueryBuilder.QueryBuilder
        Dim campos As String() = {"id_proveedor", "razon_social", "cuit", "direccion", "observaciones", "deleted_at"}
        p.table("Proveedores").seleccionar()
        Return DBConn.executeSQL(p.build)
    End Function

    Public Shared Function addProveedor(razonSocial As String, cuit As Integer, direccion As String, observacion As String, telefonos As List(Of Telefono), mails As List(Of Mail)) As Boolean
        Dim p As New QueryBuilder.QueryBuilder

        Dim com(mails.Count + telefonos.Count + 2) As String


        p.table("Proveedores").insert({
                                      {"razon_social", razonSocial},
                                      {"cuit", cuit},
                                      {"direccion", direccion},
                                      {"observaciones", observacion}
                                  })
        Dim v As String = "DECLARE @ProvId INT = @@IDENTITY"

        com(1) = p.build
        com(2) = v
        Dim i As Integer = 3

        For Each t As Telefono In telefonos
            Dim b As String = "Insert into Proveedor_Telefonos (id_proveedor,telefono, observaciones)" & _
                                "values (@ProvId, '" & t.Numero & "' , '" & t.Observacion & "')"
            com(i) = b
            i += 1
        Next
        For Each m As Mail In mails
            Dim b As String = "Insert into Proveedor_Mails (id_proveedor,mail, observaciones)" & _
                                "values (@ProvId, '" & m.Direccion & "' , '" & m.Observacion & "')"
            com(i) = b
            i += 1
        Next

        Return DBConn.executeTransaction(com)

    End Function

    Public Shared Function modificarProveedor(id As Integer) As Proveedor
        Dim q As New QueryBuilder.QueryBuilder
        q.table("Proveedores").seleccionar.where("@id_proveedor", id)
        Dim b As Data.DataTable = DBConn.executeSQL(q.build)
        Dim rs As String = b.Rows(0).Item("razon_social"),
            direccion As String = b.Rows(0).Item("direccion"),
            cuit As Integer = b.Rows(0).Item("cuit"),
            observacion As String = b.Rows(0).Item("observaciones")


        Dim mails As List(Of Mail) = getMailsProveedor(id)
        Dim telefonos As List(Of Telefono) = getTelefonosProveedor(id)
       

        Dim p As New Proveedor(id, telefonos, mails)
        p.RazonSocial = rs
        p.Cuit = cuit
        p.Observacion = observacion
        p.Direccion = direccion

        Return p
    End Function

    Public Shared Function agregarMailProveedor(id As Integer, mail As String, texto As String) As List(Of Mail)
        Dim q As New QueryBuilder.QueryBuilder
        q.table("Proveedor_Mails").insert({
                                          {"id_proveedor", id},
                                          {"direccion", mail},
                                          {"observaciones", texto}
                                      })
        If DBConn.executeOnlySQL(q.build) Then
            Return getMailsProveedor(id)
        End If
        Return Nothing
    End Function

    Public Shared Function agregarTelefonoProveedor(id As Integer, numero As String, texto As String) As List(Of Telefono)
        Dim q As New QueryBuilder.QueryBuilder
        q.table("Proveedor_Telefonos").insert({
                                          {"id_proveedor", id},
                                          {"numero", numero},
                                          {"observaciones", texto}
                                      })
        If DBConn.executeOnlySQL(q.build) Then
            Return getTelefonosProveedor(id)
        End If
        Return Nothing
    End Function

    Public Shared Function getMailsProveedor(id As Integer) As List(Of Mail)
        Dim q As New QueryBuilder.QueryBuilder
        q.table("Proveedor_Mails").seleccionar.where("@id_proveedor", id)
        Dim b = DBConn.executeSQL(q.build)
        Dim mails As New List(Of Mail)
        For Each r As Data.DataRow In b.Rows
            Dim m As New Mail
            m.Direccion = r.Item("mail")
            m.Observacion = r.Item("observaciones")
            mails.Add(m)
        Next
        Return mails
    End Function

    Private Shared Function getTelefonosProveedor(id As Integer) As List(Of Telefono)
        Dim q As New QueryBuilder.QueryBuilder
        q.table("Proveedor_Telefonos").seleccionar.where("@id_proveedor", id)
        Dim b = DBConn.executeSQL(q.build)
        Dim telefonos As New List(Of Telefono)
        For Each r As Data.DataRow In b.Rows
            Dim t As New Telefono
            t.Numero = r.Item("telefono")
            t.Observacion = r.Item("observaciones")
            telefonos.Add(t)
        Next
        Return telefonos
    End Function

End Class
