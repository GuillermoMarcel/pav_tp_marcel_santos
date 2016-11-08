Public Class DBHCheque
    Public Shared Function addCheque(nro_cheque As Integer,
                                     monto As Decimal,
                                     fecha_emision As Date,
                                     fecna_vencimiento As Date,
                                     cruzado As Boolean,
                                     observacion As String,
                                      cuenta As Cuenta)
        Dim q As New QB.QueryBuilder
        'Insert de cheque en estado "Disponible" que tiene id 1
        q.table("Cheques").insert({
                                  {"nro_cheque", nro_cheque},
                                  {"monto", monto},
                                  {"nro_cuenta", cuenta.NroCuenta},
                                  {"nro_banco", cuenta.Banco.id},
                                  {"fecha_emision", fecha_emision},
                                  {"fecha_vencimiento", fecna_vencimiento},
                                  {"cruzado", DBUtils.BooleanToDB(cruzado)},
                                  {"observacion", observacion},
                                  {"id_estado", 1}
                              })

        Return DBConn.executeOnlySQL(q.build)
    End Function

    Public Shared Function getChequesCartera() As List(Of Cheque)
        'Dim q As New QB.QueryBuilder
        Dim cheques As New List(Of Cheque)
        ' q.table("Cheques").seleccionar({"nro_cheque Cheque",
        '      "fecha_vencimiento Vencimiento", "monto Monto"}).
        '   join("Bancos", "nro_banco", {"nombre Nombre"}).
        '   join("Cuentas", {"nro_cuenta Cuenta"}, "nro_cuenta").
        '   join("Titulares", {"Apellido"},Nothing,
        ' where("@id_estado", 1)

        Dim str As String
        str = "SELECT c.fecha_vencimiento as Vencimiento, "
        str += "c.nro_cheque as Cheque, "
        str += "(t.Apellido+ ', ' +t.Nombre) as ApellidoNombre, "
        str += "b.nombre as Banco, "
        str += "c.monto as Monto, "
        str += "c. nro_banco, c.nro_cuenta "
        str += "From Cheques c join  Bancos b on c.nro_banco = b.nro_banco "
        str += "Join Cuentas on Cuentas.nro_cuenta = c.nro_cuenta "
        str += "Join Titulares t on t.id_titular = Cuentas.id_titular "
        str += "Where c.id_estado = 1"

        Dim t As DataTable = DBConn.executeSQL(str)
        If t.Rows.Count = 0 Then Throw New Exception("No se encontraron cheques en cartera")

        For Each row As DataRow In t.Rows
            Dim c As New Cheque
            c = map(row)
            cheques.Add(c)
        Next

        Return cheques
    End Function

    Private Shared Function map(row As DataRow) As Cheque
        Dim c As New Cheque
        c.Numero = Convert.ToInt32(row.Item("Cheque").ToString)
        c.Titular = row.Item("ApellidoNombre").ToString
        c.Monto = Decimal.Parse(row.Item("Monto").ToString)
        c.FechaVencimiento = Date.Parse(row.Item("Vencimiento").ToString)
        c.Banco = row.Item("Banco").ToString
        c.NroBanco = Integer.Parse(row.Item("nro_banco"))
        c.NroCuenta = row.Item("nro_cuenta")

        Return c
    End Function

    Public Shared Function getCheques() As DataTable
        Dim str As String
        str = "SELECT c.fecha_vencimiento as Vencimiento, "
        str += "c.nro_cheque as Cheque, "
        str += "(t.Apellido+ ', ' +t.Nombre) as Titular, "
        str += "b.nombre as Banco, "
        str += "c.monto as Monto, "
        str += "e.nombre Estado "
        str += "From Cheques c join  Bancos b on c.nro_banco = b.nro_banco "
        str += "Join Cuentas on Cuentas.nro_cuenta = c.nro_cuenta "
        str += "Join Titulares t on t.id_titular = Cuentas.id_titular "
        str += "Join EstadosCheques e on c.id_Estado = e.id_estado "
        str += "Order by c.id_estado asc, c.fecha_vencimiento asc"

        Return DBConn.executeSQL(str)
    End Function

End Class
