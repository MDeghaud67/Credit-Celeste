Public Class Vendeur
    Private monIdtVendeur As String
    Private monNomVendeur As String
    Private monPrenomVendeur As String

    'les constructeurs

    Sub New()

    End Sub

    Sub New(ByVal idtVendeur As String, ByVal prenomVendeur As String, ByVal nomVendeur As String)
        monIdtVendeur = idtVendeur
        monNomVendeur = nomVendeur
        monPrenomVendeur = prenomVendeur
    End Sub

    Public Function getInfoVendeur() As String

        Return monIdtVendeur + " " + monNomVendeur + " " + monPrenomVendeur

    End Function

End Class
