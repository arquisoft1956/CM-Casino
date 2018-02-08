Imports GrFingerXLib
Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Diagnostics
Imports Casino.Library

Public Class CasinoAdmin


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
    Dim mAbiertoPorCasino As Boolean
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
        If condicion = "no titular" Then Lab_Mensaje.Text = "No es titular"
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

            mPersona = per
            Dim myArray2 As Byte() = Library.NoHayFoto.GetImagen()


            If per.mRut <> "" Then
                PersonaExists = True
                M_EstadoTexto(True)
                Txt_Nombre.Text = per.mNombre
                Txt_Cargos.Text = per.mCargos
                Txt_Unidad.Text = per.mUnidad
                CbBox_CentroCosto.Text = per.mCentroCosto
                CbBox_Sindicalizado.SelectedIndex = per.mSindicalizado
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
                CbBox_CentroCosto.Items.AddRange(myUtil.CentrosCosto.ToArray)
                EnrollButton.Enabled = True
                Panel_Foto.Visible = True
                M_Mensaje("bienvenido")
                Btn_ModificarPersona.Enabled = True
                Btn_CancelarModifica.Visible = False
                EnrollButton.Visible = False
                GrBox_DatosUsuario.Text = "  Datos de la persona  "

            Else
                If Txt_Rut.Text.Length = 8 Then
                    Dim rut As Rut = New Rut()
                    rut.rut = Txt_Rut.Text + Lab_Dv.Text
                    rut.dv = Txt_Rut.Text.Substring(0, Txt_Rut.Text.Length - 1) + " - " + Valida_rut(Txt_Rut.Text.Substring(0, Txt_Rut.Text.Length - 1))
                    rut.ShowDialog()
                    Dim d() As String
                    If rut.decision <> "" Then
                        d = rut.decision.Replace(" ", "").Split("-")
                        Txt_Rut.Text = d(0)
                        Lab_Dv.Text = " - " & d(1)
                    Else
                        GrBox_DatosUsuario.Visible = False
                        GrBox_Rut.Visible = False
                        Btn_Rut.Visible = True
                        Exit Sub
                    End If

                End If

                PersonaExists = False
                M_EstadoTexto(False)
                Try
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
    'Private Sub Identificar()
    '    Dim ret As Integer, score As Integer

    '    score = 0
    '    ' identify it
    '    ret = myUtil.Identify(score)
    '    ' write result to log 
    '    Dim lujar As Point = New Point
    '    lujar.Y = GrBox_Rut.Location.Y + GrBox_Rut.Height + 10
    '    lujar.X = GrBox_Rut.Location.X
    '    GrBox_DatosUsuario.Location = lujar

    '    If ret > 0 Then
    '        myUtil.WriteLog("Fingerprint identified. ID = " & ret & ". Score = " & score & ".")
    '        myUtil.PrintBiometricDisplay(True, GRConstants.GR_DEFAULT_CONTEXT)
    '        GrBox_Rut.Visible = False
    '        GrBox_DatosUsuario.Visible = True
    '        Panel_Foto.Visible = True
    '        M_Mensaje("bienvenido")
    '        GrBox_DatosUsuario.Location = GrBox_Rut.Location
    '        Btn_Rut.Visible = False
    '        M_LlenadoTexto(myUtil.ObtenerPersona(ret))


    '    ElseIf ret = 0 Then
    '        myUtil.WriteLog("Fingerprint not Found.")
    '        GrBox_Rut.Visible = True
    '        GrBox_DatosUsuario.Visible = False

    '        Panel_Foto.Visible = False
    '        HuellaPersonaExists = False
    '        M_Mensaje("huella no reconocida")
    '        Txt_Rut.Text = ""
    '        Btn_Rut.Visible = False
    '    Else
    '        Txt_Rut.Text = ""
    '        myUtil.WriteError(ret)
    '        GrBox_Rut.Visible = False
    '        GrBox_DatosUsuario.Visible = False
    '        Panel_Foto.Visible = False
    '        M_Mensaje("huella falta")
    '        Btn_Rut.Visible = True

    '    End If
    'End Sub
    'Private Sub Verificar()
    '    Dim ret As Integer
    '    Dim score As Integer
    '    Dim sid As String

    '    ' ask target fingerprint ID
    '    score = 0
    '    sid = InputBox("Enter the ID to verify", "Verify", "")
    '    If sid <> "" Then
    '        ' compare fingerprints
    '        ret = myUtil.Verify(Val(sid), score)
    '        ' write result to log
    '        If ret < 0 Then
    '            myUtil.WriteError(ret)
    '        ElseIf ret = GRConstants.GR_NOT_MATCH Then
    '            myUtil.WriteLog("Did not match with score = " & score)
    '        Else
    '            myUtil.WriteLog("Matched with score = " & score)
    '            ' if they match, display matching minutiae/segments/directions
    '            myUtil.PrintBiometricDisplay(True, GRConstants.GR_DEFAULT_CONTEXT)
    '        End If
    '    End If
    'End Sub
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
    'Private Sub Extracttemplate()

    '    Dim ret As Integer

    '    ' extract template
    '    ret = myUtil.ExtractTemplate()
    '    ' write template quality to log
    '    If ret = GRConstants.GR_BAD_QUALITY Then
    '        myUtil.WriteLog("Template extracted successfully. Bad quality.")
    '    ElseIf ret = GRConstants.GR_MEDIUM_QUALITY Then
    '        myUtil.WriteLog("Template extracted successfully. Medium quality.")
    '    ElseIf ret = GRConstants.GR_HIGH_QUALITY Then
    '        myUtil.WriteLog("Template extracted successfully. High quality.")
    '    End If
    '    If ret >= 0 Then
    '        ' if no error, display minutiae/segments/directions into the image
    '        myUtil.PrintBiometricDisplay(True, GRConstants.GR_NO_CONTEXT)
    '        ' enable operations we can do over extracted template
    '        EnrollButton.Enabled = True
    '    Else
    '        ' write error to log
    '        myUtil.WriteError(ret)
    '    End If
    'End Sub
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

            While PorAtender.Read

                Dim idcomida As String = PorAtender("id")

                'imagen 
                'Dim myArray As Byte() = DirectCast(PorAtender("foto"), Byte())
                'If myArray.Length = 1 Then
                'Dim fra As String = M_Foto_Temporal(PorAtender("nombre"))

                Dim ARRAY() As String = {PorAtender("rut") + " - " + PorAtender("DVrut") & " " & PorAtender("nombre"), PorAtender("ID")}

                'DataGridView1.Rows(tamaño + 1).Cells(0).Value = PorAtender("rut") & " " & PorAtender("nombre")   ' Image.FromFile(Environment.CurrentDirectory + fra)
                'DataGridView1.Rows(tamaño + 1).Height = 50
                'DataGridView1.Rows(tamaño + 1).Cells(1).Value = idcomida


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

        End If
        Dim timer2 As Date = Date.Now

        'Label1.Text = (timer2 - time1).ToString
        Return PorAtender
    End Function

#End Region

#Region "New"


    Private Sub FormMain2_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        myUtil.FinalizeGrFinger()
        If cerrar = True Then
            Me.Close()
        End If
        If mAbiertoPorCasino Then
            Dim ad As New FormMain2(mPersona)
            ad.Show()
        End If
    End Sub

    Public Sub New(ByVal Personas As Persona, ByVal AbiertoPorCasino As Boolean)
        InitializeComponent()
        mPersona = Personas
        mAbiertoPorCasino = AbiertoPorCasino
        Dim myArray As Byte() = Library.NoHayFoto.GetImagen()
        PicBox_Foto.Image = byteArrayToImage(myArray)


        ' initialize util class
        myUtil = New Util(LogList, PictureBoxHuella, AxGrFingerXCtrl1)

        Dim err As Integer
        ' Initialize GrFingerX Library
        err = myUtil.InitializeGrFinger()
        ' Print result in log
        Try
            If err < 0 Then
                myUtil.WriteError(err)

            Else
                myUtil.WriteLog("**GrFingerX Initialized Successfull**")
            End If
        Catch ex As Exception

        End Try

        If mPersona Is Nothing Then
        ElseIf mPersona.mRut <> "" Then
            Dim sender As Object = Nothing
            Dim e As EventArgs = Nothing
            Btn_Rut_Click(sender, e)
            Txt_Rut.Text = mPersona.mRut


            Btn_Obtener_Click(sender, e)
        End If

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

        'cerrar boton
        lugar.X = Me.Width - Btn_Cerrar.Width - 20
        lugar.Y = Me.Height - Btn_Cerrar.Height - Btn_Cerrar.Height
        Btn_Cerrar.Location = lugar
        'consumidores
        M_PersonasPorAtender(Date.Now, False)
        'Timer_PorAtender.Start()
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
    'Extract a template from a fingerprint image 
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
            'EnrollButton.Enabled = True
        Else
            ' write error to log
            myUtil.WriteError(ret)
        End If
    End Sub
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


        ElseIf ret = 0 Then
            myUtil.WriteLog("Fingerprint not Found.")
            GrBox_Rut.Visible = True
            GrBox_DatosUsuario.Visible = False

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
#End Region
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
            M_LlenadoTexto(myUtil.ObtenerPersona(Txt_Rut.Text, Valida_rut(Txt_Rut.Text)))
        End If

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
        Using busy As New StatusBusy("Cargando Enroll...", Me)

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

            EnrollButton.Visible = True

        End If
    End Sub



    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As Byte() = {0}
        foto = a
        Timer1_huella.Interval = 100
        Timer1_huella.Start()
        PersonaExists = True
        PersonaUpdate = False
        HuellaPersonaExists = True
        GrBox_DatosUsuario.Visible = False
        GrBox_Rut.Visible = False

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

    End Sub





    Private Sub Btn_VerAtendidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim srg As Asistentes = New Asistentes
        If srg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

    End Sub
    Private Sub CbBox_Sindicalizado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbBox_Sindicalizado.SelectedIndexChanged
        PersonaUpdate = True
    End Sub

    Private Sub CbBox_CentroCosto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbBox_CentroCosto.SelectedIndexChanged
        PersonaUpdate = True
    End Sub

    Private Sub CbBox_CentroCosto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbBox_CentroCosto.KeyPress
        PersonaUpdate = True
    End Sub
    Private Sub Btn_IngresarOtraPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_IngresarOtraPersona.Click
        Txt_Rut.Text = ""
        Txt_Nombre.Text = ""
        Txt_Unidad.Text = ""
        Txt_Cargos.Text = ""
        Lab_Dv.Text = ""
        GrBox_DatosUsuario.Visible = False

    End Sub
    Private Sub BorrarConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarConsumo.Click
        Dim con As New Consumos(mPersona)
        con.ShowDialog()
    End Sub
#End Region





End Class
