Imports System


Module Program

    Friend mmm As String = "YNTKLSA"
    Public Class Sembarang

        Private a As String
        Public b As String
        Protected c As String
        Friend d As String = "Makan Bang" 'aksesibel di dalam sesama assembly


    End Class

    Sub main()

        Dim p As Sembarang = New Sembarang

        Dim rr As String = p.d
        Console.WriteLine(rr)

        coba()

        Console.WriteLine(jajal)

    End Sub

End Module
