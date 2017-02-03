Imports System.Data.SqlClient
Public Class Menu
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.Show()
    End Sub
    Private Sub ImagenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenesToolStripMenuItem.Click
        Imagen.Show()
    End Sub
End Class
