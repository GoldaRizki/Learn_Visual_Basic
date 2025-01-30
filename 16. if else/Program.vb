

Module pengecekanKondisi

    Sub main()

        Dim benar As Boolean

        benar = True

        If benar = True Then ' logical operation tetap pake sama dengan (=) biasa, gapake double sama dengan (==)
            Console.WriteLine("Kamu benar")
        End If

        'coba minta input angka
        Console.Write("Masukkan angka : ")
        Dim angka As Integer = CInt(Console.ReadLine())

        If angka > 30 And angka < 90 Then

            Console.WriteLine("Angka yang kamu masukkan pas")

        Else

            Console.WriteLine("Angka yang kamu masukkan tidak pas")

        End If

        Console.WriteLine("Apakah kamu islam? [y/n]")
        Dim agama As Char = Console.ReadLine()

        If agama = "y" Or agama = "Y" Then

            Console.WriteLine("Selamat Kamu masuk surga")

        ElseIf agama = "n" Or agama = "N" Then

            Console.WriteLine("Maaf, Kamu masuk neraka")

        Else

            Console.WriteLine("Pilih yang bener!1!1")

        End If



        Console.Write("Masukkan angka lagi dong : ")
        angka = CInt(Console.ReadLine())

        If angka Mod 2 = 0 Then

            Console.WriteLine("Bilangan Genap")

        Else

            Console.WriteLine("Bilangan Ganjil")

        End If

    End Sub


End Module