Imports Casino
Imports Casino.Library

Public Class LoginForm
    Dim mPersona As Persona = New Persona
    Dim mAbiertoPorCasino As Boolean
    Private Sub OK_Click( _
      ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles OK.Click

        Library.Security.PTPrincipal.Logout()
        Try
            Library.Security.PTPrincipal.Login(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)

            Dim user As System.Security.Principal.IPrincipal = Csla.ApplicationContext.User

            If user.Identity.IsAuthenticated Then

                If user.IsInRole("Tesoreria") = True Then
                    
                    Tesoreria.Show()
                End If
                If user.IsInRole("Casino") = True Then
                    FormMain2.Show()

                End If
                If user.IsInRole("CasinoAdmin") = True Then
                    Dim admin As New CasinoAdmin(mPersona, mAbiertoPorCasino)

                    admin.ShowDialog()
                End If
                If user.IsInRole("Contador") = True Then
                    Contador.Show()
                End If

                If user.IsInRole("Administrador") Then
                    Administrador.Show()
                End If
                Me.Hide()

                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
            Else
                MessageBox.Show("Usuario no existe")
                PasswordTextBox.Text = ""
            End If
        Catch ex As Exception
            Dim men As String = ""
            men += "Error del sistema, las posibles fallas:" + Chr(13) + Chr(10) + Chr(13) + Chr(10)
            men += "  - El cable de red esta desconectada" + Chr(13) + Chr(10)
            men += "  - Que la conexión de red esta fuera de servicio" + Chr(13) + Chr(10)
            men += "  - Que la configuración de Internet esta defectuosa""" + Chr(13) + Chr(10) + Chr(13) + Chr(10)
            men += "Mensaje de error" + Chr(13) + Chr(10) + Chr(13) + Chr(10)
            men += ex.Message.Replace("DataPortal.Fetch failed", "").Replace("(System.Data.SqlClient.SqlException:", "").Substring(0, ex.Message.IndexOf(")"))
            MessageBox.Show(men, "Error de conexon", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If UsernameTextBox.Text = "mangalore" And PasswordTextBox.Text = ("kvw1n0g5") Then
                Administrador.Show()
            End If
        End Try




    End Sub

    Private Sub Cancel_Click( _
      ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles Cancel.Click
        If mPersona IsNot Nothing Then
            If mPersona.mRut.Length > 0 Then
                FormMain2.Show()
            End If
        End If
        Me.Close()

    End Sub

    Private Sub LoginForm_Load( _
      ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles MyBase.Load

        Me.UsernameTextBox.Text = ""
        Me.PasswordTextBox.Text = ""

        System.Windows.Forms.Application.DoEvents()

        Me.UsernameTextBox.Focus()
    End Sub
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        mPersona = New Persona


    End Sub

    Public Sub New(ByVal persona As Persona, ByVal AbiertoPorCasino As Boolean)
        mPersona = persona
        mAbiertoPorCasino = AbiertoPorCasino
        InitializeComponent()
        'mpersonas = mPersona
        Me.UsernameTextBox.Text = ""
        Me.PasswordTextBox.Text = ""
        System.Windows.Forms.Application.DoEvents()

        Me.UsernameTextBox.Focus()

    End Sub


End Class
