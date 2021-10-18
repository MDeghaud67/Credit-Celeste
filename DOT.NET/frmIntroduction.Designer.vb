<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroduction
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboCidt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.cboVdr = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_Enr = New System.Windows.Forms.Button()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc5 = New System.Windows.Forms.RadioButton()
        Me.gpbAge = New System.Windows.Forms.Label()
        Me.txtNouveauVehicule = New System.Windows.Forms.TextBox()
        Me.txtAncienVehicule = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdVoiture = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmd_Client = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNomJF = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodePostal = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtProfession = New System.Windows.Forms.TextBox()
        Me.txtRevenuAnnuel = New System.Windows.Forms.TextBox()
        Me.txtDateNaiss = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.CreditCelesteDataSet = New CreditCeleste.creditCelesteDataSet()
        Me.CLIENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTTableAdapter = New CreditCeleste.creditCelesteDataSetTableAdapters.CLIENTTableAdapter()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Je m'appelle"
        '
        'CboCidt
        '
        Me.CboCidt.FormattingEnabled = True
        Me.CboCidt.Items.AddRange(New Object() {"Monsieur", "Madame", "Autre"})
        Me.CboCidt.Location = New System.Drawing.Point(89, 45)
        Me.CboCidt.Name = "CboCidt"
        Me.CboCidt.Size = New System.Drawing.Size(121, 21)
        Me.CboCidt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Prenom"
        '
        'txtNom
        '
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource1, "nom", True))
        Me.txtNom.Location = New System.Drawing.Point(89, 96)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 4
        '
        'CLIENTBindingSource
        '
        Me.CLIENTBindingSource.DataMember = "CLIENT"
        '
        'txtPrenom
        '
        Me.txtPrenom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource1, "prenom", True))
        Me.txtPrenom.Location = New System.Drawing.Point(89, 198)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrenom.TabIndex = 5
        '
        'cboVdr
        '
        Me.cboVdr.FormattingEnabled = True
        Me.cboVdr.Location = New System.Drawing.Point(89, 249)
        Me.cboVdr.Name = "cboVdr"
        Me.cboVdr.Size = New System.Drawing.Size(121, 21)
        Me.cboVdr.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Vendeur"
        '
        'cmd_Enr
        '
        Me.cmd_Enr.Location = New System.Drawing.Point(89, 392)
        Me.cmd_Enr.Name = "cmd_Enr"
        Me.cmd_Enr.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Enr.TabIndex = 8
        Me.cmd_Enr.Text = "Enregistrer"
        Me.cmd_Enr.UseVisualStyleBackColor = True
        '
        'rdbNeuf
        '
        Me.rdbNeuf.AutoSize = True
        Me.rdbNeuf.Location = New System.Drawing.Point(436, 261)
        Me.rdbNeuf.Name = "rdbNeuf"
        Me.rdbNeuf.Size = New System.Drawing.Size(48, 17)
        Me.rdbNeuf.TabIndex = 9
        Me.rdbNeuf.TabStop = True
        Me.rdbNeuf.Text = "Neuf"
        Me.rdbNeuf.UseVisualStyleBackColor = True
        '
        'rdbOcc3
        '
        Me.rdbOcc3.AutoSize = True
        Me.rdbOcc3.Location = New System.Drawing.Point(436, 284)
        Me.rdbOcc3.Name = "rdbOcc3"
        Me.rdbOcc3.Size = New System.Drawing.Size(114, 17)
        Me.rdbOcc3.TabIndex = 10
        Me.rdbOcc3.TabStop = True
        Me.rdbOcc3.Text = "Occasion de 3 ans"
        Me.rdbOcc3.UseVisualStyleBackColor = True
        '
        'rdbOcc3a5
        '
        Me.rdbOcc3a5.AutoSize = True
        Me.rdbOcc3a5.Location = New System.Drawing.Point(436, 307)
        Me.rdbOcc3a5.Name = "rdbOcc3a5"
        Me.rdbOcc3a5.Size = New System.Drawing.Size(132, 17)
        Me.rdbOcc3a5.TabIndex = 11
        Me.rdbOcc3a5.TabStop = True
        Me.rdbOcc3a5.Text = "Occasion de 3 à 5 ans"
        Me.rdbOcc3a5.UseVisualStyleBackColor = True
        '
        'rdbOcc5
        '
        Me.rdbOcc5.AutoSize = True
        Me.rdbOcc5.Location = New System.Drawing.Point(436, 330)
        Me.rdbOcc5.Name = "rdbOcc5"
        Me.rdbOcc5.Size = New System.Drawing.Size(135, 17)
        Me.rdbOcc5.TabIndex = 12
        Me.rdbOcc5.TabStop = True
        Me.rdbOcc5.Text = "Occasion de 5 ans et +"
        Me.rdbOcc5.UseVisualStyleBackColor = True
        '
        'gpbAge
        '
        Me.gpbAge.AutoSize = True
        Me.gpbAge.Location = New System.Drawing.Point(444, 222)
        Me.gpbAge.Name = "gpbAge"
        Me.gpbAge.Size = New System.Drawing.Size(90, 13)
        Me.gpbAge.TabIndex = 13
        Me.gpbAge.Text = "Age du véhicule :"
        '
        'txtNouveauVehicule
        '
        Me.txtNouveauVehicule.Location = New System.Drawing.Point(544, 151)
        Me.txtNouveauVehicule.Name = "txtNouveauVehicule"
        Me.txtNouveauVehicule.Size = New System.Drawing.Size(100, 20)
        Me.txtNouveauVehicule.TabIndex = 14
        '
        'txtAncienVehicule
        '
        Me.txtAncienVehicule.Location = New System.Drawing.Point(544, 83)
        Me.txtAncienVehicule.Name = "txtAncienVehicule"
        Me.txtAncienVehicule.Size = New System.Drawing.Size(100, 20)
        Me.txtAncienVehicule.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(541, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nom de l'ancien véhicule"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(541, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nom du nouveau véhicule"
        '
        'cmdVoiture
        '
        Me.cmdVoiture.Location = New System.Drawing.Point(198, 392)
        Me.cmdVoiture.Name = "cmdVoiture"
        Me.cmdVoiture.Size = New System.Drawing.Size(75, 23)
        Me.cmdVoiture.TabIndex = 18
        Me.cmdVoiture.Text = "Voiture"
        Me.cmdVoiture.UseVisualStyleBackColor = True
        '
        'cmdCredit
        '
        Me.cmdCredit.Location = New System.Drawing.Point(319, 392)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 19
        Me.cmdCredit.Text = "Credit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(643, 391)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Plus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmd_Client
        '
        Me.cmd_Client.Location = New System.Drawing.Point(448, 391)
        Me.cmd_Client.Name = "cmd_Client"
        Me.cmd_Client.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Client.TabIndex = 21
        Me.cmd_Client.Text = "Client"
        Me.cmd_Client.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(86, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "nom de jeune fille"
        '
        'txtNomJF
        '
        Me.txtNomJF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource, "nomJeuneFille", True))
        Me.txtNomJF.Location = New System.Drawing.Point(89, 147)
        Me.txtNomJF.Name = "txtNomJF"
        Me.txtNomJF.Size = New System.Drawing.Size(100, 20)
        Me.txtNomJF.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(265, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "code postal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(89, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "adresse"
        '
        'txtCodePostal
        '
        Me.txtCodePostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource1, "codePostal", True))
        Me.txtCodePostal.Location = New System.Drawing.Point(262, 43)
        Me.txtCodePostal.Name = "txtCodePostal"
        Me.txtCodePostal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodePostal.TabIndex = 30
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(89, 307)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(100, 20)
        Me.txtAdresse.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(262, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "profession"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(262, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "revenu annuel"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(259, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "date de naissance"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(265, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "telephone"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(262, 331)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "ville"
        '
        'txtProfession
        '
        Me.txtProfession.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource1, "profession", True))
        Me.txtProfession.Location = New System.Drawing.Point(262, 287)
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(100, 20)
        Me.txtProfession.TabIndex = 37
        '
        'txtRevenuAnnuel
        '
        Me.txtRevenuAnnuel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource1, "revenu", True))
        Me.txtRevenuAnnuel.Location = New System.Drawing.Point(262, 233)
        Me.txtRevenuAnnuel.Name = "txtRevenuAnnuel"
        Me.txtRevenuAnnuel.Size = New System.Drawing.Size(100, 20)
        Me.txtRevenuAnnuel.TabIndex = 36
        '
        'txtDateNaiss
        '
        Me.txtDateNaiss.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource1, "dateNaissance", True))
        Me.txtDateNaiss.Location = New System.Drawing.Point(262, 155)
        Me.txtDateNaiss.Name = "txtDateNaiss"
        Me.txtDateNaiss.Size = New System.Drawing.Size(100, 20)
        Me.txtDateNaiss.TabIndex = 35
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(262, 90)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 34
        '
        'txtVille
        '
        Me.txtVille.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource1, "ville", True))
        Me.txtVille.Location = New System.Drawing.Point(262, 347)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(100, 20)
        Me.txtVille.TabIndex = 33
        '
        'CreditCelesteDataSet
        '
        Me.CreditCelesteDataSet.DataSetName = "creditCelesteDataSet"
        Me.CreditCelesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTBindingSource1
        '
        Me.CLIENTBindingSource1.DataMember = "CLIENT"
        Me.CLIENTBindingSource1.DataSource = Me.CreditCelesteDataSet
        '
        'CLIENTTableAdapter
        '
        Me.CLIENTTableAdapter.ClearBeforeFill = True
        '
        'frmIntroduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtProfession)
        Me.Controls.Add(Me.txtRevenuAnnuel)
        Me.Controls.Add(Me.txtDateNaiss)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCodePostal)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNomJF)
        Me.Controls.Add(Me.cmd_Client)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdVoiture)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAncienVehicule)
        Me.Controls.Add(Me.txtNouveauVehicule)
        Me.Controls.Add(Me.gpbAge)
        Me.Controls.Add(Me.rdbOcc5)
        Me.Controls.Add(Me.rdbOcc3a5)
        Me.Controls.Add(Me.rdbOcc3)
        Me.Controls.Add(Me.rdbNeuf)
        Me.Controls.Add(Me.cmd_Enr)
        Me.Controls.Add(Me.cboVdr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboCidt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIntroduction"
        Me.Text = "frmIntroduction"
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CboCidt As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents cboVdr As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmd_Enr As Button
    Friend WithEvents rdbNeuf As RadioButton
    Friend WithEvents rdbOcc3 As RadioButton
    Friend WithEvents rdbOcc3a5 As RadioButton
    Friend WithEvents rdbOcc5 As RadioButton
    Friend WithEvents gpbAge As Label
    Friend WithEvents txtNouveauVehicule As TextBox
    Friend WithEvents txtAncienVehicule As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdVoiture As Button
    Friend WithEvents cmdCredit As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cmd_Client As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNomJF As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodePostal As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtProfession As TextBox
    Friend WithEvents txtRevenuAnnuel As TextBox
    Friend WithEvents txtDateNaiss As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents CLIENTBindingSource As BindingSource
    Friend WithEvents CreditCelesteDataSet As creditCelesteDataSet
    Friend WithEvents CLIENTBindingSource1 As BindingSource
    Friend WithEvents CLIENTTableAdapter As creditCelesteDataSetTableAdapters.CLIENTTableAdapter
End Class
