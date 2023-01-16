<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt = New Guna.UI.WinForms.GunaTextBox()
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.BaseColor = System.Drawing.Color.White
        Me.txt.BorderColor = System.Drawing.Color.Silver
        Me.txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt.FocusedBaseColor = System.Drawing.Color.White
        Me.txt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt.Location = New System.Drawing.Point(265, 243)
        Me.txt.Name = "txt"
        Me.txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt.SelectedText = ""
        Me.txt.Size = New System.Drawing.Size(160, 30)
        Me.txt.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt As Guna.UI.WinForms.GunaTextBox
End Class
