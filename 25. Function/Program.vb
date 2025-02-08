
Module fungsii

    ' Bedanya function dengan sub adalah kalau function ada return valuenya
    ' Kalau ndak dikasih return value, dia akan ngasih return value secara default

    Function kelilingLingkaran(radius As Single) As Single ' gini juga bisa

        Dim keliling As Single
        keliling = 2 * 3.14 * radius
        Return keliling

    End Function


    Function LuasLingkaran(ByVal radius As Single) As Single

        Return 3.14 * radius ^ 2

    End Function

    Sub main()

        Dim l1 As Single = 5
        Dim l2 As Single = 8

        Console.WriteLine("Keliling Lingkaran kalau jari2 nya {0} adalah {1}", l1, kelilingLingkaran(l1))
        Console.WriteLine("Luas Lingkaran kalau jari2 nya {0} adalah {1}", l2, LuasLingkaran(l2))



    End Sub


End Module
