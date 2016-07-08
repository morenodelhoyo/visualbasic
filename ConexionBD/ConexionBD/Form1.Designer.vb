<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblConsultar = New System.Windows.Forms.Label()
        Me.btnCosnultarTodos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tabConsultar = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tabInsertar = New System.Windows.Forms.TabPage()
        Me.lblEstadoInsercion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnCancelarInsertar = New System.Windows.Forms.Button()
        Me.dtFechaInsertar = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDescripcionInsertar = New System.Windows.Forms.TextBox()
        Me.tbTituloInsertar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEstadoInsertar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabActualizar = New System.Windows.Forms.TabPage()
        Me.dtFechaActualizar = New System.Windows.Forms.DateTimePicker()
        Me.tbDescripcionActualizar = New System.Windows.Forms.TextBox()
        Me.tbTituloActualizar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.brnSeleccionarActualizar = New System.Windows.Forms.Button()
        Me.cmbViajesActualizar = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCargarActualizar = New System.Windows.Forms.Button()
        Me.lblEstadoActualizar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabEliminar = New System.Windows.Forms.TabPage()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCargarViajes = New System.Windows.Forms.Button()
        Me.cmbViajes = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblEstadoEliminar = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblEliminado = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsultar.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tabInsertar.SuspendLayout()
        Me.tabActualizar.SuspendLayout()
        Me.tabEliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblConsultar
        '
        Me.lblConsultar.AutoSize = True
        Me.lblConsultar.Location = New System.Drawing.Point(6, 26)
        Me.lblConsultar.Name = "lblConsultar"
        Me.lblConsultar.Size = New System.Drawing.Size(136, 13)
        Me.lblConsultar.TabIndex = 0
        Me.lblConsultar.Text = "Consultar todos los campos"
        '
        'btnCosnultarTodos
        '
        Me.btnCosnultarTodos.Location = New System.Drawing.Point(148, 16)
        Me.btnCosnultarTodos.Name = "btnCosnultarTodos"
        Me.btnCosnultarTodos.Size = New System.Drawing.Size(75, 23)
        Me.btnCosnultarTodos.TabIndex = 1
        Me.btnCosnultarTodos.Text = "Consultar"
        Me.btnCosnultarTodos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estado de la conexión"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(124, 3)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(10, 13)
        Me.lblEstado.TabIndex = 3
        Me.lblEstado.Text = "-"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(464, 224)
        Me.DataGridView1.TabIndex = 4
        '
        'tabConsultar
        '
        Me.tabConsultar.Controls.Add(Me.TabPage1)
        Me.tabConsultar.Controls.Add(Me.tabInsertar)
        Me.tabConsultar.Controls.Add(Me.tabActualizar)
        Me.tabConsultar.Controls.Add(Me.tabEliminar)
        Me.tabConsultar.Location = New System.Drawing.Point(12, 12)
        Me.tabConsultar.Name = "tabConsultar"
        Me.tabConsultar.SelectedIndex = 0
        Me.tabConsultar.Size = New System.Drawing.Size(487, 301)
        Me.tabConsultar.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.lblEstado)
        Me.TabPage1.Controls.Add(Me.btnCosnultarTodos)
        Me.TabPage1.Controls.Add(Me.lblConsultar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(479, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consultar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tabInsertar
        '
        Me.tabInsertar.Controls.Add(Me.lblEstadoInsercion)
        Me.tabInsertar.Controls.Add(Me.Label3)
        Me.tabInsertar.Controls.Add(Me.btnInsertar)
        Me.tabInsertar.Controls.Add(Me.btnCancelarInsertar)
        Me.tabInsertar.Controls.Add(Me.dtFechaInsertar)
        Me.tabInsertar.Controls.Add(Me.Label8)
        Me.tabInsertar.Controls.Add(Me.Label6)
        Me.tabInsertar.Controls.Add(Me.Label5)
        Me.tabInsertar.Controls.Add(Me.tbDescripcionInsertar)
        Me.tabInsertar.Controls.Add(Me.tbTituloInsertar)
        Me.tabInsertar.Controls.Add(Me.Label4)
        Me.tabInsertar.Controls.Add(Me.lblEstadoInsertar)
        Me.tabInsertar.Controls.Add(Me.Label2)
        Me.tabInsertar.Location = New System.Drawing.Point(4, 22)
        Me.tabInsertar.Name = "tabInsertar"
        Me.tabInsertar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInsertar.Size = New System.Drawing.Size(479, 275)
        Me.tabInsertar.TabIndex = 1
        Me.tabInsertar.Text = "Insertar"
        Me.tabInsertar.UseVisualStyleBackColor = True
        '
        'lblEstadoInsercion
        '
        Me.lblEstadoInsercion.AutoSize = True
        Me.lblEstadoInsercion.Location = New System.Drawing.Point(196, 185)
        Me.lblEstadoInsercion.Name = "lblEstadoInsercion"
        Me.lblEstadoInsercion.Size = New System.Drawing.Size(10, 13)
        Me.lblEstadoInsercion.TabIndex = 15
        Me.lblEstadoInsercion.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Estado de inserción"
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(196, 140)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 13
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnCancelarInsertar
        '
        Me.btnCancelarInsertar.Location = New System.Drawing.Point(320, 140)
        Me.btnCancelarInsertar.Name = "btnCancelarInsertar"
        Me.btnCancelarInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarInsertar.TabIndex = 12
        Me.btnCancelarInsertar.Text = "Cancelar"
        Me.btnCancelarInsertar.UseVisualStyleBackColor = True
        '
        'dtFechaInsertar
        '
        Me.dtFechaInsertar.Location = New System.Drawing.Point(196, 103)
        Me.dtFechaInsertar.Name = "dtFechaInsertar"
        Me.dtFechaInsertar.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaInsertar.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Descripción del viaje"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Título del viaje"
        '
        'tbDescripcionInsertar
        '
        Me.tbDescripcionInsertar.Location = New System.Drawing.Point(196, 76)
        Me.tbDescripcionInsertar.Name = "tbDescripcionInsertar"
        Me.tbDescripcionInsertar.Size = New System.Drawing.Size(200, 20)
        Me.tbDescripcionInsertar.TabIndex = 4
        '
        'tbTituloInsertar
        '
        Me.tbTituloInsertar.Location = New System.Drawing.Point(196, 50)
        Me.tbTituloInsertar.Name = "tbTituloInsertar"
        Me.tbTituloInsertar.Size = New System.Drawing.Size(200, 20)
        Me.tbTituloInsertar.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Todos los campos son obligatorios"
        '
        'lblEstadoInsertar
        '
        Me.lblEstadoInsertar.AutoSize = True
        Me.lblEstadoInsertar.Location = New System.Drawing.Point(124, 3)
        Me.lblEstadoInsertar.Name = "lblEstadoInsertar"
        Me.lblEstadoInsertar.Size = New System.Drawing.Size(10, 13)
        Me.lblEstadoInsertar.TabIndex = 1
        Me.lblEstadoInsertar.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Estado de la conexión"
        '
        'tabActualizar
        '
        Me.tabActualizar.Controls.Add(Me.dtFechaActualizar)
        Me.tabActualizar.Controls.Add(Me.tbDescripcionActualizar)
        Me.tabActualizar.Controls.Add(Me.tbTituloActualizar)
        Me.tabActualizar.Controls.Add(Me.Label14)
        Me.tabActualizar.Controls.Add(Me.Label13)
        Me.tabActualizar.Controls.Add(Me.Label12)
        Me.tabActualizar.Controls.Add(Me.brnSeleccionarActualizar)
        Me.tabActualizar.Controls.Add(Me.cmbViajesActualizar)
        Me.tabActualizar.Controls.Add(Me.Label11)
        Me.tabActualizar.Controls.Add(Me.btnCargarActualizar)
        Me.tabActualizar.Controls.Add(Me.lblEstadoActualizar)
        Me.tabActualizar.Controls.Add(Me.Label9)
        Me.tabActualizar.Location = New System.Drawing.Point(4, 22)
        Me.tabActualizar.Name = "tabActualizar"
        Me.tabActualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabActualizar.Size = New System.Drawing.Size(479, 275)
        Me.tabActualizar.TabIndex = 2
        Me.tabActualizar.Text = "Actualizar"
        Me.tabActualizar.UseVisualStyleBackColor = True
        '
        'dtFechaActualizar
        '
        Me.dtFechaActualizar.Location = New System.Drawing.Point(127, 198)
        Me.dtFechaActualizar.Name = "dtFechaActualizar"
        Me.dtFechaActualizar.Size = New System.Drawing.Size(346, 20)
        Me.dtFechaActualizar.TabIndex = 11
        '
        'tbDescripcionActualizar
        '
        Me.tbDescripcionActualizar.Location = New System.Drawing.Point(127, 172)
        Me.tbDescripcionActualizar.Name = "tbDescripcionActualizar"
        Me.tbDescripcionActualizar.Size = New System.Drawing.Size(346, 20)
        Me.tbDescripcionActualizar.TabIndex = 10
        '
        'tbTituloActualizar
        '
        Me.tbTituloActualizar.Location = New System.Drawing.Point(127, 145)
        Me.tbTituloActualizar.Name = "tbTituloActualizar"
        Me.tbTituloActualizar.Size = New System.Drawing.Size(346, 20)
        Me.tbTituloActualizar.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 205)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Fecha"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Descripción"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Título"
        '
        'brnSeleccionarActualizar
        '
        Me.brnSeleccionarActualizar.Location = New System.Drawing.Point(127, 111)
        Me.brnSeleccionarActualizar.Name = "brnSeleccionarActualizar"
        Me.brnSeleccionarActualizar.Size = New System.Drawing.Size(75, 23)
        Me.brnSeleccionarActualizar.TabIndex = 5
        Me.brnSeleccionarActualizar.Text = "Seleccionar viaje"
        Me.brnSeleccionarActualizar.UseVisualStyleBackColor = True
        '
        'cmbViajesActualizar
        '
        Me.cmbViajesActualizar.FormattingEnabled = True
        Me.cmbViajesActualizar.Location = New System.Drawing.Point(127, 68)
        Me.cmbViajesActualizar.Name = "cmbViajesActualizar"
        Me.cmbViajesActualizar.Size = New System.Drawing.Size(346, 21)
        Me.cmbViajesActualizar.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Listado de viajes"
        '
        'btnCargarActualizar
        '
        Me.btnCargarActualizar.Location = New System.Drawing.Point(127, 31)
        Me.btnCargarActualizar.Name = "btnCargarActualizar"
        Me.btnCargarActualizar.Size = New System.Drawing.Size(121, 23)
        Me.btnCargarActualizar.TabIndex = 2
        Me.btnCargarActualizar.Text = "Cargar viajes"
        Me.btnCargarActualizar.UseVisualStyleBackColor = True
        '
        'lblEstadoActualizar
        '
        Me.lblEstadoActualizar.AutoSize = True
        Me.lblEstadoActualizar.Location = New System.Drawing.Point(124, 3)
        Me.lblEstadoActualizar.Name = "lblEstadoActualizar"
        Me.lblEstadoActualizar.Size = New System.Drawing.Size(10, 13)
        Me.lblEstadoActualizar.TabIndex = 1
        Me.lblEstadoActualizar.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Estado de la conexión"
        '
        'tabEliminar
        '
        Me.tabEliminar.Controls.Add(Me.lblEliminado)
        Me.tabEliminar.Controls.Add(Me.Label15)
        Me.tabEliminar.Controls.Add(Me.btnEliminar)
        Me.tabEliminar.Controls.Add(Me.btnCargarViajes)
        Me.tabEliminar.Controls.Add(Me.cmbViajes)
        Me.tabEliminar.Controls.Add(Me.Label10)
        Me.tabEliminar.Controls.Add(Me.lblEstadoEliminar)
        Me.tabEliminar.Controls.Add(Me.Label7)
        Me.tabEliminar.Location = New System.Drawing.Point(4, 22)
        Me.tabEliminar.Name = "tabEliminar"
        Me.tabEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEliminar.Size = New System.Drawing.Size(479, 275)
        Me.tabEliminar.TabIndex = 3
        Me.tabEliminar.Text = "Eliminar"
        Me.tabEliminar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(127, 111)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(121, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar seleccionado"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCargarViajes
        '
        Me.btnCargarViajes.Location = New System.Drawing.Point(127, 31)
        Me.btnCargarViajes.Name = "btnCargarViajes"
        Me.btnCargarViajes.Size = New System.Drawing.Size(121, 23)
        Me.btnCargarViajes.TabIndex = 4
        Me.btnCargarViajes.Text = "Cargar viajes"
        Me.btnCargarViajes.UseVisualStyleBackColor = True
        '
        'cmbViajes
        '
        Me.cmbViajes.FormattingEnabled = True
        Me.cmbViajes.Location = New System.Drawing.Point(127, 69)
        Me.cmbViajes.Name = "cmbViajes"
        Me.cmbViajes.Size = New System.Drawing.Size(346, 21)
        Me.cmbViajes.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Listado de viajes"
        '
        'lblEstadoEliminar
        '
        Me.lblEstadoEliminar.AutoSize = True
        Me.lblEstadoEliminar.Location = New System.Drawing.Point(124, 3)
        Me.lblEstadoEliminar.Name = "lblEstadoEliminar"
        Me.lblEstadoEliminar.Size = New System.Drawing.Size(10, 13)
        Me.lblEstadoEliminar.TabIndex = 1
        Me.lblEstadoEliminar.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Estado de la conexión"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Estado del viaje:"
        '
        'lblEliminado
        '
        Me.lblEliminado.AutoSize = True
        Me.lblEliminado.Location = New System.Drawing.Point(124, 161)
        Me.lblEliminado.Name = "lblEliminado"
        Me.lblEliminado.Size = New System.Drawing.Size(58, 13)
        Me.lblEliminado.TabIndex = 7
        Me.lblEliminado.Text = "sin eliminar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 325)
        Me.Controls.Add(Me.tabConsultar)
        Me.Name = "Form1"
        Me.Text = "Mis viajes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsultar.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.tabInsertar.ResumeLayout(False)
        Me.tabInsertar.PerformLayout()
        Me.tabActualizar.ResumeLayout(False)
        Me.tabActualizar.PerformLayout()
        Me.tabEliminar.ResumeLayout(False)
        Me.tabEliminar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblConsultar As Label
    Friend WithEvents btnCosnultarTodos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tabConsultar As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tabInsertar As TabPage
    Friend WithEvents tabActualizar As TabPage
    Friend WithEvents tabEliminar As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDescripcionInsertar As TextBox
    Friend WithEvents tbTituloInsertar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEstadoInsertar As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnCancelarInsertar As Button
    Friend WithEvents dtFechaInsertar As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents lblEstadoEliminar As Label
    Friend WithEvents lblEstadoInsercion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEstadoActualizar As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbViajes As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCargarViajes As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dtFechaActualizar As DateTimePicker
    Friend WithEvents tbDescripcionActualizar As TextBox
    Friend WithEvents tbTituloActualizar As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents brnSeleccionarActualizar As Button
    Friend WithEvents cmbViajesActualizar As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCargarActualizar As Button
    Friend WithEvents lblEliminado As Label
    Friend WithEvents Label15 As Label
End Class
