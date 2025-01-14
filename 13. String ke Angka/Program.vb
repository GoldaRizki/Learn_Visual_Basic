
Module stringKeAngka

    Sub Main()

        Dim angka As Double
        Dim angka2 As Double
        Dim Inputan As String

        Console.Write("Masukkan angka :")
        Inputan = Console.ReadLine

        angka = CDbl(Inputan)


        Console.WriteLine("Hasilnya adalah : {0}", angka)

        angka2 = angka + 10.1

        Console.WriteLine("Kalau angkanya ditambah dengan 10.1 hasilnya adalah: {0}", angka2)
        Console.ReadKey()

    End Sub

End Module

