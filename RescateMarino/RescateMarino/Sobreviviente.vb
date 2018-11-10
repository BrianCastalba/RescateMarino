Imports System.IO
Imports RescateMarino.Additional
Public Class Sobreviviente
    Dim rnd As Random = New Random()
    Dim ventana As Form
    Dim dirx, diry As Integer
    Private location_x As Integer
    Private location_y As Integer
    Dim pic_box As New PictureBox
    Dim mediaFolder As String
    Dim additional_tools As Additional

    Public Sub New(v As Form)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ventana = v
        Me.Size = New Size(50, 50)
        Me.Location = New Point(rnd.Next(50, 680), rnd.Next(50, 500))
        dirx = rnd.Next(-2, 2)
        diry = rnd.Next(-2, 2)
        ventana.Controls.Add(Me)
    End Sub


    Public Sub mover()
        Dim x, y As Integer
        x = Me.Location.X
        y = Me.Location.Y

        If x < 0 Then
            x = 0
            dirx = -dirx
        End If
        If y < 0 Then
            y = 0
            diry = -diry
        End If
        If x > ventana.Width - Me.Width Then
            x = ventana.Width - Me.Width
            dirx = -dirx
        End If
        If y > ventana.Height - Me.Height - 40 Then
            y = ventana.Height - Me.Height - 40
            diry = -diry
        End If

        Me.Location = New Point(x + dirx, y + diry)
    End Sub


End Class

