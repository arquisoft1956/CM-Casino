<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consumos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnBuscarConsumo = New System.Windows.Forms.Button
        Me.GridViewConsumos = New System.Windows.Forms.DataGridView
        Me.idConsumo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DTPFechaHasta = New System.Windows.Forms.DateTimePicker
        Me.BtnBorrar = New System.Windows.Forms.Button
        Me.BtnCerrar = New System.Windows.Forms.Button
        Me.LabSubMensaje = New System.Windows.Forms.Label
        Me.LabNombre = New System.Windows.Forms.Label
        Me.LabNombre2 = New System.Windows.Forms.Label
        CType(Me.GridViewConsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscarConsumo
        '
        Me.BtnBuscarConsumo.Location = New System.Drawing.Point(265, 29)
        Me.BtnBuscarConsumo.Name = "BtnBuscarConsumo"
        Me.BtnBuscarConsumo.Size = New System.Drawing.Size(82, 29)
        Me.BtnBuscarConsumo.TabIndex = 0
        Me.BtnBuscarConsumo.Text = "Buscar"
        Me.BtnBuscarConsumo.UseVisualStyleBackColor = True
        '
        'GridViewConsumos
        '
        Me.GridViewConsumos.AllowUserToAddRows = False
        Me.GridViewConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewConsumos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idConsumo, Me.Fecha, Me.Nombre, Me.Descripcion, Me.sel})
        Me.GridViewConsumos.Location = New System.Drawing.Point(12, 81)
        Me.GridViewConsumos.Name = "GridViewConsumos"
        Me.GridViewConsumos.Size = New System.Drawing.Size(557, 361)
        Me.GridViewConsumos.TabIndex = 1
        '
        'idConsumo
        '
        Me.idConsumo.HeaderText = "Id"
        Me.idConsumo.Name = "idConsumo"
        Me.idConsumo.Width = 50
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 150
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'sel
        '
        Me.sel.HeaderText = "Borrar"
        Me.sel.Name = "sel"
        '
        'DTPFechaHasta
        '
        Me.DTPFechaHasta.Location = New System.Drawing.Point(41, 31)
        Me.DTPFechaHasta.Name = "DTPFechaHasta"
        Me.DTPFechaHasta.Size = New System.Drawing.Size(200, 20)
        Me.DTPFechaHasta.TabIndex = 3
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(154, 476)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(105, 33)
        Me.BtnBorrar.TabIndex = 6
        Me.BtnBorrar.Text = "Borrar Consumos"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(308, 476)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(94, 33)
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'LabSubMensaje
        '
        Me.LabSubMensaje.AutoSize = True
        Me.LabSubMensaje.Location = New System.Drawing.Point(9, 519)
        Me.LabSubMensaje.Name = "LabSubMensaje"
        Me.LabSubMensaje.Size = New System.Drawing.Size(19, 13)
        Me.LabSubMensaje.TabIndex = 8
        Me.LabSubMensaje.Text = "__"
        '
        'LabNombre
        '
        Me.LabNombre.AutoSize = True
        Me.LabNombre.Location = New System.Drawing.Point(38, 9)
        Me.LabNombre.Name = "LabNombre"
        Me.LabNombre.Size = New System.Drawing.Size(50, 13)
        Me.LabNombre.TabIndex = 9
        Me.LabNombre.Text = "Nombre :"
        '
        'LabNombre2
        '
        Me.LabNombre2.AutoSize = True
        Me.LabNombre2.Location = New System.Drawing.Point(94, 9)
        Me.LabNombre2.Name = "LabNombre2"
        Me.LabNombre2.Size = New System.Drawing.Size(22, 13)
        Me.LabNombre2.TabIndex = 10
        Me.LabNombre2.Text = "     "
        '
        'Consumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 541)
        Me.Controls.Add(Me.LabNombre2)
        Me.Controls.Add(Me.LabNombre)
        Me.Controls.Add(Me.LabSubMensaje)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.DTPFechaHasta)
        Me.Controls.Add(Me.GridViewConsumos)
        Me.Controls.Add(Me.BtnBuscarConsumo)
        Me.Name = "Consumos"
        Me.Text = "Consumos"
        CType(Me.GridViewConsumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuscarConsumo As System.Windows.Forms.Button
    Friend WithEvents GridViewConsumos As System.Windows.Forms.DataGridView
    Friend WithEvents DTPFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents LabSubMensaje As System.Windows.Forms.Label
    Friend WithEvents LabNombre As System.Windows.Forms.Label
    Friend WithEvents LabNombre2 As System.Windows.Forms.Label
    Friend WithEvents idConsumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
