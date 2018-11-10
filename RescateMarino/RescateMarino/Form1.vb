Imports RescateMarino.Sobreviviente

Public Class Form1
    Dim dirX, dirY As Integer
    Dim pic_Planta As PictureBox
    Dim boton As Button
    Dim RandomClass As New Random()
    Dim rnd As Random
    Dim sobrevivientes(9) As Sobreviviente

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dirX = 0
        dirY = 0
        Dim sob As Sobreviviente

        For i = 0 To 9
            sob = New Sobreviviente(Me)
            sobrevivientes(i) = sob
        Next

        tmr_Sobreviviente.Start()
        tmr_Mover.Start()

    End Sub


    Private Sub tmr_Mover_Tick(sender As Object, e As EventArgs) Handles tmr_Mover.Tick
        Dim x, y As Integer
        x = barco_salvavidas.Location.X
        y = barco_salvavidas.Location.Y
        If y < 0 Then
            y = 0
            dirY = -dirY
        End If
        If y > Me.Height - barco_salvavidas.Height - 40 Then
            y = Me.Height - barco_salvavidas.Height - 40
            dirY = -dirY
        End If
        If x < 0 Then
            x = 0
            dirX = -dirX
        End If
        If x > Me.Width - barco_salvavidas.Width - 10 Then
            x = Me.Width - barco_salvavidas.Width - 10
            dirX = -dirX
        End If
        barco_salvavidas.Location = New Point(x + dirX, y + dirY)
        rnd = New Random()
        'If barco_salvavidas.Bounds.IntersectsWith(sobreviviente.Bounds) Then
        'tmr_Mover.Stop()
        'sobreviviente.Location = New Point(rnd.Next(0, Me.Width), rnd.Next(0, Me.Height))
        'End If
    End Sub

    Private Sub tmr_Sobreviviente_Tick(sender As Object, e As EventArgs) Handles tmr_Sobreviviente.Tick
        For Each sob As Sobreviviente In sobrevivientes
            sob.mover()
        Next
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                dirY -= 1
            Case Keys.Down
                dirY += 1
            Case Keys.Left
                dirX -= 1
            Case Keys.Right
                dirX += 1
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
