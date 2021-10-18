Public Class Agence
    Private numAgence As Integer
    Private nomAgence As String
    Private mesSecteurs As List(Of Secteur)
    Private lesCollaborateurs As List(Of Collaborateur)

    Sub New(ByVal numA, ByVal nomA)
        numA = numAgence
        nomA = nomAgence
    End Sub

    Public Function getNumA() As Integer
        Return numAgence
    End Function

    Public Function getNomA() As String
        Return nomAgence
    End Function

End Class
