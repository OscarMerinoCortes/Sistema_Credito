Public Class CambiarPassword
    Public Tabla As New DataTable
    Private Sub CambiarPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        Dim EntidadCambiarPassword As New Capa_Entidad.CambiarPassword
        Dim NegocioCambiarPassword As New Capa_Negocio.CambiarPassword
        Dim Username As String
        Dim Pass As String
        Username = TbUsuario.Text
        Pass = TbPassActual.Text
        For Each row As DataRow In Tabla.Rows
            If row("Usuario") = TbUsuario.Text Then
                If row("Pass") = TbPassActual.Text Then
                    If TbNuevaPass.Text = TbConfNuevaPass.Text Then
                        EntidadCambiarPassword.Usuario = Username
                        EntidadCambiarPassword.Password = TbNuevaPass.Text
                        NegocioCambiarPassword.Actualizar(EntidadCambiarPassword)
                        MsgBox("Contraseña actualizada correctamente", MsgBoxStyle.OkOnly, "Aviso")
                        Limpiar()
                        Hide()
                        Login.Show()
                        Exit Sub
                    Else
                        MsgBox("La nueva contraseña no coincide", MsgBoxStyle.OkOnly, "Aviso")
                        Exit Sub
                    End If
                Else
                    MsgBox("La contraseña actual es incorrecta", MsgBoxStyle.OkOnly, "Aviso")
                    Exit Sub
                End If
            End If
        Next
        MsgBox("Usuario inexistente", MsgBoxStyle.OkOnly, "Aviso")
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
        Login.Show()
    End Sub
    Private Sub CargarUsuarios()
        Dim EntidadUsuario As New Capa_Entidad.Usuario
        Dim NegocioUsuario As New Capa_Negocio.Usuario
        EntidadUsuario.IdTipoConsulta = 1
        NegocioUsuario.Consultar(EntidadUsuario)
        Tabla = EntidadUsuario.tabla
    End Sub
    Private Sub Limpiar()
        TbUsuario.Text = ""
        TbPassActual.Text = ""
        TbNuevaPass.Text = ""
        TbConfNuevaPass.Text = ""
    End Sub
End Class