Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class immiAppDbContext
    Inherits DbContext

    ' Your context has been configured to use a 'immiAppDbContext' connection string from your application's 
    ' configuration file (App.config or Web.config). By default, this connection string targets the 
    ' 'immiApp.immiAppDbContext' database on your LocalDb instance. 
    ' 
    ' If you wish to target a different database and/or database provider, modify the 'immiAppDbContext' 
    ' connection string in the application configuration file.
    Public Sub New()
        MyBase.New("name=immiAppDbContext")
    End Sub

    ' Add a DbSet for each entity type that you want to include in your model. For more information 
    ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.
    ' Public Overridable Property MyEntities() As DbSet(Of MyEntity)

    Private _application As DbSet(Of ApplicationModels)
    Public Property ApplicationCollectio() As DbSet(Of ApplicationModels)
        Get
            Return _application
        End Get
        Set(ByVal value As DbSet(Of ApplicationModels))
            _application = value
        End Set
    End Property

    Public Property OtherNames As System.Data.Entity.DbSet(Of OtherName)
    Public Property PassportModels As System.Data.Entity.DbSet(Of PassportModels)
    Public Property NationalIDs As System.Data.Entity.DbSet(Of NationalIDs)
End Class

'Public Class MyEntity
'    Public Property Id() As Int32
'    Public Property Name() As String
'End Class
