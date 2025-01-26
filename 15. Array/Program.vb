Module CobaArray

    Sub main()

        'ada beberapa cara untuk mendeclare array

        Dim array1 As Integer() = {2, 3, 5, 4, 5, 6, 8}

        Console.WriteLine("Hasil output arraynya adalah {0}", array1(6))


        'atau

        Dim array2(7) As Integer
        array2(0) = 96
        array2(1) = 25
        array2(2) = 89
        array2(3) = 42
        array2(4) = 65
        array2(5) = 87
        array2(6) = 31
        Console.WriteLine("Hasil output arraynya adalah {0}", array2(6))

        ' atau bisa juga 

        Dim array3 As Integer() = New Integer(6) {}
        array3(6) = 555

        Console.WriteLine("Hasil keluaran dari array ke tiga adalah {0}", array3(5))


        'array itu sifatnya konstan, besarannya tidak bisa diubah. (Sama seperti yang ada pada c++)

        'Kalau membutuhkan structure yang bisa diubah2 nilainya, bisa consider untuk memakai dynamic array atau yang lainnya 

    End Sub

End Module