﻿Public Class Clientes
    Public Overridable Sub Guardar(ByRef EntidadClientes As Capa_Entidad.Clientes)
        Dim EntidadClientes1 As New Capa_Entidad.Clientes()
        Dim DatosClientes As New Capa_Datos.Clientes()
        EntidadClientes1 = EntidadClientes
        DatosClientes.Upsert(EntidadClientes1)
    End Sub
End Class
