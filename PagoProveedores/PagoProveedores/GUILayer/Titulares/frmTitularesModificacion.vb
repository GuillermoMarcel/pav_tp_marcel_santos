Public Class frmTitularesModificacion
    Private id_titular As Integer
    Private t As Titular
    Public Sub New(id_titular As Integer)
        'Metodo necesario para iniciar la parte grafica
        InitializeComponent()
        Me.id_titular = id_titular
    End Sub




    Private Sub frmTitularesModificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarTodo()
        cargarDatos()
    End Sub

    Private Sub cargarDatos()
        t = DBHTitular.getTitular(id_titular)
        txt_id_titular.Text = "ID: " + t.id_titular.ToString
        txt_apellido.Text = t.apellido
        txt_nombre.Text = t.nombre
        If t.cuit = 0 Then
            cb_cuitnull.Checked = True
            txt_cuit.Text = ""

        Else
            cb_cuitnull.Checked = False
            txt_cuit.Text = t.cuit.ToString

        End If
        txt_calle.Text = t.calle
        txt_altura.Text = t.altura.ToString
        dgv_cuentas.DataSource = t.cuentas
    End Sub


    Private Sub desactivarTodo()
        'txt_altura.Enabled = False
        txt_altura.ReadOnly = True
        txt_apellido.ReadOnly = True
        txt_calle.ReadOnly = True
        txt_cuit.ReadOnly = True
        txt_nombre.ReadOnly = True
        cb_cuitnull.Enabled = False
        btn_aceptar.Enabled = False
    End Sub
    Private Sub modificar()
        txt_altura.ReadOnly = False
        txt_apellido.ReadOnly = False
        txt_calle.ReadOnly = False
        txt_cuit.ReadOnly = False
        txt_nombre.ReadOnly = False
        cb_cuitnull.Enabled = True
        btn_aceptar.Enabled = True
    End Sub

    
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        'Valido para asegurarme de que todos los datos esten correctos.
        If Not validar() Then Return

        'Valor por defecto.
        Dim cuit As Long = -1
        If Not cb_cuitnull.Checked Then
            'Como ya valide se que esto debe pasar bien.
            cuit = Long.Parse(txt_cuit.Text)
        End If

        'Como ya valide se que esto va a funcionar.
        Dim altura As Integer = Integer.Parse(txt_altura.Text)

        'Confirmo antes de modificar
        Dim mensaje As String = "¿Desea guardar el titular: " + txt_nombre.Text + ", " + txt_apellido.Text + "?"
        If MsgBox(mensaje, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question) = MsgBoxResult.No Then
            Return
        End If

        If DBHTitular.modifyTitular(id_titular, txt_nombre.Text, txt_apellido.Text, cuit, txt_calle.Text, altura) Then
            'Advierto el resultado de la operacion
            MsgBox("Exito")
            'Devuelvo resultado de la operacion. Se cierra automaticamente el formulario despues asignarle resultado.
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

        'Se encarga solo el formulario de actualizar si este devuelve un OK
        'frmTitularesConsulta.dgv_titulares.DataSource = DBHTitular.getTitulares()

        'No cierro. Si hay un error debo permitir modificar y volver enviar.
        'Me.Close()

    End Sub

    Private Function validar() As Boolean
        Return True
    End Function

    Private Sub btn_modif_Click(sender As Object, e As EventArgs) Handles btn_modif.Click
        modificar()
    End Sub

    Private Sub cb_cuitnull_CheckedChanged(sender As Object, e As EventArgs) Handles cb_cuitnull.CheckedChanged
        txt_cuit.Enabled = Not cb_cuitnull.Checked
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim f As New frmNuevaCuenta(t.id_titular)
        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            cargarDatos()
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim c As Cuenta = t.cuentas(dgv_cuentas.CurrentRow.Index)
        If DBHTitular.deleteCuenta(c.nro_cuenta, c.banco.id) Then
            MsgBox("Exito")
            cargarDatos()
        End If
    End Sub
End Class