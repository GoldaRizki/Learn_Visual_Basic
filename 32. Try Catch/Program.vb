Imports System

Module Program
    Sub Main(args As String())

        Dim i As Integer

        Dim pilih As Boolean = True

        While (pilih)

            Try
                i = CInt(Console.ReadLine())
            Catch
                pilih = False
            End Try


        End While

    End Sub
End Module
