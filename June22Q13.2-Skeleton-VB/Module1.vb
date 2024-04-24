Module Module1
    ' June 2022 Q13.2 GCSE Code Problem
    Sub Main()
        Dim rnd As New Random
        Dim cards = genHand(rnd)
        Dim gameWon As Boolean = False


    End Sub

    '' This function creates the hand for you.  Don't edit this
    Function genHand(rnd As Random) As Integer()
        Dim handOfCards(99) As Integer
        Dim deck(499) As Integer
        Dim n As Integer = 1
        For i = 0 To 499
            deck(i) = n
            n += 1
            If n > 250 Then
                n = 1
            End If
        Next
        For i = 0 To 99
            Dim num As Integer = rnd.Next(0, 500)
            While deck(num) = -1
                num = rnd.Next(0, 500)
            End While
            handOfCards(i) = deck(num)
        Next
        Array.Sort(handOfCards)
        Return handOfCards
    End Function
End Module
