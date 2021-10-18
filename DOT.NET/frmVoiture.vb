Public Class frmVoiture
    Private Sub cmd_Enregistrer_Click(sender As Object, e As EventArgs) Handles cmd_Enregistrer.Click


        If fenVoit Is Nothing Then
            fenVoit = New frmVoiture ' pour instancier un objet
        ElseIf fenVoit.IsDisposed Then
            fenVoit = New frmVoiture ' pour instancier un objet
        End If

        If fenVoit.txtDatePremImmat.Text Is Nothing Then
            MessageBox.Show("Veillez saisir toutes les informations !")

        ElseIf fenVoit.txtAnnéeModèle.Text Is Nothing Then
            MessageBox.Show("Veillez saisir toutes les informations !")

        ElseIf fenVoit.txtNumImmat.Text Is Nothing Then
            MessageBox.Show("Veillez saisir toutes les informations !")

        ElseIf fenVoit.txtNumSérie.Text Is Nothing Then
            MessageBox.Show("Veillez saisir toutes les informations !")

        ElseIf fenVoit.txtPuissance.Text Is Nothing Then
            MessageBox.Show("Veillez saisir toutes les informations !")

        Else
            VEHICULEBindingSource.EndEdit()
            MessageBox.Show("Vos informations ont bien été enregistrées !")
        End If


    End Sub

    Private Sub cmd_Introduction_Click(sender As Object, e As EventArgs) Handles cmd_Introduction.Click

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
        fenVoit.Close()



        ' fenIntro.ShowDialog() ' montre la fenêtre au format modale 
    End Sub

    Private Sub cmd_Credit_Click(sender As Object, e As EventArgs) Handles cmd_Credit.Click
        Dim frmCredit As Form
        If fenCredit Is Nothing Then
            frmCredit = New frmCredit  ' pour instancier un objet
        End If
        ''''
        fenCredit.Show() ' montre la fenêtre  
        fenCredit.BringToFront()
        fenVoit.Close()
    End Sub

    Private Sub frmVoiture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'CreditCelesteDataSet.VEHICULE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.VEHICULETableAdapter.Fill(Me.CreditCelesteDataSet.VEHICULE)

        txtNumSérie.Text = uneVoiture.getnumSérie
        txtAnnéeModèle.Text = uneVoiture.getAnnéeMod
        txtNumImmat.Text = uneVoiture.getnumImmat
        txtDatePremImmat.Text = uneVoiture.getpremImmat
        txtPuissance.Text = uneVoiture.getPuiss
    End Sub

    Private Sub cmd_Client_Click(sender As Object, e As EventArgs) Handles cmd_Client.Click

        'Dim frmVoiture As Form
        If fenClient Is Nothing Then
            fenClient = New frmClient  ' pour instancier un objet
        End If
        ''''
        fenClient.Show() ' montre la fenêtre  
        fenClient.BringToFront()
        fenVoit.Close()

    End Sub
End Class
