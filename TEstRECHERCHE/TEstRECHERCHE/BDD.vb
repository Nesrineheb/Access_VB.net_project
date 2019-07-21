Imports System.Data.OleDb
Module BDD

    Dim con As New OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data source =D:\mo projjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj\TEstRECHERCHE\TEstRECHERCHE\bin\Debug\Affectation.mdb")
    Public Sub connection()
        If con.State = ConnectionState.Closed Then con.Open()
    End Sub

    Public Sub InsertUpdateDelete(ByVal sql As String)
        connection()
        Dim cmd As New OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
    End Sub

    Public Function IsConfirm(ByVal message As String) As Boolean
        Return MessageBox.Show(message, "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Public Function QueryAsDataTable(ByVal sql As String) As DataTable
        Dim da As New OleDbDataAdapter(sql, con)
        Dim ds As New DataSet
        da.Fill(ds, "result")
        Return ds.Tables("result")
    End Function

    Public Function QueryAsDataTable(ByVal cmd As OleDbCommand) As DataTable

        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "result")
        Return ds.Tables("result")
    End Function

End Module


