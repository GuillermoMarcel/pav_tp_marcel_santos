Public Class frmTitularesModificacion
    Private id_titular As Integer
    Public Sub New(id_titular As Integer)
        Me.id_titular = id_titular
    End Sub

    Private t As New Titular


    Private Sub frmTitularesModificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id_titular.Text = "ID: " + id_titular.ToString
        t = DBHTitular.getTitular(id_titular)
        txt_apellido.Text = t.apellido
        txt_nombre.Text = t.nombre
        txt_cuit.Text = t.cuit.ToString
        txt_calle.Text = t.calle
        txt_altura.Text = t.altura.ToString
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
End Class