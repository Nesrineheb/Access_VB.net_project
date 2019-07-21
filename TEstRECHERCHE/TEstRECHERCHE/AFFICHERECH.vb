Public Class AFFICHERECH
    Sub New(Nom As String, Prenom As String, Locale As String, num_table As Integer)
        InitializeComponent()
        Me.nom.Text = Nom
        Me.prenom.Text = Prenom

        Me.locale.Text = Locale
        Me.num_table.Text = num_table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub num_table_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub locale_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub prenom_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub nom_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles nom.Click

    End Sub
End Class