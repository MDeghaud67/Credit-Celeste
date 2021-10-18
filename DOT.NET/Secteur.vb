Public Class Secteur
    Private numSecteur As Integer
    Private nomSecteur As String
    Private unCollaborateur As Collaborateur
    Private monAgence As Agence

    Sub New(ByVal numS, ByVal nomS)
        numS = numSecteur
        nomS = nomSecteur
    End Sub

    Public Function getNumA() As Integer
        Return numSecteur
    End Function

    Public Function getNomA() As String
        Return nomSecteur
    End Function
End Class
