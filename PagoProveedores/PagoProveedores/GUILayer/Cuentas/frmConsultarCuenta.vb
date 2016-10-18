Public Class frmConsultarCuenta
    Private id_titular As Integer
    Public Sub New(id_titular As Integer)
        Me.id_titular = id_titular
    End Sub

    Private Sub frmConsultarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With frmTitularesConsulta.dgv_titulares
            txt_apellido.Text = "Apellido y nombre: " & .CurrentRow.Cells.Item("apellido").Value.ToString & " " & .CurrentRow.Cells.Item("nombre").Value.ToString
            txt_cuit.Text = "CUIT:" & .CurrentRow.Cells.Item("cuit").Value.ToString
        End With
        Dim id_titular As Integer = frmTitularesConsulta.dgv_titulares.CurrentRow.Cells.Item("id_titular").Value
        dgv_cuentas.DataSource = DBHTitular.getCuentas(id_titular)

    End Sub



    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        frmNuevaCuenta.ShowDialog()
    End Sub
End Class