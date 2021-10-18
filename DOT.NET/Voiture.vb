Public Class Voiture

    Private monNomVehicule As String
    Private monAncienVehicule As String
    Private monAgeVehicule As String

    Private date1èreImmatriculation As Date
    Private annéeModèle As Date
    Private numéroImmatriculation As String
    Private numéroSérie As Integer
    Private puissance As Integer


    Sub New()
        ' constructeur vide'
    End Sub

    Sub New(ByVal NomVehicule As String, ByVal AncienVehicule As String, ByVal AgeVehicule As String)

        monNomVehicule = NomVehicule
        monAncienVehicule = AncienVehicule
        monAgeVehicule = AgeVehicule


    End Sub

    Sub New(ByVal premImmat As Date, ByVal AnnéeMod As Date, ByVal numImmat As String, ByVal numSérie As Integer, ByVal Puiss As Integer)
        date1èreImmatriculation = premImmat
        annéeModèle = AnnéeMod
        numéroImmatriculation = numImmat
        numéroSérie = numSérie
        puissance = Puiss
    End Sub

    Public Function getNomVehicule()

        Return monNomVehicule

    End Function
    Public Function getAncienNomVehicule()

        Return monAncienVehicule

    End Function

    Public Function getAgeVehicule()

        Return monAgeVehicule

    End Function

    Public Function getpremImmat()

        Return date1èreImmatriculation

    End Function
    Public Function getAnnéeMod()

        Return annéeModèle

    End Function
    Public Function getnumImmat()

        Return numéroImmatriculation

    End Function
    Public Function getnumSérie()

        Return numéroSérie

    End Function
    Public Function getPuiss()

        Return puissance

    End Function


End Class
