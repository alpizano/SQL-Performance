' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

''' <summary>
'''   This class implements the data layer collection for clients.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public NotInheritable Class Clients
  Inherits System.Collections.ObjectModel.Collection(Of Client)

#Region " Constructors "

  ''' <summary>
  '''   Default constructor.
  ''' </summary>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub New()
    MyBase.New(New System.Collections.Generic.List(Of Client))
  End Sub

#End Region

#Region " Additional Properties And Methods "

  ''' <summary>
  '''   Exposes a client specified by an ID.
  ''' </summary>
  ''' <param name="iEntityID">
  '''   Integer indicating the ID of the desired client.
  ''' </param>
  ''' <value>
  '''   Client class containing the desired client.
  ''' </value>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public ReadOnly Property ItemByID(ByVal iEntityID As Integer) As Client
    Get

      For Each datClient As Client In Me
        If datClient.EntityID = iEntityID Then
          Return datClient
        End If
      Next

      Return Nothing

    End Get
  End Property

  ''' <summary>
  '''   Removes a client specified by an ID.
  ''' </summary>
  ''' <param name="iEntityID">
  '''   Integer indicating the ID of the desired client.
  ''' </param>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Sub RemoveByID(ByVal iEntityID As Integer)

    For Each datClient As Client In Me
      If datClient.EntityID = iEntityID Then
        Remove(datClient)
        Exit For
      End If
    Next

  End Sub

#End Region

End Class