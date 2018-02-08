'-------------------------------------------------------------------------------
'GrFinger Sample
'(c) 2005 Griaule Tecnologia Ltda.
'http://www.griaule.com
'-------------------------------------------------------------------------------
'
'This sample is provided with "GrFinger Fingerprint Recognition Library" and
'can't run without it. It's provided just as an example of using GrFinger
'Fingerprint Recognition Library and should not be used as basis for any
'commercial product.
'
'Griaule Tecnologia makes no representations concerning either the merchantability
'of this software or the suitability of this sample for any particular purpose.
'
'THIS SAMPLE IS PROVIDED BY THE AUTHOR "AS IS" AND ANY EXPRESS OR
'IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
'OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
'IN NO EVENT SHALL GRIAULE BE LIABLE FOR ANY DIRECT, INDIRECT,
'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
'NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
'DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
'THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
'(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
'THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
'
'You can download the free version of GrFinger directly from Griaule website.
'
'These notices must be retained in any copies of any part of this
'documentation and/or sample.
'
'-------------------------------------------------------------------------------

' -----------------------------------------------------------------------------------
' Database routines
' -----------------------------------------------------------------------------------
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlDbType
Imports System.Runtime.InteropServices

' Template data
Public Class TTemplateSQL
    ' Template itself
    Public tpt(GrFingerXLib.GRConstants.GR_MAX_SIZE_TEMPLATE) As Byte
    ' Template size
    Public Size As Long

End Class

' Template list
Public Structure TTemplatesSQL

    ' ID
    Public ID As Integer
    ' Template itself
    Public template As TTemplateSQL

    Public tet As TTemplateSQL
End Structure


Public Class DBClassSQL
    Dim cn As SqlConnection
    ' the database we'll be connecting to
    Const DBFile As String = "../../../GrFingerSample.mdb"
    'Const ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
    Const ConnectionString As String = ""
    ' the connection object
    Dim connection As New SqlConnection

#Region "conneccion"
    ' Open connection
    Public Function StringConnection() As String
        Dim conn As String = Casino.Library.Database.CasinoConnection
        Return conn
    End Function

    Public Sub OpenBD()

        If connection.State = ConnectionState.Open Then connection.Close()
        connection.ConnectionString = StringConnection()
        connection.Open()

    End Sub

    ' Close conection
    Public Sub CloseDB()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub
#End Region

    ' Clear database
    Public Sub clearDB()

        Dim sqlCMD As SqlCommand = New SqlCommand("exe deleteBD", connection)
        ' run "clear" query
        OpenBD()
        sqlCMD.ExecuteNonQuery()
        connection.Close()

    End Sub

#Region "Persona"
    'select centrocosto
    Public Function CentrosCosto() As ArrayList
        Dim reader As SqlDataReader
        Dim comm As SqlCommand = connection.CreateCommand
        Dim arra As New ArrayList()


        OpenBD()

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[SelectCentroCosto]"

        reader = comm.ExecuteReader()

        While reader.Read()

            arra.Add(CType(reader("centrocosto"), String))
        End While

        CloseDB()
        Return arra
    End Function
    'select usuario
    Public Function ObtenerPersona(ByRef enroll As Integer) As Casino.Library.Persona
        Dim reader As SqlDataReader
        Dim per As New Casino.Library.Persona
        Dim comm As SqlCommand = connection.CreateCommand
        OpenBD()

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SelectPersona"
        comm.Parameters.AddWithValue("@enroll", enroll)
        comm.Parameters.AddWithValue("@rut", "")

        reader = comm.ExecuteReader()
        If reader.HasRows = True Then
            reader.Read()
            If reader("nombre").ToString <> "" Then per.mNombre = CType(reader("nombre"), String)
            If reader("unidad").ToString <> "" Then per.mUnidad = CType(reader("unidad"), String)
            If reader("cargos").ToString <> "" Then per.mCargos = CType(reader("cargos"), String)
            If reader("CentroCosto").ToString <> "" Then per.mCentroCosto = CType(reader("CentroCosto"), String)
            If reader("Estamento").ToString <> "" Then per.mEstamento = CType(reader("Estamento"), String)
            If reader("Sindicalizados").ToString <> "" Then per.mSindicalizado = CType(reader("Sindicalizados"), Integer)

            per.mIdPersona = CType(reader("idpersona"), Integer)
            per.mFoto = DirectCast(reader("foto"), Byte())
            per.mRut = CType(reader("rut"), String)
            per.Titular = CType(reader("titular"), Integer)
        End If

        CloseDB()
        Return per
    End Function
    'select usuario
    Public Function ObtenerPersona(ByRef rut As String, ByRef dvRut As String) As Casino.Library.Persona

        Dim reader As SqlDataReader
        Dim per As New Casino.Library.Persona
        Dim comm As SqlCommand = connection.CreateCommand

        OpenBD()
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SelectPersona"
        comm.Parameters.AddWithValue("@enroll", "")
        comm.Parameters.AddWithValue("@rut", rut)

        reader = comm.ExecuteReader()
        If reader.HasRows = True Then
            reader.Read()
            If reader("nombre").ToString <> "" Then per.mNombre = CType(reader("nombre"), String)
            If reader("unidad").ToString <> "" Then per.mUnidad = CType(reader("unidad"), String)
            If reader("cargos").ToString <> "" Then per.mCargos = CType(reader("cargos"), String)
            If reader("CentroCosto".ToString) <> "" Then per.mCentroCosto = CType(reader("CentroCosto"), String)
            If reader("Estamento").ToString <> "" Then per.mEstamento = CType(reader("Estamento"), String)
            If reader("Sindicalizados").ToString <> "" Then per.mSindicalizado = CType(reader("Sindicalizados"), Integer)

            per.mIdPersona = CType(reader("idpersona"), Integer)
            per.mFoto = DirectCast(reader("foto"), Byte())
            per.mRut = CType(reader("rut"), String)
            per.Titular = CType(reader("titular"), Integer)
        End If
        CloseDB()
        Return per

    End Function
    'update persona
    Public Function UpdatePersona(ByRef persona As Integer, ByRef nombre As String, ByVal foto As Byte()) As Long
        Dim id As Integer

        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()

        cm.CommandText = "UpdatePersona"
        With cm
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@id", persona)
            .Parameters.AddWithValue("@nombre", nombre)
            .Parameters.AddWithValue("@foto", foto)
            id = .ExecuteScalar
        End With
        ' Fill DataSet.

        connection.Close()

        Return persona
    End Function
    'add persona
    Public Function AddPersona(ByRef rut As String, ByRef dvRut As String, ByVal nombre As String, ByVal foto As Byte()) As Long

        Dim id As Integer
        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()
        cm.CommandText = "addPersona"
        With cm
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@rut", rut)
            .Parameters.AddWithValue("@dvrut", dvRut)
            .Parameters.AddWithValue("@nombre", nombre)
            .Parameters.AddWithValue("@foto", foto)
            id = .ExecuteScalar

        End With
        ' Fill DataSet.
        connection.Close()
        Return id

    End Function
    'eliminar huella
    Public Sub EliminarHuella(ByVal Rut As String)

        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()
        cm.CommandText = "deleteHuellaPorRut"
        cm.CommandType = CommandType.StoredProcedure
        cm.Parameters.AddWithValue("@rut", Rut)
        cm.ExecuteScalar()
        connection.Close()

    End Sub
    'select persona y fotos
    Public Function SelecionarFotosPersona() As SqlDataReader
        Dim reader As SqlDataReader = Nothing
        OpenBD()

        Dim comm As SqlCommand = connection.CreateCommand
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SelectFotosPersona"
        reader = comm.ExecuteReader(CommandBehavior.CloseConnection)

        Return reader
    End Function

#End Region
#Region "Empleado"
    'add empleado
    Public Function UpdateEmpleado(ByRef persona As Integer, ByRef unidad As String, ByRef cargos As String, ByVal Sindicalizado As Integer, ByVal CentroCosto As String) As Long
        Dim id As Integer
        
        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()
        cm.CommandText = "UpdateEmpleado"
        With cm
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@persona", persona)
            .Parameters.AddWithValue("@unidad", unidad)
            .Parameters.AddWithValue("@cargos", cargos)
            .Parameters.AddWithValue("@Sindicalizado", Sindicalizado)
            .Parameters.AddWithValue("@CentroCosto", CentroCosto)
            Try
                id = .ExecuteScalar()
            Catch ex As Exception

            End Try

        End With
        ' Fill DataSet.

        connection.Close()

        Return id

    End Function
    'add empleado
    Public Function AddEmpleado(ByRef persona As Integer, ByRef unidad As String, ByRef cargos As String, ByVal Sindicalizado As Integer, ByVal CentroCosto As String) As Long
        Dim id As Integer

        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()
        cm.CommandText = "addEmpleado"
        With cm
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@persona", persona)
            .Parameters.AddWithValue("@unidad", unidad)
            .Parameters.AddWithValue("@cargos", cargos)
            .Parameters.AddWithValue("@Sindicalizado", Sindicalizado)
            .Parameters.AddWithValue("@CentroCosto", CentroCosto)
            id = .ExecuteScalar
        End With
        ' Fill DataSet.

        closeDB()

        Return id
    End Function
#End Region
#Region "Consumo"
    Public Function ConsumosPorCentroCostoyMes(ByVal Año As Integer, ByVal Mes As Integer, ByVal CentroCosto As String, ByVal Sindicalizados As Integer) As SqlDataAdapter
        OpenBD()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SelectConsumosPorCentroCostoyMes", Me.connection)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@año", Año)
        da.SelectCommand.Parameters.AddWithValue("@mes", Mes)
        da.SelectCommand.Parameters.AddWithValue("@centrocosto", CentroCosto)
        da.SelectCommand.Parameters.AddWithValue("@sindicalizados", Sindicalizados)
        da.Fill(dt) 'ejecutor sql o ExecuteReader
        CloseDB()
        Return da

    End Function
    Public Function ConsumosPorMes(ByVal Año As Integer, ByVal Mes As Integer) As SqlDataAdapter
        OpenBD()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SelectConsumosPorMes", Me.connection)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@año", Año)
        da.SelectCommand.Parameters.AddWithValue("@mes", Mes)
        da.Fill(dt) 'ejecutor sql o ExecuteReader
        CloseDB()
        Return da

    End Function
    Public Function ConsumosPorFecha(ByVal rut As String, ByVal fecha As Date) As SqlDataReader
        Dim reader As SqlDataReader
        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()
        cm.CommandText = "SelectConsumoPorRutFecha"
        cm.CommandType = CommandType.StoredProcedure
        cm.Parameters.AddWithValue("Rut", rut)
        cm.Parameters.AddWithValue("@fecha", fecha)
        reader = cm.ExecuteReader(CommandBehavior.CloseConnection)

        Return reader

    End Function
    Public Function ConsumosDelete(ByVal NumerosDeConsumos As String) As Boolean
        NumerosDeConsumos = NumerosDeConsumos + ","

        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()
        cm.CommandText = "DeleteConsumos"
        cm.CommandType = CommandType.StoredProcedure
        cm.Parameters.AddWithValue("@NumerosDeConsumos", NumerosDeConsumos)
        cm.ExecuteScalar()
        CloseDB()

        Return True

    End Function
    'add insumo de persona
    Public Function IngresoConsumoPersona(ByRef persona As Integer, ByVal LugardeConsumo As Integer, ByVal CantidadVisitas As Integer) As Long


        Dim id As Integer
        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()

        cm.CommandText = "addConsumo"
        With cm
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@Persona", persona)
            .Parameters.AddWithValue("@LugardeConsumo", LugardeConsumo)
            .Parameters.AddWithValue("@CantidadVisitas", CantidadVisitas)
            id = .ExecuteScalar

        End With

        connection.Close()

        Return id


    End Function

    Public Function CheckConsumoPersona(ByRef idConsumo As Integer) As Long


        Dim id As Integer
        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()
        cm.CommandText = "UpdateConsumo"
        With cm
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@idconsumo", idConsumo)

            id = .ExecuteScalar

        End With

        connection.Close()

        Return id


    End Function

    Public Function VerAsistentes(ByRef fecha As Date) As SqlDataReader
        Dim reader As SqlDataReader
        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()
        cm.CommandText = "SelectVerAsistentes"
        cm.CommandType = CommandType.StoredProcedure
        cm.Parameters.AddWithValue("@fecha", fecha)

        reader = cm.ExecuteReader(CommandBehavior.CloseConnection)

        Return reader


    End Function
    Public Function PorAtender(ByRef fecha As Date, ByRef Chekeado As Boolean) As SqlDataReader
        Dim reader As SqlDataReader
        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()
        cm.CommandText = "[SelectConsumoPorAtender]"
        cm.CommandType = CommandType.StoredProcedure
        cm.Parameters.AddWithValue("@fecha", fecha)
        If Chekeado = True Then
            cm.Parameters.AddWithValue("@Atendido", 1)
        Else
            cm.Parameters.AddWithValue("@Atendido", 0)
        End If

        reader = cm.ExecuteReader(CommandBehavior.CloseConnection)

        Return reader


    End Function
#End Region
#Region "enroll"
    Private Sub DoInsertUpdate(ByVal cm As SqlCommand)



    End Sub
    ' Add template to database. Returns added template ID.

    Public Function AddTemplate(ByRef template As TTemplateSQL, ByRef Persona As Integer) As Long


        Dim id As Integer
        Dim cm As SqlCommand = connection.CreateCommand
        OpenBD()
        cm.CommandText = "addHuella"
        With cm
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@template", template.tpt)
            .Parameters.AddWithValue("@Persona", Persona)
            id = .ExecuteScalar()

        End With

        connection.Close()

        Return id

    End Function

    ' Event procedure for OnRowUpdated
    Private Sub OnRowUpdated(ByVal sender As Object, ByVal args As SqlRowUpdatedEventArgs)
        ' Include a variable and a command to retrieve identity value
        ' from Access database.
        Dim newID As Integer = 0
        OpenBD()
        Dim idCMD As SqlCommand = New SqlCommand("SELECT @@IDENTITY", connection)

        If args.StatementType = StatementType.Insert Then
            ' Retrieve identity value and store it in column
            newID = CInt(idCMD.ExecuteScalar())
            args.Row("ID") = newID
        End If
    End Sub

    ' Returns a DataTable with all enrolled templates from database.
    Public Function getTemplates() As TTemplatesSQL()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("select * from enroll", connection)
        Dim ttpts As TTemplatesSQL()
        Dim i As Integer
        OpenBD()
        ' Get query response
        Try
            da.Fill(ds)
        Catch ex As Exception

        End Try

        Dim tpts As DataRowCollection = ds.Tables(0).Rows
        ' Create response array
        ReDim ttpts(tpts.Count)
        ' No results?
        If tpts.Count = 0 Then Return ttpts
        ' get each template and put results in our array
        For i = 1 To tpts.Count
            ttpts(i).template = New TTemplateSQL
            ttpts(i).ID = tpts.Item(i - 1).Item("ID")
            ttpts(i).template.tpt = tpts.Item(i - 1).Item("template")
            ttpts(i).template.Size = ttpts(i).template.tpt.Length
        Next
        Return ttpts
    End Function

    ' Returns template with supplied ID.
    Public Function getTemplate(ByVal id As Long) As Byte()
        Dim ds As New DataSet
        'connection.ConnectionString = OpenDB()
        OpenBD()
        Dim da As New SqlDataAdapter("select * from enroll where ID = " & id, connection)
        Dim tpt As New TTemplateSQL

        ' Get query response
        da.Fill(ds)
        Dim tpts As DataRowCollection = ds.Tables(0).Rows
        ' No results?
        If tpts.Count <> 1 Then Return Nothing
        ' Deserialize template and return it
        Return tpts.Item(0).Item("template")
    End Function
 
#End Region

End Class
