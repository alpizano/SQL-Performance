<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolicyList
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PolicyList))
    Me.grpPolicies = New System.Windows.Forms.GroupBox
    Me.lvwPolicies = New System.Windows.Forms.ListView
    Me.colLine = New System.Windows.Forms.ColumnHeader
    Me.colStatusDescription = New System.Windows.Forms.ColumnHeader
    Me.colEffectiveDate = New System.Windows.Forms.ColumnHeader
    Me.colExpirationDate = New System.Windows.Forms.ColumnHeader
    Me.colPolicyNumber = New System.Windows.Forms.ColumnHeader
    Me.colPolicyDescription = New System.Windows.Forms.ColumnHeader
    Me.grpPolicyDetail = New System.Windows.Forms.GroupBox
    Me.txtAnnualizedPremium = New System.Windows.Forms.TextBox
    Me.txtAnnualizedCommission = New System.Windows.Forms.TextBox
    Me.txtBilledPremium = New System.Windows.Forms.TextBox
    Me.txtBilledCommission = New System.Windows.Forms.TextBox
    Me.lblAnnualizedPremium = New System.Windows.Forms.Label
    Me.lblAnnualizedCommission = New System.Windows.Forms.Label
    Me.lblBilledPremium = New System.Windows.Forms.Label
    Me.lblBilledCommission = New System.Windows.Forms.Label
    Me.grpLineDetail = New System.Windows.Forms.GroupBox
    Me.txtIssuingState = New System.Windows.Forms.TextBox
    Me.txtIssuingCompany = New System.Windows.Forms.TextBox
    Me.txtBillingCompany = New System.Windows.Forms.TextBox
    Me.lblIssuingState = New System.Windows.Forms.Label
    Me.lblIssuingCompany = New System.Windows.Forms.Label
    Me.lblBillingCompany = New System.Windows.Forms.Label
    Me.grpActions = New System.Windows.Forms.GroupBox
    Me.cmdPrint = New System.Windows.Forms.Button
    Me.cmdDelete = New System.Windows.Forms.Button
    Me.cmdRenew = New System.Windows.Forms.Button
    Me.cmdEndorse = New System.Windows.Forms.Button
    Me.grpPolicies.SuspendLayout()
    Me.grpPolicyDetail.SuspendLayout()
    Me.grpLineDetail.SuspendLayout()
    Me.grpActions.SuspendLayout()
    Me.SuspendLayout()
    '
    'grpPolicies
    '
    Me.grpPolicies.Controls.Add(Me.lvwPolicies)
    Me.grpPolicies.Location = New System.Drawing.Point(12, 12)
    Me.grpPolicies.Name = "grpPolicies"
    Me.grpPolicies.Size = New System.Drawing.Size(770, 412)
    Me.grpPolicies.TabIndex = 0
    Me.grpPolicies.TabStop = False
    Me.grpPolicies.Text = "Policies"
    '
    'lvwPolicies
    '
    Me.lvwPolicies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colLine, Me.colStatusDescription, Me.colEffectiveDate, Me.colExpirationDate, Me.colPolicyNumber, Me.colPolicyDescription})
    Me.lvwPolicies.FullRowSelect = True
    Me.lvwPolicies.HideSelection = False
    Me.lvwPolicies.Location = New System.Drawing.Point(6, 19)
    Me.lvwPolicies.MultiSelect = False
    Me.lvwPolicies.Name = "lvwPolicies"
    Me.lvwPolicies.Size = New System.Drawing.Size(758, 387)
    Me.lvwPolicies.TabIndex = 0
    Me.lvwPolicies.UseCompatibleStateImageBehavior = False
    Me.lvwPolicies.View = System.Windows.Forms.View.Details
    '
    'colLine
    '
    Me.colLine.Text = "Line"
    Me.colLine.Width = 50
    '
    'colStatusDescription
    '
    Me.colStatusDescription.Text = "Status Description"
    Me.colStatusDescription.Width = 160
    '
    'colEffectiveDate
    '
    Me.colEffectiveDate.Text = "Effective Date"
    Me.colEffectiveDate.Width = 100
    '
    'colExpirationDate
    '
    Me.colExpirationDate.Text = "Expiration Date"
    Me.colExpirationDate.Width = 100
    '
    'colPolicyNumber
    '
    Me.colPolicyNumber.Text = "Policy Number"
    Me.colPolicyNumber.Width = 160
    '
    'colPolicyDescription
    '
    Me.colPolicyDescription.Text = "Policy Description"
    Me.colPolicyDescription.Width = 160
    '
    'grpPolicyDetail
    '
    Me.grpPolicyDetail.Controls.Add(Me.txtAnnualizedPremium)
    Me.grpPolicyDetail.Controls.Add(Me.txtAnnualizedCommission)
    Me.grpPolicyDetail.Controls.Add(Me.txtBilledPremium)
    Me.grpPolicyDetail.Controls.Add(Me.txtBilledCommission)
    Me.grpPolicyDetail.Controls.Add(Me.lblAnnualizedPremium)
    Me.grpPolicyDetail.Controls.Add(Me.lblAnnualizedCommission)
    Me.grpPolicyDetail.Controls.Add(Me.lblBilledPremium)
    Me.grpPolicyDetail.Controls.Add(Me.lblBilledCommission)
    Me.grpPolicyDetail.Location = New System.Drawing.Point(12, 430)
    Me.grpPolicyDetail.Name = "grpPolicyDetail"
    Me.grpPolicyDetail.Size = New System.Drawing.Size(250, 126)
    Me.grpPolicyDetail.TabIndex = 1
    Me.grpPolicyDetail.TabStop = False
    Me.grpPolicyDetail.Text = "Policy Detail"
    '
    'txtAnnualizedPremium
    '
    Me.txtAnnualizedPremium.Location = New System.Drawing.Point(138, 97)
    Me.txtAnnualizedPremium.Name = "txtAnnualizedPremium"
    Me.txtAnnualizedPremium.ReadOnly = True
    Me.txtAnnualizedPremium.Size = New System.Drawing.Size(100, 20)
    Me.txtAnnualizedPremium.TabIndex = 7
    '
    'txtAnnualizedCommission
    '
    Me.txtAnnualizedCommission.Location = New System.Drawing.Point(138, 71)
    Me.txtAnnualizedCommission.Name = "txtAnnualizedCommission"
    Me.txtAnnualizedCommission.ReadOnly = True
    Me.txtAnnualizedCommission.Size = New System.Drawing.Size(100, 20)
    Me.txtAnnualizedCommission.TabIndex = 5
    '
    'txtBilledPremium
    '
    Me.txtBilledPremium.Location = New System.Drawing.Point(138, 45)
    Me.txtBilledPremium.Name = "txtBilledPremium"
    Me.txtBilledPremium.ReadOnly = True
    Me.txtBilledPremium.Size = New System.Drawing.Size(100, 20)
    Me.txtBilledPremium.TabIndex = 3
    '
    'txtBilledCommission
    '
    Me.txtBilledCommission.Location = New System.Drawing.Point(138, 19)
    Me.txtBilledCommission.Name = "txtBilledCommission"
    Me.txtBilledCommission.ReadOnly = True
    Me.txtBilledCommission.Size = New System.Drawing.Size(100, 20)
    Me.txtBilledCommission.TabIndex = 1
    '
    'lblAnnualizedPremium
    '
    Me.lblAnnualizedPremium.AutoSize = True
    Me.lblAnnualizedPremium.Location = New System.Drawing.Point(27, 100)
    Me.lblAnnualizedPremium.Name = "lblAnnualizedPremium"
    Me.lblAnnualizedPremium.Size = New System.Drawing.Size(105, 13)
    Me.lblAnnualizedPremium.TabIndex = 6
    Me.lblAnnualizedPremium.Text = "Annualized Premium:"
    Me.lblAnnualizedPremium.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblAnnualizedCommission
    '
    Me.lblAnnualizedCommission.AutoSize = True
    Me.lblAnnualizedCommission.Location = New System.Drawing.Point(12, 74)
    Me.lblAnnualizedCommission.Name = "lblAnnualizedCommission"
    Me.lblAnnualizedCommission.Size = New System.Drawing.Size(120, 13)
    Me.lblAnnualizedCommission.TabIndex = 4
    Me.lblAnnualizedCommission.Text = "Annualized Commission:"
    Me.lblAnnualizedCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblBilledPremium
    '
    Me.lblBilledPremium.AutoSize = True
    Me.lblBilledPremium.Location = New System.Drawing.Point(54, 48)
    Me.lblBilledPremium.Name = "lblBilledPremium"
    Me.lblBilledPremium.Size = New System.Drawing.Size(78, 13)
    Me.lblBilledPremium.TabIndex = 2
    Me.lblBilledPremium.Text = "Billed Premium:"
    Me.lblBilledPremium.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblBilledCommission
    '
    Me.lblBilledCommission.AutoSize = True
    Me.lblBilledCommission.Location = New System.Drawing.Point(39, 22)
    Me.lblBilledCommission.Name = "lblBilledCommission"
    Me.lblBilledCommission.Size = New System.Drawing.Size(93, 13)
    Me.lblBilledCommission.TabIndex = 0
    Me.lblBilledCommission.Text = "Billed Commission:"
    Me.lblBilledCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'grpLineDetail
    '
    Me.grpLineDetail.Controls.Add(Me.txtIssuingState)
    Me.grpLineDetail.Controls.Add(Me.txtIssuingCompany)
    Me.grpLineDetail.Controls.Add(Me.txtBillingCompany)
    Me.grpLineDetail.Controls.Add(Me.lblIssuingState)
    Me.grpLineDetail.Controls.Add(Me.lblIssuingCompany)
    Me.grpLineDetail.Controls.Add(Me.lblBillingCompany)
    Me.grpLineDetail.Location = New System.Drawing.Point(268, 430)
    Me.grpLineDetail.Name = "grpLineDetail"
    Me.grpLineDetail.Size = New System.Drawing.Size(325, 126)
    Me.grpLineDetail.TabIndex = 2
    Me.grpLineDetail.TabStop = False
    Me.grpLineDetail.Text = "Line Detail"
    '
    'txtIssuingState
    '
    Me.txtIssuingState.Location = New System.Drawing.Point(110, 71)
    Me.txtIssuingState.Name = "txtIssuingState"
    Me.txtIssuingState.ReadOnly = True
    Me.txtIssuingState.Size = New System.Drawing.Size(40, 20)
    Me.txtIssuingState.TabIndex = 5
    '
    'txtIssuingCompany
    '
    Me.txtIssuingCompany.Location = New System.Drawing.Point(110, 45)
    Me.txtIssuingCompany.Name = "txtIssuingCompany"
    Me.txtIssuingCompany.ReadOnly = True
    Me.txtIssuingCompany.Size = New System.Drawing.Size(200, 20)
    Me.txtIssuingCompany.TabIndex = 3
    '
    'txtBillingCompany
    '
    Me.txtBillingCompany.Location = New System.Drawing.Point(110, 19)
    Me.txtBillingCompany.Name = "txtBillingCompany"
    Me.txtBillingCompany.ReadOnly = True
    Me.txtBillingCompany.Size = New System.Drawing.Size(200, 20)
    Me.txtBillingCompany.TabIndex = 1
    '
    'lblIssuingState
    '
    Me.lblIssuingState.AutoSize = True
    Me.lblIssuingState.Location = New System.Drawing.Point(33, 74)
    Me.lblIssuingState.Name = "lblIssuingState"
    Me.lblIssuingState.Size = New System.Drawing.Size(71, 13)
    Me.lblIssuingState.TabIndex = 4
    Me.lblIssuingState.Text = "Issuing State:"
    '
    'lblIssuingCompany
    '
    Me.lblIssuingCompany.AutoSize = True
    Me.lblIssuingCompany.Location = New System.Drawing.Point(14, 48)
    Me.lblIssuingCompany.Name = "lblIssuingCompany"
    Me.lblIssuingCompany.Size = New System.Drawing.Size(90, 13)
    Me.lblIssuingCompany.TabIndex = 2
    Me.lblIssuingCompany.Text = "Issuing Company:"
    '
    'lblBillingCompany
    '
    Me.lblBillingCompany.AutoSize = True
    Me.lblBillingCompany.Location = New System.Drawing.Point(20, 22)
    Me.lblBillingCompany.Name = "lblBillingCompany"
    Me.lblBillingCompany.Size = New System.Drawing.Size(84, 13)
    Me.lblBillingCompany.TabIndex = 0
    Me.lblBillingCompany.Text = "Billing Company:"
    '
    'grpActions
    '
    Me.grpActions.Controls.Add(Me.cmdPrint)
    Me.grpActions.Controls.Add(Me.cmdDelete)
    Me.grpActions.Controls.Add(Me.cmdRenew)
    Me.grpActions.Controls.Add(Me.cmdEndorse)
    Me.grpActions.Location = New System.Drawing.Point(599, 430)
    Me.grpActions.Name = "grpActions"
    Me.grpActions.Size = New System.Drawing.Size(183, 126)
    Me.grpActions.TabIndex = 3
    Me.grpActions.TabStop = False
    Me.grpActions.Text = "Actions"
    '
    'cmdPrint
    '
    Me.cmdPrint.Enabled = False
    Me.cmdPrint.Location = New System.Drawing.Point(6, 95)
    Me.cmdPrint.Name = "cmdPrint"
    Me.cmdPrint.Size = New System.Drawing.Size(171, 23)
    Me.cmdPrint.TabIndex = 3
    Me.cmdPrint.Text = "Print"
    Me.cmdPrint.UseVisualStyleBackColor = True
    '
    'cmdDelete
    '
    Me.cmdDelete.Enabled = False
    Me.cmdDelete.Location = New System.Drawing.Point(6, 69)
    Me.cmdDelete.Name = "cmdDelete"
    Me.cmdDelete.Size = New System.Drawing.Size(171, 23)
    Me.cmdDelete.TabIndex = 2
    Me.cmdDelete.Text = "Delete"
    Me.cmdDelete.UseVisualStyleBackColor = True
    '
    'cmdRenew
    '
    Me.cmdRenew.Enabled = False
    Me.cmdRenew.Location = New System.Drawing.Point(6, 43)
    Me.cmdRenew.Name = "cmdRenew"
    Me.cmdRenew.Size = New System.Drawing.Size(171, 23)
    Me.cmdRenew.TabIndex = 1
    Me.cmdRenew.Text = "Renew"
    Me.cmdRenew.UseVisualStyleBackColor = True
    '
    'cmdEndorse
    '
    Me.cmdEndorse.Enabled = False
    Me.cmdEndorse.Location = New System.Drawing.Point(6, 17)
    Me.cmdEndorse.Name = "cmdEndorse"
    Me.cmdEndorse.Size = New System.Drawing.Size(171, 23)
    Me.cmdEndorse.TabIndex = 0
    Me.cmdEndorse.Text = "Endorse"
    Me.cmdEndorse.UseVisualStyleBackColor = True
    '
    'PolicyList
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(794, 568)
    Me.Controls.Add(Me.grpActions)
    Me.Controls.Add(Me.grpPolicyDetail)
    Me.Controls.Add(Me.grpLineDetail)
    Me.Controls.Add(Me.grpPolicies)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "PolicyList"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.Text = "Policy List - "
    Me.grpPolicies.ResumeLayout(False)
    Me.grpPolicyDetail.ResumeLayout(False)
    Me.grpPolicyDetail.PerformLayout()
    Me.grpLineDetail.ResumeLayout(False)
    Me.grpLineDetail.PerformLayout()
    Me.grpActions.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents grpPolicies As System.Windows.Forms.GroupBox
  Friend WithEvents lvwPolicies As System.Windows.Forms.ListView
  Friend WithEvents grpPolicyDetail As System.Windows.Forms.GroupBox
  Friend WithEvents grpLineDetail As System.Windows.Forms.GroupBox
  Friend WithEvents colLine As System.Windows.Forms.ColumnHeader
  Friend WithEvents colStatusDescription As System.Windows.Forms.ColumnHeader
  Friend WithEvents colEffectiveDate As System.Windows.Forms.ColumnHeader
  Friend WithEvents colExpirationDate As System.Windows.Forms.ColumnHeader
  Friend WithEvents colPolicyNumber As System.Windows.Forms.ColumnHeader
  Friend WithEvents colPolicyDescription As System.Windows.Forms.ColumnHeader
  Friend WithEvents txtAnnualizedPremium As System.Windows.Forms.TextBox
  Friend WithEvents txtAnnualizedCommission As System.Windows.Forms.TextBox
  Friend WithEvents txtBilledPremium As System.Windows.Forms.TextBox
  Friend WithEvents txtBilledCommission As System.Windows.Forms.TextBox
  Friend WithEvents lblAnnualizedPremium As System.Windows.Forms.Label
  Friend WithEvents lblAnnualizedCommission As System.Windows.Forms.Label
  Friend WithEvents lblBilledPremium As System.Windows.Forms.Label
  Friend WithEvents lblBilledCommission As System.Windows.Forms.Label
  Friend WithEvents txtIssuingState As System.Windows.Forms.TextBox
  Friend WithEvents txtIssuingCompany As System.Windows.Forms.TextBox
  Friend WithEvents txtBillingCompany As System.Windows.Forms.TextBox
  Friend WithEvents lblIssuingState As System.Windows.Forms.Label
  Friend WithEvents lblIssuingCompany As System.Windows.Forms.Label
  Friend WithEvents lblBillingCompany As System.Windows.Forms.Label
  Friend WithEvents grpActions As System.Windows.Forms.GroupBox
  Friend WithEvents cmdPrint As System.Windows.Forms.Button
  Friend WithEvents cmdDelete As System.Windows.Forms.Button
  Friend WithEvents cmdRenew As System.Windows.Forms.Button
  Friend WithEvents cmdEndorse As System.Windows.Forms.Button
End Class
