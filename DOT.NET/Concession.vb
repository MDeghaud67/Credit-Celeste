Public Class Concession

    Private monNomConcession As String
    Private monAdresseConcession As String

    Public lesVendeurs As New List(Of Vendeur) ' collection de vendeur

    '
    ' constructeur vide
    ' 
    ' en c#, java : c'est le nom de la classe Concession
    ' 
    Sub New()
        '
        ' constructeur vide
        '
    End Sub
    '
    ' constructeur nom et adresse
    ' 
    Sub New(ByVal nomConcession As String, ByVal adresseConcession As String)
        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession

    End Sub

    Sub setConcession(ByVal nomConcession As String, ByVal adresseConcession As String)

    End Sub

End Class