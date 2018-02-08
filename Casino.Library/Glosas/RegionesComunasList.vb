

<Serializable()> _
Public Class RegionesComunasList
    Inherits ReadOnlyListBase(Of RegionesComunasList, RegionesComunasInfo)

#Region " Business Methods "

    Public Function GetItem(ByVal Id As Integer) As RegionesComunasInfo

        For Each RegionesComunas As RegionesComunasInfo In Me
            If RegionesComunas.Id = Id Then
                Return RegionesComunas
            End If
        Next
        Return Nothing

    End Function


    Public Function GetItemsPorPadre(ByVal Padre As Integer) As RegionesComunasList
        Dim list As RegionesComunasList
        list = Me.Clone

        If Padre = 0 Then
            Return list
        End If

        list.Clear()
        For Each item As RegionesComunasInfo In Me
            If item.Padre = Padre Then
                list.Add(item)
            End If
        Next
        Return list

    End Function


    Public Overloads Function Contains( _
        ByVal Id As Integer) As Boolean

        For Each RegionesComunas As RegionesComunasInfo In Me
            If RegionesComunas.Id = Id Then
                Return True
            End If
        Next

        Return False

    End Function



#End Region

#Region " Factory Methods "

    Public Shared Function EmptyList() As RegionesComunasList

        Return New RegionesComunasList

    End Function

    Public Shared Function GetRegionesComunasList() As RegionesComunasList

        Return DataPortal.Fetch(Of RegionesComunasList)(New Criteria())

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria
        Private mid As Int16

        Public Sub New()

            ' mid = id

        End Sub
        Public Property id() As Int16
            Get
                Return mid
            End Get

            Set(ByVal Value As Int16)

                If mid <> Value Then
                    mid = Value

                End If
            End Set
        End Property


    End Class
    Private Overloads Sub DataPortal_Fetch(ByVal criteria As Criteria)
        RaiseListChangedEvents = False



        Using cn As New SqlConnection(Database.CasinoConnection)
            cn.Open()
            Using cm As SqlCommand = cn.CreateCommand
                With cm
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "GetComunasRegiones"

                    Using dr As New SafeDataReader(.ExecuteReader)
                        IsReadOnly = False
                        While dr.Read()
                            Dim info As New RegionesComunasInfo(dr)
                            Me.Add(info)
                        End While
                        Dim info2 As New RegionesComunasInfo
                        With info2
                            .Id = 0
                            .Glosa = ""
                            .Padre = 0
                            .GlosaPadre = ""
                        End With
                        Me.Add(info2)

                    End Using
                End With
            End Using
        End Using


        RaiseListChangedEvents = True
    End Sub

#End Region

End Class




