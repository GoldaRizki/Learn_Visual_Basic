Imports Microsoft.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek_db()
        Awal()
    End Sub

    Private Sub Awal()

        DataGridView1.ClearSelection()
        DataGridView1.Rows.Clear()
        Dim kueri As String = "Select * From pengguna"

        Dim perintah As SqlCommand = New SqlCommand(kueri, koneksi)

        Try
            koneksi.Open()
            Dim baca As SqlDataReader = perintah.ExecuteReader()

            While (baca.Read())
                DataGridView1.Rows.Add(baca("id"), baca("nama"), baca("alamat"))
            End While

        Catch ex As Exception
            MsgBox("Error disini")
        Finally
            koneksi.Close()

        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As Form2 = New Form2
        form2.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
