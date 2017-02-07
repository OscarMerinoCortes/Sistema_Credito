Imports System.Data.SqlClient
Imports System.IO
Public Class Prerregistro
    Public TipoPersona As String
    Private Sub Prerregistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBFecha.Text = Now
        OFDPreregistro.Filter = "Todos(*.Jpg, *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"
        CBTipoPersona.SelectedText = "FISICA"
        ConsultarDocumentos()
    End Sub
    Private Sub PBFoto_Click(sender As Object, e As EventArgs) Handles PBFoto.Click
        Dim Ruta As String
        OFDPreregistro.ShowDialog()
        Ruta = OFDPreregistro.FileName.ToString
        PBFoto.Image = Image.FromFile(Ruta)
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        TBNombre.Text = ""
        TBRFC.Text = ""
        TBCURP.Text = ""
        TBTelefono.Text = ""
        TBCorreo.Text = ""
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro

        Dim arrFilename() As String = Split(Text, "\")
        Array.Reverse(arrFilename)
        Dim ms As New MemoryStream
        PBFoto.Image.Save(ms, PBFoto.Image.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer

        EntidadPreregistro.Foto = arrImage
        EntidadPreregistro.Fecha = TBFecha.Text
        EntidadPreregistro.Nombre = TBNombre.Text
        EntidadPreregistro.RFC = TBRFC.Text
        EntidadPreregistro.CURP = TBCURP.Text
        EntidadPreregistro.Telefono = TBTelefono.Text
        EntidadPreregistro.Correo = TBCorreo.Text
        NegocioPreregistro.Guardar(EntidadPreregistro)

        'Try
        '    Cn.Open()
        '    Dim arrFilename() As String = Split(Text, "\")
        '    Array.Reverse(arrFilename)
        '    Dim ms As New MemoryStream
        '    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        '    Dim arrImage() As Byte = ms.GetBuffer
        '    With Cmd
        '        .CommandType = CommandType.Text
        '        .CommandText = "Insert Into AlmacenarImagenes(Imagen)Values(@Imagen)"
        '        .Connection = Cn
        '        .Parameters.Add(New SqlParameter("@Imagen", SqlDbType.Image)).Value = arrImage
        '    End With
        '    MessageBox.Show("Registrado Correctamente")
        '    Cmd.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    Cmd.Parameters.Clear()
        '    Cn.Close()
        'End Try
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub ConsultarDocumentos()
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        Dim TablaDocumentos2 As New DataTable
        If CBTipoPersona.Text = "FISICA" Then
            TipoPersona = "F"
        Else
            TipoPersona = "M"
        End If
        EntidadPreregistro.TipoPersona = TipoPersona
        NegocioPreregistro.Consultar(EntidadPreregistro)
        TablaDocumentos2 = EntidadPreregistro.TablaDocumentos
        DGDocumentos.DataSource = TablaDocumentos2
    End Sub
    Private Sub CBTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoPersona.SelectedIndexChanged
        ConsultarDocumentos()
    End Sub
    Private Sub FormatoDGDocumentos()

    End Sub
End Class