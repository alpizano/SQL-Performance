' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

Imports dat = ASI.ScaleTraining.Data.Client
Imports da = ASI.ScaleTraining.DataAccess.Client

''' <summary>
'''   This class implements the business layer for clients.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public Class Client

#Region " Constants "

  Private Const FLAGS_ACTIVE As Integer = 1 << 1

#End Region

#Region " Properties "

  ''' <summary>
  '''   Since business objects are supposed to be stateless, this property eliminates
  '''   the need to hold a private class-level data access object or to create one
  '''   on-the-fly in every function requiring one.
  ''' </summary>
  ''' <value>
  '''   New instance of the data access class.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private ReadOnly Property daClient() As da.Client
    Get
      Return New da.Client
    End Get
  End Property

#End Region

#Region " Methods - Find "

  ''' <summary>
  '''   Retrieves a list of clients matching the search criteria.
  ''' </summary>
  ''' <param name="sValue">
  '''   String containing the value to search on.
  ''' </param>
  ''' <returns>
  '''   Collection of client objects representing the results of the search.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FindByAccountNameBeginsWith(ByVal sValue As String) As dat.Clients

    Return PopulateDataObject(daClient.FetchByAccountNameBeginsWith(sValue))

  End Function

  ''' <summary>
  '''   Retrieves a list of clients matching the search criteria.
  ''' </summary>
  ''' <param name="sValue">
  '''   String containing the value to search on.
  ''' </param>
  ''' <returns>
  '''   Collection of client objects representing the results of the search.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FindByAccountNameContains(ByVal sValue As String) As dat.Clients

    Return PopulateDataObject(daClient.FetchByAccountNameContains(sValue))

  End Function

  ''' <summary>
  '''   Retrieves a list of clients matching the search criteria.
  ''' </summary>
  ''' <param name="sValue">
  '''   String containing the value to search on.
  ''' </param>
  ''' <returns>
  '''   Collection of client objects representing the results of the search.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FindByLookupCodeBeginsWith(ByVal sValue As String) As dat.Clients

    Return PopulateDataObject(daClient.FetchByLookupCodeBeginsWith(sValue))

  End Function

  ''' <summary>
  '''   Retrieves a list of clients matching the search criteria.
  ''' </summary>
  ''' <param name="sValue">
  '''   String containing the value to search on.
  ''' </param>
  ''' <returns>
  '''   Collection of client objects representing the results of the search.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FindByLookupCodeContains(ByVal sValue As String) As dat.Clients

    Return PopulateDataObject(daClient.FetchByLookupCodeContains(sValue))

  End Function

#End Region

#Region " Methods - Security Check "

  ''' <summary>
  '''   Determines the type code of a particular user code.
  ''' </summary>
  ''' <param name="sUserCode">
  '''   String containing the user code.
  ''' </param>
  ''' <returns>
  '''   U - Regular User
  '''   E - Enterprise Admin
  '''   X - Invalid UserCode
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function CheckLoginSecurity(ByVal sUserCode As String) As String

    Dim oDataTable As DataTable = daClient.CheckLoginSecurity(sUserCode)

    If oDataTable IsNot Nothing AndAlso oDataTable.Rows.Count > 0 Then
      Return oDataTable.Rows(0).Field(Of String)("TypeCode")
    Else
      Return "X"
    End If

  End Function

#End Region

#Region " Translate Functions "

  ''' <summary>
  '''   Translates a DataTable containing SQL records into a collection of client objects.
  ''' </summary>
  ''' <param name="oDataTable">
  '''   DataTable containing rows to be translated into client objects.
  ''' </param>
  ''' <returns>
  '''   Collection of client objects.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private Function PopulateDataObject(ByVal oDataTable As DataTable) As dat.Clients

    Dim datClients As New dat.Clients
    Dim datClient As dat.Client = Nothing

    If oDataTable IsNot Nothing Then
      For Each oDataRow As DataRow In oDataTable.Rows
        datClient = New dat.Client()
        With datClient
          .EntityID = oDataRow.Field(Of Integer)("UniqEntity")
          .LookupCode = oDataRow.Field(Of String)("LookupCode")
          .AccountName = oDataRow.Field(Of String)("NameOf")
          If (oDataRow.Field(Of Integer)("Flags") And FLAGS_ACTIVE) = FLAGS_ACTIVE Then
            .Active = True
          Else
            .Active = False
          End If
          .Address1 = oDataRow.Field(Of String)("Address1")
          .Address2 = oDataRow.Field(Of String)("Address2")
          .City = oDataRow.Field(Of String)("City")
          .State = oDataRow.Field(Of String)("CdStateCode")
          .Zip = oDataRow.Field(Of String)("PostalCode")
        End With
        datClients.Add(datClient)
      Next
    End If

    Return datClients

  End Function

#End Region

End Class