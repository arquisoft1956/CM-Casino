<Serializable()> _
Public Class GlosasList
    Inherits NameValueListBase(Of Int16, String)

#Region " Business Methods "

    Public Shared Function DefaultGlosa() As Integer

        Dim list As GlosasList = GetList(1)
        If list.Count > 0 Then
            Return list.Items(0).Key

        Else
            Throw New NullReferenceException( _
              "No hay glosas disponibles; glosa default no puede ser obtenida")
        End If

    End Function


    Public Function RetornaIdGlosa(ByVal Glosa As String) As Int16

        For Each item As NameValuePair In mList
            If item.Value.Trim.ToUpper = Glosa.Trim.ToUpper Then
                Return item.Key
            End If
        Next

    End Function

    Public Function RetornaGlosa(ByVal Id As Int16) As String

        For Each item As NameValuePair In mList
            If item.Key = Id Then
                Return item.Value
            End If
        Next
        Return ""
    End Function


    Public Function RetornaGlosaFirst(ByVal id As Int16) As GlosasList

        Dim List As GlosasList = mList.Clone
        List.Clear()

        For Each obj As Casino.Library.GlosasList.NameValuePair In Me
            If obj.Key = id Then
                List.Add(obj)
                Exit For
            End If
        Next

        For Each obj As Casino.Library.GlosasList.NameValuePair In Me
            If obj.Key <> id Then
                List.Add(obj)
            End If
        Next
        Return List

    End Function


    

   

  
#End Region

#Region " Factory Methods "

    Private Shared mList As GlosasList

    Public Shared Function GetList(ByVal TipoID As Int16) As GlosasList

        '   If mList Is Nothing Then
        mList = DataPortal.Fetch(Of GlosasList) _
          (New Criteria(TipoID))
        '  End If
        Return mList

    End Function

    Public Function GetListRecaudar() As GlosasList
        Dim ls As GlosasList = mList.Clone
        ls.Clear()
        For Each obj As Casino.Library.GlosasList.NameValuePair In Me
            If obj.Key = 9 Or obj.Key = 11 Or obj.Key = 20 Then
                ls.Add(obj)
            End If
        Next
        Return ls
    End Function

    ''' <summary>
    ''' Clears the in-memory RoleList cache
    ''' so the list of roles is reloaded on
    ''' next request.
    ''' </summary>
    Public Shared Sub InvalidateCache()

        mList = Nothing

    End Sub

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "
    <Serializable()> _
     Private Shadows Class Criteria

        Private mId As Int16
        Public ReadOnly Property Id() As Int16
            Get
                Return mId
            End Get
        End Property

        Public Sub New(ByVal id As Int16)
            mId = id
        End Sub
    End Class

    Private Overloads Sub DataPortal_Fetch(ByVal criteria As Criteria)

        Me.RaiseListChangedEvents = False
        Using cn As New SqlConnection(Database.CasinoConnection)
            cn.Open()
            Using cm As SqlCommand = cn.CreateCommand
                cm.CommandType = CommandType.StoredProcedure
                cm.CommandText = "GetParam1"
                cm.Parameters.AddWithValue("@Id_TipoParametro", criteria.Id)
                Using dr As New SafeDataReader(cm.ExecuteReader)
                    IsReadOnly = False
                    With dr
                        While .Read()
                            Me.Add(New NameValuePair( _
                              .GetInt16("Id_Parametro"), .GetString("Descripcion")))
                        End While
                        Me.Add(New NameValuePair(0, "- Sin Selección -"))
                    End With
                    ' IsReadOnly = True
                End Using
            End Using
        End Using
        Me.RaiseListChangedEvents = True

    End Sub

#End Region

End Class
