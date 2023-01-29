Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
    End Sub

    Private Sub tUsuario_TextChanged(sender As Object, e As EventArgs) Handles tUsuario.TextChanged
        tUsuario.Text = tUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "")
    End Sub

    Private Sub tClave_TextChanged(sender As Object, e As EventArgs) Handles tClave.TextChanged
        tClave.Text = tClave.Text.Replace("'", "").Replace(" ", "").Replace("""", "")
    End Sub

    Private Sub bEntrar_Click(sender As Object, e As EventArgs) Handles bEntrar.Click
        Try

            If usuarioRegistrado(tUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "") = True) Then 'recibe un usuario, si está
                Dim contra As String = clave(tUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", ""))
                If contra.Equals(tClave.Text.Replace("'", "").Replace(" ", "").Replace("""", "")) = True Then 'corrobora que la contra sea correcta la contraseña
                    MsgBox("Bienvenido/a: " + Me.tUsuario.Text)
                    My.Forms.Menu_Principal.Visible = True 'si está bien entonces muestra mi menú 
                    Me.Visible = False
                Else
                    MsgBox("Contraseña incorrecta. Por favor, revise que esté bien escrita", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("El usuario: " + tUsuario.Text + "no se encuentra registrado.")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString) 'pa q me muestre el error
        End Try


    End Sub

End Class