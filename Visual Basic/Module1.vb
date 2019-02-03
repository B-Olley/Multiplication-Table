Module Module1

    Sub Main()
        Dim i = 0
        Dim row = 0
        Dim column = 0
        Console.WriteLine("                    Multiplication table")
        Console.WriteLine("")
        Console.Write("      ")
        For i = 1 To 10 Step 1
            Console.Write("{0,5}", i)
        Next
        Console.WriteLine("")
        Console.Write("          ")
        For i = 1 To 9 Step 1
            Console.Write("_____")
        Next
        Console.WriteLine("")
        Console.WriteLine("")
        For row = 1 To 10 Step 1
            Console.Write("{0,5}|", row)
            For column = 1 To 10 Step 1
                Console.Write("{0,5}", row * column)
            Next
            Console.WriteLine(" ")
        Next

        Console.ReadKey()


    End Sub

End Module
