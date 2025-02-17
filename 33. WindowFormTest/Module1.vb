
Imports Microsoft.Data.SqlClient

Module Module1


    Public string_koneksi As String = "Server=localhost\SQLEXPRESS;Database=coba_database;User=sa;Password=123;TrustServerCertificate=True"
    Public koneksi As SqlConnection = New SqlConnection(string_koneksi)


    Public Sub konek_db()

        Try

            koneksi.Open()

        Catch
            MsgBox("Error Ning kene")

        Finally
            koneksi.Close()

        End Try

    End Sub

End Module
