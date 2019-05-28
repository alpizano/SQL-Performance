' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

''' <summary>
'''   This class implements the data layer for clients.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public NotInheritable Class Client

#Region " Private Variables "

  Private p_iEntityID As Integer
  Private p_sLookupCode As String
  Private p_sAccountName As String
  Private p_fActive As Boolean
  Private p_sAddress1 As String
  Private p_sAddress2 As String
  Private p_sCity As String
  Private p_sState As String
  Private p_sZip As String

#End Region

#Region " Constructors "

  ''' <summary>
  '''   Parameterized constructor.
  ''' </summary>
  ''' <param name="iEntityID">
  '''   Integer indicating the client's ID value.
  ''' </param>
  ''' <param name="sLookupCode">
  '''   String indicating the client's lookup code.
  ''' </param>
  ''' <param name="sAccountName">
  '''   String indicating the client's account name.
  ''' </param>
  ''' <param name="fActive">
  '''   Boolean indicating if the client is active.
  ''' </param>
  ''' <param name="sAddress1">
  '''   String indicating the client's address1.
  ''' </param>
  ''' <param name="sAddress2">
  '''   String indicating the client's address2.
  ''' </param>
  ''' <param name="sCity">
  '''   String indicating the client's city.
  ''' </param>
  ''' <param name="sState">
  '''   String indicating the client's state.
  ''' </param>
  ''' <param name="sZip">
  '''   String indicating the client's zip code.
  ''' </param>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New(ByVal iEntityID As Integer, ByVal sLookupCode As String, ByVal sAccountName As String, ByVal fActive As Boolean, ByVal sAddress1 As String, ByVal sAddress2 As String, ByVal sCity As String, ByVal sState As String, ByVal sZip As String)

    p_iEntityID = iEntityID
    p_sLookupCode = sLookupCode
    p_sAccountName = sAccountName
    p_fActive = fActive
    p_sAddress1 = sAddress1
    p_sAddress2 = sAddress2
    p_sCity = sCity
    p_sState = sState
    p_sZip = sZip

  End Sub

  ''' <summary>
  '''   Default constructor.
  ''' </summary>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New()

    p_iEntityID = -1
    p_sLookupCode = String.Empty
    p_sAccountName = String.Empty
    p_fActive = True
    p_sAddress1 = String.Empty
    p_sAddress2 = String.Empty
    p_sCity = String.Empty
    p_sState = String.Empty
    p_sZip = String.Empty

  End Sub

#End Region

#Region " Properties "

  ''' <summary>
  '''   This property indicates the value of the client's ID.
  ''' </summary>
  ''' <value>
  '''   Integer containing the client's ID.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property EntityID() As Integer
    Get
      Return p_iEntityID
    End Get
    Set(ByVal iValue As Integer)
      p_iEntityID = iValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the client's lookup code.
  ''' </summary>
  ''' <value>
  '''   String containing the client's lookup code.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property LookupCode() As String
    Get
      Return p_sLookupCode
    End Get
    Set(ByVal sValue As String)
      p_sLookupCode = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the client's account name.
  ''' </summary>
  ''' <value>
  '''   String containing the client's account name.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property AccountName() As String
    Get
      Return p_sAccountName
    End Get
    Set(ByVal sValue As String)
      p_sAccountName = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the client's active status.
  ''' </summary>
  ''' <value>
  '''   Boolean containing the client's active status.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property Active() As Boolean
    Get
      Return p_fActive
    End Get
    Set(ByVal fValue As Boolean)
      p_fActive = fValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the client's address1.
  ''' </summary>
  ''' <value>
  '''   String containing the client's address1.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property Address1() As String
    Get
      Return p_sAddress1
    End Get
    Set(ByVal sValue As String)
      p_sAddress1 = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the client's address2.
  ''' </summary>
  ''' <value>
  '''   String containing the client's address2.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property Address2() As String
    Get
      Return p_sAddress2
    End Get
    Set(ByVal sValue As String)
      p_sAddress2 = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the client's city.
  ''' </summary>
  ''' <value>
  '''   String containing the client's city.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property City() As String
    Get
      Return p_sCity
    End Get
    Set(ByVal sValue As String)
      p_sCity = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the client's state.
  ''' </summary>
  ''' <value>
  '''   String containing the client's state.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property State() As String
    Get
      Return p_sState
    End Get
    Set(ByVal sValue As String)
      p_sState = sValue
    End Set
  End Property

  ''' <summary>
  '''   This property indicates the value of the client's zip code.
  ''' </summary>
  ''' <value>
  '''   String containing the client's zip code.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Property Zip() As String
    Get
      Return p_sZip
    End Get
    Set(ByVal sValue As String)
      p_sZip = sValue
    End Set
  End Property

#End Region

End Class