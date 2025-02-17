Imports System

Module Program

    Class Orang

        Sub bentuk()
            Console.WriteLine("Orang")
        End Sub

    End Class

    Class Konservatif
        Inherits Orang

        Sub behavior()

            Console.WriteLine("Konservatif")

        End Sub

    End Class


    Class Wotif
        Inherits Konservatif

        Public wota As Boolean = True


    End Class


    Sub Main(args As String())

        Dim w As Wotif = New Wotif()
        Console.WriteLine(w.wota)

        w.bentuk()
        w.behavior()



    End Sub
End Module
