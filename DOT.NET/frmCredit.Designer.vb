<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCredit
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
        Me.components = New System.ComponentModel.Container()
        Me.txtMensualité = New System.Windows.Forms.TextBox()
        Me.txtTauxAnnuel = New System.Windows.Forms.TextBox()
        Me.txtMontantFinancé = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbDurée = New System.Windows.Forms.ComboBox()
        Me.cmd_Connexion = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmd_introduction = New System.Windows.Forms.Button()
        Me.cmd_enregistrer = New System.Windows.Forms.Button()
        Me.cmd_voiture = New System.Windows.Forms.Button()
        Me.cmd_Client = New System.Windows.Forms.Button()
        Me.CreditCelesteDataSet = New CreditCeleste.creditCelesteDataSet()
        Me.CREDITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CREDITTableAdapter = New CreditCeleste.creditCelesteDataSetTableAdapters.CREDITTableAdapter()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CREDITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMensualité
        '
        Me.txtMensualité.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDITBindingSource, "mensualite", True))
        Me.txtMensualité.Location = New System.Drawing.Point(58, 297)
        Me.txtMensualité.Name = "txtMensualité"
        Me.txtMensualité.Size = New System.Drawing.Size(100, 20)
        Me.txtMensualité.TabIndex = 0
        '
        'txtTauxAnnuel
        '
        Me.txtTauxAnnuel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDITBindingSource, "taux", True))
        Me.txtTauxAnnuel.Location = New System.Drawing.Point(58, 229)
        Me.txtTauxAnnuel.Name = "txtTauxAnnuel"
        Me.txtTauxAnnuel.Size = New System.Drawing.Size(100, 20)
        Me.txtTauxAnnuel.TabIndex = 2
        '
        'txtMontantFinancé
        '
        Me.txtMontantFinancé.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDITBindingSource, "montantFinance", True))
        Me.txtMontantFinancé.Location = New System.Drawing.Point(58, 76)
        Me.txtMontantFinancé.Name = "txtMontantFinancé"
        Me.txtMontantFinancé.Size = New System.Drawing.Size(100, 20)
        Me.txtMontantFinancé.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mensualité"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Durée (mois)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Taux annuel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Montant financé"
        '
        'cbDurée
        '
        Me.cbDurée.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDITBindingSource, "duree", True))
        Me.cbDurée.FormattingEnabled = True
        Me.cbDurée.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbDurée.Location = New System.Drawing.Point(58, 153)
        Me.cbDurée.Name = "cbDurée"
        Me.cbDurée.Size = New System.Drawing.Size(121, 21)
        Me.cbDurée.TabIndex = 8
        '
        'cmd_Connexion
        '
        Me.cmd_Connexion.Location = New System.Drawing.Point(692, 382)
        Me.cmd_Connexion.Name = "cmd_Connexion"
        Me.cmd_Connexion.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Connexion.TabIndex = 9
        Me.cmd_Connexion.Text = "Connexion"
        Me.cmd_Connexion.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(83, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Calcul"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmd_introduction
        '
        Me.cmd_introduction.Location = New System.Drawing.Point(336, 382)
        Me.cmd_introduction.Name = "cmd_introduction"
        Me.cmd_introduction.Size = New System.Drawing.Size(75, 23)
        Me.cmd_introduction.TabIndex = 11
        Me.cmd_introduction.Text = "Introduction"
        Me.cmd_introduction.UseVisualStyleBackColor = True
        '
        'cmd_enregistrer
        '
        Me.cmd_enregistrer.Location = New System.Drawing.Point(210, 382)
        Me.cmd_enregistrer.Name = "cmd_enregistrer"
        Me.cmd_enregistrer.Size = New System.Drawing.Size(75, 23)
        Me.cmd_enregistrer.TabIndex = 12
        Me.cmd_enregistrer.Text = "J'enregistre"
        Me.cmd_enregistrer.UseVisualStyleBackColor = True
        '
        'cmd_voiture
        '
        Me.cmd_voiture.Location = New System.Drawing.Point(454, 382)
        Me.cmd_voiture.Name = "cmd_voiture"
        Me.cmd_voiture.Size = New System.Drawing.Size(75, 23)
        Me.cmd_voiture.TabIndex = 13
        Me.cmd_voiture.Text = "Voiture"
        Me.cmd_voiture.UseVisualStyleBackColor = True
        '
        'cmd_Client
        '
        Me.cmd_Client.Location = New System.Drawing.Point(578, 382)
        Me.cmd_Client.Name = "cmd_Client"
        Me.cmd_Client.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Client.TabIndex = 14
        Me.cmd_Client.Text = "Client"
        Me.cmd_Client.UseVisualStyleBackColor = True
        '
        'CreditCelesteDataSet
        '
        Me.CreditCelesteDataSet.DataSetName = "creditCelesteDataSet"
        Me.CreditCelesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CREDITBindingSource
        '
        Me.CREDITBindingSource.DataMember = "CREDIT"
        Me.CREDITBindingSource.DataSource = Me.CreditCelesteDataSet
        '
        'CREDITTableAdapter
        '
        Me.CREDITTableAdapter.ClearBeforeFill = True
        '
        'frmCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmd_Client)
        Me.Controls.Add(Me.cmd_voiture)
        Me.Controls.Add(Me.cmd_enregistrer)
        Me.Controls.Add(Me.cmd_introduction)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmd_Connexion)
        Me.Controls.Add(Me.cbDurée)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMontantFinancé)
        Me.Controls.Add(Me.txtTauxAnnuel)
        Me.Controls.Add(Me.txtMensualité)
        Me.Name = "frmCredit"
        Me.Text = "frmCredit"
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CREDITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMensualité As TextBox
    Friend WithEvents txtTauxAnnuel As TextBox
    Friend WithEvents txtMontantFinancé As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDurée As ComboBox
    Friend WithEvents cmd_Connexion As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmd_introduction As Button
    Friend WithEvents cmd_enregistrer As Button
    Friend WithEvents cmd_voiture As Button
    Friend WithEvents cmd_Client As Button
    Friend WithEvents CreditCelesteDataSet As creditCelesteDataSet
    Friend WithEvents CREDITBindingSource As BindingSource
    Friend WithEvents CREDITTableAdapter As creditCelesteDataSetTableAdapters.CREDITTableAdapter
End Class
