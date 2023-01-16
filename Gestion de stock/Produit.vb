Imports MySql.Data.MySqlClient

Public Class Produit
    Private name As String
    Private idCategory As Integer
    Private idFournisseur As Integer
    Private prix As Integer
    Private stock As Integer
    Private datePeremption As Date

    Sub New()

    End Sub

    Sub New(ByVal name As String, ByVal idCategory As Integer, ByVal idFournisseur As Integer, ByVal prix As Integer, ByVal stock As Integer, ByVal datePeremption As Date)
        Me.name = nom
        Me.idCategory = id_category
        Me.idFournisseur = id_fournisseur
        Me.prix = _prix
        Me.stock = _stock
        Me.datePeremption = date_peremption
    End Sub

    Public Property nom As String
        Set(value As String)
            Me.name = value
        End Set
        Get
            Return Me.name
        End Get
    End Property

    Public Property id_category As Integer
        Set(value As Integer)
            Me.idCategory = value
        End Set
        Get
            Return Me.idCategory
        End Get
    End Property

    Public Property id_fournisseur As Integer
        Set(value As Integer)
            Me.idFournisseur = value
        End Set
        Get
            Return Me.idFournisseur
        End Get
    End Property

    Public Property _prix As Integer
        Set(value As Integer)
            Me.prix = value
        End Set
        Get
            Return Me.prix
        End Get
    End Property

    Public Property _stock As Integer
        Set(value As Integer)
            Me.stock = value
        End Set
        Get
            Return Me.stock
        End Get
    End Property

    Public Property date_peremption As Date
        Set(value As Date)
            Me.datePeremption = value
        End Set
        Get
            Return Me.datePeremption
        End Get
    End Property

    Public Sub presentation()
        Console.WriteLine(nom & " " & prix)
    End Sub

    Public Sub add(ByVal produit As Produit)
        Dim sql = "INSERT INTO products () VALUES ()"
        Dim cmd As MySqlCommand = BaseDeDonnees.GetCommande(sql)
        'cmd.Parameters.AddWithValue("@name", txtbox_nom.Text)
        'cmd.Parameters.AddWithValue("@id_category", txtbox_idCat.Text)
        'cmd.Parameters.AddWithValue("@id_fournisseur", txtbox_idFour.Text)
        'cmd.Parameters.AddWithValue("@prix", txtbox_prix.Text)
        'cmd.Parameters.AddWithValue("@stock", txtbox_stock.Text)
        'cmd.Parameters.AddWithValue("@date_peremption", txtbox_date.Text)

        'Dim rowAffected = cmd.ExecuteNonQuery
        'If rowAffected > 0 Then
        'MsgBox("Nouveau produit ajoute avec succes !")
        'End If
    End Sub

    Public Sub delete(ByVal id As Integer)
        Dim sql = "DELETE FROM products WHERE id="
        'cmd.Parameters.AddWithValue("@name", txtbox_nom.Text)
        Dim cmd As MySqlCommand = BaseDeDonnees.GetCommande(sql)
        Dim rowAffected = cmd.ExecuteNonQuery
        If rowAffected > 0 Then
            MsgBox("Nouveau produit ajoute avec succes !")
        End If
    End Sub

    Public Sub update(ByVal produit As Produit)

    End Sub
End Class
