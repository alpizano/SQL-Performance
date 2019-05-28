' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

Imports dat = ASI.ScaleTraining.Data.Policy
Imports da = ASI.ScaleTraining.DataAccess.Policy

''' <summary>
'''   This class implements the business layer for policies.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public Class Policy

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
  Private ReadOnly Property daPolicy() As da.Policy
    Get
      Return New da.Policy
    End Get
  End Property

#End Region

#Region " Methods - Find "

  ''' <summary>
  '''   Retrieves a list of policies matching a client ID.
  ''' </summary>
  ''' <param name="iEntityID">
  '''   Integer containing the client ID.
  ''' </param>
  ''' <returns>
  '''   Collection of policy objects representing the results of the search.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function Find(ByVal iEntityID As Integer) As dat.Policies

    Return PopulateDataObject(daPolicy.Fetch(iEntityID))

  End Function

  ''' <summary>
  '''   Retrieves policy detail information matching a line ID.
  ''' </summary>
  ''' <param name="iLineID">
  '''   Integer containing the line ID.
  ''' </param>
  ''' <returns>
  '''   Policy detail object.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FindPolicyDetail(ByVal iLineID As Integer) As dat.PolicyDetail

    Return PopulateDataObjectPolicyDetail(daPolicy.FetchPolicyDetail(iLineID))

  End Function

  ''' <summary>
  '''   Retrieves line detail information matching a line ID.
  ''' </summary>
  ''' <param name="iLineID">
  '''   Integer containing the line ID.
  ''' </param>
  ''' <returns>
  '''   Line detail object.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FindLineDetail(ByVal iLineID As Integer) As dat.LineDetail

    Return PopulateDataObjectLineDetail(daPolicy.FetchLineDetail(iLineID))

  End Function

  Public Function FindComboDetail(ByVal iLineID As Integer) As dat.ComboDetail

    Return PopulateDataComboObjectDetail(daPolicy.FetchComboDetail(iLineID))

  End Function


#End Region

#Region " Methods - Save "

  ''' <summary>
  '''   Renews a policy.
  ''' </summary>
  ''' <param name="iPolicyID">
  '''   Integer containing the policy ID.
  ''' </param>
  ''' <returns>
  '''   Boolean value indicating if the renewal was successful or not.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function Renew(ByVal iPolicyID As Integer) As Boolean

    Return daPolicy.Renew(iPolicyID)

  End Function

#End Region

#Region " Methods - Security Check "

  ''' <summary>
  '''   Determines if a particular user has rights to view a particular policy.
  ''' </summary>
  ''' <param name="iPolicyID">
  '''   Integer containing the policy ID.
  ''' </param>
  ''' <param name="sUserCode">
  '''   String containing the user code.
  ''' </param>
  ''' <returns>
  '''   Boolean indicating if the user can view the policy.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function CheckPolicySecurity(ByVal iPolicyID As Integer, ByVal sUserCode As String) As Boolean

    Dim oDataTable As DataTable = daPolicy.CheckPolicySecurity(iPolicyID, sUserCode)

    If oDataTable IsNot Nothing AndAlso oDataTable.Rows.Count > 0 Then
      If oDataTable.Rows(0).Field(Of Integer)("CountOf") = 1 Then
        Return True
      End If
    End If

    Return False

  End Function

#End Region

#Region " Translate Functions "

  ''' <summary>
  '''   Translates a DataTable containing SQL records into a collection of policy objects.
  ''' </summary>
  ''' <param name="oDataTable">
  '''   DataTable containing rows to be translated into policy objects.
  ''' </param>
  ''' <returns>
  '''   Collection of policy objects.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private Function PopulateDataObject(ByVal oDataTable As DataTable) As dat.Policies

    Dim datPolicies As New dat.Policies
    Dim datPolicy As dat.Policy = Nothing

    If oDataTable IsNot Nothing Then
      For Each oDataRow As DataRow In oDataTable.Rows
        datPolicy = New dat.Policy()
        With datPolicy
          .PolicyID = oDataRow.Field(Of Integer)("UniqPolicy")
          .LineID = oDataRow.Field(Of Integer)("UniqLine")
          .Line = oDataRow.Field(Of String)("Line")
          .StatusDescription = oDataRow.Field(Of String)("StatusDescription")
          .Effective = oDataRow.Field(Of Date)("EffectiveDate")
          .Expiration = oDataRow.Field(Of Date)("ExpirationDate")
          .PolicyNumber = oDataRow.Field(Of String)("PolicyNumber")
          .PolicyDescription = oDataRow.Field(Of String)("PolicyDescription")
        End With
        datPolicies.Add(datPolicy)
      Next
    End If

    Return datPolicies

  End Function

  ''' <summary>
  '''   Translates a DataTable containing a SQL record into a policy detail object.
  ''' </summary>
  ''' <param name="oDataTable">
  '''   DataTable containing a row to be translated into a policy detail object.
  ''' </param>
  ''' <returns>
  '''   Policy detail object.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private Function PopulateDataObjectPolicyDetail(ByVal oDataTable As DataTable) As dat.PolicyDetail

    Dim datPolicyDetail As dat.PolicyDetail = Nothing

    If oDataTable IsNot Nothing AndAlso oDataTable.Rows.Count > 0 Then
      datPolicyDetail = New dat.PolicyDetail()
      With datPolicyDetail
        .PolicyID = oDataTable.Rows(0).Field(Of Integer)("UniqPolicy")
        If oDataTable.Rows(0).Field(Of Object)("BilledCommission") Is Nothing Then
          .BilledCommission = -1
        Else
          .BilledCommission = oDataTable.Rows(0).Field(Of Decimal)("BilledCommission")
        End If
        If oDataTable.Rows(0).Field(Of Object)("BilledPremium") Is Nothing Then
          .BilledPremium = -1
        Else
          .BilledPremium = oDataTable.Rows(0).Field(Of Decimal)("BilledPremium")
        End If
        If oDataTable.Rows(0).Field(Of Object)("AnnualizedCommission") Is Nothing Then
          .AnnualizedCommission = -1
        Else
          .AnnualizedCommission = oDataTable.Rows(0).Field(Of Decimal)("AnnualizedCommission")
        End If
        If oDataTable.Rows(0).Field(Of Object)("AnnualizedPremium") Is Nothing Then
          .AnnualizedPremium = -1
        Else
          .AnnualizedPremium = oDataTable.Rows(0).Field(Of Decimal)("AnnualizedPremium")
        End If
      End With
    End If

    Return datPolicyDetail

  End Function

  ''' <summary>
  '''   Translates a DataTable containing a SQL record into a line detail object.
  ''' </summary>
  ''' <param name="oDataTable">
  '''   DataTable containing a row to be translated into a line detail object.
  ''' </param>
  ''' <returns>
  '''   Line detail object.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private Function PopulateDataObjectLineDetail(ByVal oDataTable As DataTable) As dat.LineDetail

    Dim datLineDetail As dat.LineDetail = Nothing

    If oDataTable IsNot Nothing AndAlso oDataTable.Rows.Count > 0 Then
      datLineDetail = New dat.LineDetail()
      With datLineDetail
        .LineID = oDataTable.Rows(0).Field(Of Integer)("UniqLine")
        .LineType = oDataTable.Rows(0).Field(Of String)("CdPolicyLineTypeCode")
        .FormCategory = oDataTable.Rows(0).Field(Of String)("FormCategory")
        '.BillToContactName = oDataTable.Rows(0).Field(Of String)("ContactNameBillTo")
        '.BillToAddress1 = oDataTable.Rows(0).Field(Of String)("Address1BillTo")
        '.BillToAddress2 = oDataTable.Rows(0).Field(Of String)("Address2BillTo")
        '.BillToAddress3 = oDataTable.Rows(0).Field(Of String)("Address3BillTo")
        '.BillToCity = oDataTable.Rows(0).Field(Of String)("CityBillTo")
        ' .BillToState = oDataTable.Rows(0).Field(Of String)("CdStateCodeBillTo")
        ' .BillToPostalCode = oDataTable.Rows(0).Field(Of String)("PostalCodeBillTo")
        '.BillToCounty = oDataTable.Rows(0).Field(Of String)("CountyBillTo")
        '.BillToCountryCode = oDataTable.Rows(0).Field(Of String)("CdCountryCodeBillTo")
        '.Email = oDataTable.Rows(0).Field(Of String)("Email")
        '.Fax = oDataTable.Rows(0).Field(Of String)("Fax")
        '.FaxExtension = oDataTable.Rows(0).Field(Of String)("FaxExtension")
        .BillingCompany = oDataTable.Rows(0).Field(Of String)("BillingCompany")
        .IssuingCompany = oDataTable.Rows(0).Field(Of String)("IssuingCompany")
        .IssuingState = oDataTable.Rows(0).Field(Of String)("IssuingState")
      End With
    End If

    Return datLineDetail

  End Function

  Private Function PopulateDataComboObjectDetail(ByVal oDataTable As DataTable) As dat.ComboDetail

    Dim datComboDetail As dat.ComboDetail = Nothing

    If oDataTable IsNot Nothing AndAlso oDataTable.Rows.Count > 0 Then
      datComboDetail = New dat.ComboDetail()
      With datComboDetail

        '.PolicyID = oDataRow.Field(Of Integer)("UniqPolicy")
        '.LineID = oDataRow.Field(Of Integer)("UniqLine")
        '.Line = oDataRow.Field(Of String)("Line")
        '.StatusDescription = oDataRow.Field(Of String)("StatusDescription")
        '.Effective = oDataRow.Field(Of Date)("EffectiveDate")
        '.Expiration = oDataRow.Field(Of Date)("ExpirationDate")
        '.PolicyNumber = oDataRow.Field(Of String)("PolicyNumber")
        '.PolicyDescription = oDataRow.Field(Of String)("PolicyDescription")

        .LineID = oDataTable.Rows(0).Field(Of Integer)("UniqLine")
        .LineType = oDataTable.Rows(0).Field(Of String)("CdPolicyLineTypeCode")
        .FormCategory = oDataTable.Rows(0).Field(Of String)("FormCategory")

        .BillingCompany = oDataTable.Rows(0).Field(Of String)("BillingCompany")
        .IssuingCompany = oDataTable.Rows(0).Field(Of String)("IssuingCompany")
        .IssuingState = oDataTable.Rows(0).Field(Of String)("IssuingState")

        .PolicyID = oDataTable.Rows(0).Field(Of Integer)("UniqPolicy")
        If oDataTable.Rows(0).Field(Of Object)("BilledCommission") Is Nothing Then
          .BilledCommission = -1
        Else
          .BilledCommission = oDataTable.Rows(0).Field(Of Decimal)("BilledCommission")
        End If
        If oDataTable.Rows(0).Field(Of Object)("BilledPremium") Is Nothing Then
          .BilledPremium = -1
        Else
          .BilledPremium = oDataTable.Rows(0).Field(Of Decimal)("BilledPremium")
        End If
        If oDataTable.Rows(0).Field(Of Object)("AnnualizedCommission") Is Nothing Then
          .AnnualizedCommission = -1
        Else
          .AnnualizedCommission = oDataTable.Rows(0).Field(Of Decimal)("AnnualizedCommission")
        End If
        If oDataTable.Rows(0).Field(Of Object)("AnnualizedPremium") Is Nothing Then
          .AnnualizedPremium = -1
        Else
          .AnnualizedPremium = oDataTable.Rows(0).Field(Of Decimal)("AnnualizedPremium")
        End If
      End With
    End If

    Return datComboDetail

  End Function


#End Region

End Class