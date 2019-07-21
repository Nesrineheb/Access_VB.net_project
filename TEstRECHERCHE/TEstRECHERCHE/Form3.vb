Public Class Form3
    Sub New(nom_etud As String, prenom_etud As String, Promo As String, Gr As String)
        InitializeComponent()
        Me.nom_etud.Text = nom_etud
        Me.prenom_etud.Text = prenom_etud

        Me.Promo.Text = Promo
        Me.Groupe.Text = Gr
    End Sub
End Class