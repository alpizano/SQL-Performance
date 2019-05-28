' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

Imports bus = ASI.ScaleTraining.Business.Policy
Imports dat = ASI.ScaleTraining.Data.Policy

''' <summary>
'''   This class contains the PolicyList UI.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public Class PolicyList

#Region " Private Variables "

  Private p_sUserCode As String
  Private p_sUserType As String

#End Region

#Region " Constructors "

  ''' <summary>
  '''   Default constructor (unused).
  ''' </summary>
  ''' <remarks>
  '''   This subroutine is intentionally overriden to be Private so that it cannot be called
  '''   externally.
  ''' </remarks>
  Private Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

  End Sub

  ''' <summary>
  '''   Overloaded constructor.
  ''' </summary>
  ''' <param name="iEntityID">
  '''   Integer indicating the client ID backing this list of policies.
  ''' </param>
  ''' <param name="sLookupCode">
  '''   String indicating the lookup code associated with the client ID backing this list
  '''   of policies.
  ''' </param>
  ''' <param name="sUserCode">
  '''   String indicating the user code to use for security checks.
  ''' </param>
  ''' <param name="sUserType">
  '''   String indicating the type of user, namely U for regular user and E for
  '''   enterprise user.
  ''' </param>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New(ByVal iEntityID As Integer, ByVal sLookupCode As String, ByVal sUserCode As String, ByVal sUserType As String)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.Tag = iEntityID
    Me.Text += sLookupCode
    p_sUserCode = sUserCode
    p_sUserType = sUserType

  End Sub

#End Region

#Region " Events - Form "

  ''' <summary>
  '''   Handles any initilization and setup.
  ''' </summary>
  ''' <param name="sender">
  '''   Object indicating the sender of the event.
  ''' </param>
  ''' <param name="e">
  '''   Object indicating the arguments of the event.
  ''' </param>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private Sub PolicyList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    PopulateListview()

  End Sub

#End Region

#Region " Events - Button "

  ''' <summary>
  '''   Handles renewing a policy.
  ''' </summary>
  ''' <param name="sender">
  '''   Object indicating the sender of the event.
  ''' </param>
  ''' <param name="e">
  '''   Object indicating the arguments of the event.
  ''' </param>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private Sub cmdRenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRenew.Click

    ' Renew Selected Policy
    Dim busPolicy As New bus.Policy
    If busPolicy.Renew(Integer.Parse(DirectCast(lvwPolicies.SelectedItems(0).Tag, String).Split(","c)(0))) = True Then

      ' Refresh Listview
      PopulateListview()

    Else

      ' Indicate Error
      MessageBox.Show("Policy renewal failed.", _
                      "Error", _
                      MessageBoxButtons.OK, _
                      MessageBoxIcon.Error)

    End If

  End Sub

#End Region

#Region " Events - Listview "

  ''' <summary>
  '''   Handles selecting policy and line detail, and enabling the action buttons.
  ''' </summary>
  ''' <param name="sender">
  '''   Object indicating the sender of the event.
  ''' </param>
  ''' <param name="e">
  '''   Object indicating the arguments of the event.
  ''' </param>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private Sub lvwPolicies_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwPolicies.SelectedIndexChanged

    If lvwPolicies.SelectedItems.Count > 0 Then

      ' Declare Detail Objects
      'Dim datPolicyDetail As dat.PolicyDetail
      'Dim datLineDetail As dat.LineDetail
      Dim datComboDetail As dat.ComboDetail

      ' Lookup Detail Information
      Dim busPolicy As New bus.Policy
      'datPolicyDetail = busPolicy.FindPolicyDetail(Integer.Parse(DirectCast(lvwPolicies.SelectedItems(0).Tag, String).Split(","c)(1)))
      'datLineDetail = busPolicy.FindLineDetail(Integer.Parse(DirectCast(lvwPolicies.SelectedItems(0).Tag, String).Split(","c)(1)))
       datComboDetail = busPolicy.FindComboDetail(Integer.Parse(DirectCast(lvwPolicies.SelectedItems(0).Tag, String).Split(","c)(1)))

      ' Populate UI
      'If datPolicyDetail.BilledCommission <> -1 Then
      If datComboDetail.BilledCommission <> -1 Then
        'txtBilledCommission.Text = datPolicyDetail.BilledCommission.ToString("c")
        txtBilledCommission.Text = datComboDetail.BilledCommission.ToString("c")
      Else
        txtBilledCommission.Text = String.Empty
      End If
    'If datPolicyDetail.BilledPremium <> -1 Then
    If datComboDetail.BilledPremium <> -1 Then
        'txtBilledPremium.Text = datPolicyDetail.BilledPremium.ToString("c")
        txtBilledPremium.Text = datComboDetail.BilledPremium.ToString("c")
      Else
      txtBilledPremium.Text = String.Empty
      End If
    'If datPolicyDetail.AnnualizedCommission <> -1 Then
    If datComboDetail.AnnualizedCommission <> -1 Then
        'txtAnnualizedCommission.Text = datPolicyDetail.AnnualizedCommission.ToString("c")
        txtAnnualizedCommission.Text = datComboDetail.AnnualizedCommission.ToString("c")
      Else
      txtAnnualizedCommission.Text = String.Empty
      End If
    'If datPolicyDetail.AnnualizedPremium <> -1 Then
    If datComboDetail.AnnualizedPremium <> -1 Then
        'txtAnnualizedPremium.Text = datPolicyDetail.AnnualizedPremium.ToString("c")
        txtAnnualizedPremium.Text = datComboDetail.AnnualizedPremium.ToString("c")
      Else
      txtAnnualizedPremium.Text = String.Empty
      End If
      'txtBillingCompany.Text = datLineDetail.BillingCompany
      'txtIssuingCompany.Text = datLineDetail.IssuingCompany
      'txtIssuingState.Text = datLineDetail.IssuingState
      txtBillingCompany.Text = datComboDetail.BillingCompany
      txtIssuingCompany.Text = datComboDetail.IssuingCompany
      txtIssuingState.Text = datComboDetail.IssuingState

      ' Enable Action Buttons
      cmdRenew.Enabled = True

    Else

      ' Populate UI
      txtBilledCommission.Text = String.Empty
      txtBilledPremium.Text = String.Empty
      txtAnnualizedCommission.Text = String.Empty
      txtAnnualizedPremium.Text = String.Empty
      txtBillingCompany.Text = String.Empty
      txtIssuingCompany.Text = String.Empty
      txtIssuingState.Text = String.Empty

      ' Enable Action Buttons
      cmdRenew.Enabled = False

    End If

  End Sub

#End Region

#Region " Private Functions And Subroutines "

  ''' <summary>
  '''   Populates the listview with policies.
  ''' </summary>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private Sub PopulateListview()

    ' Declare Business Object
    Dim busPolicy As New bus.Policy()

    ' Declare Policy Collection
    Dim datPolicies As dat.Policies = Nothing

    ' Lookup Policies
    datPolicies = busPolicy.Find(DirectCast(Me.Tag, Integer))

    ' Populate Listview
    lvwPolicies.SelectedItems.Clear()
    lvwPolicies.Items.Clear()

    If datPolicies IsNot Nothing Then
      For Each datPolicy As dat.Policy In datPolicies
        'If p_sUserType = "E" OrElse busPolicy.CheckPolicySecurity(datPolicy.PolicyID, p_sUserCode) = True Then

        Dim lvwItem As New ListViewItem(datPolicy.Line)
        With lvwItem
          .SubItems.Add(datPolicy.StatusDescription)
          .SubItems.Add(datPolicy.Effective.ToString("d"))
          .SubItems.Add(datPolicy.Expiration.ToString("d"))
          .SubItems.Add(datPolicy.PolicyNumber)
          .SubItems.Add(datPolicy.PolicyDescription)
          .Tag = datPolicy.PolicyID.ToString & "," & datPolicy.LineID.ToString
        End With
        lvwPolicies.Items.Add(lvwItem)

        'End If
      Next
    End If

  End Sub

#End Region

End Class