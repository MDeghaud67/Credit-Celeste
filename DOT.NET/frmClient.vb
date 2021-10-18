Public Class frmClient
    Private Sub frmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CboCidt.Text = unClienVoit.getCidtClient()
        txtNom.Text = unClienVoit.getNomClient
        txtNomJF.Text = unClienVoit.getNomJeuneFille
        txtPrénom.Text = unClienVoit.getPrenomClient
        txtAdresse.Text = unClienVoit.getAdresseClient
        txtCodePostal.Text = unClienVoit.getCodePostal
        txtTelephone.Text = unClienVoit.getTelClient
        txtDateNaiss.Text = unClienVoit.getDateNaiss
        txtRevenuAnnuel.Text = unClienVoit.getRevenuAnnuel
        txtProfession.Text = unClienVoit.getProfession
        txtVille.Text = unClienVoit.getVilleClient



    End Sub

    Private Sub cmd_Credit_Click(sender As Object, e As EventArgs) Handles cmd_Credit.Click

        'Dim frmVoiture As Form
        If fenCredit Is Nothing Then
            fenCredit = New frmCredit  ' pour instancier un objet
        End If
        ''''
        fenCredit.Show() ' montre la fenêtre  
        fenCredit.BringToFront()
        fenClient.Close()

    End Sub

    Private Sub cmd_Intro_Click(sender As Object, e As EventArgs) Handles cmd_Intro.Click

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
        fenClient.Close()



        ' fenIntro.ShowDialog() ' montre la fenêtre au format modale 

    End Sub

    Private Sub cmd_Voiture_Click(sender As Object, e As EventArgs) Handles cmd_Voiture.Click

        'Dim frmVoiture As Form
        If fenVoit Is Nothing Then
            fenVoit = New frmVoiture  ' pour instancier un objet
        End If
        ''''
        fenVoit.Show() ' montre la fenêtre  
        fenVoit.BringToFront()
        fenClient.Close()

    End Sub

    Private Sub cmd_Enregistrer_Click(sender As Object, e As EventArgs) Handles cmd_Enregistrer.Click

        Dim situation As String ' on déclare la variable
        '
        '
        ' stockage des données dans les objets
        '
        ' Le client
        ' mettre à jour le code identifiant, le nom et le prénom
        ' 2 possibilités :
        ' soit une méthode
        ' 

        If rdbProp.Checked Then
            ' le bouton est coché

            situation = rdbProp.Text 'on affiche le texte

        ElseIf rdbLoc.Checked Then
            situation = rdbLoc.Text

        Else
            situation = rdbOTG.Text

        End If

        MsgBox(situation)

       '' unClienVoit.setCidtClient(CboCidt)
       '' unClienVoit.setNomClient(txtNom)
       '' unClienVoit.setPrenomClient(txtPrénom)

      ''  unClienVoit.setAdresseClient(txtAdresse)
      ''  unClienVoit.setCodePostal(txtCodePostal)
       '' unClienVoit.setVilleClient(txtVille)
       '' unClienVoit.setTelClient(txtTelephone)

        unClienVoit.setDateNaiss(txtDateNaiss)
        unClienVoit.setRevenuAnnuel(txtRevenuAnnuel)
        unClienVoit.setProfession(txtProfession)
        unClienVoit.setNomJeuneFille(txtNomJF)

    End Sub
End Class