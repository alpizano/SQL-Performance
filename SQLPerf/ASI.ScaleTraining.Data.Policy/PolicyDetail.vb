' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

''' <summary>
'''   This class implements the data layer for policy detail.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public NotInheritable Class PolicyDetail

#Region " Private Variables "

  Private p_iPolicyID As Integer
  Private p_dBilledCommission As Double
  Private p_dBilledPremium As Double
  Private p_dAnnualizedCommission As Double
  Private p_dAnnualizedPremium As Double

#End Region

#Region " Constructors "

  ''' <summary>
  '''   Parameterized constructor.
  ''' </summary>
  ''' <param name="iPolicyID">
  '''   Integer indicating the policy's policy ID value.
  ''' </param>
  ''' <param name="dBilledCommission">
  '''   Double indicating the policy's billed commission.
  ''' </param>
  ''' <param name="dBilledPremium">
  '''   Double indicating the policy's billed premium.
  ''' </param>
  ''' <param name="dAnnualizedCommission">
  '''   Double indicating the policy's annualized commission.
  ''' </param>
  ''' <param name="dAnnualizedPremium">
  '''   Double indicating the policy's annualized premium.
  ''' </param>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New(ByVal iPolicyID As Integer, ByVal dBilledCommission As Double, ByVal dBilledPremium As Double, ByVal dAnnualizedCommission As Double, ByVal dAnnualizedPremium As Double)

    p_iPolicyID = iPolicyID
    p_dBilledCommission = dBilledCommission
    p_dBilledPremium = dBilledPremium
    p_dAnnualizedCommission = dAnnualizedCommission
    p_dAnnualizedPremium = dAnnualizedPremium

  End Sub

  ''' <summary>
  '''   Default constructor.
  ''' </summary>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New()

    p_iPolicyID = -1
    p_dBilledCommission = 0
    p_dBilledPremium = 0
    p_dAnnualizedCommission = 0
    p_dAnnualizedPremium = 0

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
  '''   This property indicates the value of the policy's billed commission.
  ''' </summary>
  ''' <value>
  '''   Double containing the policy's billed commission.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BilledCommission() As Double
    Get
      Return p_dBilledCommission
    End Get
    Set(ByVal dValue As Double)
      p_dBilledCommission = dValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's billed premium.
  ''' </summary>
  ''' <value>
  '''   Double containing the policy's billed premium.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BilledPremium() As Double
    Get
      Return p_dBilledPremium
    End Get
    Set(ByVal dValue As Double)
      p_dBilledPremium = dValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's annualized commission.
  ''' </summary>
  ''' <value>
  '''   Double containing the policy's annualized commission.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property AnnualizedCommission() As Double
    Get
      Return p_dAnnualizedCommission
    End Get
    Set(ByVal dValue As Double)
      p_dAnnualizedCommission = dValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's annualized premium.
  ''' </summary>
  ''' <value>
  '''   Double containing the policy's annualized premium.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property AnnualizedPremium() As Double
    Get
      Return p_dAnnualizedPremium
    End Get
    Set(ByVal dValue As Double)
      p_dAnnualizedPremium = dValue
    End Set
  End Property

#End Region

End Class