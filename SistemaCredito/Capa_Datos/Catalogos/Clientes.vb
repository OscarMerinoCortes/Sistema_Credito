Imports System.Data.SqlClient
Public Class Clientes
    Public Overridable Sub Upsert(ByRef EntidadClientes As Capa_Entidad.Clientes)
        Dim EntidadClientes1 As New Capa_Entidad.Clientes()
        EntidadClientes1 = EntidadClientes
        'Dim cnn As New SqlConnection()
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("PV_InsCliDet", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdCliente", EntidadClientes1.IdCliente))
            cmdGuardar.Parameters.Add(New SqlParameter("@Socio", EntidadClientes1.Socio))
            cmdGuardar.Parameters.Add(New SqlParameter("@Nombre", EntidadClientes1.Nombre))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadClientes = EntidadClientes1
        End Try
    End Sub
End Class
