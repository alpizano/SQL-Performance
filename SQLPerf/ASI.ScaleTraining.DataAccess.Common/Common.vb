' Copyright (c) 2009 Applied Systems, Inc.
Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.IO

''' <summary>
'''   This class provides a common access point for all DB queries.
''' </summary>
''' <remarks>
'''   None
''' </remarks>
Public Module Common

#Region " Methods "

  ''' <summary>
  '''   Returns a DataTable containing the results of a query.
  ''' </summary>
  ''' <param name="sSQL">
  '''   String indicating the query to issue.
  ''' </param>
  ''' <returns>
  '''   DataTable containing the results of the query.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function ExecuteDataTable(ByVal sSQL As String) As DataTable

    Dim oDataTable As New DataTable
    Dim oDataAdapter As New SqlDataAdapter(sSQL, GetConnectionString())
    oDataAdapter.Fill(oDataTable)
    Return oDataTable

  End Function

  ''' <summary>
  '''   Executes a SQL command on the database.
  ''' </summary>
  ''' <param name="sSQL">
  '''   String indicating the command to issue.
  ''' </param>
  ''' <returns>
  '''   Integer indicating the number of rows affected.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function ExecuteCommand(ByVal sSQL As String) As Integer

    Dim cnSQL As New SqlConnection(GetConnectionString())
    Dim cmSQL As New SqlCommand(sSQL, cnSQL)

    Try
      cnSQL.Open()
      Return cmSQL.ExecuteNonQuery()
    Catch ex As Exception
      Throw ex
    Finally
      cnSQL.Close()
    End Try

  End Function

  ''' <summary>
  '''   Makes an input string safe to be used in a database query.
  ''' </summary>
  ''' <param name="sValue">
  '''   String containing the value to be sanitized.
  ''' </param>
  ''' <returns>
  '''   String containing the sanitized, database-safe value.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Public Function ToDBString(ByVal sValue As String) As String

    Return sValue.Replace("'", "''")

  End Function

#End Region

#Region " Helper Functions "

  ''' <summary>
  '''   Reads a text file containing the DB information.
  ''' </summary>
  ''' <returns>
  '''   String containing the connection string.
  ''' </returns>
  ''' <remarks>
  '''   None
  ''' </remarks>
  Private Function GetConnectionString() As String

    Using rdrSettings As StreamReader = File.OpenText(Path.Combine(Environment.CurrentDirectory, "ASI.ScaleTraining.DataAccess.Common.txt"))

      Return "Data Source=" & rdrSettings.ReadLine() & "; Database=" & rdrSettings.ReadLine() & "; Integrated Security=SSPI"

    End Using

  End Function

#End Region

End Module