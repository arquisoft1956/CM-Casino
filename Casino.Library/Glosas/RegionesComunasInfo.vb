
<Serializable()> _
Public Class RegionesComunasInfo
    Inherits ReadOnlyBase(Of RegionesComunasInfo)

    Private mId As Int16
    Private mGlosa As String
    Private mPadre As Int16
    Private mGlosaPadre As String

    Public Property Id() As Int16
        Get
            Return mId
        End Get
        Set(ByVal Value As Int16)
            If mId <> Value Then
                mId = Value
            End If
        End Set
    End Property

    Public Property Padre() As Int16
        Get
            Return mPadre
        End Get
        Set(ByVal Value As Int16)
            If mPadre <> Value Then
                mPadre = Value
            End If
        End Set
    End Property

    Public Property Glosa() As String
        Get
            Return mGlosa
        End Get
        Set(ByVal Value As String)
            If mGlosa <> Value Then
                mGlosa = Value
            End If
        End Set
    End Property

    Public Property GlosaPadre() As String
        Get
            Return mGlosaPadre
        End Get
        Set(ByVal Value As String)
            If mGlosaPadre <> Value Then
                mGlosaPadre = Value
            End If
        End Set
    End Property


    Friend Sub New()
        ' require use of factory methods
    End Sub

    Protected Overrides Function GetIdValue() As Object
        Return mId
    End Function


#Region " Factory Methods "


    Public Shared Function GetRegionesComunasInfo(ByVal ID As Int32) As RegionesComunasInfo

        Return DataPortal.Fetch(Of RegionesComunasInfo)(New Criteria(ID))

    End Function
#End Region



    Friend Sub New(ByVal dr As SafeDataReader)
        Try
            mId = dr.GetInt16("PKID")
            mGlosa = dr.GetString("Descripcion")
            mPadre = dr.GetInt16("GlosaPadre")
            mGlosaPadre = dr.GetString("DescripcionPadre")

        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
    End Sub



#Region " Data Access "


    <Serializable()> _
        Private Class Criteria
        Private mId As Int32
        Public ReadOnly Property Id() As Int32
            Get
                Return mId
            End Get
        End Property
        Public Sub New(ByVal id As Int32)
            mId = id
        End Sub
    End Class

    <RunLocal()> _
        Private Overloads Sub DataPortal_Create(ByVal criteria As Object)
        mId = criteria.ID
    End Sub
    Private Overloads Sub DataPortal_Fetch(ByVal criteria As Criteria)

        Using cn As New SqlConnection(Database.CasinoConnection)
            cn.Open()
            Using cm As SqlCommand = cn.CreateCommand
                cm.CommandType = CommandType.StoredProcedure
                cm.CommandText = "getTiposRequerimiento"

                Using dr As New SafeDataReader(cm.ExecuteReader)
                    dr.Read()
                    With dr
                        mId = dr.GetInt16("PKID")
                        mGlosa = dr.GetString("Descripcion")
                        mPadre = dr.GetInt16("GlosaPadre")
                        mGlosaPadre = dr.GetString("DescripcionPadre")
                    End With
                End Using
            End Using
        End Using

    End Sub
#End Region



End Class




