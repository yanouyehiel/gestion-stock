Imports MySql.Data.MySqlClient
Module BaseDeDonnees
    Public Function Connect()
        Dim chaineConneciotn As String = "DataSource=localhost;Initial Catalog=gestock;User Id=root;Password=root;"
        Dim Connection = New MySqlConnection(chaineConneciotn)
        Try
            If Connection.State <> ConnectionState.Open Then
                Connection.Open()
            End If
        Catch ex As Exception
            ErrorMessage.MessageError(ex)
        End Try

        Return Connection
    End Function

    Public Function GetCommande(ByVal sql As String) As MySqlCommand
        Dim cmd = Connect().CreateCommand
        cmd.CommandText = sql

        Return cmd
    End Function
End Module