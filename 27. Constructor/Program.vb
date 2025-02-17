

Module kontraktor

    Class mantan

        Private nama As String

        Public Sub New(nama As String)

            Me.nama = nama
            'keyword me itu seperti "this" pada javascript, yaitu merefer pada attribut class itu sendiri...

        End Sub


        Public Sub show()

            Console.WriteLine("Nama mantanmu adalah: " + Me.nama)

        End Sub




    End Class


    Public Sub main()

        Dim m As mantan = New mantan("Yantii")

        m.show()

    End Sub


End Module
