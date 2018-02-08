<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contador
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ConsumoPorMes = New System.Windows.Forms.TabPage
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GrBox_Fecha = New System.Windows.Forms.GroupBox
        Me.Btn_Buscar = New System.Windows.Forms.Button
        Me.Lab_Mes = New System.Windows.Forms.Label
        Me.Lab_Año = New System.Windows.Forms.Label
        Me.Txt_Mes = New System.Windows.Forms.TextBox
        Me.Txt_Año = New System.Windows.Forms.TextBox
        Me.CentroCosto = New System.Windows.Forms.TabPage
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GrBox_Centrocosto = New System.Windows.Forms.GroupBox
        Me.Lab_Sindicalizados = New System.Windows.Forms.Label
        Me.CbBox_Sindicalizados = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txt_MesCentroCosto = New System.Windows.Forms.TextBox
        Me.Txt_AñoCentroCosto = New System.Windows.Forms.TextBox
        Me.CbBox_CentroCosto = New System.Windows.Forms.ComboBox
        Me.Lab_centrocosto = New System.Windows.Forms.Label
        Me.Btn_buscarCentrocosto = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.ConsumoPorMes.SuspendLayout()
        Me.GrBox_Fecha.SuspendLayout()
        Me.CentroCosto.SuspendLayout()
        Me.GrBox_Centrocosto.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.ConsumoPorMes)
        Me.TabControl1.Controls.Add(Me.CentroCosto)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(986, 669)
        Me.TabControl1.TabIndex = 2
        '
        'ConsumoPorMes
        '
        Me.ConsumoPorMes.Controls.Add(Me.CrystalReportViewer1)
        Me.ConsumoPorMes.Controls.Add(Me.GrBox_Fecha)
        Me.ConsumoPorMes.Location = New System.Drawing.Point(4, 25)
        Me.ConsumoPorMes.Name = "ConsumoPorMes"
        Me.ConsumoPorMes.Padding = New System.Windows.Forms.Padding(3)
        Me.ConsumoPorMes.Size = New System.Drawing.Size(978, 640)
        Me.ConsumoPorMes.TabIndex = 0
        Me.ConsumoPorMes.Text = "Consumos Por Mes"
        Me.ConsumoPorMes.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 100)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(972, 515)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'GrBox_Fecha
        '
        Me.GrBox_Fecha.Controls.Add(Me.Btn_Buscar)
        Me.GrBox_Fecha.Controls.Add(Me.Lab_Mes)
        Me.GrBox_Fecha.Controls.Add(Me.Lab_Año)
        Me.GrBox_Fecha.Controls.Add(Me.Txt_Mes)
        Me.GrBox_Fecha.Controls.Add(Me.Txt_Año)
        Me.GrBox_Fecha.Location = New System.Drawing.Point(6, 15)
        Me.GrBox_Fecha.Name = "GrBox_Fecha"
        Me.GrBox_Fecha.Size = New System.Drawing.Size(276, 79)
        Me.GrBox_Fecha.TabIndex = 2
        Me.GrBox_Fecha.TabStop = False
        Me.GrBox_Fecha.Text = "Fecha"
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Location = New System.Drawing.Point(179, 30)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Buscar.TabIndex = 4
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'Lab_Mes
        '
        Me.Lab_Mes.AutoSize = True
        Me.Lab_Mes.Location = New System.Drawing.Point(25, 48)
        Me.Lab_Mes.Name = "Lab_Mes"
        Me.Lab_Mes.Size = New System.Drawing.Size(33, 13)
        Me.Lab_Mes.TabIndex = 3
        Me.Lab_Mes.Text = "Mes :"
        '
        'Lab_Año
        '
        Me.Lab_Año.AutoSize = True
        Me.Lab_Año.Location = New System.Drawing.Point(26, 22)
        Me.Lab_Año.Name = "Lab_Año"
        Me.Lab_Año.Size = New System.Drawing.Size(32, 13)
        Me.Lab_Año.TabIndex = 2
        Me.Lab_Año.Text = "Año :"
        '
        'Txt_Mes
        '
        Me.Txt_Mes.Location = New System.Drawing.Point(64, 45)
        Me.Txt_Mes.Name = "Txt_Mes"
        Me.Txt_Mes.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Mes.TabIndex = 1
        '
        'Txt_Año
        '
        Me.Txt_Año.Location = New System.Drawing.Point(64, 19)
        Me.Txt_Año.Name = "Txt_Año"
        Me.Txt_Año.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Año.TabIndex = 0
        '
        'CentroCosto
        '
        Me.CentroCosto.Controls.Add(Me.CrystalReportViewer2)
        Me.CentroCosto.Controls.Add(Me.GrBox_Centrocosto)
        Me.CentroCosto.Location = New System.Drawing.Point(4, 25)
        Me.CentroCosto.Name = "CentroCosto"
        Me.CentroCosto.Padding = New System.Windows.Forms.Padding(3)
        Me.CentroCosto.Size = New System.Drawing.Size(978, 640)
        Me.CentroCosto.TabIndex = 1
        Me.CentroCosto.Text = "Consumo por Centro Costo"
        Me.CentroCosto.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(8, 122)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.SelectionFormula = ""
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(970, 510)
        Me.CrystalReportViewer2.TabIndex = 1
        Me.CrystalReportViewer2.ViewTimeSelectionFormula = ""
        '
        'GrBox_Centrocosto
        '
        Me.GrBox_Centrocosto.Controls.Add(Me.Lab_Sindicalizados)
        Me.GrBox_Centrocosto.Controls.Add(Me.CbBox_Sindicalizados)
        Me.GrBox_Centrocosto.Controls.Add(Me.Label1)
        Me.GrBox_Centrocosto.Controls.Add(Me.Label2)
        Me.GrBox_Centrocosto.Controls.Add(Me.Txt_MesCentroCosto)
        Me.GrBox_Centrocosto.Controls.Add(Me.Txt_AñoCentroCosto)
        Me.GrBox_Centrocosto.Controls.Add(Me.CbBox_CentroCosto)
        Me.GrBox_Centrocosto.Controls.Add(Me.Lab_centrocosto)
        Me.GrBox_Centrocosto.Controls.Add(Me.Btn_buscarCentrocosto)
        Me.GrBox_Centrocosto.Location = New System.Drawing.Point(8, 16)
        Me.GrBox_Centrocosto.Name = "GrBox_Centrocosto"
        Me.GrBox_Centrocosto.Size = New System.Drawing.Size(468, 100)
        Me.GrBox_Centrocosto.TabIndex = 0
        Me.GrBox_Centrocosto.TabStop = False
        Me.GrBox_Centrocosto.Text = "Centro Costo"
        '
        'Lab_Sindicalizados
        '
        Me.Lab_Sindicalizados.AutoSize = True
        Me.Lab_Sindicalizados.Location = New System.Drawing.Point(233, 71)
        Me.Lab_Sindicalizados.Name = "Lab_Sindicalizados"
        Me.Lab_Sindicalizados.Size = New System.Drawing.Size(80, 13)
        Me.Lab_Sindicalizados.TabIndex = 9
        Me.Lab_Sindicalizados.Text = "Sindicalizados :"
        '
        'CbBox_Sindicalizados
        '
        Me.CbBox_Sindicalizados.FormattingEnabled = True
        Me.CbBox_Sindicalizados.Items.AddRange(New Object() {"TODOS", "SINDICALIZADOS", "NO SINDICALIZADOS"})
        Me.CbBox_Sindicalizados.Location = New System.Drawing.Point(319, 68)
        Me.CbBox_Sindicalizados.Name = "CbBox_Sindicalizados"
        Me.CbBox_Sindicalizados.Size = New System.Drawing.Size(121, 21)
        Me.CbBox_Sindicalizados.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Mes :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Año :"
        '
        'Txt_MesCentroCosto
        '
        Me.Txt_MesCentroCosto.Location = New System.Drawing.Point(90, 39)
        Me.Txt_MesCentroCosto.Name = "Txt_MesCentroCosto"
        Me.Txt_MesCentroCosto.Size = New System.Drawing.Size(115, 20)
        Me.Txt_MesCentroCosto.TabIndex = 5
        '
        'Txt_AñoCentroCosto
        '
        Me.Txt_AñoCentroCosto.Location = New System.Drawing.Point(90, 13)
        Me.Txt_AñoCentroCosto.Name = "Txt_AñoCentroCosto"
        Me.Txt_AñoCentroCosto.Size = New System.Drawing.Size(115, 20)
        Me.Txt_AñoCentroCosto.TabIndex = 4
        '
        'CbBox_CentroCosto
        '
        Me.CbBox_CentroCosto.FormattingEnabled = True
        Me.CbBox_CentroCosto.Items.AddRange(New Object() {"TODOS"})
        Me.CbBox_CentroCosto.Location = New System.Drawing.Point(90, 68)
        Me.CbBox_CentroCosto.Name = "CbBox_CentroCosto"
        Me.CbBox_CentroCosto.Size = New System.Drawing.Size(115, 21)
        Me.CbBox_CentroCosto.TabIndex = 2
        '
        'Lab_centrocosto
        '
        Me.Lab_centrocosto.AutoSize = True
        Me.Lab_centrocosto.Location = New System.Drawing.Point(16, 71)
        Me.Lab_centrocosto.Name = "Lab_centrocosto"
        Me.Lab_centrocosto.Size = New System.Drawing.Size(73, 13)
        Me.Lab_centrocosto.TabIndex = 1
        Me.Lab_centrocosto.Text = "Centro costo :"
        '
        'Btn_buscarCentrocosto
        '
        Me.Btn_buscarCentrocosto.Location = New System.Drawing.Point(338, 32)
        Me.Btn_buscarCentrocosto.Name = "Btn_buscarCentrocosto"
        Me.Btn_buscarCentrocosto.Size = New System.Drawing.Size(75, 23)
        Me.Btn_buscarCentrocosto.TabIndex = 0
        Me.Btn_buscarCentrocosto.Text = "Buscar"
        Me.Btn_buscarCentrocosto.UseVisualStyleBackColor = True
        '
        'Contador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 669)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Contador"
        Me.Text = "Contador"
        Me.TabControl1.ResumeLayout(False)
        Me.ConsumoPorMes.ResumeLayout(False)
        Me.GrBox_Fecha.ResumeLayout(False)
        Me.GrBox_Fecha.PerformLayout()
        Me.CentroCosto.ResumeLayout(False)
        Me.GrBox_Centrocosto.ResumeLayout(False)
        Me.GrBox_Centrocosto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConsumoPorMes As System.Windows.Forms.TabPage
    Friend WithEvents CentroCosto As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GrBox_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Lab_Mes As System.Windows.Forms.Label
    Friend WithEvents Lab_Año As System.Windows.Forms.Label
    Friend WithEvents Txt_Mes As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Año As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GrBox_Centrocosto As System.Windows.Forms.GroupBox
    Friend WithEvents Lab_centrocosto As System.Windows.Forms.Label
    Friend WithEvents Btn_buscarCentrocosto As System.Windows.Forms.Button
    Friend WithEvents CbBox_CentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_MesCentroCosto As System.Windows.Forms.TextBox
    Friend WithEvents Txt_AñoCentroCosto As System.Windows.Forms.TextBox
    Friend WithEvents Lab_Sindicalizados As System.Windows.Forms.Label
    Friend WithEvents CbBox_Sindicalizados As System.Windows.Forms.ComboBox
End Class
