Public Class frmTitularesNuevo

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

        If DBHTitular.addTitular(txt_nombre.Text, txt_apellido.Text, cuit, txt_calle.Text, altura) Then
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

    ''' <summary>
    ''' Metodo para validar que las entradas sean correctas.
    ''' Mejor sacarlo afuera para mejorar la cohesion y disminuir el acoplamiento en un solo metodo.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function validar() As Boolean
        'El Mensaje comienza siendo vacio. Si no se modifica aprueba.
        Dim mensaje As String = String.Empty
        If txt_calle.Text = "" Then mensaje = "Debe ingresar la calle de la direccion"
        If Not IsNumeric(txt_altura.Text) Then mensaje = "La altura debe ser numerico."
        'Se valida el cuit si el chequeo de null esta desactivado.
        If Not cb_cuitnull.Checked And Not validarCuit() Then _
            mensaje = "CUIT No valido"

        If txt_apellido.Text = String.Empty Then mensaje = "Debe ingresar el apellido del titular"
        If txt_nombre.Text = String.Empty Then mensaje = "Deben ingresar el nombre del titular"

        'Si se modifico el mensaje se lo muestra y se anula la validacion
        If mensaje <> String.Empty Then
            MsgBox(mensaje)
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Funcion especifica para validar el cuit
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function validarCuit() As Boolean
        If Not txt_cuit.MaskFull Then Return False
        Dim l As Long = Long.Parse(txt_cuit.Text)
        If l.ToString.Length <> 11 Then Return False
        Return True
    End Function



    'Elimino porque el id se va a asignar solo por ser atributo identidad.
    'Private Sub frmTitularesNuevo_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    txt_id.Text = DBHTitular.getMaxID + 1
    'End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        'Me.Close()
        'Para que en vez de solo cerrarse de un resultado de como es que termino la operacion.
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cb_cuitnull_CheckedChanged(sender As Object, e As EventArgs) Handles cb_cuitnull.CheckedChanged
        txt_cuit.Enabled = Not cb_cuitnull.Checked
    End Sub
End Class