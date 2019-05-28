' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

''' <summary>
'''   This class implements the data layer collection for policies.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public NotInheritable Class Policies
  Inherits System.Collections.ObjectModel.Collection(Of Policy)

#Region " Constructors "

  ''' <summary>
  '''   Default constructor.
  ''' </summary>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New()
    MyBase.New(New System.Collections.Generic.List(Of Policy))
  End Sub

#End Region

#Region " Additional Properties And Methods "

  ''' <summary>
  '''   Exposes a policy specified by an ID.
  ''' </summary>
  ''' <param name="iPolicyID">
  '''   Integer indicating the ID of the desired policy.
  ''' </param>
  ''' <value>
  '''   Policy class containing the desired policy.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public ReadOnly Property ItemByID(ByVal iPolicyID As Integer) As Policy
    Get

      For Each datPolicy As Policy In Me
        If datPolicy.PolicyID = iPolicyID Then
          Return datPolicy
        End If
      Next

      Return Nothing

    End Get
  End Property

  ''' <summary>
  '''   Removes a policy specified by an ID.
  ''' </summary>
  ''' <param name="iPolicyID">
  '''   Integer indicating the ID of the desired policy.
  ''' </param>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub RemoveByID(ByVal iPolicyID As Integer)

    For Each datPolicy As Policy In Me
      If datPolicy.PolicyID = iPolicyID Then
        Remove(datPolicy)
        Exit For
      End If
    Next

  End Sub

#End Region

End Class