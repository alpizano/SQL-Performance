' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

Imports ASI.ScaleTraining.DataAccess.Common

''' <summary>
'''   This class implements the data access layer for clients.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public Class Client

#Region " Methods - Fetch "

  ''' <summary>
  '''   Queries the database for a list of clients based on a complete or partial account name.
  ''' </summary>
  ''' <param name="sValue">
  '''   String containing the account name.
  ''' </param>
  ''' <returns>
  '''   DataTable containing a collection of matching clients.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FetchByAccountNameBeginsWith(ByVal sValue As String) As DataTable

    Return Fetch(" WHERE c.nameof LIKE '" & ToDBString(sValue) & "%' ")

  End Function

  ''' <summary>
  '''   Queries the database for a list of clients based on a complete or partial account name.
  ''' </summary>
  ''' <param name="sValue">
  '''   String containing the account name.
  ''' </param>
  ''' <returns>
  '''   DataTable containing a collection of matching clients.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FetchByAccountNameContains(ByVal sValue As String) As DataTable

    Return Fetch(" WHERE c.nameof LIKE '%" & ToDBString(sValue) & "%' ")

  End Function

  ''' <summary>
  '''   Queries the database for a list of clients based on a complete or partial lookup code.
  ''' </summary>
  ''' <param name="sValue">
  '''   String containing the lookup code.
  ''' </param>
  ''' <returns>
  '''   DataTable containing a collection of matching clients.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FetchByLookupCodeBeginsWith(ByVal sValue As String) As DataTable

    Return Fetch(" WHERE c.lookupcode LIKE '" & ToDBString(sValue) & "%' ")

  End Function

  ''' <summary>
  '''   Queries the database for a list of clients based on a complete or partial lookup code.
  ''' </summary>
  ''' <param name="sValue">
  '''   String containing the lookup code.
  ''' </param>
  ''' <returns>
  '''   DataTable containing a collection of matching clients.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FetchByLookupCodeContains(ByVal sValue As String) As DataTable

    Return Fetch(" WHERE c.lookupcode LIKE '%" & ToDBString(sValue) & "%' ")

  End Function

  ''' <summary>
  '''   Queries the database for a list of clients based on an arbitrary WHERE clause.
  ''' </summary>
  ''' <param name="sWhereClause">
  '''   String containing the WHERE clause.
  ''' </param>
  ''' <returns>
  '''   DataTable containing a collection of matching clients.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private Function Fetch(ByVal sWhereClause As String) As DataTable

    Dim sSQL As String = " SELECT c.uniqentity, c.lookupcode, c.nameof, " & _
                         "        c.flags, a.address1, a.address2, " & _
                         "        a.city, a.cdstatecode, a.postalcode " & _
                         " FROM client c " & _
                         " INNER JOIN contactaddress a ON a.uniqcontactaddress = c.uniqcontactaddressaccount " & _
                         sWhereClause
    Return ExecuteDataTable(sSQL)

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
  '''   DataTable containing a single record with one column representing the
  '''   type code of the user, or no records if the user does not exist.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function CheckLoginSecurity(ByVal sUserCode As String) As DataTable

    Dim sSQL As String = " SELECT    TypeCode                                   " & _
                         " FROM      SecurityUser                               " & _
                         " WHERE     UserCode = '" & ToDBString(sUserCode) & "' "
    Return ExecuteDataTable(sSQL)

  End Function

#End Region

End Class