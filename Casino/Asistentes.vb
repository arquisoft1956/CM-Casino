Public Class Asistentes

#Region "Variable"
    Dim myUtil As Library.DBClassSQL = New Library.DBClassSQL
    Dim LogList As ListBox = New ListBox
    Dim PictureBoxHuella As PictureBox = New PictureBox
#End Region
#Region "New"


    Private Sub Atendidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Lab_Fecha.Text = Date.Today
        M_PersonasPorAtender(Date.Now, True)

    End Sub
#End Region
#Region "Metodos"


    Private Sub M_PersonasPorAtender(ByRef fecha As Date, ByRef Checkeado As Boolean)

        Dim Atendidos As SqlClient.SqlDataReader = myUtil.VerAsistentes(Date.Now)
        If Atendidos.HasRows = True Then
            DataGridView1.Rows.Clear()
            While Atendidos.Read

                Dim array() As String = {Atendidos("rut") + " - " + Atendidos("dvrut"), Atendidos("nombre")}
                DataGridView1.Rows.Add(array)

            End While
            Atendidos.Close()
        Else
            DataGridView1.Rows.Clear()
        End If

    End Sub
#End Region
#Region "Botones"


    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub
#End Region

End Class