Public Class frmConcession
    Private Sub frmConcession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'CreditCelesteDataSet.CONCESSION'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.CONCESSIONTableAdapter.Fill(Me.CreditCelesteDataSet.CONCESSION)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OutilsEchangesTableConcession.InsertConcession(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
    End Sub
End Class