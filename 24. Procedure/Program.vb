

Module Program

    Dim angkaSembarang As Integer = 69


    Sub print(ByVal a As String)

        Console.WriteLine(a)

    End Sub

    Sub print2(b As String)

        Console.WriteLine(b)

    End Sub

    Sub gantiAngka(ByRef angka As Integer) ' ByRef artinya parameter langsung ngambil dari alamat memori variable tsb. 

        angka = angka + 1

        Console.WriteLine("Angkanya jadi : {0}", angka)

    End Sub

    Sub Main()

        print("JAngan lupa makan nasi")
        print("Ngoding vb rasa python")

        print2("Gini doang juga bisa")

        Console.WriteLine("Nilai angka sembarang sebelum masuk procedure: {0}", angkaSembarang)
        gantiAngka(angkaSembarang)
        Console.WriteLine("Sekarang angka sembarang jadi: {0}", angkaSembarang)

    End Sub
End Module
