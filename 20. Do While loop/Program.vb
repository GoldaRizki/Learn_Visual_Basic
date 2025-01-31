Module do_while

    Sub main()


        Console.Write("Masukkan angka: ")
        Dim inputan As Integer = Console.ReadLine()

        Dim p As Integer = 0

        Do
            Console.WriteLine("Looping ke-{0}", p)
            p = p + 1
        Loop While p < inputan

    End Sub

End Module