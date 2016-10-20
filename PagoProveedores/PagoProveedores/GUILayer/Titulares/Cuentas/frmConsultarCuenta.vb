Public Class frmConsultarCuenta
    Private id_titular As Integer
    Public Sub New(id_titular As Integer)
        'Metodo necesario para iniciar la parte grafica
        InitializeComponent()
        Me.id_titular = id_titular
    End Sub

    Private Sub frmConsultarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargardatos()
    End Sub
    Private Sub cargardatos()
        Dim t As Titular = DBHTitular.getTitular(id_titular)
        txt_apellido.Text = "Apellido y nombre: " & t.nombre
        txt_cuit.Text = "CUIT:" & t.cuit
        dgv_cuentas.DataSource = DBHTitular.getCuentas(id_titular)
    End Sub


    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim f As New frmNuevaCuenta(id_titular)
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            cargardatos()
        End If
    End Sub
End Class