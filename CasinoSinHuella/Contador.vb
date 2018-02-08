Imports System.Data.SqlClient
Imports System.Data
Imports Casino.Library


Public Class Contador

#Region "Variable"
    Dim myUtil As New Casino.Library.DBClassSQL
    Dim cn As SqlConnection

#End Region
#Region "New"

    Private Sub Contador1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myUtil = New DBClassSQL
        Dim FechaActual As Date
        FechaActual = Date.Now
        If (FechaActual.Month = 1) Then
            Txt_Año.Text = FechaActual.Year - 1
            Txt_AñoCentroCosto.Text = FechaActual.Year - 1
            Txt_Mes.Text = 12
            Txt_MesCentroCosto.Text = 12
        Else
            Txt_Año.Text = FechaActual.Year
            Txt_AñoCentroCosto.Text = FechaActual.Year
            Txt_Mes.Text = FechaActual.Month - 1
            Txt_MesCentroCosto.Text = FechaActual.Month - 1
        End If


        CbBox_CentroCosto.Items.AddRange(myUtil.CentrosCosto().ToArray)

    End Sub
    Private Sub Contador_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub
#End Region

#Region "Botones o Ejecutores"

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        CbBox_CentroCosto.SelectedIndex = 0
        CbBox_Sindicalizados.SelectedIndex = 0
    End Sub

    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Using busy As New StatusBusy("Cargando Consumo del Mes...", Me)

            'coneccions base de datos
            Dim miSQL As SqlDataAdapter = myUtil.ConsumosPorMes(CType(Txt_Año.Text, Integer), CType(Txt_Mes.Text, Integer))

            'tablas de almasenamiento
            Dim mConsumosPorMes As New ConsumosPorMes

            miSQL.TableMappings.Add("Table", "ConsumoPorMes")
            miSQL.TableMappings.Add("Table1", "SubTotalConsumo")

            'mostrar en grilla 
            miSQL.Fill(mConsumosPorMes)
            Dim mirpt As New ConsumoPorMes
            mirpt.SetDataSource(mConsumosPorMes)
            CrystalReportViewer1.DisplayGroupTree = False
            CrystalReportViewer1.ReportSource = mirpt

        End Using

    End Sub
    Private Sub Btn_buscarCentrocosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_buscarCentrocosto.Click
        Using busy As New StatusBusy("Cargando Centro Costo por mes...", Me)

            'conecciones base de datos

            Dim miSQL As SqlDataAdapter = myUtil.ConsumosPorCentroCostoyMes(CType(Txt_AñoCentroCosto.Text, Integer), CType(Txt_MesCentroCosto.Text, Integer), CbBox_CentroCosto.Text, CbBox_Sindicalizados.SelectedIndex)

            'tablas de almasenamiento
            Dim mConsumosPorMes As New ConsumosPorMes
            miSQL.TableMappings.Add("Table", "ConsumoPorMes")
            miSQL.TableMappings.Add("Table1", "SubTotalConsumo")
            miSQL.Fill(mConsumosPorMes)

            'mostrar en grilla
            Dim mirpt As New ComsumoCentroCostoPorMes2
            'Dim mirpt As New CrystalReport1

            mirpt.SetDataSource(mConsumosPorMes)
            CrystalReportViewer2.DisplayGroupTree = False
            CrystalReportViewer2.ReportSource = mirpt

        End Using
    End Sub
#End Region

End Class