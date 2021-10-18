Public Class Collaborateur

    Private numCol As Integer
    Private civCol As Integer
    Private nomCol As Integer
    Private prenomCol As Integer
    Private uneAgence As Agence
    Private lesSecteurs As List(Of Agence)

    Sub New()

    End Sub

    Sub New(ByVal num, ByVal civ, ByVal nom, ByVal prenom)
        num = numCol
        civ = civCol
        nom = nomCol
        prenom = prenomCol
    End Sub

    Public Function getNum() As Integer
        Return numCol
    End Function

    Public Function getCiv() As Integer
        Return civCol
    End Function

    Public Function getNom() As Integer
        Return nomCol
    End Function

    Public Function getPrenom() As Integer
        Return prenomCol
    End Function

End Class
