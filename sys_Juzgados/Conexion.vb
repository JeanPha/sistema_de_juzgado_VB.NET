Module Conexion
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader
    Public conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-4DU3JSJ\SQLEXPRESS;Initial Catalog=EJER5;Integrated Security=false ;user id=sa;password=12345")
    Public Sub conectar() 'FUNCION PARA ABRIR LA CONEXION
        Try
            conexion.Open()
            cmd.Connection = conexion
        Catch ex As Exception
            MsgBox("Error al conectar con el servidor.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module
