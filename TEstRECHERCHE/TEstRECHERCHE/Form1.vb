Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class Form1
    Dim Niveau As String = "2SQ"
    Dim sql As String = ""
    Dim con As New OleDbConnection("provider=Microsoft.jet.oledb.4.0;Data source =D:\mo projjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj\TEstRECHERCHE\TEstRECHERCHE\bin\Debug\Affectation.mdb")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim Tableaff As New DataTable
    Dim TableEtudiants As New DataTable







    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Remplir la liste box avec les modules 
        con.Open()
        Listmodule.Items.Clear()
        sql = $"select MODULES.Code_Mat from MODULES WHERE (Niveau = '{Niveau}');"
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        While dr.Read
            Listmodule.Items.Add(dr("Code_Mat").ToString())
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Rechercher_Click(sender As Object, e As EventArgs) Handles Rechercher.Click
        If Matricule.Text = Nothing Then
            MsgBox("Vous devez donner le matricule", MsgBoxStyle.Exclamation, "Verification")
            Exit Sub
        End If
        If Listmodule.Text = Nothing Then
            con.Open()
            sql = $"SELECT Matricule,NomEtud,Prenoms,Promo,Gr from ETUDIANTS where (Matricule = '{Matricule.Text}'   AND Promo = '{Niveau}')"
            TableEtudiants = QueryAsDataTable(sql)
            If TableEtudiants.Rows.Count = 0 Then

                MsgBox("le matricule  existe pas !", MsgBoxStyle.Exclamation, "Verification")
                Me.Matricule.Text = ""
                Exit Sub

            ElseIf TableEtudiants.Rows.Count <> 0 Then

                sql = $"select Num_Table,Code_Sal from Post_Affectation where (Matricule ='{Matricule.Text}')"
                Tableaff = QueryAsDataTable(sql)
                If Tableaff.Rows.Count = 0 Then
                    MsgBox("le matricule  n'est pas encore ete  afecter  !", MsgBoxStyle.Exclamation, "Verification")
                    Exit Sub

                ElseIf Tableaff.Rows.Count <> 0 Then

                    Dim Form2 As New Form3(TableEtudiants.Rows(0).Item("NomEtud"), TableEtudiants.Rows(0).Item("Prenoms"), TableEtudiants.Rows(0).Item("Promo"), TableEtudiants.Rows(0).Item("Gr"))


                    sql = $"SELECT Post_Affectation.Code_Mat,Post_Affectation.Code_Sal,Post_Affectation.Num_Table from  Post_Affectation  where(Post_Affectation.Matricule='{Matricule.Text}')"
                    Tableaff = QueryAsDataTable(sql)
                    Form2.DataGridView1.ReadOnly = False
                    Form2.DataGridView1.DataSource = Tableaff
                    Form2.DataGridView1.ReadOnly = True

                    Form2.ShowDialog()

                    con.Close()

                End If
            End If





        Else
            sql = $"SELECT Matricule,NomEtud,Prenoms from ETUDIANTS where (Matricule = '{Matricule.Text}'AND  Promo = '{Niveau}')"
            TableEtudiants = QueryAsDataTable(sql)
            If TableEtudiants.Rows.Count = 0 Then

                MsgBox("le matricule  existe pas !", MsgBoxStyle.Exclamation, "Verification")
                Exit Sub

            ElseIf TableEtudiants.Rows.Count <> 0 Then
                sql = $"SELECT Matricule from INSCRITMODULE where (Matricule = '{Matricule.Text}' AND Code_Mat='{Listmodule.Text}' AND  Promo = '{Niveau}')"
                TableEtudiants = QueryAsDataTable(sql)
                If TableEtudiants.Rows.Count = 0 Then

                    MsgBox("le matricule n'est pas inscrit dans ce module !", MsgBoxStyle.Exclamation, "Verification")
                    Exit Sub
                ElseIf TableEtudiants.Rows.Count <> 0 Then
                    sql = $"select Num_Table,Code_Sal from Post_Affectation where (Matricule ='{Matricule.Text}'AND Code_Mat='{Listmodule.Text}');"
                    Tableaff = QueryAsDataTable(sql)
                    If Tableaff.Rows.Count = 0 Then
                        MsgBox("le matricule  n'est pas encore afecter  !", MsgBoxStyle.Exclamation, "Verification")
                        Exit Sub

                    ElseIf Tableaff.Rows.Count <> 0 Then
                        sql = $"SELECT NomEtud,Prenoms from ETUDIANTS where (Matricule = '{Matricule.Text}')"
                        TableEtudiants = QueryAsDataTable(sql)
                        Dim rechform As New AFFICHERECH(TableEtudiants.Rows(0).Item("NomEtud"), TableEtudiants.Rows(0).Item("Prenoms"), Tableaff.Rows(0).Item("Code_Sal"), Tableaff.Rows(0).Item("Num_Table"))
                        rechform.ShowDialog()
                    End If
                End If

            End If
        End If
        con.Close()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
