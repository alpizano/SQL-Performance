' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

Imports bus = ASI.ScaleTraining.Business.Client
Imports dat = ASI.ScaleTraining.Data.Client

''' <summary>
'''   This class contains the AccountLocate UI.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public Class AccountLocate

#Region " Private Variables "

  Private p_sTypeCode As String

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
  Private Sub Accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    cboLocateBy.SelectedIndex = 0
    cboLocateType.SelectedIndex = 1

    If Environment.GetCommandLineArgs.Count = 2 Then

      p_sTypeCode = (New bus.Client).CheckLoginSecurity(Environment.GetCommandLineArgs(1))

      Select Case p_sTypeCode

        Case "U"
          Me.Text += Environment.GetCommandLineArgs(1)

        Case "E"
          Me.Text += Environment.GetCommandLineArgs(1) + " (ENTERPRISE USER)"

        Case "X"
          MessageBox.Show("Invalid user code.", _
                          "Error", _
                          MessageBoxButtons.OK, _
                          MessageBoxIcon.Error)
          Me.Close()

      End Select

    Else

      MessageBox.Show("Invalid arguments.  The command line should be in the form ""ASI.ScaleTesting.UI.exe <UserCode>"".", _
                      "Error", _
                      MessageBoxButtons.OK, _
                      MessageBoxIcon.Error)
      Me.Close()

    End If

  End Sub

#End Region

#Region " Events - Button "

  ''' <summary>
  '''   Handles clicking the locate button.
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
  Private Sub cmdLocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocate.Click

    ' Declare Client Collection
    Dim datClients As dat.Clients = Nothing

    ' Lookup Clients
    If cboLocateBy.SelectedIndex = 0 Then
      If cboLocateType.SelectedIndex = 0 Then
        datClients = (New bus.Client).FindByAccountNameBeginsWith(txtLocate.Text)
      Else
        datClients = (New bus.Client).FindByAccountNameContains(txtLocate.Text)
      End If
    Else
      If cboLocateType.SelectedIndex = 0 Then
        datClients = (New bus.Client).FindByLookupCodeBeginsWith(txtLocate.Text)
      Else
        datClients = (New bus.Client).FindByLookupCodeContains(txtLocate.Text)
      End If
    End If

    ' Populate Listview
    lvwClients.SelectedItems.Clear()
    lvwClients.Items.Clear()

    If datClients IsNot Nothing Then
      For Each datClient As dat.Client In datClients

        Dim lvwItem As New ListViewItem(datClient.LookupCode)
        With lvwItem
          .SubItems.Add(datClient.AccountName)
          If datClient.Active = True Then
            .SubItems.Add("Active")
          Else
            .SubItems.Add("Inactive")
          End If
          .SubItems.Add(datClient.Address1)
          .SubItems.Add(datClient.Address2)
          .SubItems.Add(datClient.City)
          .SubItems.Add(datClient.State)
          .SubItems.Add(datClient.Zip)
          .Tag = datClient.EntityID
        End With
        lvwClients.Items.Add(lvwItem)

      Next
    End If

  End Sub

  ''' <summary>
  '''   Handles clicking the policies button.
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
  Private Sub cmdPolicies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPolicies.Click

    Dim oPolicyList As New PolicyList(DirectCast(lvwClients.SelectedItems(0).Tag, Integer), _
                                      lvwClients.SelectedItems(0).Text, _
                                      Environment.GetCommandLineArgs(1), _
                                      p_sTypeCode)
    oPolicyList.Show()

  End Sub

#End Region

#Region " Events - Listview "

  ''' <summary>
  '''   Handles enabling the area buttons.
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
  Private Sub lvwClients_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwClients.SelectedIndexChanged

    If lvwClients.SelectedItems.Count > 0 Then
      cmdPolicies.Enabled = True
    Else
      cmdPolicies.Enabled = False
    End If

  End Sub

#End Region

End Class