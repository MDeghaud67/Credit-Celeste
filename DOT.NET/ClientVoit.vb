Imports Client ' permet de récupérer le client en c# lien physique

Public Class ClientVoit ' déclaration de la classe
    Inherits Client.Client ' c'est un héritage; en c# : Client

    Private dateNaiss As TextBox
    Private revenuAnnuel As TextBox
    Private profession As TextBox
    Private nomJeuneFille As TextBox
    Private mail As TextBox

    Public Function getDateNaiss()

        Return dateNaiss

    End Function

    Public Function getRevenuAnnuel()

        Return revenuAnnuel

    End Function

    Public Function getProfession()

        Return profession

    End Function

    Public Function getNomJeuneFille()

        Return nomJeuneFille

    End Function

    Public Function getMailClient()

        Return mail

    End Function

    Public Function setDateNaiss(dateNaiss As TextBox)



    End Function

    Public Function setRevenuAnnuel(revenu As TextBox)

        revenuAnnuel = revenu

    End Function

    Public Function setProfession(professionCli As TextBox)

        profession = professionCli

    End Function
    Public Function setNomJeuneFille(nomJF As TextBox)

        nomJeuneFille = nomJF

    End Function

    Public Function setMailClient(mailClient As TextBox)

        mail = mailClient

    End Function

End Class
