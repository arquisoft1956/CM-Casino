<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rut))
        Me.Btn_Rut1 = New System.Windows.Forms.Button
        Me.Btn_Rut2 = New System.Windows.Forms.Button
        Me.Btn_canselar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Btn_Rut1
        '
        Me.Btn_Rut1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rut1.Location = New System.Drawing.Point(56, 121)
        Me.Btn_Rut1.Name = "Btn_Rut1"
        Me.Btn_Rut1.Size = New System.Drawing.Size(105, 36)
        Me.Btn_Rut1.TabIndex = 0
        Me.Btn_Rut1.Text = "Button1"
        Me.Btn_Rut1.UseVisualStyleBackColor = True
        '
        'Btn_Rut2
        '
        Me.Btn_Rut2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rut2.Location = New System.Drawing.Point(180, 121)
        Me.Btn_Rut2.Name = "Btn_Rut2"
        Me.Btn_Rut2.Size = New System.Drawing.Size(110, 36)
        Me.Btn_Rut2.TabIndex = 1
        Me.Btn_Rut2.Text = "Button2"
        Me.Btn_Rut2.UseVisualStyleBackColor = True
        '
        'Btn_canselar
        '
        Me.Btn_canselar.Location = New System.Drawing.Point(310, 121)
        Me.Btn_canselar.Name = "Btn_canselar"
        Me.Btn_canselar.Size = New System.Drawing.Size(115, 36)
        Me.Btn_canselar.TabIndex = 2
        Me.Btn_canselar.Text = "Cancelar"
        Me.Btn_canselar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Su rut correcto es:"
        '
        'Rut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 186)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_canselar)
        Me.Controls.Add(Me.Btn_Rut2)
        Me.Controls.Add(Me.Btn_Rut1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Verificación de Rut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Rut1 As System.Windows.Forms.Button
    Friend WithEvents Btn_Rut2 As System.Windows.Forms.Button
    Friend WithEvents Btn_canselar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
