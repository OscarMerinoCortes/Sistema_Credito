Public Class Login
    Public Tabla As New DataTable
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        CargarUsuarios()
        Dim Username As String
        Dim Pass As String
        Username = TbUsername.Text
        Pass = TbPassword.Text
        For Each row As DataRow In Tabla.Rows
            If row("Usuario") = Username And row("Pass") = Pass Then
                _Usuario = row("Usuario")
                _TipoUsuario = row("TipoUsuario")
                _IdUsuario = row("IdTipoUsuario")
                Hide()
                MenuOpciones.Show()
                Exit Sub
            ElseIf row("Usuario") <> Username And row("Pass") = Pass Then
                LbMensaje.Text = "*Nombre de usuario incorrecto"
                Exit Sub
            ElseIf row("Usuario") = Username And row("Pass") <> Pass Then
                LbMensaje.Text = "*Contraseña incorrecta"
                Exit Sub
            End If
        Next
        LbMensaje.Text = "*Usuario inexistente"
    End Sub
    Private Sub CargarUsuarios()
        Dim EntidadUsuario As New Capa_Entidad.Usuario
        Dim NegocioUsuario As New Capa_Negocio.Usuario
        EntidadUsuario.IdTipoConsulta = 1
        NegocioUsuario.Consultar(EntidadUsuario)
        Tabla = EntidadUsuario.tabla
    End Sub
    Private _Usuario As String
    Private _TipoUsuario As String
    Private _IdUsuario As Integer
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property
    Public Property Tipo() As String
        Get
            Return _TipoUsuario
        End Get
        Set(ByVal value As String)
            _TipoUsuario = value
        End Set
    End Property
    Public Property IdUser() As String
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As String)
            _IdUsuario = value
        End Set
    End Property
    Private Sub LLCambiarContrasenia_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLCambiarContrasenia.LinkClicked
        CambiarPassword.Show()
        Hide()
    End Sub
End Class