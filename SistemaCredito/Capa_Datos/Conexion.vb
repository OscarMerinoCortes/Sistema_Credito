Imports System.Data.SqlClient
Module Conexion
    Public cnn As SqlConnection
    Public consulta As SqlCommand
    Public respuesta As SqlDataReader
    Sub abrir()
        Try
            cnn = New SqlConnection("Data Source=MSISTEMAS;Initial Catalog=CREDITO;Persist Security Info=True;User ID=sa;Password=Usuario01")
            cnn.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub
End Module
