Imports System

Module Program

    Class Konservatif

        Public Sub behavior()

            Console.WriteLine("Konservatif")

        End Sub

    End Class


    Class Wong
        Inherits Konservatif

        Public wong As Boolean = True

    End Class


    Sub Main()

        Dim a As Wong = New Wong()

        Console.WriteLine("Wong : {0}", a.wong)
        a.behavior()


    End Sub
End Module
