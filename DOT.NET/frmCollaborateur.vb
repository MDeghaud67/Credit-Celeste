Public Class frmCollaborateur
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        On Error GoTo saveErr
        COLLABORATEURBindingSource.EndEdit()
        COLLABORATEURTableAdapter.Update(CreditCelesteDataSet.COLLABORATEUR)
        'OutilsEchangesTableCollaborateur.InsertCollab(21, "azert", "azert", "zerty", 777, 999)
        'Me.COLLABORATEURTableAdapter.Fill(Me.CreditCelesteDataSet.COLLABORATEUR)
        MessageBox.Show("Vos information ont bien été enregistrées")
saveErr:
        Exit Sub
    End Sub

    Private Sub frmCollaborateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'CreditCelesteDataSet.COLLABORATEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.COLLABORATEURTableAdapter.Fill(Me.CreditCelesteDataSet.COLLABORATEUR)




        'OutilsEchangesTableCollaborateur.InsertCollab(TextBox2.Text, TextBox3.Text, )





    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        COLLABORATEURBindingSource.AddNew()
    End Sub
End Class