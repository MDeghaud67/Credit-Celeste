Imports Credit

Module moduleVariable

    '
    ' déclaration des fenêtres
    '
    Public fenIntro As frmIntroduction
    ' il faut un élément click pour générer l'objet, donc pas de new

    Public fenVoit As frmVoiture

    Public uneConcession As New Concession()

    Public unVendeur As New Vendeur()

    Public unClienVoit As New ClientVoit()

    Public fenCredit As frmCredit

    Public uneVoiture As New Voiture()

    Public unCredit As New Credit.Credit()

    Public fenClient As frmClient

    Public fenAgence As frmAgence

    Public fenSecteur As frmSecteur

    Public fenConcession As frmConcession

    Public fenCollaborateur As frmCollaborateur

    Public leDataSet As creditCelesteDataSet




    'permet de réaliser les requetes très facilement 
    ' I N S T A N C I A T I O N   D E S   T A B L E   A D A P T E R S 
    Public OutilsEchangesTableClient As New creditCelesteDataSetTableAdapters.CLIENTTableAdapter()

    Public OutilsEchangesTableAgence As New creditCelesteDataSetTableAdapters.AGENCETableAdapter()

    Public OutilsEchangesTableConcession As New creditCelesteDataSetTableAdapters.CONCESSIONTableAdapter()

    Public OutilsEchangesTableSecteur As New creditCelesteDataSetTableAdapters.SECTEURTableAdapter()

    Public OutilsEchangesTableCollaborateur As New creditCelesteDataSetTableAdapters.COLLABORATEURTableAdapter()

End Module
