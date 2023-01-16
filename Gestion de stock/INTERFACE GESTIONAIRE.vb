Public Class INTERFACE_GESTIONAIRE
    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub switchpanel(ByVal panel As Form)
        GunaPanel1.Controls.Clear()
        panel.TopLevel = False
        GunaPanel1.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub INTERFACE_GESTIONAIRE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaTextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        switchpanel(GERER_PRODUIT)

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Me.Hide()
        newconnect.Show()

    End Sub

    Private Sub GunaLabel3_Click_1(sender As Object, e As EventArgs) Handles GunaLabel3.Click

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

    End Sub
End Class