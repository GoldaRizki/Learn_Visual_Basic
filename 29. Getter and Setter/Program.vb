Imports System

Module Program

    Class Mantan

        Private nama_mantan As String

        Public Property Nama As String
            Get
                Return Me.nama_mantan
            End Get
            Set(value As String)
                Me.nama_mantan = value.ToUpper()
            End Set
        End Property


    End Class

    Sub Main(args As String())

        Dim a As Mantan = New Mantan()

        a.Nama = "wotif"
        Console.WriteLine(a.Nama)


    End Sub
End Module
