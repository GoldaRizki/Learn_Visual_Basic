
Module LanBoolean
    Sub Main()

        Dim lanang As Boolean = False
        Dim wedok As Boolean = True


        Console.WriteLine("Lanang itu {0}", lanang)
        Console.WriteLine("Wedok itu {0}", wedok)

        Dim gabungan As Boolean = lanang And wedok ' logical operation

        lanang = Not lanang

        Console.WriteLine("Saiki lanang dadi {0}", lanang)
        Console.WriteLine("Nilai variabel gabungan adalah {0}", gabungan)

        Console.ReadKey()

    End Sub
End Module
