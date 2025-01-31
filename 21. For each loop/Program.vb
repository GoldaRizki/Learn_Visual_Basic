Module for_each

    Sub main()

        ' aku punya array angka

        Dim angka As Integer() = {2, 5, 6, 4, 8, 75, 96, 25, 56}

        Console.WriteLine("Angka yang ada pada array diantaranya: ")

        For Each a As Integer In angka

            Console.Write(" {0}", a)

        Next
        Console.WriteLine()


        ' misal aku punya daftar nama

        Dim nama As String() = {"Yanto", "Yanti", "Budi", "Kimin", "Mulyono"}

        Console.WriteLine("Nama nama orang yg ada di dalam array:")


        For Each n As String In nama

            Console.Write(" {0}", n)

        Next


    End Sub

End Module
