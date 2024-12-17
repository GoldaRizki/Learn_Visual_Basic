
Module GleSingle
    Sub Main()

        ' Type Single adalah seperti float kalau di bahasa lain
        ' Besarnya adalah 4 Byte

        Dim desimal1 As Single = 1.12
        Dim desimal2 As Single = 0.08
        Dim totalDesimal As Single

        totalDesimal = desimal1 + desimal2

        Console.WriteLine("Angka 1 adalah : {0}", desimal1)
        Console.WriteLine("Angka 2 adalah : {0}", desimal2)
        Console.WriteLine("Totalnya adalah : {0}", totalDesimal)
        Console.ReadKey()

    End Sub
End Module
