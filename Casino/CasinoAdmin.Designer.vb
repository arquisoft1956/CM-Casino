<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CasinoAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    <System.Diagnostics.DebuggerStepThrough()> _
Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CasinoAdmin))
        Me.AxGrFingerXCtrl1 = New AxGrFingerXLib.AxGrFingerXCtrl
        Me.Lab_Titulo = New System.Windows.Forms.Label
        Me.Lab_Mensaje = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel_Foto = New System.Windows.Forms.Panel
        Me.Btn_ExaminarFoto = New System.Windows.Forms.Button
        Me.PicBox_Foto = New System.Windows.Forms.PictureBox
        Me.GrBox_DatosUsuario = New System.Windows.Forms.GroupBox
        Me.BorrarConsumo = New System.Windows.Forms.Button
        Me.Btn_IngresarOtraPersona = New System.Windows.Forms.Button
        Me.Txt_Unidad = New System.Windows.Forms.TextBox
        Me.Txt_Nombre = New System.Windows.Forms.TextBox
        Me.Lab_Sindicato = New System.Windows.Forms.Label
        Me.CbBox_CentroCosto = New System.Windows.Forms.ComboBox
        Me.Lab_CentroCosto = New System.Windows.Forms.Label
        Me.CbBox_Sindicalizado = New System.Windows.Forms.ComboBox
        Me.Btn_CancelarModifica = New System.Windows.Forms.Button
        Me.Btn_ModificarPersona = New System.Windows.Forms.Button
        Me.Txt_Cargos = New System.Windows.Forms.TextBox
        Me.Lab_Cargos = New System.Windows.Forms.Label
        Me.Lab_Unidad = New System.Windows.Forms.Label
        Me.Lab_Nombre = New System.Windows.Forms.Label
        Me.EnrollButton = New System.Windows.Forms.Button
        Me.GrBox_Rut = New System.Windows.Forms.GroupBox
        Me.Lab_Rut = New System.Windows.Forms.Label
        Me.Btn_Obtener = New System.Windows.Forms.Button
        Me.Lab_Dv = New System.Windows.Forms.Label
        Me.Txt_Rut = New System.Windows.Forms.TextBox
        Me.Btn_Rut = New System.Windows.Forms.Button
        Me.Timer1_huella = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Cerrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer_PorAtender = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxGrFingerXCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel_Foto.SuspendLayout()
        CType(Me.PicBox_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBox_DatosUsuario.SuspendLayout()
        Me.GrBox_Rut.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxGrFingerXCtrl1
        '
        Me.AxGrFingerXCtrl1.Enabled = True
        Me.AxGrFingerXCtrl1.Location = New System.Drawing.Point(504, 32)
        Me.AxGrFingerXCtrl1.Name = "AxGrFingerXCtrl1"
        Me.AxGrFingerXCtrl1.OcxState = CType(resources.GetObject("AxGrFingerXCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxGrFingerXCtrl1.Size = New System.Drawing.Size(32, 32)
        Me.AxGrFingerXCtrl1.TabIndex = 9
        '
        'Lab_Titulo
        '
        Me.Lab_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Titulo.ForeColor = System.Drawing.Color.Blue
        Me.Lab_Titulo.Location = New System.Drawing.Point(80, 16)
        Me.Lab_Titulo.Name = "Lab_Titulo"
        Me.Lab_Titulo.Size = New System.Drawing.Size(552, 40)
        Me.Lab_Titulo.TabIndex = 25
        Me.Lab_Titulo.Text = "Administracion del Casino"
        Me.Lab_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Mensaje
        '
        Me.Lab_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Mensaje.Location = New System.Drawing.Point(32, 32)
        Me.Lab_Mensaje.Name = "Lab_Mensaje"
        Me.Lab_Mensaje.Size = New System.Drawing.Size(600, 64)
        Me.Lab_Mensaje.TabIndex = 26
        Me.Lab_Mensaje.Text = "Ingrese su Huella"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel_Foto)
        Me.Panel1.Controls.Add(Me.GrBox_DatosUsuario)
        Me.Panel1.Controls.Add(Me.GrBox_Rut)
        Me.Panel1.Controls.Add(Me.Btn_Rut)
        Me.Panel1.Controls.Add(Me.AxGrFingerXCtrl1)
        Me.Panel1.Controls.Add(Me.Lab_Mensaje)
        Me.Panel1.Location = New System.Drawing.Point(24, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 501)
        Me.Panel1.TabIndex = 27
        '
        'Panel_Foto
        '
        Me.Panel_Foto.Controls.Add(Me.Btn_ExaminarFoto)
        Me.Panel_Foto.Controls.Add(Me.PicBox_Foto)
        Me.Panel_Foto.Location = New System.Drawing.Point(439, 114)
        Me.Panel_Foto.Name = "Panel_Foto"
        Me.Panel_Foto.Size = New System.Drawing.Size(208, 224)
        Me.Panel_Foto.TabIndex = 38
        Me.Panel_Foto.Visible = False
        '
        'Btn_ExaminarFoto
        '
        Me.Btn_ExaminarFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ExaminarFoto.Location = New System.Drawing.Point(56, 182)
        Me.Btn_ExaminarFoto.Name = "Btn_ExaminarFoto"
        Me.Btn_ExaminarFoto.Size = New System.Drawing.Size(103, 33)
        Me.Btn_ExaminarFoto.TabIndex = 18
        Me.Btn_ExaminarFoto.Text = "Examinar"
        '
        'PicBox_Foto
        '
        Me.PicBox_Foto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicBox_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox_Foto.Location = New System.Drawing.Point(16, 16)
        Me.PicBox_Foto.Name = "PicBox_Foto"
        Me.PicBox_Foto.Size = New System.Drawing.Size(176, 160)
        Me.PicBox_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox_Foto.TabIndex = 18
        Me.PicBox_Foto.TabStop = False
        '
        'GrBox_DatosUsuario
        '
        Me.GrBox_DatosUsuario.BackColor = System.Drawing.Color.LightYellow
        Me.GrBox_DatosUsuario.Controls.Add(Me.BorrarConsumo)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Btn_IngresarOtraPersona)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Txt_Unidad)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Txt_Nombre)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Sindicato)
        Me.GrBox_DatosUsuario.Controls.Add(Me.CbBox_CentroCosto)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_CentroCosto)
        Me.GrBox_DatosUsuario.Controls.Add(Me.CbBox_Sindicalizado)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Btn_CancelarModifica)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Btn_ModificarPersona)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Txt_Cargos)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Cargos)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Unidad)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Nombre)
        Me.GrBox_DatosUsuario.Controls.Add(Me.EnrollButton)
        Me.GrBox_DatosUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrBox_DatosUsuario.Location = New System.Drawing.Point(32, 176)
        Me.GrBox_DatosUsuario.Name = "GrBox_DatosUsuario"
        Me.GrBox_DatosUsuario.Size = New System.Drawing.Size(401, 322)
        Me.GrBox_DatosUsuario.TabIndex = 37
        Me.GrBox_DatosUsuario.TabStop = False
        Me.GrBox_DatosUsuario.Visible = False
        '
        'BorrarConsumo
        '
        Me.BorrarConsumo.Location = New System.Drawing.Point(237, 280)
        Me.BorrarConsumo.Name = "BorrarConsumo"
        Me.BorrarConsumo.Size = New System.Drawing.Size(149, 36)
        Me.BorrarConsumo.TabIndex = 17
        Me.BorrarConsumo.Text = "Borrar Consumo"
        Me.BorrarConsumo.UseVisualStyleBackColor = True
        '
        'Btn_IngresarOtraPersona
        '
        Me.Btn_IngresarOtraPersona.Location = New System.Drawing.Point(20, 280)
        Me.Btn_IngresarOtraPersona.Name = "Btn_IngresarOtraPersona"
        Me.Btn_IngresarOtraPersona.Size = New System.Drawing.Size(194, 36)
        Me.Btn_IngresarOtraPersona.TabIndex = 16
        Me.Btn_IngresarOtraPersona.Text = "Ingresar otra Persona"
        Me.Btn_IngresarOtraPersona.UseVisualStyleBackColor = True
        '
        'Txt_Unidad
        '
        Me.Txt_Unidad.Location = New System.Drawing.Point(154, 61)
        Me.Txt_Unidad.Name = "Txt_Unidad"
        Me.Txt_Unidad.Size = New System.Drawing.Size(232, 26)
        Me.Txt_Unidad.TabIndex = 15
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(154, 32)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(233, 26)
        Me.Txt_Nombre.TabIndex = 14
        '
        'Lab_Sindicato
        '
        Me.Lab_Sindicato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Sindicato.Location = New System.Drawing.Point(16, 126)
        Me.Lab_Sindicato.Name = "Lab_Sindicato"
        Me.Lab_Sindicato.Size = New System.Drawing.Size(133, 21)
        Me.Lab_Sindicato.TabIndex = 11
        Me.Lab_Sindicato.Text = "Sindicalizados:"
        '
        'CbBox_CentroCosto
        '
        Me.CbBox_CentroCosto.FormattingEnabled = True
        Me.CbBox_CentroCosto.Location = New System.Drawing.Point(155, 154)
        Me.CbBox_CentroCosto.Name = "CbBox_CentroCosto"
        Me.CbBox_CentroCosto.Size = New System.Drawing.Size(232, 28)
        Me.CbBox_CentroCosto.TabIndex = 10
        '
        'Lab_CentroCosto
        '
        Me.Lab_CentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CentroCosto.Location = New System.Drawing.Point(16, 157)
        Me.Lab_CentroCosto.Name = "Lab_CentroCosto"
        Me.Lab_CentroCosto.Size = New System.Drawing.Size(127, 21)
        Me.Lab_CentroCosto.TabIndex = 9
        Me.Lab_CentroCosto.Text = "Centro Costo :"
        '
        'CbBox_Sindicalizado
        '
        Me.CbBox_Sindicalizado.FormattingEnabled = True
        Me.CbBox_Sindicalizado.Items.AddRange(New Object() {"Sindicalizados", "No Sindicalizados"})
        Me.CbBox_Sindicalizado.Location = New System.Drawing.Point(155, 123)
        Me.CbBox_Sindicalizado.Name = "CbBox_Sindicalizado"
        Me.CbBox_Sindicalizado.Size = New System.Drawing.Size(232, 28)
        Me.CbBox_Sindicalizado.TabIndex = 8
        '
        'Btn_CancelarModifica
        '
        Me.Btn_CancelarModifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelarModifica.Location = New System.Drawing.Point(280, 217)
        Me.Btn_CancelarModifica.Name = "Btn_CancelarModifica"
        Me.Btn_CancelarModifica.Size = New System.Drawing.Size(90, 30)
        Me.Btn_CancelarModifica.TabIndex = 7
        Me.Btn_CancelarModifica.Text = "Cancelar"
        Me.Btn_CancelarModifica.Visible = False
        '
        'Btn_ModificarPersona
        '
        Me.Btn_ModificarPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ModificarPersona.Location = New System.Drawing.Point(46, 217)
        Me.Btn_ModificarPersona.Name = "Btn_ModificarPersona"
        Me.Btn_ModificarPersona.Size = New System.Drawing.Size(90, 30)
        Me.Btn_ModificarPersona.TabIndex = 6
        Me.Btn_ModificarPersona.Text = "Modificar"
        '
        'Txt_Cargos
        '
        Me.Txt_Cargos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cargos.Location = New System.Drawing.Point(154, 93)
        Me.Txt_Cargos.Name = "Txt_Cargos"
        Me.Txt_Cargos.Size = New System.Drawing.Size(232, 26)
        Me.Txt_Cargos.TabIndex = 3
        '
        'Lab_Cargos
        '
        Me.Lab_Cargos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Cargos.Location = New System.Drawing.Point(16, 96)
        Me.Lab_Cargos.Name = "Lab_Cargos"
        Me.Lab_Cargos.Size = New System.Drawing.Size(81, 26)
        Me.Lab_Cargos.TabIndex = 3
        Me.Lab_Cargos.Text = "Cargos : "
        '
        'Lab_Unidad
        '
        Me.Lab_Unidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Unidad.Location = New System.Drawing.Point(16, 64)
        Me.Lab_Unidad.Name = "Lab_Unidad"
        Me.Lab_Unidad.Size = New System.Drawing.Size(81, 26)
        Me.Lab_Unidad.TabIndex = 2
        Me.Lab_Unidad.Text = "Unidad : "
        '
        'Lab_Nombre
        '
        Me.Lab_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Nombre.Location = New System.Drawing.Point(16, 32)
        Me.Lab_Nombre.Name = "Lab_Nombre"
        Me.Lab_Nombre.Size = New System.Drawing.Size(81, 26)
        Me.Lab_Nombre.TabIndex = 1
        Me.Lab_Nombre.Text = "Nombre :"
        '
        'EnrollButton
        '
        Me.EnrollButton.Enabled = False
        Me.EnrollButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollButton.Location = New System.Drawing.Point(154, 216)
        Me.EnrollButton.Name = "EnrollButton"
        Me.EnrollButton.Size = New System.Drawing.Size(111, 30)
        Me.EnrollButton.TabIndex = 4
        Me.EnrollButton.Text = "Enroll"
        Me.EnrollButton.Visible = False
        '
        'GrBox_Rut
        '
        Me.GrBox_Rut.BackColor = System.Drawing.Color.LightYellow
        Me.GrBox_Rut.Controls.Add(Me.Lab_Rut)
        Me.GrBox_Rut.Controls.Add(Me.Btn_Obtener)
        Me.GrBox_Rut.Controls.Add(Me.Lab_Dv)
        Me.GrBox_Rut.Controls.Add(Me.Txt_Rut)
        Me.GrBox_Rut.Location = New System.Drawing.Point(32, 104)
        Me.GrBox_Rut.Name = "GrBox_Rut"
        Me.GrBox_Rut.Size = New System.Drawing.Size(401, 64)
        Me.GrBox_Rut.TabIndex = 36
        Me.GrBox_Rut.TabStop = False
        Me.GrBox_Rut.Visible = False
        '
        'Lab_Rut
        '
        Me.Lab_Rut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Rut.Location = New System.Drawing.Point(16, 24)
        Me.Lab_Rut.Name = "Lab_Rut"
        Me.Lab_Rut.Size = New System.Drawing.Size(50, 18)
        Me.Lab_Rut.TabIndex = 14
        Me.Lab_Rut.Text = "Rut :"
        '
        'Btn_Obtener
        '
        Me.Btn_Obtener.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Obtener.Location = New System.Drawing.Point(272, 24)
        Me.Btn_Obtener.Name = "Btn_Obtener"
        Me.Btn_Obtener.Size = New System.Drawing.Size(98, 26)
        Me.Btn_Obtener.TabIndex = 13
        Me.Btn_Obtener.Text = "Obtener"
        '
        'Lab_Dv
        '
        Me.Lab_Dv.AutoSize = True
        Me.Lab_Dv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Dv.Location = New System.Drawing.Point(233, 29)
        Me.Lab_Dv.Name = "Lab_Dv"
        Me.Lab_Dv.Size = New System.Drawing.Size(30, 20)
        Me.Lab_Dv.TabIndex = 12
        Me.Lab_Dv.Text = "Dv"
        '
        'Txt_Rut
        '
        Me.Txt_Rut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Rut.Location = New System.Drawing.Point(72, 24)
        Me.Txt_Rut.MaxLength = 8
        Me.Txt_Rut.Name = "Txt_Rut"
        Me.Txt_Rut.Size = New System.Drawing.Size(155, 26)
        Me.Txt_Rut.TabIndex = 0
        '
        'Btn_Rut
        '
        Me.Btn_Rut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rut.Location = New System.Drawing.Point(32, 75)
        Me.Btn_Rut.Name = "Btn_Rut"
        Me.Btn_Rut.Size = New System.Drawing.Size(124, 28)
        Me.Btn_Rut.TabIndex = 35
        Me.Btn_Rut.Text = "Ingresar Rut"
        '
        'Timer1_huella
        '
        Me.Timer1_huella.Interval = 4000
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.Location = New System.Drawing.Point(599, 587)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(81, 29)
        Me.Btn_Cerrar.TabIndex = 29
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer_PorAtender
        '
        Me.Timer_PorAtender.Interval = 12000
        '
        'CasinoAdmin
        '
        Me.ClientSize = New System.Drawing.Size(782, 669)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lab_Titulo)
        Me.Name = "CasinoAdmin"
        Me.Text = "Casino Administrador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxGrFingerXCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel_Foto.ResumeLayout(False)
        CType(Me.PicBox_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBox_DatosUsuario.ResumeLayout(False)
        Me.GrBox_DatosUsuario.PerformLayout()
        Me.GrBox_Rut.ResumeLayout(False)
        Me.GrBox_Rut.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxGrFingerXCtrl1 As AxGrFingerXLib.AxGrFingerXCtrl
    Friend WithEvents Lab_Titulo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lab_Mensaje As System.Windows.Forms.Label
    Friend WithEvents Btn_Rut As System.Windows.Forms.Button
    Friend WithEvents GrBox_Rut As System.Windows.Forms.GroupBox
    Friend WithEvents Lab_Rut As System.Windows.Forms.Label
    Friend WithEvents Btn_Obtener As System.Windows.Forms.Button
    Friend WithEvents Lab_Dv As System.Windows.Forms.Label
    Friend WithEvents Txt_Rut As System.Windows.Forms.TextBox
    Friend WithEvents GrBox_DatosUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_CancelarModifica As System.Windows.Forms.Button
    Friend WithEvents Btn_ModificarPersona As System.Windows.Forms.Button
    Friend WithEvents Txt_Cargos As System.Windows.Forms.TextBox
    Friend WithEvents Lab_Cargos As System.Windows.Forms.Label
    Friend WithEvents Lab_Unidad As System.Windows.Forms.Label
    Friend WithEvents Lab_Nombre As System.Windows.Forms.Label
    Friend WithEvents EnrollButton As System.Windows.Forms.Button
    Friend WithEvents Panel_Foto As System.Windows.Forms.Panel
    Friend WithEvents Btn_ExaminarFoto As System.Windows.Forms.Button
    Friend WithEvents PicBox_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer_PorAtender As System.Windows.Forms.Timer
    Friend WithEvents CbBox_Sindicalizado As System.Windows.Forms.ComboBox
    Friend WithEvents CbBox_CentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents Lab_Sindicato As System.Windows.Forms.Label
    Friend WithEvents Lab_CentroCosto As System.Windows.Forms.Label
    Friend WithEvents Timer1_huella As System.Windows.Forms.Timer
    Friend WithEvents Txt_Unidad As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Btn_IngresarOtraPersona As System.Windows.Forms.Button
    Friend WithEvents BorrarConsumo As System.Windows.Forms.Button
End Class