Imports System.Data.SqlClient

Public Class SQLControl

    Public SqlCon As New SqlConnection With {.ConnectionString = "Server=SERVIDOR;Database=BD;User=USER;Pwd=PASSWORD"}
    Public SqlConsultarTodos As String = "SELECT idViaje, titulo, descripcion, fecha FROM Viajes.dbo.misviajes;"
    Public SqlConsultarID As String = "SELECT idViaje, titulo FROM Viajes.dbo.misviajes;"
    Public miDataReader As SqlDataReader

    Public Function AbrirConexion() As Boolean
        Try
            SqlCon.Open()
            Return True
        Catch ex As Exception
            MsgBox("no se pudo abrir la conexión")
            Return False
        End Try
    End Function

    Public Function CerrarConexion() As Boolean
        Try
            SqlCon.Close()
            Return True
        Catch ex As Exception
            MsgBox("no se pudo cerrar la conexión")
            Return False
        End Try
    End Function

    Public Function HasConnection() As Boolean
        Try
            SqlCon.Open()
            SqlCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.GetBaseException.ToString)
            Return False
        End Try
    End Function


End Class
