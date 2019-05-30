<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountLocate
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountLocate))
    Me.grpAreas = New System.Windows.Forms.GroupBox()
    Me.lblTest = New System.Windows.Forms.Label()
    Me.testOutput = New System.Windows.Forms.TextBox()
    Me.cmdActivities = New System.Windows.Forms.Button()
    Me.cmdClaims = New System.Windows.Forms.Button()
    Me.cmdAttachments = New System.Windows.Forms.Button()
    Me.cmdTransactions = New System.Windows.Forms.Button()
    Me.cmdProofsOfInsurance = New System.Windows.Forms.Button()
    Me.cmdPolicies = New System.Windows.Forms.Button()
    Me.cmdContacts = New System.Windows.Forms.Button()
    Me.cmdAccountDetail = New System.Windows.Forms.Button()
    Me.grpLocate = New System.Windows.Forms.GroupBox()
    Me.txtLocate = New System.Windows.Forms.TextBox()
    Me.cboLocateType = New System.Windows.Forms.ComboBox()
    Me.cboLocateBy = New System.Windows.Forms.ComboBox()
    Me.lblLocateBy = New System.Windows.Forms.Label()
    Me.cmdLocate = New System.Windows.Forms.Button()
    Me.grpClients = New System.Windows.Forms.GroupBox()
    Me.lvwClients = New System.Windows.Forms.ListView()
    Me.colLookupCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.colAccountName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.colAccountStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.colAddress1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.colAddress2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.colCity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.colState = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.colZip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.grpAreas.SuspendLayout()
    Me.grpLocate.SuspendLayout()
    Me.grpClients.SuspendLayout()
    Me.SuspendLayout()
    '
    'grpAreas
    '
    Me.grpAreas.Controls.Add(Me.lblTest)
    Me.grpAreas.Controls.Add(Me.testOutput)
    Me.grpAreas.Controls.Add(Me.cmdActivities)
    Me.grpAreas.Controls.Add(Me.cmdClaims)
    Me.grpAreas.Controls.Add(Me.cmdAttachments)
    Me.grpAreas.Controls.Add(Me.cmdTransactions)
    Me.grpAreas.Controls.Add(Me.cmdProofsOfInsurance)
    Me.grpAreas.Controls.Add(Me.cmdPolicies)
    Me.grpAreas.Controls.Add(Me.cmdContacts)
    Me.grpAreas.Controls.Add(Me.cmdAccountDetail)
    Me.grpAreas.Location = New System.Drawing.Point(12, 12)
    Me.grpAreas.Name = "grpAreas"
    Me.grpAreas.Size = New System.Drawing.Size(127, 544)
    Me.grpAreas.TabIndex = 2
    Me.grpAreas.TabStop = False
    Me.grpAreas.Text = "Areas"
    '
    'lblTest
    '
    Me.lblTest.AutoSize = True
    Me.lblTest.Location = New System.Drawing.Point(7, 267)
    Me.lblTest.Name = "lblTest"
    Me.lblTest.Size = New System.Drawing.Size(55, 13)
    Me.lblTest.TabIndex = 9
    Me.lblTest.Text = "Hi Testing"
    '
    'testOutput
    '
    Me.testOutput.Location = New System.Drawing.Point(7, 286)
    Me.testOutput.Name = "testOutput"
    Me.testOutput.Size = New System.Drawing.Size(100, 20)
    Me.testOutput.TabIndex = 8
    '
    'cmdActivities
    '
    Me.cmdActivities.Enabled = False
    Me.cmdActivities.Location = New System.Drawing.Point(6, 222)
    Me.cmdActivities.Name = "cmdActivities"
    Me.cmdActivities.Size = New System.Drawing.Size(115, 23)
    Me.cmdActivities.TabIndex = 7
    Me.cmdActivities.Text = "Activities"
    Me.cmdActivities.UseVisualStyleBackColor = True
    '
    'cmdClaims
    '
    Me.cmdClaims.Enabled = False
    Me.cmdClaims.Location = New System.Drawing.Point(6, 193)
    Me.cmdClaims.Name = "cmdClaims"
    Me.cmdClaims.Size = New System.Drawing.Size(115, 23)
    Me.cmdClaims.TabIndex = 6
    Me.cmdClaims.Text = "Claims"
    Me.cmdClaims.UseVisualStyleBackColor = True
    '
    'cmdAttachments
    '
    Me.cmdAttachments.Enabled = False
    Me.cmdAttachments.Location = New System.Drawing.Point(6, 164)
    Me.cmdAttachments.Name = "cmdAttachments"
    Me.cmdAttachments.Size = New System.Drawing.Size(115, 23)
    Me.cmdAttachments.TabIndex = 5
    Me.cmdAttachments.Text = "Attachments"
    Me.cmdAttachments.UseVisualStyleBackColor = True
    '
    'cmdTransactions
    '
    Me.cmdTransactions.Enabled = False
    Me.cmdTransactions.Location = New System.Drawing.Point(6, 135)
    Me.cmdTransactions.Name = "cmdTransactions"
    Me.cmdTransactions.Size = New System.Drawing.Size(115, 23)
    Me.cmdTransactions.TabIndex = 4
    Me.cmdTransactions.Text = "Transactions"
    Me.cmdTransactions.UseVisualStyleBackColor = True
    '
    'cmdProofsOfInsurance
    '
    Me.cmdProofsOfInsurance.Enabled = False
    Me.cmdProofsOfInsurance.Location = New System.Drawing.Point(6, 106)
    Me.cmdProofsOfInsurance.Name = "cmdProofsOfInsurance"
    Me.cmdProofsOfInsurance.Size = New System.Drawing.Size(115, 23)
    Me.cmdProofsOfInsurance.TabIndex = 3
    Me.cmdProofsOfInsurance.Text = "Proofs Of Insurance"
    Me.cmdProofsOfInsurance.UseVisualStyleBackColor = True
    '
    'cmdPolicies
    '
    Me.cmdPolicies.Enabled = False
    Me.cmdPolicies.Location = New System.Drawing.Point(6, 77)
    Me.cmdPolicies.Name = "cmdPolicies"
    Me.cmdPolicies.Size = New System.Drawing.Size(115, 23)
    Me.cmdPolicies.TabIndex = 2
    Me.cmdPolicies.Text = "Policies"
    Me.cmdPolicies.UseVisualStyleBackColor = True
    '
    'cmdContacts
    '
    Me.cmdContacts.Enabled = False
    Me.cmdContacts.Location = New System.Drawing.Point(6, 48)
    Me.cmdContacts.Name = "cmdContacts"
    Me.cmdContacts.Size = New System.Drawing.Size(115, 23)
    Me.cmdContacts.TabIndex = 1
    Me.cmdContacts.Text = "Contacts"
    Me.cmdContacts.UseVisualStyleBackColor = True
    '
    'cmdAccountDetail
    '
    Me.cmdAccountDetail.Enabled = False
    Me.cmdAccountDetail.Location = New System.Drawing.Point(6, 19)
    Me.cmdAccountDetail.Name = "cmdAccountDetail"
    Me.cmdAccountDetail.Size = New System.Drawing.Size(115, 23)
    Me.cmdAccountDetail.TabIndex = 0
    Me.cmdAccountDetail.Text = "Account Detail"
    Me.cmdAccountDetail.UseVisualStyleBackColor = True
    '
    'grpLocate
    '
    Me.grpLocate.Controls.Add(Me.txtLocate)
    Me.grpLocate.Controls.Add(Me.cboLocateType)
    Me.grpLocate.Controls.Add(Me.cboLocateBy)
    Me.grpLocate.Controls.Add(Me.lblLocateBy)
    Me.grpLocate.Controls.Add(Me.cmdLocate)
    Me.grpLocate.Location = New System.Drawing.Point(145, 12)
    Me.grpLocate.Name = "grpLocate"
    Me.grpLocate.Size = New System.Drawing.Size(637, 84)
    Me.grpLocate.TabIndex = 0
    Me.grpLocate.TabStop = False
    Me.grpLocate.Text = "Locate"
    '
    'txtLocate
    '
    Me.txtLocate.Location = New System.Drawing.Point(281, 46)
    Me.txtLocate.Name = "txtLocate"
    Me.txtLocate.Size = New System.Drawing.Size(121, 20)
    Me.txtLocate.TabIndex = 3
    '
    'cboLocateType
    '
    Me.cboLocateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboLocateType.FormattingEnabled = True
    Me.cboLocateType.Items.AddRange(New Object() {"Begins With", "Contains"})
    Me.cboLocateType.Location = New System.Drawing.Point(154, 46)
    Me.cboLocateType.Name = "cboLocateType"
    Me.cboLocateType.Size = New System.Drawing.Size(121, 21)
    Me.cboLocateType.TabIndex = 2
    '
    'cboLocateBy
    '
    Me.cboLocateBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboLocateBy.FormattingEnabled = True
    Me.cboLocateBy.Items.AddRange(New Object() {"Account Name", "Lookup Code"})
    Me.cboLocateBy.Location = New System.Drawing.Point(281, 19)
    Me.cboLocateBy.Name = "cboLocateBy"
    Me.cboLocateBy.Size = New System.Drawing.Size(121, 21)
    Me.cboLocateBy.TabIndex = 1
    '
    'lblLocateBy
    '
    Me.lblLocateBy.AutoSize = True
    Me.lblLocateBy.Location = New System.Drawing.Point(218, 22)
    Me.lblLocateBy.Name = "lblLocateBy"
    Me.lblLocateBy.Size = New System.Drawing.Size(57, 13)
    Me.lblLocateBy.TabIndex = 0
    Me.lblLocateBy.Text = "Locate by:"
    Me.lblLocateBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cmdLocate
    '
    Me.cmdLocate.Location = New System.Drawing.Point(408, 44)
    Me.cmdLocate.Name = "cmdLocate"
    Me.cmdLocate.Size = New System.Drawing.Size(75, 23)
    Me.cmdLocate.TabIndex = 4
    Me.cmdLocate.Text = "Locate"
    Me.cmdLocate.UseVisualStyleBackColor = True
    '
    'grpClients
    '
    Me.grpClients.Controls.Add(Me.lvwClients)
    Me.grpClients.Location = New System.Drawing.Point(145, 102)
    Me.grpClients.Name = "grpClients"
    Me.grpClients.Size = New System.Drawing.Size(637, 454)
    Me.grpClients.TabIndex = 1
    Me.grpClients.TabStop = False
    Me.grpClients.Text = "Clients"
    '
    'lvwClients
    '
    Me.lvwClients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colLookupCode, Me.colAccountName, Me.colAccountStatus, Me.colAddress1, Me.colAddress2, Me.colCity, Me.colState, Me.colZip})
    Me.lvwClients.FullRowSelect = True
    Me.lvwClients.HideSelection = False
    Me.lvwClients.Location = New System.Drawing.Point(6, 19)
    Me.lvwClients.MultiSelect = False
    Me.lvwClients.Name = "lvwClients"
    Me.lvwClients.Size = New System.Drawing.Size(625, 429)
    Me.lvwClients.TabIndex = 0
    Me.lvwClients.UseCompatibleStateImageBehavior = False
    Me.lvwClients.View = System.Windows.Forms.View.Details
    '
    'colLookupCode
    '
    Me.colLookupCode.Text = "Lookup Code"
    Me.colLookupCode.Width = 87
    '
    'colAccountName
    '
    Me.colAccountName.Text = "Account Name"
    Me.colAccountName.Width = 88
    '
    'colAccountStatus
    '
    Me.colAccountStatus.Text = "Account Status"
    Me.colAccountStatus.Width = 94
    '
    'colAddress1
    '
    Me.colAddress1.Text = "Address 1"
    Me.colAddress1.Width = 84
    '
    'colAddress2
    '
    Me.colAddress2.Text = "Address 2"
    Me.colAddress2.Width = 79
    '
    'colCity
    '
    Me.colCity.Text = "City"
    '
    'colState
    '
    Me.colState.Text = "State"
    '
    'colZip
    '
    Me.colZip.Text = "Zip"
    Me.colZip.Width = 55
    '
    'AccountLocate
    '
    Me.AcceptButton = Me.cmdLocate
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(794, 568)
    Me.Controls.Add(Me.grpLocate)
    Me.Controls.Add(Me.grpClients)
    Me.Controls.Add(Me.grpAreas)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "AccountLocate"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.Text = "Account Locate - Logged In As "
    Me.grpAreas.ResumeLayout(False)
    Me.grpAreas.PerformLayout()
    Me.grpLocate.ResumeLayout(False)
    Me.grpLocate.PerformLayout()
    Me.grpClients.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents grpAreas As System.Windows.Forms.GroupBox
  Friend WithEvents grpLocate As System.Windows.Forms.GroupBox
  Friend WithEvents grpClients As System.Windows.Forms.GroupBox
  Friend WithEvents lvwClients As System.Windows.Forms.ListView
  Friend WithEvents colLookupCode As System.Windows.Forms.ColumnHeader
  Friend WithEvents colAccountName As System.Windows.Forms.ColumnHeader
  Friend WithEvents colAccountStatus As System.Windows.Forms.ColumnHeader
  Friend WithEvents colAddress1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents colAddress2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents colCity As System.Windows.Forms.ColumnHeader
  Friend WithEvents colState As System.Windows.Forms.ColumnHeader
  Friend WithEvents colZip As System.Windows.Forms.ColumnHeader
  Friend WithEvents txtLocate As System.Windows.Forms.TextBox
  Friend WithEvents cboLocateType As System.Windows.Forms.ComboBox
  Friend WithEvents cboLocateBy As System.Windows.Forms.ComboBox
  Friend WithEvents lblLocateBy As System.Windows.Forms.Label
  Friend WithEvents cmdLocate As System.Windows.Forms.Button
  Friend WithEvents cmdActivities As System.Windows.Forms.Button
  Friend WithEvents cmdClaims As System.Windows.Forms.Button
  Friend WithEvents cmdAttachments As System.Windows.Forms.Button
  Friend WithEvents cmdTransactions As System.Windows.Forms.Button
  Friend WithEvents cmdProofsOfInsurance As System.Windows.Forms.Button
  Friend WithEvents cmdPolicies As System.Windows.Forms.Button
  Friend WithEvents cmdContacts As System.Windows.Forms.Button
  Friend WithEvents cmdAccountDetail As System.Windows.Forms.Button
  Friend WithEvents testOutput As TextBox
  Friend WithEvents lblTest As Label
End Class
