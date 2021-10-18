Public Class frmAccueil
    Private Sub cmdIntroduction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdIntroduction.Click

        '''''
        ' Dim fenIntro As Form
        ''''
        ' Dim fenIntro2 As Form, création possible de deux objets
        ''''
        ' affichage de la fenêtre d'introduction
        ''''
        ' frmIntroduction.Show()    ok fonctionne mais c'est une classe !!! 
        ''''
        ' création possible d'une seul fenêtre introduction : design pattern ; singleton
        ''''
        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction  ' pour instancier un objet
        End If
        ''''
        fenIntro.Show() ' montre la fenêtre  
        fenIntro.BringToFront()
        Me.Close()
        ' fenIntro.Show()
        ''''
        ' fenIntro2 = New frmIntroduction  ' pour instancier un objet
        ''''
        ' fenIntro2.Show()
        ''''



    End Sub

    Private Sub frmAccueil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        'creation d'une concession
        '
        ' Dim uneConcession As New Concession()
        'ne pas déclarer ici, locale à la procédure

        '
        '1ère solution

        'uneConcession = New Concession()
        'uneConcession = New Concession("Garage des muguets", "65,rue des pieds")

        '
        '2ème solution
        '
        uneConcession = New Concession("Garage des muguets", "65,rue des pieds")

        '
        'creation du vendeur
        '
        unVendeur = New Vendeur("M.", "Kreyder", "Armand")
        '
        'rajouter le vendeur dans la concession
        '
        uneConcession.lesVendeurs.Add(unVendeur)
        '
        '
        '
        Dim un2èmeVendeur As New Vendeur("M.", "Dubois", "Paul")
        Dim un3èmeVendeur As New Vendeur("Mme.", "Duran", "Stephanie")

        '
        uneConcession.lesVendeurs.Add(un2èmeVendeur)
        uneConcession.lesVendeurs.Add(un3èmeVendeur)

    End Sub

    Private Sub cmdEtude_Click(sender As Object, e As EventArgs) Handles cmdEtude.Click

    End Sub

    Private Sub BTN_Agence_Click(sender As Object, e As EventArgs) Handles BTN_Agence.Click
        If fenAgence Is Nothing Then
            fenAgence = New frmAgence  ' pour instancier un objet
        End If
        ''''
        fenAgence.Show() ' montre la fenêtre  
        fenAgence.BringToFront()

    End Sub

    Private Sub BTN_Secteur_Click(sender As Object, e As EventArgs) Handles BTN_Secteur.Click
        If fenSecteur Is Nothing Then
            fenSecteur = New frmSecteur  ' pour instancier un objet
        End If
        ''''
        fenSecteur.Show() ' montre la fenêtre  
        fenSecteur.BringToFront()
    End Sub

    Private Sub BTN_Concession_Click(sender As Object, e As EventArgs) Handles BTN_Concession.Click
        If fenConcession Is Nothing Then
            fenConcession = New frmConcession  ' pour instancier un objet
        End If
        ''''
        fenConcession.Show() ' montre la fenêtre  
        fenConcession.BringToFront()
    End Sub

    Private Sub BTN_Collabo_Click(sender As Object, e As EventArgs) Handles BTN_Collabo.Click
        If fenCollaborateur Is Nothing Then
            fenCollaborateur = New frmCollaborateur  ' pour instancier un objet
        End If
        ''''
        fenCollaborateur.Show() ' montre la fenêtre  
        fenCollaborateur.BringToFront()
    End Sub
End Class


