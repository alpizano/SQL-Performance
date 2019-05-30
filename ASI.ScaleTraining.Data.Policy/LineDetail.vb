' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

''' <summary>
'''   This class implements the data layer for line detail.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public NotInheritable Class LineDetail

#Region " Private Variables "

  Private p_iLineID As Integer
  Private p_sLineType As String
  Private p_sFormCategory As String
  Private p_sBillToContactName As String
  Private p_sBillToAddress1 As String
  Private p_sBillToAddress2 As String
  Private p_sBillToAddress3 As String
  Private p_sBillToCity As String
  Private p_sBillToState As String
  Private p_sBillToPostalCode As String
  Private p_sBillToCounty As String
  Private p_sBillToCountryCode As String
  Private p_sEmail As String
  Private p_sFax As String
  Private p_sFaxExtension As String
  Private p_sBillingCompany As String
  Private p_sIssuingCompany As String
  Private p_sIssuingState As String

#End Region

#Region " Constructors "

  ''' <summary>
  '''   Parameterized constructor.
  ''' </summary>
  ''' <param name="iLineID">
  '''   Integer indicating the policy's line ID value.
  ''' </param>
  ''' <param name="sLineType">
  '''   String indicating the policy's line type.
  ''' </param>
  ''' <param name="sFormCategory">
  '''   String indicating the policy's form category.
  ''' </param>
  ''' <param name="sBillToContactName">
  '''   String indicating the policy's bill to contact name.
  ''' </param>
  ''' <param name="sBillToAddress1">
  '''   String indicating the policy's bill to address1.
  ''' </param>
  ''' <param name="sBillToAddress2">
  '''   String indicating the policy's bill to address2.
  ''' </param>
  ''' <param name="sBillToAddress3">
  '''   String indicating the policy's bill to address3.
  ''' </param>
  ''' <param name="sBillToCity">
  '''   String indicating the policy's bill to city.
  ''' </param>
  ''' <param name="sBillToState">
  '''   String indicating the policy's bill to state.
  ''' </param>
  ''' <param name="sBillToPostalCode">
  '''   String indicating the policy's bill to postal code.
  ''' </param>
  ''' <param name="sBillToCounty">
  '''   String indicating the policy's bill to county.
  ''' </param>
  ''' <param name="sBillToCountryCode">
  '''   String indicating the policy's bill to country code.
  ''' </param>
  ''' <param name="sEmail">
  '''   String indicating the policy's email.
  ''' </param>
  ''' <param name="sFax">
  '''   String indicating the policy's fax.
  ''' </param>
  ''' <param name="sFaxExtension">
  '''   String indicating the policy's fax extension.
  ''' </param>
  ''' <param name="sBillingCompany">
  '''   String indicating the policy's billing company.
  ''' </param>
  ''' <param name="sIssuingCompany">
  '''   String indicating the policy's issuing company.
  ''' </param>
  ''' <param name="sIssuingState">
  '''   String indicating the policy's issuing state.
  ''' </param>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New(ByVal iLineID As Integer, ByVal sLineType As String, ByVal sFormCategory As String, ByVal sBillToContactName As String, ByVal sBillToAddress1 As String, ByVal sBillToAddress2 As String, ByVal sBillToAddress3 As String, ByVal sBillToCity As String, ByVal sBillToState As String, ByVal sBillToPostalCode As String, ByVal sBillToCounty As String, ByVal sBillToCountryCode As String, ByVal sEmail As String, ByVal sFax As String, ByVal sFaxExtension As String, ByVal sBillingCompany As String, ByVal sIssuingCompany As String, ByVal sIssuingState As String)

    p_iLineID = iLineID
    p_sLineType = sLineType
    p_sFormCategory = sFormCategory
    p_sBillToContactName = sBillToContactName
    p_sBillToAddress1 = sBillToAddress1
    p_sBillToAddress2 = sBillToAddress2
    p_sBillToAddress3 = sBillToAddress3
    p_sBillToCity = sBillToCity
    p_sBillToState = sBillToState
    p_sBillToPostalCode = sBillToPostalCode
    p_sBillToCounty = sBillToCounty
    p_sBillToCountryCode = sBillToCountryCode
    p_sEmail = sEmail
    p_sFax = sFax
    p_sFaxExtension = sFaxExtension
    p_sBillingCompany = sBillingCompany
    p_sIssuingCompany = sIssuingCompany
    p_sIssuingState = sIssuingState

  End Sub

  ''' <summary>
  '''   Default constructor.
  ''' </summary>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New()

    p_iLineID = -1
    p_sLineType = String.Empty
    p_sFormCategory = String.Empty
    p_sBillToContactName = String.Empty
    p_sBillToAddress1 = String.Empty
    p_sBillToAddress2 = String.Empty
    p_sBillToAddress3 = String.Empty
    p_sBillToCity = String.Empty
    p_sBillToState = String.Empty
    p_sBillToPostalCode = String.Empty
    p_sBillToCounty = String.Empty
    p_sBillToCountryCode = String.Empty
    p_sEmail = String.Empty
    p_sFax = String.Empty
    p_sFaxExtension = String.Empty
    p_sBillingCompany = String.Empty
    p_sIssuingCompany = String.Empty
    p_sIssuingState = String.Empty

  End Sub

#End Region

#Region " Properties "

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
  '''   This property indicates the value of the policy's line type.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's line type.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property LineType() As String
    Get
      Return p_sLineType
    End Get
    Set(ByVal sValue As String)
      p_sLineType = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's form category.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's form category.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property FormCategory() As String
    Get
      Return p_sFormCategory
    End Get
    Set(ByVal sValue As String)
      p_sFormCategory = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's bill to contact name.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's bill to contact name.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BillToContactName() As String
    Get
      Return p_sBillToContactName
    End Get
    Set(ByVal sValue As String)
      p_sBillToContactName = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's bill to address1.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's bill to address1.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BillToAddress1() As String
    Get
      Return p_sBillToAddress1
    End Get
    Set(ByVal sValue As String)
      p_sBillToAddress1 = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's bill to address2.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's bill to address2.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BillToAddress2() As String
    Get
      Return p_sBillToAddress2
    End Get
    Set(ByVal sValue As String)
      p_sBillToAddress2 = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's bill to address3.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's bill to address3.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BillToAddress3() As String
    Get
      Return p_sBillToAddress3
    End Get
    Set(ByVal sValue As String)
      p_sBillToAddress3 = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's bill to city.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's bill to city.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BillToCity() As String
    Get
      Return p_sBillToCity
    End Get
    Set(ByVal sValue As String)
      p_sBillToCity = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's bill to state.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's bill to state.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BillToState() As String
    Get
      Return p_sBillToState
    End Get
    Set(ByVal sValue As String)
      p_sBillToState = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's bill to postal code.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's bill to postal code.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BillToPostalCode() As String
    Get
      Return p_sBillToPostalCode
    End Get
    Set(ByVal sValue As String)
      p_sBillToPostalCode = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's bill to county.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's bill to county.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BillToCounty() As String
    Get
      Return p_sBillToCounty
    End Get
    Set(ByVal sValue As String)
      p_sBillToCounty = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's bill to country code.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's bill to country code.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BillToCountryCode() As String
    Get
      Return p_sBillToCountryCode
    End Get
    Set(ByVal sValue As String)
      p_sBillToCountryCode = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's email.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's email.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property Email() As String
    Get
      Return p_sEmail
    End Get
    Set(ByVal sValue As String)
      p_sEmail = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's fax.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's fax.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property Fax() As String
    Get
      Return p_sFax
    End Get
    Set(ByVal sValue As String)
      p_sFax = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's fax extension.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's fax extension.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property FaxExtension() As String
    Get
      Return p_sFaxExtension
    End Get
    Set(ByVal sValue As String)
      p_sFaxExtension = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's billing company.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's billing company.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property BillingCompany() As String
    Get
      Return p_sBillingCompany
    End Get
    Set(ByVal sValue As String)
      p_sBillingCompany = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's issuing company.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's issuing company.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property IssuingCompany() As String
    Get
      Return p_sIssuingCompany
    End Get
    Set(ByVal sValue As String)
      p_sIssuingCompany = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the policy's issuing state.
  ''' </summary>
  ''' <value>
  '''   String containing the policy's issuing state.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property IssuingState() As String
    Get
      Return p_sIssuingState
    End Get
    Set(ByVal sValue As String)
      p_sIssuingState = sValue
    End Set
  End Property

#End Region

End Class