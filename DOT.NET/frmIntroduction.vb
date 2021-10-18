Public Class frmIntroduction
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmIntroduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'CreditCelesteDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.CLIENTTableAdapter.Fill(Me.CreditCelesteDataSet.CLIENT)
        'TODO: cette ligne de code charge les données dans la table 'CreditCelesteDataSet2.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'parcourir la collection des vendeurs de la concession
        'pour l'affichage dans la combobox




        For Each xVendeur As Vendeur In uneConcession.lesVendeurs
            cboVdr.Items.Add(xVendeur.getInfoVendeur())
        Next

        txtNouveauVehicule.Text = uneVoiture.getNomVehicule()
        txtAncienVehicule.Text = uneVoiture.getAncienNomVehicule()
        '
        ' gestion de l'age du vehicule
        '
        '' todo md
        '
        ' charger le client, de l'objet vers l'ecran
        '
        txtNom.Text = unClienVoit.getNomClient()
        txtPrenom.Text = unClienVoit.getPrenomClient()
        CboCidt.Text = unClienVoit.getCidtClient()
    End Sub

    Private Sub cmd_Enr_Click(sender As Object, e As EventArgs) Handles cmd_Enr.Click

        ' création possible d'une seule fenêtre d'introduction
        '


        Dim age As String ' on déclare la variable
        '
        '
        ' stockage des données dans les objets
        '
        ' Le client
        ' mettre à jour le code identifiant, le nom et le prénom
        ' 2 possibilités :
        ' soit une méthode
        ' 

        If rdbNeuf.Checked Then
            ' le bouton est coché

            age = rdbNeuf.Text 'on affiche le texte

        ElseIf rdbOcc3.Checked Then
            age = rdbOcc3.Text

        ElseIf rdbOcc3a5.Checked Then
            age = rdbOcc3a5.Text

        Else
            age = rdbOcc5.Text

        End If

        '
        ' 2e méthode

        ' Dim i As Integer
        ' Dim radio As RadioButton

        '  Do While radio.Checked = False And i < gpbAge.Controls.Count
        '
        ' Loop
        '
        '  age = radio.Text

        ' 3ème méthode

        '   For Each radio In gpbAge.Controls
        '

        '  If radio.Checked Then
        ' age = radio.Text
        'End If
        '
        'Next
        '
        ' 4ème méthode
        '
        'For i = 0 To gpbAge.Controls.Count - 1
        '
        'radio = gpbAge.Controls(i) 'cast explicit
        'If gpbAge.Controls(i) Then
        '
        '
        'End If
        'Next
        '
        MsgBox(age)

        CLIENTBindingSource.EndEdit()
        MessageBox.Show("Vos informations ont bien été enregistrées")


    End Sub

    Private Sub cmdVoiture_Click(sender As Object, e As EventArgs) Handles cmdVoiture.Click

        'Dim frmVoiture As Form
        If fenVoit Is Nothing Then
            fenVoit = New frmVoiture  ' pour instancier un objet
        End If
        ''''
        fenVoit.Show() ' montre la fenêtre  
        fenVoit.BringToFront()
        fenIntro.Close()
    End Sub

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click
        ' Dim frmCredit As Form
        If fenCredit Is Nothing Then
            fenCredit = New frmCredit  ' pour instancier un objet
        End If
        ''''
        fenCredit.Show() ' montre la fenêtre  
        fenCredit.BringToFront()
        fenIntro.Close()
    End Sub

    Private Sub cmd_Client_Click(sender As Object, e As EventArgs) Handles cmd_Client.Click

        'Dim frmVoiture As Form
        If fenClient Is Nothing Then
            fenClient = New frmClient  ' pour instancier un objet
        End If
        ''''
        fenClient.Show() ' montre la fenêtre  
        fenClient.BringToFront()
        fenIntro.Close()

    End Sub

    Private Sub CboCidt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCidt.SelectedIndexChanged

    End Sub
End Class


