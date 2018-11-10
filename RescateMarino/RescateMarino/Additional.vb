Public Class Additional

    Public Function TrimStr(str As String, charsToRemove As String)
        If str.EndsWith(charsToRemove) Then
            Return str.Substring(0, str.Length - charsToRemove.Length)
        Else
            Return str
        End If
    End Function

End Class
