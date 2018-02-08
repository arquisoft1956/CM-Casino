Public Class Rut
#Region "Variable"

    Public rut As String
    Public dv As String
    Public decision As String
#End Region
#Region "New"


    Private Sub Rut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Btn_Rut1.Text = rut
        Btn_Rut2.Text = dv

    End Sub
#End Region
#Region "Botones"


    Private Sub Btn_canselar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_canselar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Rut1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Rut1.Click
        decision = Btn_Rut1.Text
        Me.Close()
    End Sub

    Private Sub Btn_Rut2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Rut2.Click
        decision = Btn_Rut2.Text
        Me.Close()
    End Sub
#End Region
End Class