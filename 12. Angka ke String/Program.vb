
Module AngkaKeString
    Sub Main()

        Dim angka As Single
        Dim hasil As String

        angka = 23
        angka = angka + 6.24

        hasil = CStr(angka) ' Cara casting ke dalam string, pokok e expression teko lebokke function kuwi

        Console.WriteLine("Hello World!")
        Console.WriteLine("Hasile adalah " + hasil)
    End Sub
End Module
