' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

''' <summary>
'''   This class implements the data layer for policies.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public NotInheritable Class Policy

#Region " Private Variables "

  Private p_iPolicyID As Integer
  Private p_iLineID As Integer
  Private p_sLine As String
  Private p_sStatusDescription As String
  Private p_dtEffective As Date
  Private p_dtExpiration As Date
  Private p_sPolicyNumber As String
  Private p_sPolicyDescription As String

#End Region

#Region " Constructors "

  ''' <summary>
  '''   Parameterized constructor.
  ''' </summary>
  ''' <param name="iPolicyID">
  '''   Integer indicating the policy's policy ID value.
  ''' </param>
  ''' <param name="iLineID">
  '''   Integer indicating the policy's line ID value.
  ''' </param>
  ''' <param name="sLine">
  '''   String indicating the policy's line.
  ''' </param>
  ''' <param name="sStatusDescription">
  '''   String indicating the policy's status description.
  ''' </param>
  ''' <param name="dtEffective">
  '''   Date indicating the policy's effective date.
  ''' </param>
  ''' <param name="dtExpiration">
  '''   Date indicating the policy's expiration date.
  ''' </param>
  ''' <param name="sPolicyNumber">
  '''   String indicating the policy's policy number.
  ''' </param>
  ''' <param name="sPolicyDescription">
  '''   String indicating the policy's policy description.
  ''' </param>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New(ByVal iPolicyID As Integer, ByVal iLineID As Integer, ByVal sLine As String, ByVal sStatusDescription As String, ByVal dtEffective As Date, ByVal dtExpiration As Date, ByVal sPolicyNumber As String, ByVal sPolicyDescription As String)

    p_iPolicyID = iPolicyID
    p_iLineID = iLineID
    p_sLine = sLine
    p_sStatusDescription = sStatusDescription
    p_dtEffective = dtEffective
    p_dtExpiration = dtExpiration
    p_sPolicyNumber = sPolicyNumber
    p_sPolicyDescription = sPolicyDescription

  End Sub

  ''' <summary>
  '''   Default constructor.
  ''' </summary>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New()

    p_iPolicyID = -1
    p_iLineID = -1
    p_sLine = String.Empty
    p_sStatusDescription = String.Empty
    p_dtEffective = Nothing
    p_dtExpiration = Nothing
    p_sPolicyNumber = String.Empty
    p_sPolicyDescription = String.Empty

  End Sub

#End Region

#Region " Properties "

  ''' <summary>
  '''   This property indicates the value of the policy's policy ID.
  ''' </summary>
  ''' <value>
  '''   Integer containing the policy's policy ID.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property PolicyID() As Integer
    Get
      Return p_iPolicyID
    End Get
    Set(ByVal iValue As Integer)
      p_iPolicyID = iValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's line ID.
  ''' </summary>
  ''' <value>
  '''   Integer containing the policy's line ID.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property LineID() As Integer
    Get
      Return p_iLineID
    End Get
    Set(ByVal iValue As Integer)
      p_iLineID = iValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's line.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's line.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property Line() As String
    Get
      Return p_sLine
    End Get
    Set(ByVal sValue As String)
      p_sLine = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's status description.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's status description.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property StatusDescription() As String
    Get
      Return p_sStatusDescription
    End Get
    Set(ByVal sValue As String)
      p_sStatusDescription = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's effective date.
  ''' </summary>
  ''' <value>
  '''   Date containing the policy's effective date.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property Effective() As Date
    Get
      Return p_dtEffective
    End Get
    Set(ByVal dtValue As Date)
      p_dtEffective = dtValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's expiration date.
  ''' </summary>
  ''' <value>
  '''   Date containing the policy's expiration date.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property Expiration() As Date
    Get
      Return p_dtExpiration
    End Get
    Set(ByVal dtValue As Date)
      p_dtExpiration = dtValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's policy number.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's policy number.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property PolicyNumber() As String
    Get
      Return p_sPolicyNumber
    End Get
    Set(ByVal sValue As String)
      p_sPolicyNumber = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's policy description.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's policy description.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property PolicyDescription() As String
    Get
      Return p_sPolicyDescription
    End Get
    Set(ByVal sValue As String)
      p_sPolicyDescription = sValue
    End Set
  End Property

#End Region

End Class