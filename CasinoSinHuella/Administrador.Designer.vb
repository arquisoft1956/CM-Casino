<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FotosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Gr_BoxBorrar = New System.Windows.Forms.GroupBox
        Me.Lab_rut = New System.Windows.Forms.Label
        Me.Txt_Dvrut = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txt_Rut = New System.Windows.Forms.TextBox
        Me.Btn_Borrar = New System.Windows.Forms.Button
        Me.Opt_Huella = New System.Windows.Forms.RadioButton
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Btn_Fotos = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewImageColumn
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Gr_BoxBorrar.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(986, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarToolStripMenuItem, Me.FotosToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'FotosToolStripMenuItem
        '
        Me.FotosToolStripMenuItem.Name = "FotosToolStripMenuItem"
        Me.FotosToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.FotosToolStripMenuItem.Text = "Fotos"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(986, 645)
        Me.TabControl1.TabIndex = 3
        Me.TabControl1.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Gr_BoxBorrar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(978, 616)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Borrar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Gr_BoxBorrar
        '
        Me.Gr_BoxBorrar.Controls.Add(Me.Lab_rut)
        Me.Gr_BoxBorrar.Controls.Add(Me.Txt_Dvrut)
        Me.Gr_BoxBorrar.Controls.Add(Me.Label1)
        Me.Gr_BoxBorrar.Controls.Add(Me.Txt_Rut)
        Me.Gr_BoxBorrar.Controls.Add(Me.Btn_Borrar)
        Me.Gr_BoxBorrar.Controls.Add(Me.Opt_Huella)
        Me.Gr_BoxBorrar.Location = New System.Drawing.Point(16, 17)
        Me.Gr_BoxBorrar.Name = "Gr_BoxBorrar"
        Me.Gr_BoxBorrar.Size = New System.Drawing.Size(159, 186)
        Me.Gr_BoxBorrar.TabIndex = 2
        Me.Gr_BoxBorrar.TabStop = False
        Me.Gr_BoxBorrar.Text = "Borrar"
        '
        'Lab_rut
        '
        Me.Lab_rut.AutoSize = True
        Me.Lab_rut.Location = New System.Drawing.Point(14, 68)
        Me.Lab_rut.Name = "Lab_rut"
        Me.Lab_rut.Size = New System.Drawing.Size(91, 13)
        Me.Lab_rut.TabIndex = 6
        Me.Lab_rut.Text = "Rut de la persona"
        '
        'Txt_Dvrut
        '
        Me.Txt_Dvrut.Enabled = False
        Me.Txt_Dvrut.Location = New System.Drawing.Point(116, 83)
        Me.Txt_Dvrut.MaxLength = 1
        Me.Txt_Dvrut.Name = "Txt_Dvrut"
        Me.Txt_Dvrut.Size = New System.Drawing.Size(26, 20)
        Me.Txt_Dvrut.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = " - "
        '
        'Txt_Rut
        '
        Me.Txt_Rut.Location = New System.Drawing.Point(18, 84)
        Me.Txt_Rut.MaxLength = 8
        Me.Txt_Rut.Name = "Txt_Rut"
        Me.Txt_Rut.Size = New System.Drawing.Size(78, 20)
        Me.Txt_Rut.TabIndex = 3
        '
        'Btn_Borrar
        '
        Me.Btn_Borrar.Enabled = False
        Me.Btn_Borrar.Location = New System.Drawing.Point(46, 121)
        Me.Btn_Borrar.Name = "Btn_Borrar"
        Me.Btn_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Borrar.TabIndex = 2
        Me.Btn_Borrar.Text = "Borrar"
        Me.Btn_Borrar.UseVisualStyleBackColor = True
        '
        'Opt_Huella
        '
        Me.Opt_Huella.AutoSize = True
        Me.Opt_Huella.Location = New System.Drawing.Point(17, 34)
        Me.Opt_Huella.Name = "Opt_Huella"
        Me.Opt_Huella.Size = New System.Drawing.Size(91, 17)
        Me.Opt_Huella.TabIndex = 0
        Me.Opt_Huella.TabStop = True
        Me.Opt_Huella.Text = "Borrar Huellas"
        Me.Opt_Huella.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ProgressBar1)
        Me.TabPage3.Controls.Add(Me.Btn_Fotos)
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(978, 616)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Fotos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(19, 584)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(860, 24)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 2
        '
        'Btn_Fotos
        '
        Me.Btn_Fotos.Location = New System.Drawing.Point(19, 27)
        Me.Btn_Fotos.Name = "Btn_Fotos"
        Me.Btn_Fotos.Size = New System.Drawing.Size(98, 23)
        Me.Btn_Fotos.TabIndex = 1
        Me.Btn_Fotos.Text = "Copilar Fotos"
        Me.Btn_Fotos.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 60
        Me.DataGridView1.Size = New System.Drawing.Size(860, 505)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Foto 1"
        Me.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Foto 2"
        Me.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Foto 3"
        Me.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "Foto 4"
        Me.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "Foto 5"
        Me.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 80
        '
        'Column6
        '
        Me.Column6.HeaderText = "Foto 6"
        Me.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "Foto 7"
        Me.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "Foto 8"
        Me.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 80
        '
        'Column9
        '
        Me.Column9.HeaderText = "Foto 9"
        Me.Column9.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 80
        '
        'Column10
        '
        Me.Column10.HeaderText = "Foto 10"
        Me.Column10.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 80
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 669)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Gr_BoxBorrar.ResumeLayout(False)
        Me.Gr_BoxBorrar.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Gr_BoxBorrar As System.Windows.Forms.GroupBox
    Friend WithEvents Lab_rut As System.Windows.Forms.Label
    Friend WithEvents Txt_Dvrut As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Rut As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents Opt_Huella As System.Windows.Forms.RadioButton
    Friend WithEvents FotosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Fotos As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewImageColumn
End Class
