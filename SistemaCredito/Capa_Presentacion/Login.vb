Public Class Login
    Public Tabla As New DataTable
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim Username As String
        Dim Pass As String
        Username = TbUsername.Text
        Pass = TbPassword.Text
        For Each row As DataRow In Tabla.Rows
            If row("Usuario") = Username And row("Pass") = Pass Then
                Hide()
                MenuOpciones.Show()
            End If
        Next
    End Sub
    Private Sub CargarUsuarios()
        Dim EntidadUsuario As New Capa_Entidad.Usuario
        Dim NegocioUsuario As New Capa_Negocio.Usuario
        EntidadUsuario.IdTipoConsulta = 1
        NegocioUsuario.Consultar(EntidadUsuario)
        Tabla = EntidadUsuario.tabla
    End Sub
End Class