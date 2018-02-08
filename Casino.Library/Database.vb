Imports System.Configuration.ConfigurationManager

Public Module Database
    Private _conn As String = ""


    Public ReadOnly Property CasinoConnection() As String
        Get
            Return ConnectionStrings("Casino").ConnectionString()
        End Get
    End Property

  
End Module
