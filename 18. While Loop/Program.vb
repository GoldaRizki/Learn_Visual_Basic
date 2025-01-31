
Module while_loop

    Sub main()

        Dim lanjut As Boolean
        Dim inputan As String
        Dim p As Integer


        lanjut = True

        While lanjut


            Console.Write("Apakah looping mau lanjut? [y/n]")
            inputan = Console.ReadLine()



            If inputan = "n" Or inputan = "N" Then

                lanjut = False

            ElseIf inputan <> "y" And inputan <> "Y" Then ' <> itu sama dengan != kalau dibahasa lain

                Console.WriteLine()
                Console.WriteLine("Sing bener wae lur")
                Console.WriteLine("Baleni meneh gih")
                Console.WriteLine()

            Else

                p = 0

                While p < 10

                    p += 1
                    Console.WriteLine("Looping ke-{0}", p)

                End While

            End If

        End While





    End Sub


End Module
