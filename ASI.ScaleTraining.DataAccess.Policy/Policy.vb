' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

Imports ASI.ScaleTraining.DataAccess.Common

''' <summary>
'''   This class implements the data access layer for policies.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public Class Policy

#Region " Methods - Fetch "

  ''' <summary>
  '''   Queries the database for a list of policies based on a client ID.
  ''' </summary>
  ''' <param name="iEntityID">
  '''   Integer containing the client ID.
  ''' </param>
  ''' <returns>
  '''   DataTable containing a collection of matching policies.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function Fetch(ByVal iEntityID As Integer) As DataTable

    'Dim sSQL As String = " SELECT p.uniqpolicy, l.uniqline, t.cdpolicylinetypecode AS line, " & _
    '  "        c.descriptionof AS statusdescription, p.effectivedate, " & _
    '   "        p.expirationdate, p.policynumber, p.descriptionof AS policydescription " & _
    '   " FROM policy p " & _
    '   " INNER JOIN line l ON l.uniqpolicy = p.uniqpolicy " & _
    '   " INNER JOIN cdpolicylinetype t ON t.uniqcdpolicylinetype = l.uniqcdpolicylinetype " & _
    '   " INNER JOIN cdlinestatus c ON c.uniqcdlinestatus = l.uniqcdlinestatus " & _
    '   " WHERE p.uniqentity = " & iEntityID


    If Environment.GetCommandLineArgs(1).Equals("TestUser") Then

      Dim sSQL As String = "SELECT p.uniqpolicy, l.uniqline, t.cdpolicylinetypecode As line, " &
                         "       c.descriptionof AS statusdescription, p.effectivedate," &
                         "       p.expirationdate, p.policynumber, p.descriptionof AS policydescription " &
                         "FROM securityuser u " &
                         "INNER Join securityuserstructurecombinationjt jt ON jt.uniqsecurityuser =  u.uniqsecurityuser " &
                         "INNER Join structurecombination s ON  s.uniqstructure = jt.uniqstructure  " &
                         "INNER Join policy p ON p.uniqagency = s.uniqagency And p.uniqbranch = s.uniqbranch And p.uniqdepartment = s.uniqdepartment " &
                         "INNER Join line l ON l.uniqpolicy = p.uniqpolicy  " &
                         "INNER Join cdpolicylinetype t ON t.uniqcdpolicylinetype = l.uniqcdpolicylinetype  " &
                         "INNER Join cdlinestatus c ON c.uniqcdlinestatus = l.uniqcdlinestatus  " &
                         "WHERE p.uniqentity = " & iEntityID
      Return ExecuteDataTable(sSQL)
    End If

    If Environment.GetCommandLineArgs(1).Equals("EnterpriseAdmin") Then
      Dim sSQL As String = " SELECT p.uniqpolicy, l.uniqline, t.cdpolicylinetypecode AS line, " &
                             "        c.descriptionof AS statusdescription, p.effectivedate, " &
                             "        p.expirationdate, p.policynumber, p.descriptionof AS policydescription " &
                             " FROM policy p " &
                             " INNER JOIN line l ON l.uniqpolicy = p.uniqpolicy " &
                             " INNER JOIN cdpolicylinetype t ON t.uniqcdpolicylinetype = l.uniqcdpolicylinetype " &
                             " INNER JOIN cdlinestatus c ON c.uniqcdlinestatus = l.uniqcdlinestatus " &
                             " WHERE p.uniqentity = " & iEntityID

      Return ExecuteDataTable(sSQL)
    End If
  End Function

  Public Function FetchAndSecurityCheck(ByVal iEntityID As Integer) As DataTable

    If Environment.GetCommandLineArgs(1).Equals("TestUser") Then

      Dim sSQL As String = "SELECT p.uniqpolicy, l.uniqline, t.cdpolicylinetypecode As line, " &
                         "       c.descriptionof AS statusdescription, p.effectivedate," &
                         "       p.expirationdate, p.policynumber, p.descriptionof AS policydescription " &
                         "FROM securityuser u " &
                         "INNER Join securityuserstructurecombinationjt jt ON jt.uniqsecurityuser =  u.uniqsecurityuser " &
                         "INNER Join structurecombination s ON  s.uniqstructure = jt.uniqstructure  " &
                         "INNER Join policy p ON p.uniqagency = s.uniqagency And p.uniqbranch = s.uniqbranch And p.uniqdepartment = s.uniqdepartment " &
                         "INNER Join line l ON l.uniqpolicy = p.uniqpolicy  " &
                         "INNER Join cdpolicylinetype t ON t.uniqcdpolicylinetype = l.uniqcdpolicylinetype  " &
                         "INNER Join cdlinestatus c ON c.uniqcdlinestatus = l.uniqcdlinestatus  " &
                         "WHERE p.uniqentity = " & iEntityID
      Return ExecuteDataTable(sSQL)
    End If

    If Environment.GetCommandLineArgs(1).Equals("EnterpriseAdmin") Then
      Dim sSQL As String = " SELECT p.uniqpolicy, l.uniqline, t.cdpolicylinetypecode AS line, " &
                             "        c.descriptionof AS statusdescription, p.effectivedate, " &
                             "        p.expirationdate, p.policynumber, p.descriptionof AS policydescription " &
                             " FROM policy p " &
                             " INNER JOIN line l ON l.uniqpolicy = p.uniqpolicy " &
                             " INNER JOIN cdpolicylinetype t ON t.uniqcdpolicylinetype = l.uniqcdpolicylinetype " &
                             " INNER JOIN cdlinestatus c ON c.uniqcdlinestatus = l.uniqcdlinestatus " &
                             " WHERE p.uniqentity = " & iEntityID

      Return ExecuteDataTable(sSQL)
    End If


  End Function
  ''' <summary>
  '''   Queries the database for detail information based on a line ID.
  ''' </summary>
  ''' <param name="iLineID">
  '''   Integer containing the line ID.
  ''' </param>
  ''' <returns>
  '''   DataTable containing the detail information.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FetchPolicyDetail(ByVal iLineID As Integer) As DataTable

    Dim sSQL As String = " Select p.uniqpolicy, p.billedcommission, p.billedpremium, " & _
                         "        p.annualizedcommission, p.annualizedpremium " & _
                         " FROM policy p " & _
                         " INNER JOIN line l On l.uniqpolicy = p.uniqpolicy " & _
                         " WHERE l.uniqline = " & iLineID
    Return ExecuteDataTable(sSQL)

  End Function

  ''' <summary>
  '''   Queries the database for detail information based on a line ID.
  ''' </summary>
  ''' <param name="iLineID">
  '''   Integer containing the line ID.
  ''' </param>
  ''' <returns>
  '''   DataTable containing the detail information.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function FetchLineDetail(ByVal iLineID As Integer) As DataTable

    Dim sSQL As String = " Select l.uniqline, l.cdstatecodeissuing As issuingstate, " &
                         "        l.contactnamebillto, l.address1billto, l.address2billto, " &
                         "        l.address3billto, l.citybillto, l.cdstatecodebillto, " &
                         "        l.postalcodebillto, l.countybillto, l.cdcountrycodebillto, " &
                         "        l.email, l.fax, l.faxextension, " &
                         "        c.cdpolicylinetypecode, f.descriptionof As formcategory,  " &
                         "        b.NameOf As billingcompany, i.NameOf As issuingcompany " &
                         " FROM line l " &
                         " INNER JOIN cdpolicylinetype c On c.uniqcdpolicylinetype = l.uniqcdpolicylinetype " &
                         " INNER JOIN formcategory f On f.uniqformcategory = l.uniqformcategory " &
                         " INNER JOIN company b On b.uniqentity = l.uniqentitycompanybilling " &
                         " INNER JOIN company i On i.uniqentity = l.uniqentitycompanyissuing " &
                         " WHERE l.uniqline = " & iLineID
    Return ExecuteDataTable(sSQL)

  End Function

  Public Function FetchComboDetail(ByVal iLineID As Integer) As DataTable

    Dim sSQL As String = " Select l.uniqline, l.cdstatecodeissuing As issuingstate, " &
                         "        c.cdpolicylinetypecode, f.descriptionof As formcategory,  " &
                         "        b.NameOf As billingcompany, i.NameOf As issuingcompany, " &
                         "        p.uniqpolicy, p.billedcommission, p.billedpremium, " &
                         "        p.annualizedcommission, p.annualizedpremium " &
                         " FROM line l " &
                         " INNER JOIN cdpolicylinetype c On c.uniqcdpolicylinetype = l.uniqcdpolicylinetype " &
                         " INNER JOIN formcategory f On f.uniqformcategory = l.uniqformcategory " &
                         " INNER JOIN company b On b.uniqentity = l.uniqentitycompanybilling " &
                         " INNER JOIN company i On i.uniqentity = l.uniqentitycompanyissuing " &
                         " INNER JOIN policy p On l.uniqpolicy = p.uniqpolicy " &
                         " WHERE l.uniqline = " & iLineID

    Return ExecuteDataTable(sSQL)


  End Function


#End Region

#Region " Methods - Save "

  ''' <summary>
  '''   Renews a policy by changing the effective date to today and changing
  '''   the expiration date to match the current policy term length.  As an example,
  '''   a policy that is currently six months long would be updated to have an
  '''   effective date of today and an expiration date of six months in the future.
  ''' </summary>
  ''' <param name="iPolicyID">
  '''   Integer containing the policy ID.
  ''' </param>
  ''' <returns>
  '''   Boolean value indicating if the renewal was successful or not.
  ''' </returns>
  ''' <remarks>
  '''   This function omits many steps required to renew a policy, but it
  '''   illustrates the concept of a renewal by updating the effective and
  '''   expiration dates.
  ''' </remarks>
  Public Function Renew(ByVal iPolicyID As Integer) As Boolean

    Dim sSQL As String = " UPDATE policy " & _
                         " Set effectivedate = DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()), 0), " & _
                         "     expirationdate = DATEADD(MONTH, DATEDIFF(MONTH, effectivedate, expirationdate), DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()), 0)) " & _
                         " WHERE uniqpolicy = " & iPolicyID
    Return (ExecuteCommand(sSQL) > 0)

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
  '''   DataTable containing a single record with one column representing either
  '''   True (1) or False (0).
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function CheckPolicySecurity(ByVal iPolicyID As Integer, ByVal sUserCode As String) As DataTable

    'Dim sSQL As String = " Select COUNT(*) As countof " & _
    '                     " FROM securityuser u " & _
    '                    " INNER JOIN securityuserstructurecombinationjt jt On jt.uniqsecurityuser =  u.uniqsecurityuser " & _
    '                    " INNER JOIN structurecombination s On  s.uniqstructure = jt.uniqstructure " & _
    '                    " INNER JOIN policy p On p.uniqagency = s.uniqagency And " & _
    '                   "                        p.uniqbranch = s.uniqbranch And " & _
    '                   "                        p.uniqdepartment = s.uniqdepartment " & _
    '                   " WHERE u.usercode = '" & ToDBString(sUserCode) & "' and " & _
    '                   "       p.uniqpolicy =  " & iPolicyID

    'Dim sSQL As String = "SELECT COUNT(*) AS CountOf " &
    '"FROM SecurityUserStructureCombinationJT jt " &
    '"INNER JOIN structurecombination s  On  s.uniqstructure = jt.uniqstructure " &
    '"INNER JOIN policy p On p.uniqagency = s.uniqagency And p.uniqbranch = s.uniqbranch And p.uniqdepartment = s.uniqdepartment " &
    '"WHERE p.uniqpolicy =  " & iPolicyID

    Dim sSQL As String = " SELECT COUNT(*) AS countof " &
                         " FROM securityuser u " &
                        " INNER JOIN securityuserstructurecombinationjt jt ON jt.uniqsecurityuser =  u.uniqsecurityuser " &
                       " INNER JOIN structurecombination s ON  s.uniqstructure = jt.uniqstructure " &
                        " INNER JOIN policy p ON p.uniqagency = s.uniqagency AND " &
                      "                        p.uniqbranch = s.uniqbranch AND " &
                      "                        p.uniqdepartment = s.uniqdepartment " &
                      " WHERE u.usercode = '" & ToDBString(sUserCode) & "' and " &
                     "       p.uniqpolicy =  " & iPolicyID



    Return ExecuteDataTable(sSQL)

  End Function

#End Region

End Class