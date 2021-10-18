Public Class frmCredit
    Private Sub frmCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'CreditCelesteDataSet.CREDIT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.CREDITTableAdapter.Fill(Me.CreditCelesteDataSet.CREDIT)
        'TODO: cette ligne de code charge les données dans la table 'CreditCelesteDataSet.CREDIT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.CREDITTableAdapter.Fill(Me.CreditCelesteDataSet.CREDIT)

        txtMontantFinancé.Text = unCredit.getMontantFinancé
        txtMensualité.Text = unCredit.getMensualite
        txtTauxAnnuel.Text = unCredit.getTaux

    End Sub



    Private Sub cmd_voiture_Click(sender As Object, e As EventArgs) Handles cmd_voiture.Click
        'Dim frmVoiture As Form
        If fenVoit Is Nothing Then
            fenVoit = New frmVoiture  ' pour instancier un objet
        End If
        ''''
        fenVoit.Show() ' montre la fenêtre  
        fenVoit.BringToFront()
        fenVoit.Close()
    End Sub

    Private Sub cmd_introduction_Click(sender As Object, e As EventArgs) Handles cmd_introduction.Click

        ' création d'une seule fenêtre introduction : design pattern ; singleton
        '
        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction ' pour instancier un objet
        ElseIf fenIntro.IsDisposed Then
            fenIntro = New frmIntroduction ' pour instancier un objet
        End If
        ''''
        fenIntro.Show() ' montre la fenêtre  
        fenIntro.BringToFront()
        fenIntro.Close()



        ' fenIntro.ShowDialog() ' montre la fenêtre au format modale 
    End Sub

    Private Sub cbDurée_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDurée.SelectedIndexChanged

        cbDurée.Items.Clear()
        cbDurée.Items.Add("Safety")
        cbDurée.Items.Add("Security")
        cbDurée.Items.Add("Governance")
        cbDurée.Items.Add("Good Music")
        cbDurée.Items.Add("Good Movies")
        cbDurée.Items.Add("Good Books")
        cbDurée.Items.Add("Education")
        cbDurée.Items.Add("Roads")
        cbDurée.Items.Add("Health")
        cbDurée.Items.Add("Food for all")
        cbDurée.Items.Add("Shelter for all")
        cbDurée.Items.Add("Industrialisation")
        cbDurée.Items.Add("Peace")
        cbDurée.Items.Add("Liberty")
        cbDurée.Items.Add("Freedom of Speech")
        cbDurée.Text = "Select from..."



    End Sub

    Private Sub cmd_Client_Click(sender As Object, e As EventArgs) Handles cmd_Client.Click

        'Dim frmVoiture As Form
        If fenClient Is Nothing Then
            fenClient = New frmClient  ' pour instancier un objet
        End If
        ''''
        fenClient.Show() ' montre la fenêtre  
        fenClient.BringToFront()
        fenCredit.Close()

    End Sub

    Private Sub cmd_enregistrer_Click(sender As Object, e As EventArgs) Handles cmd_enregistrer.Click
        CREDITBindingSource.EndEdit()
        MessageBox.Show("Vos informations ont bien été enregistrées")
    End Sub



End Class