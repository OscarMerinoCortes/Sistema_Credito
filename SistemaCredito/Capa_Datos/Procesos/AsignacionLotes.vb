Imports System.Data.SqlClient
Public Class AsignacionLotes
    Public Overridable Sub ConsultarCultivo(ByRef EntidadAsignacionLotes As Capa_Entidad.AsignacionLotes)
        Dim EntidadAsignacionLotes1 As New Capa_Entidad.AsignacionLotes
        EntidadAsignacionLotes1 = EntidadAsignacionLotes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Dim cmd As New SqlCommand("sp_LisCultivo", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            EntidadAsignacionLotes1.TablaCultivos = dt
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadAsignacionLotes = EntidadAsignacionLotes1
        End Try
    End Sub
    Public Overridable Sub GuardaAsignacion(ByRef EntidadAsignacionLotes As Capa_Entidad.AsignacionLotes)
        Dim EntidadAsignacionLotes1 As New Capa_Entidad.AsignacionLotes
        EntidadAsignacionLotes1 = EntidadAsignacionLotes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsAsignacion", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdAsignacion", EntidadAsignacionLotes1.IdAsignacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdCliente", EntidadAsignacionLotes1.IdCliente))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdCultivo", EntidadAsignacionLotes1.IdCultivo))
            cmdGuardar.Parameters.Add(New SqlParameter("@Hectareas", EntidadAsignacionLotes1.IdHectareas))
            If EntidadAsignacionLotes1.IdAsignacion = 0 Then
                cmdGuardar.Parameters("@IdAsignacion").Direction = ParameterDirection.InputOutput
            End If
            cmdGuardar.ExecuteNonQuery()
            EntidadAsignacionLotes1.IdAsignacion = cmdGuardar.Parameters("@IdAsignacion").Value
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadAsignacionLotes = EntidadAsignacionLotes1
        End Try
        For Each row As DataRow In EntidadAsignacionLotes1.TablaLotesSeleccionados.Rows
                Try
                    cnn.Open()
                    cmdGuardar = New SqlCommand("sp_InsSeleccionLote", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                cmdGuardar.Parameters.Add(New SqlParameter("@IdSeleccion", 0))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdAsignacion", EntidadAsignacionLotes1.IdAsignacion))
                cmdGuardar.ExecuteNonQuery()
            Catch ex As Exception
                Finally
                    cnn.Close()
                    EntidadAsignacionLotes = EntidadAsignacionLotes1
                End Try
            Next

    End Sub
    'Private Sub InsertaSelecciones(ByRef EntidadAsignacionLotes As Capa_Entidad.AsignacionLotes)
    '    Dim EntidadAsignacionLotes1 As New Capa_Entidad.AsignacionLotes
    '    EntidadAsignacionLotes1 = EntidadAsignacionLotes
    '    Dim cnn As New SqlConnection(conexionPrincipal)
    '    Dim cmdGuardar As SqlCommand
    '    For Each row As DataRow In EntidadAsignacionLotes1.TablaLotesSeleccionados.Rows
    '        Try
    '            cnn.Open()
    '            cmdGuardar = New SqlCommand("sp_InsSeleccionLote", cnn)
    '            cmdGuardar.CommandType = CommandType.StoredProcedure
    '            cmdGuardar.Parameters.Add(New SqlParameter("@IdSeleccion", row("IdSeleccion")))
    '            cmdGuardar.Parameters.Add(New SqlParameter("@IdAsignacion", row("IdAsignacion")))

    '        Catch ex As Exception
    '        Finally
    '            cnn.Close()
    '            EntidadAsignacionLotes = EntidadAsignacionLotes1
    '        End Try
    '    Next
    'End Sub
End Class
