<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.barco_salvavidas = New System.Windows.Forms.PictureBox()
        Me.tmr_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_Sobreviviente = New System.Windows.Forms.Timer(Me.components)
        CType(Me.barco_salvavidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barco_salvavidas
        '
        Me.barco_salvavidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barco_salvavidas.Location = New System.Drawing.Point(357, 386)
        Me.barco_salvavidas.Name = "barco_salvavidas"
        Me.barco_salvavidas.Size = New System.Drawing.Size(50, 50)
        Me.barco_salvavidas.TabIndex = 1
        Me.barco_salvavidas.TabStop = False
        '
        'tmr_Mover
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(764, 561)
        Me.Controls.Add(Me.barco_salvavidas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(780, 600)
        Me.MinimumSize = New System.Drawing.Size(780, 600)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.barco_salvavidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents barco_salvavidas As PictureBox
    Friend WithEvents tmr_Mover As Timer
    Friend WithEvents tmr_Sobreviviente As Timer
End Class
