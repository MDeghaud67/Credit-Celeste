Public Class frmSecteur
    Private Sub frmSecteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'CreditCelesteDataSet.SECTEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.SECTEURTableAdapter.Fill(Me.CreditCelesteDataSet.SECTEUR)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label0.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OutilsEchangesTableSecteur.InsertSecteur(TextBox2.Text,TextBox1.text)

    End Sub
End Class