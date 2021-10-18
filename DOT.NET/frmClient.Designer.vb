<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtPrénom = New System.Windows.Forms.TextBox()
        Me.txtCodePostal = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtDateNaiss = New System.Windows.Forms.TextBox()
        Me.txtRevenuAnnuel = New System.Windows.Forms.TextBox()
        Me.txtProfession = New System.Windows.Forms.TextBox()
        Me.txtNomJF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmd_Enregistrer = New System.Windows.Forms.Button()
        Me.cmd_Credit = New System.Windows.Forms.Button()
        Me.cmd_Intro = New System.Windows.Forms.Button()
        Me.cmd_Voiture = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbOTG = New System.Windows.Forms.RadioButton()
        Me.rdbLoc = New System.Windows.Forms.RadioButton()
        Me.rdbProp = New System.Windows.Forms.RadioButton()
        Me.CboCidt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(59, 118)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 5
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(59, 319)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(100, 20)
        Me.txtAdresse.TabIndex = 6
        '
        'txtPrénom
        '
        Me.txtPrénom.Location = New System.Drawing.Point(59, 262)
        Me.txtPrénom.Name = "txtPrénom"
        Me.txtPrénom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrénom.TabIndex = 7
        '
        'txtCodePostal
        '
        Me.txtCodePostal.Location = New System.Drawing.Point(59, 383)
        Me.txtCodePostal.Name = "txtCodePostal"
        Me.txtCodePostal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodePostal.TabIndex = 8
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(293, 339)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(100, 20)
        Me.txtVille.TabIndex = 9
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(293, 55)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 10
        '
        'txtDateNaiss
        '
        Me.txtDateNaiss.Location = New System.Drawing.Point(293, 130)
        Me.txtDateNaiss.Name = "txtDateNaiss"
        Me.txtDateNaiss.Size = New System.Drawing.Size(100, 20)
        Me.txtDateNaiss.TabIndex = 11
        '
        'txtRevenuAnnuel
        '
        Me.txtRevenuAnnuel.Location = New System.Drawing.Point(293, 204)
        Me.txtRevenuAnnuel.Name = "txtRevenuAnnuel"
        Me.txtRevenuAnnuel.Size = New System.Drawing.Size(100, 20)
        Me.txtRevenuAnnuel.TabIndex = 12
        '
        'txtProfession
        '
        Me.txtProfession.Location = New System.Drawing.Point(293, 279)
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(100, 20)
        Me.txtProfession.TabIndex = 13
        '
        'txtNomJF
        '
        Me.txtNomJF.Location = New System.Drawing.Point(59, 185)
        Me.txtNomJF.Name = "txtNomJF"
        Me.txtNomJF.Size = New System.Drawing.Size(100, 20)
        Me.txtNomJF.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "prénom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "adresse"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "code postal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "ville"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(293, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "telephone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(293, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "date de naissance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(293, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "revenu annuel"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(293, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "profession"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(59, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "nom de jeune fille"
        '
        'cmd_Enregistrer
        '
        Me.cmd_Enregistrer.Location = New System.Drawing.Point(293, 398)
        Me.cmd_Enregistrer.Name = "cmd_Enregistrer"
        Me.cmd_Enregistrer.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Enregistrer.TabIndex = 27
        Me.cmd_Enregistrer.Text = "Enregistrer"
        Me.cmd_Enregistrer.UseVisualStyleBackColor = True
        '
        'cmd_Credit
        '
        Me.cmd_Credit.Location = New System.Drawing.Point(433, 398)
        Me.cmd_Credit.Name = "cmd_Credit"
        Me.cmd_Credit.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Credit.TabIndex = 28
        Me.cmd_Credit.Text = "Credit"
        Me.cmd_Credit.UseVisualStyleBackColor = True
        '
        'cmd_Intro
        '
        Me.cmd_Intro.Location = New System.Drawing.Point(567, 398)
        Me.cmd_Intro.Name = "cmd_Intro"
        Me.cmd_Intro.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Intro.TabIndex = 29
        Me.cmd_Intro.Text = "Introduction"
        Me.cmd_Intro.UseVisualStyleBackColor = True
        '
        'cmd_Voiture
        '
        Me.cmd_Voiture.Location = New System.Drawing.Point(692, 398)
        Me.cmd_Voiture.Name = "cmd_Voiture"
        Me.cmd_Voiture.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Voiture.TabIndex = 30
        Me.cmd_Voiture.Text = "Voiture"
        Me.cmd_Voiture.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbOTG)
        Me.GroupBox1.Controls.Add(Me.rdbLoc)
        Me.GroupBox1.Controls.Add(Me.rdbProp)
        Me.GroupBox1.Location = New System.Drawing.Point(530, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 195)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Situation patrimoniale du client"
        '
        'rdbOTG
        '
        Me.rdbOTG.AutoSize = True
        Me.rdbOTG.Location = New System.Drawing.Point(37, 110)
        Me.rdbOTG.Name = "rdbOTG"
        Me.rdbOTG.Size = New System.Drawing.Size(131, 17)
        Me.rdbOTG.TabIndex = 2
        Me.rdbOTG.TabStop = True
        Me.rdbOTG.Text = "occupant à titre gratuit"
        Me.rdbOTG.UseVisualStyleBackColor = True
        '
        'rdbLoc
        '
        Me.rdbLoc.AutoSize = True
        Me.rdbLoc.Location = New System.Drawing.Point(37, 66)
        Me.rdbLoc.Name = "rdbLoc"
        Me.rdbLoc.Size = New System.Drawing.Size(65, 17)
        Me.rdbLoc.TabIndex = 1
        Me.rdbLoc.TabStop = True
        Me.rdbLoc.Text = "locataire"
        Me.rdbLoc.UseVisualStyleBackColor = True
        '
        'rdbProp
        '
        Me.rdbProp.AutoSize = True
        Me.rdbProp.Location = New System.Drawing.Point(37, 31)
        Me.rdbProp.Name = "rdbProp"
        Me.rdbProp.Size = New System.Drawing.Size(77, 17)
        Me.rdbProp.TabIndex = 0
        Me.rdbProp.TabStop = True
        Me.rdbProp.Text = "propriétaire"
        Me.rdbProp.UseVisualStyleBackColor = True
        '
        'CboCidt
        '
        Me.CboCidt.FormattingEnabled = True
        Me.CboCidt.Items.AddRange(New Object() {"Monsieur", "Madame", "Autre"})
        Me.CboCidt.Location = New System.Drawing.Point(59, 54)
        Me.CboCidt.Name = "CboCidt"
        Me.CboCidt.Size = New System.Drawing.Size(121, 21)
        Me.CboCidt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Je m'appelle"
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CboCidt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_Voiture)
        Me.Controls.Add(Me.cmd_Intro)
        Me.Controls.Add(Me.cmd_Credit)
        Me.Controls.Add(Me.cmd_Enregistrer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomJF)
        Me.Controls.Add(Me.txtProfession)
        Me.Controls.Add(Me.txtRevenuAnnuel)
        Me.Controls.Add(Me.txtDateNaiss)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.txtCodePostal)
        Me.Controls.Add(Me.txtPrénom)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtNom)
        Me.Name = "frmClient"
        Me.Text = "frmClient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtPrénom As TextBox
    Friend WithEvents txtCodePostal As TextBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtDateNaiss As TextBox
    Friend WithEvents txtRevenuAnnuel As TextBox
    Friend WithEvents txtProfession As TextBox
    Friend WithEvents txtNomJF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmd_Enregistrer As Button
    Friend WithEvents cmd_Credit As Button
    Friend WithEvents cmd_Intro As Button
    Friend WithEvents cmd_Voiture As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbOTG As RadioButton
    Friend WithEvents rdbLoc As RadioButton
    Friend WithEvents rdbProp As RadioButton
    Friend WithEvents CboCidt As ComboBox
    Friend WithEvents Label1 As Label
End Class
