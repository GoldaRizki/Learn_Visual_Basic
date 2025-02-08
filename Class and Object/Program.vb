
Module Program
    Public Class Orang

        Public nama As String ' field
        Public usia As Integer
        Public agama As String

        Public Sub show() ' procedure

            Console.WriteLine("Nama : {0}", nama)
            Console.WriteLine("Usia : {0}", usia)
            Console.WriteLine("Agama: {0}", agama)

        End Sub

    End Class


    Sub main()

        Dim orang1 As Orang = New Orang()
        orang1.nama = "Yanto"
        orang1.usia = 56
        orang1.agama = "Islam Ortodoks"

        orang1.show()


        Dim orang2 As Orang = New Orang()
        orang2.nama = "BigChunggus"
        orang2.usia = 12
        orang2.agama = "Sinkretisme"

        orang2.show()



    End Sub


End Module
