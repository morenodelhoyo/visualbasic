Imports System.Data.SqlClient

Public Class Form1
    Dim SQL As New SQLControl

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Estados iniciales para informar al usuario
        lblEstadoInsercion.Text = " Sin insertar"
        lblEstado.Text = " cerrada"
        lblEstadoInsertar.Text = " cerrada"
        lblEstadoEliminar.Text = " cerrada"
        'Formato específico para los DateTimePicker, dejando seleccionar la fecha y hora.
        dtFechaInsertar.Format = DateTimePickerFormat.Custom
        dtFechaInsertar.CustomFormat = "dd-MM-yyyy HH:mm:ss"
        dtFechaActualizar.Format = DateTimePickerFormat.Custom
        dtFechaActualizar.CustomFormat = "dd-MM-yyyy HH:mm:ss"
    End Sub

    Private Sub llenarGrid()
        'Se obtienen los datos para llenar el grid con los viajes de la BD.
        Dim miDataSet As New DataSet
        Dim miDataTable As New DataTable
        Dim miDataAdapter As New SqlDataAdapter(SQL.SqlConsultarTodos, SQL.SqlCon)

        miDataSet.Tables.Add("misviajes")
        miDataAdapter.Fill(miDataSet.Tables("misviajes"))
        DataGridView1.DataSource = miDataSet.Tables("misviajes")
    End Sub

    Private Sub insertardatos(ByVal titulo As String, ByVal descripcion As String, ByVal fecha As String)
        'Se permite insertar un nuevo viaje a partir de los datos insertados en el formulario.
        Dim midataadapter As New SqlDataAdapter(SQL.SqlConsultarTodos, SQL.SqlCon)
        Dim sqlCmd As New SqlCommand
        Dim SqlInsertar As String = "INSERT INTO Viajes.dbo.misviajes (titulo, descripcion, fecha) VALUES ('" & titulo & "', '" & descripcion & "','" & fecha & "');"

        sqlCmd.CommandType = CommandType.Text
        sqlCmd.Connection = SQL.SqlCon
        sqlCmd.CommandText = SqlInsertar

        Try
            sqlCmd.ExecuteNonQuery()
            lblEstadoInsercion.Text = " insertado con éxito"
        Catch ex As Exception
            MsgBox(ex.Message)
            lblEstadoInsercion.Text = " error de inserción"
        End Try

    End Sub

    Private Sub btnCosnultarTodos_Click(sender As Object, e As EventArgs) Handles btnCosnultarTodos.Click
        'Botón para mostrar los viajes.
        If (SQL.AbrirConexion()) Then
            lblEstado.Text = " establecida"
            llenarGrid()

        End If
        SQL.CerrarConexion()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        'Botón de inserción de un nuevo viaje.
        Dim titulo As String = tbTituloInsertar.Text
        Dim descripcion As String = tbDescripcionInsertar.Text
        'Formateo de la fecha para enviar a la BD.
        Dim mifecha As Date = "#" + dtFechaInsertar.Text + "#"
        Dim fecha As String = Format(mifecha, "dd-MM-yyyy HH:mm:ss")

        Dim flagTitulo, flagDesc As Boolean
        flagTitulo = True
        flagDesc = True

        If (titulo = "") Then
            MsgBox("El campo título no puede estar vacío", MsgBoxStyle.Critical, "Error")
            tbTituloInsertar.Select()
            flagTitulo = False
        End If
        If (flagTitulo And descripcion = "") Then
            MsgBox("El campo descripcion no puede estar vacío", MsgBoxStyle.Critical, "Error")
            tbDescripcionInsertar.Select()
            flagDesc = False
        End If

        If (SQL.AbrirConexion() And flagTitulo And flagDesc) Then
            lblEstadoInsertar.Text = " establecida"
            insertardatos(titulo, descripcion, DateString + " " + TimeString)
        End If
        SQL.CerrarConexion()
    End Sub

    Private Sub btnCargarViajes_Click(sender As Object, e As EventArgs) Handles btnCargarViajes.Click
        cargarViajes("eliminar")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Botón para eliminar el viaje seleccionado.
        MsgBox("Se eliminará el viaje seleccionado", MsgBoxStyle.Information)
        Dim seleccionado As Integer = cmbViajes.SelectedValue
        Dim sqlComm As New SqlCommand
        Dim miReader As SqlDataReader
        Dim SqlConsultarID As String = "DELETE FROM Viajes.dbo.misviajes WHERE IdViaje = " & seleccionado & ";"

        If (SQL.AbrirConexion()) Then
            sqlComm.CommandText = SqlConsultarID
            sqlComm.CommandType = CommandType.Text
            sqlComm.Connection = SQL.SqlCon
            miReader = sqlComm.ExecuteReader()

            lblEliminado.Text = " eliminado con éxito"

            SQL.CerrarConexion()
        End If
    End Sub

    Private Sub btnCargarActualizar_Click(sender As Object, e As EventArgs) Handles btnCargarActualizar.Click
        'Botón para cargar los viajes.
        cargarViajes("cargar")
    End Sub


    Private Sub cargarViajes(ByVal lugar As String)
        'Función que permite cargar los viajes. Depende del estado (eliminar o cargar)
        Dim dataTable As DataTable = New DataTable("viajes")
        Dim sqlComm As New SqlCommand
        Dim miReader As SqlDataReader
        Dim dataRow As DataRow

        dataTable.Columns.Add("idViaje")
        dataTable.Columns.Add("titulo")

        If (SQL.AbrirConexion()) Then
            If (lugar.Contains("cargar")) Then
                lblEstadoActualizar.Text = " establecida"
            Else
                lblEstadoEliminar.Text = " establecida"
            End If

            sqlComm.CommandText = SQL.SqlConsultarID
            sqlComm.CommandType = CommandType.Text
            sqlComm.Connection = SQL.SqlCon

            miReader = sqlComm.ExecuteReader()

            If (miReader.HasRows) Then
                While (miReader.Read)
                    dataRow = dataTable.NewRow()
                    dataRow("idViaje") = miReader("idViaje")
                    dataRow("titulo") = miReader("idViaje").ToString + " " + miReader("titulo").ToString
                    dataTable.Rows.Add(dataRow)
                End While
            End If
            SQL.CerrarConexion()
        Else
            dataRow = dataTable.NewRow()
            dataRow("idViaje") = -1
            dataRow("titulo") = " -"
            dataTable.Rows.Add(dataRow)
        End If
        If (lugar.Contains("cargar")) Then
            cmbViajesActualizar.DataSource = dataTable
            cmbViajesActualizar.ValueMember = "idViaje"
            cmbViajesActualizar.DisplayMember = "titulo"
        Else
            cmbViajes.DataSource = dataTable
            cmbViajes.ValueMember = "idViaje"
            cmbViajes.DisplayMember = "titulo"
        End If

    End Sub

    Private Sub brnSeleccionarActualizar_Click(sender As Object, e As EventArgs) Handles brnSeleccionarActualizar.Click
        'Botón para obtener los datos del viaje seleccionado.
        Dim seleccionado As Integer = cmbViajesActualizar.SelectedValue
        Dim sqlComm As New SqlCommand
        Dim miReader As SqlDataReader
        Dim SqlConsultarID As String = "SELECT titulo, descripcion, fecha FROM Viajes.dbo.misviajes WHERE IdViaje = " & seleccionado & ";"

        If (SQL.AbrirConexion()) Then
            sqlComm.CommandText = SqlConsultarID
            sqlComm.CommandType = CommandType.Text
            sqlComm.Connection = SQL.SqlCon
            miReader = sqlComm.ExecuteReader()

            If (miReader.HasRows) Then
                While (miReader.Read)
                    tbTituloActualizar.Text = miReader("titulo")
                    tbDescripcionActualizar.Text = miReader("descripcion")
                    dtFechaActualizar.Text = Convert.ToDateTime(miReader("fecha").ToString)
                End While
            End If
            SQL.CerrarConexion()
            End If

    End Sub

End Class
