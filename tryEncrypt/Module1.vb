Module Module1
    '   Title:          tryEncrypt
    '   Author:         Abdullah Bhutta
    '   Version:        0.1
    '   Date:           24/11/2026
    '   Description:    To encrypt 
    Sub Main()
        Dim str As String = ""
        Dim num As Integer = 0
        Dim encrypted As String = ""
        '   Ask for str
        Console.WriteLine("Please enter something")
        str = Console.ReadLine
        Console.WriteLine("Enter an amount to shift by")
        '   Ask for the amount to shift
        num = Console.ReadLine
        '   Display the shifted text
        encrypted = decrypt(str, num)
        Console.WriteLine(encrypted)


    End Sub
    Function encrypt(str As String, num As Integer) As String
        ' Convert the input to uppercase
        str = UCase(str)

        Dim result As String = ""

        num = num Mod 26

        '   Go through the string one character at a time
        For Each letter As Char In str
            '    Only shift letters A through Z.
            If letter >= "A" AndAlso letter <= "Z" Then
                '    Get the letters  code and shift it backward
                Dim code As Integer = Asc(letter) - num

                '    Wrap around if the code goes below A
                If code < Asc("A") Then code = code + 26
                ' Wrap around if the code goes above Z
                If code > Asc("Z") Then code = code - 26

                '    Convert the shifted code back to a character
                letter = Chr(code)
            End If
            result = result & letter
        Next

        ' Return the finished encrypted text
        Return result
    End Function

    Function decrypt(str As String, num As Integer) As String
        ' Convert the input to uppercase
        str = UCase(str)

        ' Start with an empty result
        Dim result As String = ""

        ' Remove full turns through the 26-letter alphabet
        num = num Mod 26

        ' Go through the string one character at a time
        For Each letter As Char In str
            ' Only shift letters A through Z.
            If letter >= "A" AndAlso letter <= "Z" Then
                ' Get the letters numeric code and shift it forward
                Dim code As Integer = Asc(letter) + num

                ' Wrap around if the code goes below A
                If code < Asc("A") Then code = code + 26

                ' Wrap around if the code goes above Z
                If code > Asc("Z") Then code = code - 26

                ' Convert the shifted code back to a character
                letter = Chr(code)
            End If

            result = result & letter
        Next

        ' Return the finished decrypted text.
        Return result
    End Function
End Module
