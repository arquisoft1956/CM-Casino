Public Class Administrador

#Region "Variable"


    Private myutil As New Util
    Private Matriz(,) As String
    
#End Region
#Region "New"

    Private Sub Administrador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myutil = New Util()
        Dim lab As Label = New Label
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(Casino.Library.Database.CasinoConnection)
        Dim men As String = ""
        men += "ConnectionString :" + conn.ConnectionString + Chr(13) + Chr(10)
        men += "Database : " + conn.Database.ToString + Chr(13) + Chr(10)
        men += "DataSource : " + conn.DataSource.ToString + Chr(13) + Chr(10)
        men += "State :  " + conn.State.ToString + Chr(13) + Chr(10)

        lab.Text = men
        lab.AutoSize = True
        Dim lujar As Point = New Point(20, 50)
        lab.Location = lujar
        Me.Controls.Add(lab)


    End Sub
#End Region
#Region "Metodo"

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
    Private Sub M_BotonBorrarEnable()
        If Opt_Huella.Checked = True Then
            If Txt_Rut.Text.Replace(" ", "").Length > 0 And Txt_Dvrut.Text.Replace(" ", "").Length > 0 Then
                Btn_Borrar.Enabled = True
            Else
                Btn_Borrar.Enabled = False
            End If

        End If

    End Sub
    Private Sub M_DatosdePersona(ByVal per As Casino.Library.Persona, ByVal Ejecutar As String)

        Dim resultado As Integer
        If per.mRut <> "" Then
            resultado = MessageBox.Show(Ejecutar + Chr(10) + Chr(13) + per.mNombre, "", MessageBoxButtons.YesNo, MessageBoxIcon.None)
        End If

        If resultado = 6 Then 'yes
            If (Ejecutar.Equals("Borrar Huella")) Then
                myutil.EliminarHuella(per.mRut)

            End If
        End If


    End Sub

#End Region
#Region "Menu"

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarToolStripMenuItem.Click
        TabControl1.Visible = True
        TabControl1.SelectTab(0)
    End Sub

    Private Sub FotosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FotosToolStripMenuItem.Click
        TabControl1.Visible = True
        TabControl1.SelectTab(1)
    End Sub

#End Region
#Region "Botones"
    Private Sub Btn_GuardarEstados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Btn_Fotos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Fotos.Click
        Dim reader As SqlClient.SqlDataReader = Nothing
        Dim dt As New DataTable()

        Using busy As New StatusBusy("Recopilando Datos De La Base de datos...", Me)
            reader = myutil.SelecionarFotosPersona()
            dt.Load(reader)
            reader = Nothing 'vaciar memoria
        End Using

        Using busy As New StatusBusy("Recopilando Fotos...", Me)
            Try

                Dim Nofoto As Byte() = Casino.Library.NoHayFoto.GetImagen()
                Dim cont As Integer = -1
                Dim _imagen As Image() = New Image(DataGridView1.ColumnCount - 1) {}



                Dim X As Integer = -1
                Dim Y As Integer = 0
                ProgressBar1.Maximum = dt.Rows.Count - 1
                ProgressBar1.Value = 0
                ProgressBar1.BackColor = Color.Red

                Matriz = New String((dt.Rows.Count / DataGridView1.ColumnCount), DataGridView1.ColumnCount - 1) {}

                For a As Integer = 0 To dt.Rows.Count - 1

                    Dim myArray As Byte() = DirectCast(dt.Rows(a)(0), Byte()) 'foto
                    If myArray.Length < 2 Then
                        myArray = Nofoto
                    End If
                    'nombre de la persona y rut
                    Dim rut As String = dt.Rows(a)(1).ToString() + "-" + dt.Rows(a)(2).ToString()
                    Dim nombre As String = dt.Rows(a)(3).ToString()
                    rut = nombre + Chr(13) + Chr(10) + rut

                    'ingremento para la matriz de fotos y imagenes
                    X = X + 1
                    _imagen(X) = byteArrayToImage(myArray)
                    Matriz(Y, X) = rut

                    If _imagen(_imagen.Length - 1) IsNot Nothing Then

                        X = -1
                        Y = Y + 1
                        DataGridView1.Rows.Add(_imagen)
                        _imagen = New Image(DataGridView1.ColumnCount - 1) {}
                    End If
                    ProgressBar1.Value = a
                    System.Windows.Forms.Application.DoEvents()
                Next
                If _imagen(0) IsNot Nothing AndAlso _imagen(_imagen.Length - 1) Is Nothing Then
                    DataGridView1.Rows.Add(_imagen)

                End If

            Catch eee As Exception
            End Try
            ProgressBar1.Value = 0
            ProgressBar1.BackColor = Me.BackColor
        End Using
    End Sub
    Private Sub Btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Borrar.Click
        Dim per As Casino.Library.Persona = Nothing
        Using busy As New StatusBusy("Recopilando datos de la base de datos", Me)
            per = myutil.ObtenerPersona(Txt_Rut.Text, Txt_Dvrut.Text)
        End Using

        Dim resultado As Integer
        If per.mRut <> "" Then
            resultado = MessageBox.Show("Borrando Huellas de :" + Chr(10) + Chr(13) + per.mNombre, "", MessageBoxButtons.YesNo, MessageBoxIcon.None)
        End If

        If resultado = 6 Then 'yes
            myutil.EliminarHuella(per.mRut)
            Txt_Rut.Text = ""
            Txt_Dvrut.Text = ""
            Opt_Huella.Checked = False
        End If

    End Sub


    Private Sub Txt_Rut_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Rut.KeyPress
        'numerico y tecla Retroceso( chr(8) )
        If (e.KeyChar > Chr(47) And e.KeyChar < Chr(58) Or e.KeyChar = Chr(8)) Then
        Else
            e.Handled = True
        End If

        If Txt_Rut.Text.Replace(" ", "").Length > 0 Then
            Txt_Dvrut.Enabled = True
        Else
            Txt_Dvrut.Enabled = False
        End If
        M_BotonBorrarEnable()
    End Sub

    Private Sub Opt_Huella_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opt_Huella.CheckedChanged
        M_BotonBorrarEnable()
    End Sub

    Private Sub Txt_Dvrut_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar > Chr(47) And e.KeyChar < Chr(58) Or e.KeyChar = Chr(8)) Then
        Else
            e.Handled = True
        End If
        M_BotonBorrarEnable()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        MessageBox.Show(Matriz(e.RowIndex, e.ColumnIndex))
    End Sub

#End Region

End Class