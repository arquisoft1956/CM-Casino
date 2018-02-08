'Imports Casino.Library
Public Class Consumos
#Region "Negocio"


    Dim mUtil As Util = New Util
    Dim mPersona As Library.Persona
    Dim mConsumosBorrar As String = ""
#End Region

#Region "new"
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
  
    End Sub
    Public Sub New(ByVal persona As Library.Persona)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        mPersona = persona
        LabNombre2.Text = mPersona.mNombre
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        BtnBuscarConsumo_Click(sender:=Nothing, e:=Nothing)
    End Sub
#End Region
#Region "Contrucion"
    Private Sub TxtRut_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub BtnBuscarConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarConsumo.Click
        LabSubMensaje.Text = "Buscando"
        Application.DoEvents()


        Dim mFecha As Date = DateTime.Now
        mFecha = DTPFechaHasta.Value

        Dim Atendidos As SqlClient.SqlDataReader = mUtil.ConsumosPorFecha(mPersona.mRut, mFecha)
        If Atendidos.HasRows = True Then
            GridViewConsumos.Rows.Clear()
            While Atendidos.Read

                Dim array() As String = {Atendidos("ID"), Atendidos("Fecha"), Atendidos("Nombre"), Atendidos("Descripcion")}
                GridViewConsumos.Rows.Add(array)

            End While
            Atendidos.Close()
        Else
            GridViewConsumos.Rows.Clear()
        End If

        LabSubMensaje.Text = ""
    End Sub
    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Dim cont As Int32
        For row As Int32 = 0 To GridViewConsumos.Rows.Count - 1
            If GridViewConsumos.Rows(row).Cells("sel").Value Then
                mConsumosBorrar += (GridViewConsumos.Rows(row).Cells(0).Value) + ","
                cont += 1
            End If
        Next row

        If Not mConsumosBorrar.Replace(",", "").Equals("") Then
            mConsumosBorrar = mConsumosBorrar.Substring(0, mConsumosBorrar.Length - 1)

            If MessageBox.Show("¿Esta seguro que desea borrar " + cont.ToString + " consumos? " + Chr(13) + Chr(10) + mConsumosBorrar, "Borrar Consumo de " + LabNombre2.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                mUtil.ConsumosDelete(mConsumosBorrar)
                mConsumosBorrar = ""
                BtnBuscarConsumo_Click(sender:=Nothing, e:=Nothing)
            End If
        End If
    End Sub
    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
#End Region

#Region "Metodos"

#End Region





End Class