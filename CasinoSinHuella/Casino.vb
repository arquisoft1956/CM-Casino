Imports GrFingerXLib
Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Diagnostics
Imports Casino.Library

Public Class FormMain2
    Inherits System.Windows.Forms.Form

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()


    End Sub
    Public Sub New(ByVal f As Persona)
        InitializeComponent()
        mPersona = f
        IniciaFormulario(False)
    End Sub
#Region " Windows Form Designer generated code "
 

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer_PorAtender As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GrBox_DatosUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents NumericVisitas As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lab_TotalConsumo2 As System.Windows.Forms.Label
    Friend WithEvents Lab_TotalConsumo As System.Windows.Forms.Label
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Lab_NumeroVisitas As System.Windows.Forms.Label
    Friend WithEvents Lab_CentroCosto2 As System.Windows.Forms.Label
    Friend WithEvents Lab_Sindicalizado As System.Windows.Forms.Label
    Friend WithEvents Lab_Cargos2 As System.Windows.Forms.Label
    Friend WithEvents Lab_Unidad2 As System.Windows.Forms.Label
    Friend WithEvents Lab_Nombre2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrBox_Asistencia As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_OK As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Panel_Foto As System.Windows.Forms.Panel
    Friend WithEvents PicBox_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents GrBox_Rut As System.Windows.Forms.GroupBox
    Friend WithEvents Lab_Rut As System.Windows.Forms.Label
    Friend WithEvents Btn_Obtener As System.Windows.Forms.Button
    Friend WithEvents Lab_Dv As System.Windows.Forms.Label
    Friend WithEvents Txt_Rut As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Rut As System.Windows.Forms.Button

    Friend WithEvents Lab_Mensaje As System.Windows.Forms.Label
    Friend WithEvents Lab_Titulo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btn_VerAtendidos As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Lab_Estamento2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1_huella As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain2))
        Me.Timer1_huella = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer_PorAtender = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GrBox_DatosUsuario = New System.Windows.Forms.GroupBox()
        Me.NumericVisitas = New System.Windows.Forms.NumericUpDown()
        Me.Lab_TotalConsumo2 = New System.Windows.Forms.Label()
        Me.Lab_TotalConsumo = New System.Windows.Forms.Label()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Lab_NumeroVisitas = New System.Windows.Forms.Label()
        Me.Lab_CentroCosto2 = New System.Windows.Forms.Label()
        Me.Lab_Sindicalizado = New System.Windows.Forms.Label()
        Me.Lab_Cargos2 = New System.Windows.Forms.Label()
        Me.Lab_Unidad2 = New System.Windows.Forms.Label()
        Me.Lab_Nombre2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GrBox_Asistencia = New System.Windows.Forms.GroupBox()
        Me.Btn_OK = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Panel_Foto = New System.Windows.Forms.Panel()
        Me.PicBox_Foto = New System.Windows.Forms.PictureBox()
        Me.GrBox_Rut = New System.Windows.Forms.GroupBox()
        Me.Lab_Rut = New System.Windows.Forms.Label()
        Me.Btn_Obtener = New System.Windows.Forms.Button()
        Me.Lab_Dv = New System.Windows.Forms.Label()
        Me.Txt_Rut = New System.Windows.Forms.TextBox()
        Me.Btn_Rut = New System.Windows.Forms.Button()
        Me.Lab_Mensaje = New System.Windows.Forms.Label()
        Me.Lab_Titulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_VerAtendidos = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lab_Estamento2 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrBox_DatosUsuario.SuspendLayout()
        CType(Me.NumericVisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBox_Asistencia.SuspendLayout()
        Me.Panel_Foto.SuspendLayout()
        CType(Me.PicBox_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBox_Rut.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1_huella
        '
        Me.Timer1_huella.Interval = 4000
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Btn_Cerrar)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Lab_Titulo)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1018, 634)
        Me.Panel3.TabIndex = 31
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.Location = New System.Drawing.Point(921, 600)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(81, 29)
        Me.Btn_Cerrar.TabIndex = 33
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GrBox_DatosUsuario)
        Me.Panel1.Controls.Add(Me.GrBox_Asistencia)
        Me.Panel1.Controls.Add(Me.Panel_Foto)
        Me.Panel1.Controls.Add(Me.GrBox_Rut)
        Me.Panel1.Controls.Add(Me.Btn_Rut)
        Me.Panel1.Controls.Add(Me.Lab_Mensaje)
        Me.Panel1.Location = New System.Drawing.Point(15, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 552)
        Me.Panel1.TabIndex = 32
        '
        'GrBox_DatosUsuario
        '
        Me.GrBox_DatosUsuario.BackColor = System.Drawing.Color.LightYellow
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Estamento2)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Label6)
        Me.GrBox_DatosUsuario.Controls.Add(Me.NumericVisitas)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_TotalConsumo2)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_TotalConsumo)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Btn_Modificar)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_NumeroVisitas)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_CentroCosto2)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Sindicalizado)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Cargos2)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Unidad2)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Nombre2)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Label1)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Label2)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Label3)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Label4)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Label5)
        Me.GrBox_DatosUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrBox_DatosUsuario.Location = New System.Drawing.Point(32, 176)
        Me.GrBox_DatosUsuario.Name = "GrBox_DatosUsuario"
        Me.GrBox_DatosUsuario.Size = New System.Drawing.Size(401, 357)
        Me.GrBox_DatosUsuario.TabIndex = 40
        Me.GrBox_DatosUsuario.TabStop = False
        Me.GrBox_DatosUsuario.Visible = False
        '
        'NumericVisitas
        '
        Me.NumericVisitas.Location = New System.Drawing.Point(225, 241)
        Me.NumericVisitas.Name = "NumericVisitas"
        Me.NumericVisitas.Size = New System.Drawing.Size(52, 26)
        Me.NumericVisitas.TabIndex = 22
        '
        'Lab_TotalConsumo2
        '
        Me.Lab_TotalConsumo2.AutoSize = True
        Me.Lab_TotalConsumo2.BackColor = System.Drawing.Color.White
        Me.Lab_TotalConsumo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_TotalConsumo2.ForeColor = System.Drawing.Color.Red
        Me.Lab_TotalConsumo2.Location = New System.Drawing.Point(225, 275)
        Me.Lab_TotalConsumo2.Name = "Lab_TotalConsumo2"
        Me.Lab_TotalConsumo2.Size = New System.Drawing.Size(31, 22)
        Me.Lab_TotalConsumo2.TabIndex = 21
        Me.Lab_TotalConsumo2.Text = "01"
        '
        'Lab_TotalConsumo
        '
        Me.Lab_TotalConsumo.AutoSize = True
        Me.Lab_TotalConsumo.Location = New System.Drawing.Point(16, 275)
        Me.Lab_TotalConsumo.Name = "Lab_TotalConsumo"
        Me.Lab_TotalConsumo.Size = New System.Drawing.Size(164, 20)
        Me.Lab_TotalConsumo.TabIndex = 20
        Me.Lab_TotalConsumo.Text = "Total de Consumo :"
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Location = New System.Drawing.Point(154, 302)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(111, 33)
        Me.Btn_Modificar.TabIndex = 19
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.UseVisualStyleBackColor = True
        '
        'Lab_NumeroVisitas
        '
        Me.Lab_NumeroVisitas.AutoSize = True
        Me.Lab_NumeroVisitas.Location = New System.Drawing.Point(18, 243)
        Me.Lab_NumeroVisitas.Name = "Lab_NumeroVisitas"
        Me.Lab_NumeroVisitas.Size = New System.Drawing.Size(201, 20)
        Me.Lab_NumeroVisitas.TabIndex = 17
        Me.Lab_NumeroVisitas.Text = "Números de visitantes : "
        '
        'Lab_CentroCosto2
        '
        Me.Lab_CentroCosto2.Location = New System.Drawing.Point(150, 157)
        Me.Lab_CentroCosto2.Name = "Lab_CentroCosto2"
        Me.Lab_CentroCosto2.Size = New System.Drawing.Size(216, 21)
        Me.Lab_CentroCosto2.TabIndex = 16
        Me.Lab_CentroCosto2.Text = "Centro Costo"
        '
        'Lab_Sindicalizado
        '
        Me.Lab_Sindicalizado.AutoSize = True
        Me.Lab_Sindicalizado.Location = New System.Drawing.Point(150, 126)
        Me.Lab_Sindicalizado.Name = "Lab_Sindicalizado"
        Me.Lab_Sindicalizado.Size = New System.Drawing.Size(115, 20)
        Me.Lab_Sindicalizado.TabIndex = 15
        Me.Lab_Sindicalizado.Text = "Sindicalizado"
        '
        'Lab_Cargos2
        '
        Me.Lab_Cargos2.Location = New System.Drawing.Point(150, 96)
        Me.Lab_Cargos2.Name = "Lab_Cargos2"
        Me.Lab_Cargos2.Size = New System.Drawing.Size(237, 24)
        Me.Lab_Cargos2.TabIndex = 14
        Me.Lab_Cargos2.Text = "Cargos"
        '
        'Lab_Unidad2
        '
        Me.Lab_Unidad2.Location = New System.Drawing.Point(150, 64)
        Me.Lab_Unidad2.Name = "Lab_Unidad2"
        Me.Lab_Unidad2.Size = New System.Drawing.Size(235, 26)
        Me.Lab_Unidad2.TabIndex = 13
        Me.Lab_Unidad2.Text = "Unidad"
        '
        'Lab_Nombre2
        '
        Me.Lab_Nombre2.Location = New System.Drawing.Point(150, 32)
        Me.Lab_Nombre2.Name = "Lab_Nombre2"
        Me.Lab_Nombre2.Size = New System.Drawing.Size(235, 26)
        Me.Lab_Nombre2.TabIndex = 12
        Me.Lab_Nombre2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Sindicalizados:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Centro Costo :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cargos : "
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Unidad : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nombre :"
        '
        'GrBox_Asistencia
        '
        Me.GrBox_Asistencia.BackColor = System.Drawing.Color.LightYellow
        Me.GrBox_Asistencia.Controls.Add(Me.Btn_OK)
        Me.GrBox_Asistencia.Controls.Add(Me.Btn_Cancelar)
        Me.GrBox_Asistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrBox_Asistencia.Location = New System.Drawing.Point(448, 374)
        Me.GrBox_Asistencia.Name = "GrBox_Asistencia"
        Me.GrBox_Asistencia.Size = New System.Drawing.Size(199, 80)
        Me.GrBox_Asistencia.TabIndex = 39
        Me.GrBox_Asistencia.TabStop = False
        Me.GrBox_Asistencia.Text = "Asistencia"
        Me.GrBox_Asistencia.Visible = False
        '
        'Btn_OK
        '
        Me.Btn_OK.Location = New System.Drawing.Point(16, 32)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(75, 32)
        Me.Btn_OK.TabIndex = 22
        Me.Btn_OK.Text = "OK"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(96, 32)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(97, 32)
        Me.Btn_Cancelar.TabIndex = 7
        Me.Btn_Cancelar.Text = "Cancelar"
        '
        'Panel_Foto
        '
        Me.Panel_Foto.Controls.Add(Me.PicBox_Foto)
        Me.Panel_Foto.Location = New System.Drawing.Point(439, 114)
        Me.Panel_Foto.Name = "Panel_Foto"
        Me.Panel_Foto.Size = New System.Drawing.Size(208, 224)
        Me.Panel_Foto.TabIndex = 38
        Me.Panel_Foto.Visible = False
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
        Me.Btn_Rut.Size = New System.Drawing.Size(143, 28)
        Me.Btn_Rut.TabIndex = 35
        Me.Btn_Rut.Text = "Ingresar Rut"
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
        'Lab_Titulo
        '
        Me.Lab_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Titulo.ForeColor = System.Drawing.Color.Blue
        Me.Lab_Titulo.Location = New System.Drawing.Point(71, 6)
        Me.Lab_Titulo.Name = "Lab_Titulo"
        Me.Lab_Titulo.Size = New System.Drawing.Size(552, 40)
        Me.Lab_Titulo.TabIndex = 31
        Me.Lab_Titulo.Text = "CASINO COLEGIO MEDICO"
        Me.Lab_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_VerAtendidos)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(677, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 466)
        Me.Panel2.TabIndex = 34
        '
        'Btn_VerAtendidos
        '
        Me.Btn_VerAtendidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_VerAtendidos.Location = New System.Drawing.Point(21, 3)
        Me.Btn_VerAtendidos.Name = "Btn_VerAtendidos"
        Me.Btn_VerAtendidos.Size = New System.Drawing.Size(148, 30)
        Me.Btn_VerAtendidos.TabIndex = 1
        Me.Btn_VerAtendidos.Text = "Ver Asistentes"
        Me.Btn_VerAtendidos.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(252, 393)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Por Atender"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 130
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'PrintDocument1
        '
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 21)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Estamento :"
        '
        'Lab_Estamento2
        '
        Me.Lab_Estamento2.Location = New System.Drawing.Point(150, 187)
        Me.Lab_Estamento2.Name = "Lab_Estamento2"
        Me.Lab_Estamento2.Size = New System.Drawing.Size(216, 21)
        Me.Lab_Estamento2.TabIndex = 24
        Me.Lab_Estamento2.Text = "Estamento"
        '
        'FormMain2
        '
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1018, 634)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain2"
        Me.Text = "Casino"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GrBox_DatosUsuario.ResumeLayout(False)
        Me.GrBox_DatosUsuario.PerformLayout()
        CType(Me.NumericVisitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBox_Asistencia.ResumeLayout(False)
        Me.Panel_Foto.ResumeLayout(False)
        CType(Me.PicBox_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBox_Rut.ResumeLayout(False)
        Me.GrBox_Rut.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    ' the options form
    Dim cerrar As Boolean = True
    'Dim OptionsForm1 As New OptionsForm
    ' the util class
    Dim myUtil As Util
    Dim PersonaExists As Boolean
    Dim PersonaUpdate As Boolean = False
    Dim HuellaPersonaExists As Boolean = True
    Dim IdPersona As Integer
    Dim LogList As ListBox = New ListBox
    Dim PictureBoxHuella As PictureBox = New PictureBox
    Dim foto As Byte() = {0}
    Dim id As Integer
    Dim mPersona As Persona
#End Region
#Region "Metodos"
    Private Function M_Foto_Temporal(ByVal NombrePersona As String) As String



        Dim txt As New Label
        txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txt.BackColor = Color.Aqua
        Dim bm As New Bitmap(100, 100)
        For i As Integer = 0 To bm.Width - 1
            For j As Integer = 0 To bm.Height - 1
                bm.SetPixel(i, j, Me.BackColor)
            Next
        Next
        Dim objGraphics As Graphics = Graphics.FromImage(bm)
        Dim nombre As String = ""
        Dim nombre2() As String = NombrePersona.Split(" ")
        For a As Integer = 0 To nombre2.Length - 1
            nombre = nombre + Chr(10) + Chr(13) + nombre2(a)
        Next

        objGraphics.DrawString(nombre, txt.Font, Brushes.Black, 5.0F, 5.0F)

        Dim fra As String = "\tem0.jpg"
        Dim num As Integer = 0

        'borra los existente
        While (File.Exists(Environment.CurrentDirectory + "\tem" + num.ToString + ".jpg")) = True
            Try
                File.Delete(Environment.CurrentDirectory + "\tem" + num.ToString + ".jpg")
            Catch ex As Exception

            End Try
            num = num + 1
        End While

        'busca el nombre
        num = 0
        While (File.Exists(Environment.CurrentDirectory + "\tem" + num.ToString + ".jpg")) = True
            num = num + 1
            fra = "\tem" + (num).ToString + ".jpg"
        End While

        bm.Save(Environment.CurrentDirectory + fra)
        bm.Dispose()
        objGraphics.Dispose()
        Return fra

    End Function
    Private Function M_Mensaje(ByVal condicion As String) As String
        condicion = condicion.ToLower
        If condicion = "bienvenido" Then Lab_Mensaje.Text = "Bienvenido Sr (a)..." : Lab_Mensaje.ForeColor = Color.Green
        If condicion = "huella no reconocida" Then Lab_Mensaje.Text = "La huella no fue reconocida." + Chr(10) + Chr(13) + "Ponga la huella nuevamente o ingrese su  rut." : Lab_Mensaje.ForeColor = Color.Red
        If condicion = "huella falta" Then Lab_Mensaje.Text = "Retire e ingrese nuevamente la huella." : Lab_Mensaje.ForeColor = Color.Blue
        If condicion = "rut no encontrado" Then Lab_Mensaje.Text = "Rut no encontrado, debera registrarse." : Lab_Mensaje.ForeColor = Color.Green
        If condicion = "esperando la huella" Then Lab_Mensaje.Text = "Esperando la Huella." : Lab_Mensaje.ForeColor = Color.Black
        If condicion = "almuerzo" Then Lab_Mensaje.Text = "Almuerzo fue registrado..." : Lab_Mensaje.ForeColor = Color.Green
        If condicion = "no titular" Then Lab_Mensaje.Text = "No es un titular" : Lab_Mensaje.ForeColor = Color.Black
        Lab_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Return ""
    End Function

    Private Sub M_LlenadoTexto(ByVal per As Casino.Library.Persona)
        Using busy As New StatusBusy("Cargando...", Me)

            Dim myArray2 As Byte() = Casino.Library.NoHayFoto.GetImagen()

            mPersona = per
            If per.mRut <> "" Then
                GrBox_DatosUsuario.Visible = True
                Lab_CentroCosto2.Text = ""
                Lab_Sindicalizado.Text = ""
                If per.Titular = 0 Then
                    M_Mensaje("no titular")
                    GrBox_Rut.Visible = False
                    Btn_Rut.Visible = True
                    Timer1_huella.Start()
                    GrBox_DatosUsuario.Visible = False
                Else
                    PersonaExists = True
                    Lab_Nombre2.Text = per.mNombre
                    Lab_Cargos2.Text = per.mCargos
                    Lab_Unidad2.Text = per.mUnidad
                    Lab_CentroCosto2.Text = per.mCentroCosto
                    Lab_Estamento2.Text = per.mEstamento
                    NumericVisitas.Value = 0
                    Lab_TotalConsumo2.Text = "1"
                    Dim NumeroSindicalizado As Integer = per.mSindicalizado
                    If NumeroSindicalizado = 2 Then
                        Lab_Sindicalizado.Text = "Sindicalizado"
                    End If
                    If NumeroSindicalizado = 1 Then
                        Lab_Sindicalizado.Text = "No Sindicalizado"
                    End If
                    IdPersona = per.mIdPersona
                    Try
                        'imagen 
                        Dim myArray As Byte() = DirectCast(per.mFoto, Byte())
                        If myArray.Length = 1 Then
                            PicBox_Foto.Image = byteArrayToImage(myArray2)
                            Dim a As Byte() = {0}
                            foto = a
                        Else

                            foto = myArray
                            Dim ms As New IO.MemoryStream(myArray)
                            PicBox_Foto.Image = Image.FromStream(ms)
                        End If

                    Catch ex As Exception

                    End Try

                    Panel_Foto.Visible = True
                    M_Mensaje("bienvenido")
                    GrBox_DatosUsuario.Text = "  Datos de la persona  "
                    GrBox_Asistencia.Visible = True
                    GrBox_Rut.Visible = True
                End If


            Else
                PersonaExists = False
                M_Mensaje("Rut no encontrado")
                Timer1_huella.Start()
                Btn_Rut.Visible = True
                Txt_Rut.Text = ""
                GrBox_Rut.Visible = False
            End If


        End Using
    End Sub
    Private Function Valida_rut(ByVal rt As String) As String
        rt = rt.Replace(".", "").Replace("-", "")
        Dim increm As Integer
        Dim suma As Integer
        Dim dig As String
        Dim resto As Integer
        Dim dig_ver As Integer
        Dim dvrutt As String = ""
        increm = 2
        suma = 0
        Dim i As Integer
        For i = 10 To 1 Step -1
            dig = Mid$(rt, i, 1)
            If Not dig = "" Then
                dig = Val(dig)
                suma = suma + (increm * dig)
                If increm = 7 Then
                    increm = 1
                End If
                increm = increm + 1
            End If
        Next i
        resto = suma Mod 11
        dig_ver = 11 - resto
        dvrutt = dig_ver.ToString
        Select Case dig_ver
            Case Is = 11
                dvrutt = "0"
            Case Is = 10
                dvrutt = "K"
        End Select

        Return dvrutt

    End Function
    ' Identify a fingerprint 
    Private Sub Identificar()
        Dim ret As Integer, score As Integer

        score = 0
        ' identify it
        ret = myUtil.Identify(score)
        ' write result to log 
        Dim lujar As Point = New Point
        lujar.Y = GrBox_Rut.Location.Y + GrBox_Rut.Height + 10
        lujar.X = GrBox_Rut.Location.X
        GrBox_DatosUsuario.Location = lujar

        If ret > 0 Then
            myUtil.WriteLog("Fingerprint identified. ID = " & ret & ". Score = " & score & ".")
            'myUtil.PrintBiometricDisplay(True, GRConstants.GR_DEFAULT_CONTEXT)
            GrBox_Rut.Visible = False
            GrBox_DatosUsuario.Visible = True
            Panel_Foto.Visible = True
            M_Mensaje("bienvenido")
            GrBox_DatosUsuario.Location = GrBox_Rut.Location
            Btn_Rut.Visible = False
            M_LlenadoTexto(myUtil.ObtenerPersona(ret))
            GrBox_Asistencia.Visible = True

        ElseIf ret = 0 Then
            myUtil.WriteLog("Fingerprint not Found.")
            GrBox_Rut.Visible = True
            GrBox_DatosUsuario.Visible = False
            GrBox_Asistencia.Visible = False
            Panel_Foto.Visible = False
            HuellaPersonaExists = False
            M_Mensaje("huella no reconocida")
            Txt_Rut.Text = ""
            Btn_Rut.Visible = False
        Else
            Txt_Rut.Text = ""
            myUtil.WriteError(ret)
            GrBox_Rut.Visible = False
            GrBox_DatosUsuario.Visible = False
            Panel_Foto.Visible = False
            M_Mensaje("huella falta")
            Btn_Rut.Visible = True
            GrBox_Asistencia.Visible = False
        End If
    End Sub
    Private Sub Verificar()
        Dim ret As Integer
        Dim score As Integer
        Dim sid As String

        ' ask target fingerprint ID
        score = 0
        sid = InputBox("Enter the ID to verify", "Verify", "")
        If sid <> "" Then
            ' compare fingerprints
            ret = myUtil.Verify(Val(sid), score)
            ' write result to log
            If ret < 0 Then
                myUtil.WriteError(ret)
                'ElseIf ret = GRConstants.GR_NOT_MATCH Then
                '    myUtil.WriteLog("Did not match with score = " & score)
            Else
                myUtil.WriteLog("Matched with score = " & score)
                ' if they match, display matching minutiae/segments/directions
                'myUtil.PrintBiometricDisplay(True, GRConstants.GR_DEFAULT_CONTEXT)
            End If
        End If
    End Sub
    Private Sub Cleardatabase()
        ' clear database
        myUtil.DB.clearDB()
        ' write result to log
        myUtil.WriteLog("Database is clear...")
    End Sub
    Private Sub Clearlog()
        ' Clear log
        LogList.Items.Clear()

    End Sub
    ' Extract a template from a fingerprint image 
    Private Sub Extracttemplate()

        Dim ret As Integer

        ' extract template
        ret = myUtil.ExtractTemplate()
        ' write template quality to log
        'If ret = GRConstants.GR_BAD_QUALITY Then
        '    myUtil.WriteLog("Template extracted successfully. Bad quality.")
        'ElseIf ret = GRConstants.GR_MEDIUM_QUALITY Then
        '    myUtil.WriteLog("Template extracted successfully. Medium quality.")
        'ElseIf ret = GRConstants.GR_HIGH_QUALITY Then
        '    myUtil.WriteLog("Template extracted successfully. High quality.")
        'End If
        If ret >= 0 Then
            ' if no error, display minutiae/segments/directions into the image
            'myUtil.PrintBiometricDisplay(True, GRConstants.GR_NO_CONTEXT)
            ' enable operations we can do over extracted template
            'EnrollButton.Enabled = True
        Else
            ' write error to log
            myUtil.WriteError(ret)
        End If
    End Sub
    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New System.IO.MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function
    Public Function byteArrayToImage(ByVal stringbyte As String) As Image
        Dim arr As [String]() = stringbyte.Split("-"c)
        Dim array As Byte() = New Byte(arr.Length - 1) {}
        For i As Integer = 0 To arr.Length - 1
            array(i) = Convert.ToByte(arr(i), 16)
        Next
        Dim ms As New System.IO.MemoryStream(array)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function
    Public Function imageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New System.IO.MemoryStream
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function
    Function TranformaArchivos(ByVal datos As String) As Byte()

        Dim fs As FileStream
        fs = New FileStream(datos, FileMode.Open)
        Dim fi As FileInfo = New FileInfo(datos)
        Dim Temp As Long = fi.Length
        Dim lung As Long = Convert.ToInt32(Temp)
        Dim File(lung) As Byte
        fs.Read(File, 0, lung)
        fs.Close()

        Return File

    End Function
    Private Function M_PersonasPorAtender(ByRef fecha As Date, ByRef Checkeado As Boolean) As SqlClient.SqlDataReader

        Dim PorAtender As SqlClient.SqlDataReader

        Dim time1 As Date = Date.Now

        PorAtender = myUtil.PorAtender(fecha, Checkeado)

        If PorAtender.HasRows = True Then
            DataGridView1.Rows.Clear()
            While PorAtender.Read

                Dim idcomida As String = PorAtender("id")

                'imagen 
                'Dim myArray As Byte() = DirectCast(PorAtender("foto"), Byte())
                'If myArray.Length = 1 Then
                'Dim fra As String = M_Foto_Temporal(PorAtender("nombre"))
                Dim tamaño As Integer = DataGridView1.Rows.Count - 1
                Dim ARRAY() As String = {PorAtender("nombre"), PorAtender("ID")}
                DataGridView1.Rows.Add(ARRAY)
                'DataGridView1.Rows(tamaño + 1).Cells(0).Value = PorAtender("rut") & " " & PorAtender("nombre")   ' Image.FromFile(Environment.CurrentDirectory + fra)
                'DataGridView1.Rows(tamaño + 1).Height = 50
                'DataGridView1.Rows(tamaño + 1).Cells(1).Value = idcomida
                DataGridView1.Rows(tamaño + 1).Cells(0).ReadOnly = False

                'Else
                'Dim tamaño As Integer = DataGridView1.Rows.Count - 1
                'DataGridView1.Rows.Add()
                'DataGridView1.Rows(tamaño + 1).Cells(0).Value = byteArrayToImage(myArray)
                'DataGridView1.Rows(tamaño + 1).Height = 100
                'DataGridView1.Rows(tamaño + 1).Cells(1).Value = idcomida
                'foto = myArray
                'End If

            End While
            PorAtender.Close()
        Else
            DataGridView1.Rows.Clear()
        End If
        Dim timer2 As Date = Date.Now

        'Label1.Text = (timer2 - time1).ToString
        Return PorAtender
    End Function

#End Region
#Region "New"
    Private Sub IniciaFormulario(ByVal ComoNuevo As Boolean)


        Dim myArray As Byte() = Casino.Library.NoHayFoto.GetImagen()
        PicBox_Foto.Image = byteArrayToImage(myArray)

        DataGridView1.BackgroundColor = Me.BackColor

        Panel2.Height = Me.Height - Panel2.Location.Y
        DataGridView1.Height = Panel2.Height - 5

        ' initialize util class
        myUtil = New Util(LogList, PictureBoxHuella)

        Dim err As Integer
        ' Initialize GrFingerX Library
        '  err = myUtil.InitializeGrFinger()
        ' Print result in log
        Try
            'If err < 0 Then
            '    myUtil.WriteError(err)

            'Else
            '    myUtil.WriteLog("**GrFingerX Initialized Successfull**")
            'End If
        Catch ex As Exception

        End Try

        ''verificador
        Dim lugar As Point
        lugar.Y = Me.Height - 10


        ''titulo
        lugar.X = 0
        lugar.Y = Lab_Titulo.Location.Y
        Lab_Titulo.Location = lugar
        Lab_Titulo.Size = New System.Drawing.Size(Me.Size.Width, Lab_Titulo.Size.Height)
        ''datos de la persona
        lugar.X = 30 'Screen.PrimaryScreen.Bounds.Width   ' Me.Width / 2 - Panel1.Width / 2

        lugar.Y = Panel1.Location.Y
        Panel1.Location = lugar
        'fotos de las personas en pedido
        lugar.X = Panel1.Location.X + Panel1.Width
        Panel2.Location = lugar
        DataGridView1.Height = 480
        'cerrar boton
        lugar.X = Me.Width - Btn_Cerrar.Width - 20
        lugar.Y = Me.Height - Btn_Cerrar.Height - Btn_Cerrar.Height
        Btn_Cerrar.Location = lugar
        'consumidores
        M_PersonasPorAtender(Date.Now, False)
        'Timer_PorAtender.Start()

        If ComoNuevo = False Then
            Txt_Rut.Text = mPersona.mRut
            Dim sender As Object = Nothing
            Dim e As EventArgs = Nothing
            Btn_Obtener_Click(sender, e)
        End If
    End Sub

    Private Sub FormMain2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IniciaFormulario(True)

    End Sub
    Private Sub FormMain2_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        myUtil.FinalizeGrFinger()
        If cerrar = True Then
            LoginForm.Close()
        End If

    End Sub


#End Region
    '#Region "GrFingerX"
    '    ' -----------------------------------------------------------------------------------
    '    ' GrFingerX events
    '    ' -----------------------------------------------------------------------------------

    '    ' A fingerprint reader was plugged on system
    '    Private Sub AxGrFingerXCtrl1_SensorPlug(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent) Handles AxGrFingerXCtrl1.SensorPlug
    '        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Plugged.")
    '        AxGrFingerXCtrl1.CapStartCapture(e.idSensor)
    '    End Sub

    '    ' A fingerprint reader was unplugged from system
    '    Private Sub AxGrFingerXCtrl1_SensorUnplug(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent) Handles AxGrFingerXCtrl1.SensorUnplug
    '        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Unplugged.")
    '        AxGrFingerXCtrl1.CapStopCapture(e.idSensor)
    '    End Sub

    '    ' A finger was placed on reader
    '    Private Sub AxGrFingerXCtrl1_FingerDown(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent) Handles AxGrFingerXCtrl1.FingerDown
    '        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Finger Placed.")
    '    End Sub

    '    ' A finger was removed from reader
    '    'Private Sub AxGrFingerXCtrl1_FingerUp(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEvent) Handles AxGrFingerXCtrl1.FingerUp
    '    '    myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Finger removed.")
    '    'End Sub

    '    ' An image was acquired from reader
    '    'Private Sub AxGrFingerXCtrl1_ImageAcquired(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent) Handles AxGrFingerXCtrl1.ImageAcquired
    '    '    ' Copying aquired image
    '    '    myUtil.raw.height = e.height
    '    '    myUtil.raw.width = e.width
    '    '    myUtil.raw.res = e.res
    '    '    myUtil.raw.img = e.rawImage

    '    '    ' Signaling that an Image Event occurred.
    '    '    myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Image captured.")

    '    '    ' display fingerprint image
    '    '    '    myUtil.PrintBiometricDisplay(False, GRConstants.GR_DEFAULT_CONTEXT)

    '    '    ' now we have a fingerprint, so we can extract template

    '    '    'EnrollButton.Enabled = False

    '    '    Extracttemplate()
    '    '    Identificar()
    '    '    Txt_Rut.Focus()
    '    'End Sub
    '#End Region
#Region "Botones"
    Private Sub Btn_Rut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Rut.Click
        Dim a As Byte() = {0}
        foto = a
        GrBox_Rut.Visible = True
        Btn_Rut.Visible = False
        Txt_Rut.Text = ""
        Txt_Rut.Focus()
    End Sub

    Private Sub Btn_Obtener_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Obtener.Click
        Dim a As Byte() = {0}
        foto = a
        If Txt_Rut.Text.Replace(" ", "").Length = 0 Then
            MessageBox.Show("No hay Rut Para comparar")
            GrBox_Rut.Visible = False
            Btn_Rut.Visible = True
        Else
            M_LlenadoTexto(myUtil.ObtenerPersona(Txt_Rut.Text, Lab_Dv.Text.Replace("-", "").Replace(" ", "")))
        End If

    End Sub

    Private Sub Btn_ModificarPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click

        mPersona.mDvRut = Lab_Dv.Text.Replace("-", "").Replace(" ", "")
        Dim login As New LoginForm(mPersona, True)
        login.Show()
        Me.Hide()


    End Sub

    Private Sub Btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_OK.Click
        Txt_Rut.Text = ""

        ' add fingerprint
        If HuellaPersonaExists = False Then
            id = myUtil.Enroll(IdPersona)
        End If
        'consumo
        myUtil.IngresoConsumoPersona(IdPersona, 0, CInt(Lab_TotalConsumo2.Text))
        'persona por atender
        M_PersonasPorAtender(Date.Now, False)

        GrBox_DatosUsuario.Visible = False
        GrBox_Rut.Visible = False
        Panel_Foto.Visible = False
        PersonaExists = True
        PersonaUpdate = False
        HuellaPersonaExists = True
        'Btn_ModificarPersona.Enabled = True
        'EnrollButton.Visible = False
        M_Mensaje("Almuerzo")
        GrBox_Asistencia.Visible = False
        Btn_Rut.Visible = True
        Timer1_huella.Start()
        PrintDocument1.Print()
    End Sub
#Region "Impresion Vale"



    Public Function FormatoCodigoBarras(ByVal code As String) As String
        Dim barcode As String = String.Empty
        barcode = String.Format("{0}", code)
        Return barcode
    End Function


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fnt1 As New Font("Arial", 12.0F, FontStyle.Bold)

        'e.Graphics.RotateTransform(-90)
        'e.Graphics.DrawString(FormatoCodigoBarras(itemIngSel.IdItemIngreso.ToString), fnt1, Brushes.Black, -150, 0)

        'e.Graphics.ResetTransform()
        e.Graphics.DrawString(FormatoCodigoBarras(Now.ToString), fnt1, Brushes.Black, 30, 0)
        e.Graphics.DrawString(FormatoCodigoBarras(Lab_Nombre2.Text), fnt1, Brushes.Black, 30, 30)
        e.Graphics.DrawString(FormatoCodigoBarras(Lab_TotalConsumo2.Text), fnt1, Brushes.Black, 30, 60)
        e.Graphics.DrawString(FormatoCodigoBarras(Lab_Estamento2.Text), fnt1, Brushes.Black, 30, 60)
        e.Graphics.DrawString(FormatoCodigoBarras("-"), fnt1, Brushes.Black, 30, 160)
       
        'e.Graphics.DrawString(FormatoCodigoBarras(itemIngSel.IdItemIngreso.ToString), fuente, Brushes.Black, 30, 100)

        'e.Graphics.RotateTransform(-90)
        'e.Graphics.DrawString(FormatoCodigoBarras(itemIngSel.IdItemIngreso.ToString), fnt1, Brushes.Black, -150, 150)

        'e.Graphics.ResetTransform()
        'e.Graphics.DrawString(FormatoCodigoBarras(mIngreso.miCliente.Rut.ToString & "-" & mIngreso.miCliente.DVRut.ToString), fnt1, Brushes.Black, 30, 150)
    End Sub

#End Region
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Dim a As Byte() = {0}
        foto = a
        Timer1_huella.Interval = 100
        Timer1_huella.Start()
        PersonaExists = True
        PersonaUpdate = False
        HuellaPersonaExists = True
        GrBox_DatosUsuario.Visible = False
        GrBox_Rut.Visible = False
        GrBox_Asistencia.Visible = False
        Panel_Foto.Visible = False
        Btn_Rut.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1_huella.Tick
        M_Mensaje("Esperando La Huella")
        Timer1_huella.Stop()
        Timer1_huella.Interval = 3000
    End Sub

    Private Sub Txt_Rut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Rut.KeyPress
        'enter
        If (e.KeyChar = Chr(13)) Then
            Btn_Obtener_Click(sender, e)
        End If
        'numerico y tecla Retroceso( chr(8) )
        If (e.KeyChar > Chr(47) And e.KeyChar < Chr(58) Or e.KeyChar = Chr(8)) Then
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_Rut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Rut.TextChanged
        Lab_Dv.Text = "-  " + Valida_rut(Txt_Rut.Text)
    End Sub

    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        cerrar = False
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DataGridView1.EndEdit()

        Dim idcomida As Long = DataGridView1.Rows(e.RowIndex).Cells(1).Value

        myUtil.CheckConsumoPersona(idcomida)

        M_PersonasPorAtender(Date.Now, False)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.EndEdit()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        DataGridView1.EndEdit()
    End Sub
    Private Sub Btn_VerAtendidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_VerAtendidos.Click
        Dim srg As Asistentes = New Asistentes
        If srg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

    End Sub
   
    Private Sub NumericVisitas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumericVisitas.KeyUp
        Lab_TotalConsumo2.Text = 1 + NumericVisitas.Value
    End Sub

    Private Sub NumericVisitas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericVisitas.ValueChanged
        Lab_TotalConsumo2.Text = 1 + NumericVisitas.Value
        NumericVisitas.Select(NumericVisitas.Value.ToString.Length, 0)
    End Sub
    Private Sub NumericVisitas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumericVisitas.KeyPress
        If e.KeyChar = Chr(46) Then
            e.Handled = True
        End If
    End Sub

#End Region



End Class
