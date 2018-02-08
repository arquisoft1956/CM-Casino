Imports GrFingerXLib
Imports Microsoft.VisualBasic
Imports System.IO
Imports Casino.Library
Public Class Tesoreria
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "
    Private Sub ApplyAuthorizationRules()



    End Sub
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()


    End Sub

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
    Friend WithEvents Txt_Unidad As System.Windows.Forms.TextBox
    Friend WithEvents Lab_Cargos As System.Windows.Forms.Label
    Friend WithEvents Lab_Unidad As System.Windows.Forms.Label
    Friend WithEvents Lab_Nombre As System.Windows.Forms.Label
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents EnrollButton As System.Windows.Forms.Button
    Friend WithEvents Panel_Foto As System.Windows.Forms.Panel
    Friend WithEvents Btn_ExaminarFoto As System.Windows.Forms.Button
    Friend WithEvents PicBox_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents GrBox_Asistencia As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_OK As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents CbBox_CentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents Lab_CentroCosto As System.Windows.Forms.Label
    Friend WithEvents CbBox_Sindicalizado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tesoreria))
        Me.AxGrFingerXCtrl1 = New AxGrFingerXLib.AxGrFingerXCtrl
        Me.Lab_Titulo = New System.Windows.Forms.Label
        Me.Lab_Mensaje = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GrBox_Asistencia = New System.Windows.Forms.GroupBox
        Me.Btn_OK = New System.Windows.Forms.Button
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.Panel_Foto = New System.Windows.Forms.Panel
        Me.Btn_ExaminarFoto = New System.Windows.Forms.Button
        Me.PicBox_Foto = New System.Windows.Forms.PictureBox
        Me.GrBox_DatosUsuario = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CbBox_CentroCosto = New System.Windows.Forms.ComboBox
        Me.Lab_CentroCosto = New System.Windows.Forms.Label
        Me.CbBox_Sindicalizado = New System.Windows.Forms.ComboBox
        Me.Btn_CancelarModifica = New System.Windows.Forms.Button
        Me.Btn_ModificarPersona = New System.Windows.Forms.Button
        Me.Txt_Cargos = New System.Windows.Forms.TextBox
        Me.Txt_Unidad = New System.Windows.Forms.TextBox
        Me.Lab_Cargos = New System.Windows.Forms.Label
        Me.Lab_Unidad = New System.Windows.Forms.Label
        Me.Lab_Nombre = New System.Windows.Forms.Label
        Me.Txt_Nombre = New System.Windows.Forms.TextBox
        Me.EnrollButton = New System.Windows.Forms.Button
        Me.GrBox_Rut = New System.Windows.Forms.GroupBox
        Me.Lab_Rut = New System.Windows.Forms.Label
        Me.Btn_Obtener = New System.Windows.Forms.Button
        Me.Lab_Dv = New System.Windows.Forms.Label
        Me.Txt_Rut = New System.Windows.Forms.TextBox
        Me.Btn_Rut = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Cerrar = New System.Windows.Forms.Button
        CType(Me.AxGrFingerXCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GrBox_Asistencia.SuspendLayout()
        Me.Panel_Foto.SuspendLayout()
        CType(Me.PicBox_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBox_DatosUsuario.SuspendLayout()
        Me.GrBox_Rut.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxGrFingerXCtrl1
        '
        Me.AxGrFingerXCtrl1.Enabled = True
        Me.AxGrFingerXCtrl1.Location = New System.Drawing.Point(491, 32)
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
        Me.Lab_Titulo.Text = "CASINO COLEGIO MEDICO"
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
        Me.Panel1.Controls.Add(Me.GrBox_Asistencia)
        Me.Panel1.Controls.Add(Me.Panel_Foto)
        Me.Panel1.Controls.Add(Me.GrBox_DatosUsuario)
        Me.Panel1.Controls.Add(Me.GrBox_Rut)
        Me.Panel1.Controls.Add(Me.Btn_Rut)
        Me.Panel1.Controls.Add(Me.AxGrFingerXCtrl1)
        Me.Panel1.Controls.Add(Me.Lab_Mensaje)
        Me.Panel1.Location = New System.Drawing.Point(24, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 432)
        Me.Panel1.TabIndex = 27
        '
        'GrBox_Asistencia
        '
        Me.GrBox_Asistencia.Controls.Add(Me.Btn_OK)
        Me.GrBox_Asistencia.Controls.Add(Me.Btn_Cancelar)
        Me.GrBox_Asistencia.Location = New System.Drawing.Point(432, 344)
        Me.GrBox_Asistencia.Name = "GrBox_Asistencia"
        Me.GrBox_Asistencia.Size = New System.Drawing.Size(184, 64)
        Me.GrBox_Asistencia.TabIndex = 39
        Me.GrBox_Asistencia.TabStop = False
        Me.GrBox_Asistencia.Text = "Asistencia"
        Me.GrBox_Asistencia.Visible = False
        '
        'Btn_OK
        '
        Me.Btn_OK.Location = New System.Drawing.Point(16, 32)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.Btn_OK.TabIndex = 22
        Me.Btn_OK.Text = "OK"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(96, 32)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 7
        Me.Btn_Cancelar.Text = "Cancelar"
        '
        'Panel_Foto
        '
        Me.Panel_Foto.Controls.Add(Me.Btn_ExaminarFoto)
        Me.Panel_Foto.Controls.Add(Me.PicBox_Foto)
        Me.Panel_Foto.Location = New System.Drawing.Point(416, 112)
        Me.Panel_Foto.Name = "Panel_Foto"
        Me.Panel_Foto.Size = New System.Drawing.Size(208, 224)
        Me.Panel_Foto.TabIndex = 38
        Me.Panel_Foto.Visible = False
        '
        'Btn_ExaminarFoto
        '
        Me.Btn_ExaminarFoto.Location = New System.Drawing.Point(56, 192)
        Me.Btn_ExaminarFoto.Name = "Btn_ExaminarFoto"
        Me.Btn_ExaminarFoto.Size = New System.Drawing.Size(88, 23)
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
        Me.GrBox_DatosUsuario.Controls.Add(Me.Label1)
        Me.GrBox_DatosUsuario.Controls.Add(Me.CbBox_CentroCosto)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_CentroCosto)
        Me.GrBox_DatosUsuario.Controls.Add(Me.CbBox_Sindicalizado)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Btn_CancelarModifica)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Btn_ModificarPersona)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Txt_Cargos)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Txt_Unidad)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Cargos)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Unidad)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Lab_Nombre)
        Me.GrBox_DatosUsuario.Controls.Add(Me.Txt_Nombre)
        Me.GrBox_DatosUsuario.Controls.Add(Me.EnrollButton)
        Me.GrBox_DatosUsuario.Location = New System.Drawing.Point(32, 176)
        Me.GrBox_DatosUsuario.Name = "GrBox_DatosUsuario"
        Me.GrBox_DatosUsuario.Size = New System.Drawing.Size(376, 223)
        Me.GrBox_DatosUsuario.TabIndex = 37
        Me.GrBox_DatosUsuario.TabStop = False
        Me.GrBox_DatosUsuario.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Sindicalizados:"
        '
        'CbBox_CentroCosto
        '
        Me.CbBox_CentroCosto.FormattingEnabled = True
        Me.CbBox_CentroCosto.Location = New System.Drawing.Point(126, 162)
        Me.CbBox_CentroCosto.Name = "CbBox_CentroCosto"
        Me.CbBox_CentroCosto.Size = New System.Drawing.Size(232, 21)
        Me.CbBox_CentroCosto.TabIndex = 13
        '
        'Lab_CentroCosto
        '
        Me.Lab_CentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CentroCosto.Location = New System.Drawing.Point(16, 163)
        Me.Lab_CentroCosto.Name = "Lab_CentroCosto"
        Me.Lab_CentroCosto.Size = New System.Drawing.Size(104, 19)
        Me.Lab_CentroCosto.TabIndex = 12
        Me.Lab_CentroCosto.Text = "Centro Costo :"
        '
        'CbBox_Sindicalizado
        '
        Me.CbBox_Sindicalizado.FormattingEnabled = True
        Me.CbBox_Sindicalizado.Items.AddRange(New Object() {"Sindicalizados", "No Sindicalizados"})
        Me.CbBox_Sindicalizado.Location = New System.Drawing.Point(126, 128)
        Me.CbBox_Sindicalizado.Name = "CbBox_Sindicalizado"
        Me.CbBox_Sindicalizado.Size = New System.Drawing.Size(232, 21)
        Me.CbBox_Sindicalizado.TabIndex = 11
        '
        'Btn_CancelarModifica
        '
        Me.Btn_CancelarModifica.Location = New System.Drawing.Point(262, 194)
        Me.Btn_CancelarModifica.Name = "Btn_CancelarModifica"
        Me.Btn_CancelarModifica.Size = New System.Drawing.Size(75, 23)
        Me.Btn_CancelarModifica.TabIndex = 7
        Me.Btn_CancelarModifica.Text = "Cancelar"
        Me.Btn_CancelarModifica.Visible = False
        '
        'Btn_ModificarPersona
        '
        Me.Btn_ModificarPersona.Location = New System.Drawing.Point(62, 194)
        Me.Btn_ModificarPersona.Name = "Btn_ModificarPersona"
        Me.Btn_ModificarPersona.Size = New System.Drawing.Size(75, 23)
        Me.Btn_ModificarPersona.TabIndex = 6
        Me.Btn_ModificarPersona.Text = "Modificar"
        '
        'Txt_Cargos
        '
        Me.Txt_Cargos.Location = New System.Drawing.Point(126, 96)
        Me.Txt_Cargos.Name = "Txt_Cargos"
        Me.Txt_Cargos.Size = New System.Drawing.Size(232, 20)
        Me.Txt_Cargos.TabIndex = 3
        '
        'Txt_Unidad
        '
        Me.Txt_Unidad.Location = New System.Drawing.Point(126, 64)
        Me.Txt_Unidad.Name = "Txt_Unidad"
        Me.Txt_Unidad.Size = New System.Drawing.Size(232, 20)
        Me.Txt_Unidad.TabIndex = 2
        '
        'Lab_Cargos
        '
        Me.Lab_Cargos.Location = New System.Drawing.Point(16, 96)
        Me.Lab_Cargos.Name = "Lab_Cargos"
        Me.Lab_Cargos.Size = New System.Drawing.Size(56, 16)
        Me.Lab_Cargos.TabIndex = 3
        Me.Lab_Cargos.Text = "Cargos : "
        '
        'Lab_Unidad
        '
        Me.Lab_Unidad.Location = New System.Drawing.Point(16, 64)
        Me.Lab_Unidad.Name = "Lab_Unidad"
        Me.Lab_Unidad.Size = New System.Drawing.Size(56, 16)
        Me.Lab_Unidad.TabIndex = 2
        Me.Lab_Unidad.Text = "Unidad : "
        '
        'Lab_Nombre
        '
        Me.Lab_Nombre.Location = New System.Drawing.Point(16, 32)
        Me.Lab_Nombre.Name = "Lab_Nombre"
        Me.Lab_Nombre.Size = New System.Drawing.Size(56, 16)
        Me.Lab_Nombre.TabIndex = 1
        Me.Lab_Nombre.Text = "Nombre :"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(126, 32)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(232, 20)
        Me.Txt_Nombre.TabIndex = 1
        '
        'EnrollButton
        '
        Me.EnrollButton.Enabled = False
        Me.EnrollButton.Location = New System.Drawing.Point(150, 194)
        Me.EnrollButton.Name = "EnrollButton"
        Me.EnrollButton.Size = New System.Drawing.Size(96, 24)
        Me.EnrollButton.TabIndex = 4
        Me.EnrollButton.Text = "Enroll"
        Me.EnrollButton.Visible = False
        '
        'GrBox_Rut
        '
        Me.GrBox_Rut.Controls.Add(Me.Lab_Rut)
        Me.GrBox_Rut.Controls.Add(Me.Btn_Obtener)
        Me.GrBox_Rut.Controls.Add(Me.Lab_Dv)
        Me.GrBox_Rut.Controls.Add(Me.Txt_Rut)
        Me.GrBox_Rut.Location = New System.Drawing.Point(32, 104)
        Me.GrBox_Rut.Name = "GrBox_Rut"
        Me.GrBox_Rut.Size = New System.Drawing.Size(376, 64)
        Me.GrBox_Rut.TabIndex = 36
        Me.GrBox_Rut.TabStop = False
        Me.GrBox_Rut.Visible = False
        '
        'Lab_Rut
        '
        Me.Lab_Rut.Location = New System.Drawing.Point(16, 24)
        Me.Lab_Rut.Name = "Lab_Rut"
        Me.Lab_Rut.Size = New System.Drawing.Size(32, 16)
        Me.Lab_Rut.TabIndex = 14
        Me.Lab_Rut.Text = "Rut :"
        '
        'Btn_Obtener
        '
        Me.Btn_Obtener.Location = New System.Drawing.Point(240, 24)
        Me.Btn_Obtener.Name = "Btn_Obtener"
        Me.Btn_Obtener.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Obtener.TabIndex = 13
        Me.Btn_Obtener.Text = "Obtener"
        '
        'Lab_Dv
        '
        Me.Lab_Dv.AutoSize = True
        Me.Lab_Dv.Location = New System.Drawing.Point(168, 28)
        Me.Lab_Dv.Name = "Lab_Dv"
        Me.Lab_Dv.Size = New System.Drawing.Size(21, 13)
        Me.Lab_Dv.TabIndex = 12
        Me.Lab_Dv.Text = "Dv"
        '
        'Txt_Rut
        '
        Me.Txt_Rut.Location = New System.Drawing.Point(48, 24)
        Me.Txt_Rut.MaxLength = 8
        Me.Txt_Rut.Name = "Txt_Rut"
        Me.Txt_Rut.Size = New System.Drawing.Size(120, 20)
        Me.Txt_Rut.TabIndex = 0
        '
        'Btn_Rut
        '
        Me.Btn_Rut.Location = New System.Drawing.Point(32, 80)
        Me.Btn_Rut.Name = "Btn_Rut"
        Me.Btn_Rut.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Rut.TabIndex = 35
        Me.Btn_Rut.Text = "Ingresar Rut"
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Location = New System.Drawing.Point(604, 510)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cerrar.TabIndex = 29
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Tesoreria
        '
        Me.ClientSize = New System.Drawing.Size(712, 558)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lab_Titulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tesoreria"
        Me.Text = "Tesoreria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxGrFingerXCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GrBox_Asistencia.ResumeLayout(False)
        Me.Panel_Foto.ResumeLayout(False)
        CType(Me.PicBox_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBox_DatosUsuario.ResumeLayout(False)
        Me.GrBox_DatosUsuario.PerformLayout()
        Me.GrBox_Rut.ResumeLayout(False)
        Me.GrBox_Rut.PerformLayout()
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
    Dim foto As Byte()
    Dim id As Integer
#End Region
#Region "Metodos"
    Private Function M_Mensaje(ByVal condicion As String) As String
        condicion = condicion.ToLower
        If condicion = "bienvenido" Then Lab_Mensaje.Text = "Bienvenido Sr (a)..." : Lab_Mensaje.ForeColor = Color.Green
        If condicion = "huella no reconocida" Then Lab_Mensaje.Text = "La huella no fue reconocida." + Chr(10) + Chr(13) + " Debera ingresar su  rut." : Lab_Mensaje.ForeColor = Color.Red
        If condicion = "huella falta" Then Lab_Mensaje.Text = "Retire e ingrese nuevamente la huella." : Lab_Mensaje.ForeColor = Color.Blue
        If condicion = "rut no encontrado" Then Lab_Mensaje.Text = "Rut no encontrado, debera registrarse." : Lab_Mensaje.ForeColor = Color.Green
        If condicion = "esperando la huella" Then Lab_Mensaje.Text = "Esperando la Huella." : Lab_Mensaje.ForeColor = Color.Black
        If condicion = "almuerzo" Then Lab_Mensaje.Text = "Almuerzo fue registrado..." : Lab_Mensaje.ForeColor = Color.Green
        Lab_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Return ""
    End Function
    Private Sub M_EstadoTexto(ByVal estado As Boolean)
        If estado = True Then
            Txt_Nombre.BackColor = Me.BackColor
            Txt_Nombre.BorderStyle = BorderStyle.None
            Txt_Nombre.ReadOnly = True
            Txt_Unidad.BackColor = Me.BackColor
            Txt_Unidad.BorderStyle = BorderStyle.None
            Txt_Unidad.ReadOnly = True
            Txt_Cargos.BackColor = Me.BackColor
            Txt_Cargos.BorderStyle = BorderStyle.None
            Txt_Cargos.ReadOnly = True
            CbBox_CentroCosto.Enabled = False
            CbBox_Sindicalizado.Enabled = False

        Else
            Txt_Nombre.BackColor = Color.White
            Txt_Nombre.BorderStyle = BorderStyle.Fixed3D
            Txt_Nombre.ReadOnly = False
            Txt_Unidad.BackColor = Color.White
            Txt_Unidad.BorderStyle = BorderStyle.Fixed3D
            Txt_Unidad.ReadOnly = False
            Txt_Cargos.BackColor = Color.White
            Txt_Cargos.BorderStyle = BorderStyle.Fixed3D
            Txt_Cargos.ReadOnly = False
            CbBox_CentroCosto.Enabled = True
            CbBox_Sindicalizado.Enabled = True

        End If
    End Sub
    Private Sub M_LlenadoTexto(ByVal per As Library.Persona)
        Using busy As New StatusBusy("Cargando...", Me)
            GrBox_DatosUsuario.Visible = True
            CbBox_CentroCosto.Items.Clear()
            CbBox_CentroCosto.Text = 0
            CbBox_Sindicalizado.SelectedIndex = 1

            Dim myArray2 As Byte() = Library.NoHayFoto.GetImagen()


            If per.mRut <> "" Then
                PersonaExists = True
                M_EstadoTexto(True)
                Txt_Nombre.Text = per.mNombre
                Txt_Cargos.Text = per.mCargos
                Txt_Unidad.Text = per.mUnidad
                IdPersona = per.mIdPersona
                Try
                    'imagen 
                    Dim myArray As Byte() = DirectCast(per.mFoto, Byte())
                    If myArray.Length = 1 Then


                        foto = myArray2
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
                EnrollButton.Enabled = True


                CbBox_CentroCosto.Items.AddRange(myUtil.CentrosCosto.ToArray)
                Panel_Foto.Visible = True
                M_Mensaje("bienvenido")
                Btn_ModificarPersona.Enabled = True
                Btn_CancelarModifica.Visible = False
                EnrollButton.Visible = False
                GrBox_DatosUsuario.Text = "  Datos de la persona  "
                GrBox_Asistencia.Visible = True
            Else
                PersonaExists = False
                M_EstadoTexto(False)
                Try

                    foto = myArray2
                    PicBox_Foto.Image = byteArrayToImage(myArray2)
                Catch ex As Exception

                End Try

                M_Mensaje("Rut no encontrado")
                Txt_Nombre.Text = "no datos"
                Txt_Unidad.Text = "no datos"
                Txt_Cargos.Text = "no datos"
                CbBox_Sindicalizado.SelectedIndex = 1
                CbBox_CentroCosto.Text = 0
                CbBox_CentroCosto.Items.AddRange(myUtil.CentrosCosto.ToArray)
                Txt_Nombre.Focus()
                GrBox_DatosUsuario.Text = "  En rolar  "
                GrBox_Asistencia.Visible = False
                EnrollButton.Visible = True
                Btn_ModificarPersona.Enabled = False
                Btn_CancelarModifica.Visible = True
                EnrollButton.Enabled = True
                Panel_Foto.Visible = True
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
            myUtil.PrintBiometricDisplay(True, GRConstants.GR_DEFAULT_CONTEXT)
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
            ElseIf ret = GRConstants.GR_NOT_MATCH Then
                myUtil.WriteLog("Did not match with score = " & score)
            Else
                myUtil.WriteLog("Matched with score = " & score)
                ' if they match, display matching minutiae/segments/directions
                myUtil.PrintBiometricDisplay(True, GRConstants.GR_DEFAULT_CONTEXT)
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
        If ret = GRConstants.GR_BAD_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. Bad quality.")
        ElseIf ret = GRConstants.GR_MEDIUM_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. Medium quality.")
        ElseIf ret = GRConstants.GR_HIGH_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. High quality.")
        End If
        If ret >= 0 Then
            ' if no error, display minutiae/segments/directions into the image
            myUtil.PrintBiometricDisplay(True, GRConstants.GR_NO_CONTEXT)
            ' enable operations we can do over extracted template
            EnrollButton.Enabled = True
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

#End Region

#Region "New"
    Private Sub Tesoreria_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        myUtil.FinalizeGrFinger()
        If cerrar = True Then
            LoginForm.Close()
        End If

    End Sub
    Private Sub FormMain2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim err As Integer

        Dim myArray As Byte() = Library.NoHayFoto.GetImagen()
        foto = myArray
        PicBox_Foto.Image = byteArrayToImage(myArray)
        ' initialize util class
        myUtil = New Util(LogList, PictureBoxHuella, AxGrFingerXCtrl1)

        ' Initialize GrFingerX Library
        err = myUtil.InitializeGrFinger()
        ' Print result in log

        If err < 0 Then
            myUtil.WriteError(err)
            Exit Sub
        Else
            myUtil.WriteLog("**GrFingerX Initialized Successfull**")
        End If

    End Sub

#End Region
#Region "GrFingerX"
    ' -----------------------------------------------------------------------------------
    ' GrFingerX events
    ' -----------------------------------------------------------------------------------

    ' A fingerprint reader was plugged on system
    Private Sub AxGrFingerXCtrl1_SensorPlug(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent) Handles AxGrFingerXCtrl1.SensorPlug
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Plugged.")
        AxGrFingerXCtrl1.CapStartCapture(e.idSensor)
    End Sub

    ' A fingerprint reader was unplugged from system
    Private Sub AxGrFingerXCtrl1_SensorUnplug(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent) Handles AxGrFingerXCtrl1.SensorUnplug
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Unplugged.")
        AxGrFingerXCtrl1.CapStopCapture(e.idSensor)
    End Sub

    ' A finger was placed on reader
    Private Sub AxGrFingerXCtrl1_FingerDown(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent) Handles AxGrFingerXCtrl1.FingerDown
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Finger Placed.")
    End Sub

    ' A finger was removed from reader
    Private Sub AxGrFingerXCtrl1_FingerUp(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEvent) Handles AxGrFingerXCtrl1.FingerUp
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Finger removed.")
    End Sub

    ' An image was acquired from reader
    Private Sub AxGrFingerXCtrl1_ImageAcquired(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent) Handles AxGrFingerXCtrl1.ImageAcquired
        ' Copying aquired image
        myUtil.raw.height = e.height
        myUtil.raw.width = e.width
        myUtil.raw.res = e.res
        myUtil.raw.img = e.rawImage

        ' Signaling that an Image Event occurred.
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Image captured.")

        ' display fingerprint image
        myUtil.PrintBiometricDisplay(False, GRConstants.GR_DEFAULT_CONTEXT)

        ' now we have a fingerprint, so we can extract template

        EnrollButton.Enabled = False

        Extracttemplate()
        Identificar()
        Txt_Rut.Focus()
    End Sub
#End Region

    Private Sub Btn_Rut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Rut.Click
        GrBox_Rut.Visible = True
        Btn_Rut.Visible = False
        Txt_Rut.Text = ""
        Txt_Rut.Focus()
    End Sub

    Private Sub Btn_Obtener_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Obtener.Click
        M_LlenadoTexto(myUtil.ObtenerPersona(Txt_Rut.Text, Valida_rut(Txt_Rut.Text)))
    End Sub

    Private Sub Btn_ModificarPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ModificarPersona.Click
        M_EstadoTexto(False)
        PersonaUpdate = True
        Txt_Nombre.Focus()
        Btn_ModificarPersona.Enabled = False
        Btn_CancelarModifica.Visible = True
        EnrollButton.Visible = True
    End Sub

    Private Sub EnrollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollButton.Click
        Using busy As New StatusBusy("Cargando enroll...", Me)
            Try
                If (foto.Length < 2) Then

                End If
            Catch ex As Exception
                Dim a As Byte() = {0}
                foto = a
            End Try

            'busca persona
            If PersonaExists = False Then
                Dim dvrut As String = Valida_rut(Txt_Rut.Text)
                IdPersona = myUtil.addPersona(Txt_Rut.Text, dvrut, Txt_Unidad.Text, Txt_Cargos.Text, Txt_Nombre.Text, foto, CbBox_Sindicalizado.SelectedIndex, CbBox_CentroCosto.Text)
            End If

            'update persona
            If PersonaUpdate = True Then
                myUtil.UpdatePersona(IdPersona, Txt_Nombre.Text, Txt_Unidad.Text, Txt_Cargos.Text, foto, CbBox_Sindicalizado.SelectedIndex, CbBox_CentroCosto.Text)
            End If

            ' add fingerprint
            If HuellaPersonaExists = False Then
                id = myUtil.Enroll(IdPersona)
            End If

            ' write result to log
            If id >= 0 Then
                myUtil.WriteLog("Fingerprint enrolled with id = " & id)
            Else
                myUtil.WriteLog("Error: Fingerprint not enrolled")
            End If

            'foto.Clear()


            M_EstadoTexto(True)
            M_Mensaje("bienvenido")
            GrBox_Asistencia.Visible = True
            Btn_ModificarPersona.Enabled = True
            Btn_CancelarModifica.Visible = False
            EnrollButton.Visible = False
        End Using
    End Sub

    Private Sub Btn_CancelarModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CancelarModifica.Click
        Btn_CancelarModifica.Visible = False
        EnrollButton.Visible = False
        M_EstadoTexto(False)
        PersonaUpdate = False
    End Sub

    Private Sub Btn_ExaminarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ExaminarFoto.Click
        Dim stFileName As String = ""

        Dim openFileDialog1 As New OpenFileDialog

        openFileDialog1.InitialDirectory = System.Environment.CurrentDirectory
        openFileDialog1.Title = "Open Imagen"
        openFileDialog1.Filter = "JPG files (*.JPG)|*.jpg|BMP files (*.BMP)|*.bmp"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            PersonaUpdate = True
            foto = TranformaArchivos(openFileDialog1.FileName)
            Dim imagen As Image = byteArrayToImage(foto)
            PicBox_Foto.Image = imagen
            GrBox_Asistencia.Visible = False
            EnrollButton.Visible = True

        End If
    End Sub

    Private Sub Btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_OK.Click
        Txt_Rut.Text = ""

        ' add fingerprint
        If HuellaPersonaExists = False Then
            id = myUtil.Enroll(IdPersona)
        End If
        MessageBox.Show("no funciona en esta vercion")
        'myUtil.IngresoConsumoPersona(IdPersona, 1)
        GrBox_DatosUsuario.Visible = False
        GrBox_Rut.Visible = False
        Panel_Foto.Visible = False
        PersonaExists = True
        PersonaUpdate = False
        HuellaPersonaExists = True
        Btn_ModificarPersona.Enabled = True
        EnrollButton.Visible = False
        M_Mensaje("Almuerzo")
        GrBox_Asistencia.Visible = False
        Btn_Rut.Visible = True
        Timer1.Start()
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Dim a As Byte() = {0}
        foto = a
        Timer1.Interval = 100
        Timer1.Start()
        PersonaExists = True
        PersonaUpdate = False
        HuellaPersonaExists = True
        GrBox_DatosUsuario.Visible = False
        GrBox_Rut.Visible = False
        GrBox_Asistencia.Visible = False
        Panel_Foto.Visible = False
        Btn_Rut.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        M_Mensaje("Esperando La Huella")
        Timer1.Stop()
        Timer1.Interval = 3000
    End Sub

    Private Sub Txt_Rut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Rut.KeyPress

        'numerico y tecla Retroceso( chr(8) )
        If (e.KeyChar > Chr(47) And e.KeyChar < Chr(58) Or e.KeyChar = Chr(8)) Then
        Else
            e.Handled = True
        End If
        'enter
        If (e.KeyChar = Chr(13)) Then
            Btn_Obtener_Click(sender, e)
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

    Private Sub Tesoreria_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        ''verificador
        Dim lujar As Point
        lujar.Y = Me.Height

        'boton cerrar
        lujar.Y = Btn_Cerrar.Height - 5
        Btn_Cerrar.Location = lujar
        ''titulo
        lujar.X = Me.Width / 2 - Lab_Titulo.Width / 2
        lujar.Y = 10
        Lab_Titulo.Location = lujar

        ''contenido
        lujar.X = Me.Width / 2 - Panel1.Width / 2
        lujar.Y = Lab_Titulo.Location.Y + Lab_Titulo.Height + 10
        Panel1.Location = lujar

    End Sub
End Class
