
Module switch_case

    Sub main()

        Dim nomor As Integer
        Dim hari As String
        Dim huruf As String


        Console.Write("Masukan angka: ")
        nomor = CInt(Console.ReadLine())


        '
        ' Cara membuat "Switch Case" dalam visual basic
        ' Dalam visual basic, keywords yang dipakai adalah
        ' Select ... Case ...
        '

        Select Case nomor

            Case 1
                hari = "senin"
            Case 2
                hari = "selasa"
            Case 3
                hari = "rabu"
            Case 4
                hari = "kamis"
            Case 5
                hari = "jum'at"
            Case 6
                hari = "sabtu"
            Case 7
                hari = "minggu/ahad"
            Case Else
                hari = "Durung ono isine, isianmu salah po?"

        End Select


        Console.WriteLine("Hari ini hari {0}", hari)


        Console.Write("masukkan huruf: ")
        huruf = Console.ReadLine()

        Select Case huruf
            Case "a", "A"
                Console.WriteLine("Yo")
            Case "b", "B"
                Console.WriteLine("Yoo")
            Case "c", "C"
                Console.WriteLine("Gahh")
            Case Else
                Console.WriteLine("Coba kau pikirkan")
        End Select

    End Sub

End Module