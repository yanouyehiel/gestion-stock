Public Class Form1
    Dim produit As New Produit("Yanou", 1, 2, 1500, 5, "2022-10-02")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        produit.nom = "Yanou"
        txt.Text = produit.nom
        produit.presentation()
        produit.add("Yanou", 1, 2, 1500, 5, "2022-10-02")
    End Sub
End Class
