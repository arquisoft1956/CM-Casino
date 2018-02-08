Imports CasinoContable
Imports Casino.Library

Public Class LoginForm

    Private Sub OK_Click( _
      ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles OK.Click

        Security.PTPrincipal.Logout()

        Security.PTPrincipal.Login(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)

        Dim user As System.Security.Principal.IPrincipal = Csla.ApplicationContext.User

        If user.Identity.IsAuthenticated Then

            If user.IsInRole("Tesoreria") = True Then
                'Tesoreria.Show()
            End If
            If user.IsInRole("Casino") = True Then
                'FormMain2.Show()
            End If
            If user.IsInRole("Administrador") = True Then
                'Administrador.Show()
            End If
            If user.IsInRole("Contador") = True Then
                Contador.Show()
            End If

            Me.Hide()
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = "111111111"
        Else
            MessageBox.Show("Usuario no existe")
            PasswordTextBox.Text = "111111111"
        End If

    End Sub

    Private Sub Cancel_Click( _
      ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles Cancel.Click

        Me.Close()

    End Sub

    Private Sub LoginForm_Load( _
      ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles MyBase.Load


        Try
            Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(Database.CasinoConnection)
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        End Try
        Me.UsernameTextBox.Text = ""
        Me.PasswordTextBox.Text = ""

        System.Windows.Forms.Application.DoEvents()

        Me.UsernameTextBox.Focus()
    End Sub

End Class
