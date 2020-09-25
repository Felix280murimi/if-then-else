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
        Me.btnDayOfTheWeek = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDayOfTheWeek
        '
        Me.btnDayOfTheWeek.Location = New System.Drawing.Point(350, 370)
        Me.btnDayOfTheWeek.Name = "btnDayOfTheWeek"
        Me.btnDayOfTheWeek.Size = New System.Drawing.Size(259, 23)
        Me.btnDayOfTheWeek.TabIndex = 0
        Me.btnDayOfTheWeek.Text = "siku Gani Hii?"
        Me.btnDayOfTheWeek.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDayOfTheWeek)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDayOfTheWeek As Button
End Class
