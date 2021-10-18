<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoiture
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gpbAge = New System.Windows.Forms.Label()
        Me.rdbOcc5 = New System.Windows.Forms.RadioButton()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.txtPuissance = New System.Windows.Forms.TextBox()
        Me.VEHICULEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNumSérie = New System.Windows.Forms.TextBox()
        Me.txtNumImmat = New System.Windows.Forms.TextBox()
        Me.txtAnnéeModèle = New System.Windows.Forms.TextBox()
        Me.txtDatePremImmat = New System.Windows.Forms.TextBox()
        Me.cmd_Credit = New System.Windows.Forms.Button()
        Me.cmd_Introduction = New System.Windows.Forms.Button()
        Me.cmd_Enregistrer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Client = New System.Windows.Forms.Button()
        Me.CreditCelesteDataSet = New CreditCeleste.creditCelesteDataSet()
        Me.VEHICULEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VEHICULETableAdapter = New CreditCeleste.creditCelesteDataSetTableAdapters.VEHICULETableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VEHICULEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VEHICULEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gpbAge)
        Me.GroupBox1.Controls.Add(Me.rdbOcc5)
        Me.GroupBox1.Controls.Add(Me.rdbNeuf)
        Me.GroupBox1.Controls.Add(Me.rdbOcc3a5)
        Me.GroupBox1.Controls.Add(Me.rdbOcc3)
        Me.GroupBox1.Location = New System.Drawing.Point(167, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 186)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mon Nouveau Vehicule"
        '
        'gpbAge
        '
        Me.gpbAge.AutoSize = True
        Me.gpbAge.Location = New System.Drawing.Point(177, 16)
        Me.gpbAge.Name = "gpbAge"
        Me.gpbAge.Size = New System.Drawing.Size(90, 13)
        Me.gpbAge.TabIndex = 32
        Me.gpbAge.Text = "Age du véhicule :"
        '
        'rdbOcc5
        '
        Me.rdbOcc5.AutoSize = True
        Me.rdbOcc5.Location = New System.Drawing.Point(180, 122)
        Me.rdbOcc5.Name = "rdbOcc5"
        Me.rdbOcc5.Size = New System.Drawing.Size(135, 17)
        Me.rdbOcc5.TabIndex = 31
        Me.rdbOcc5.TabStop = True
        Me.rdbOcc5.Text = "Occasion de 5 ans et +"
        Me.rdbOcc5.UseVisualStyleBackColor = True
        '
        'rdbNeuf
        '
        Me.rdbNeuf.AutoSize = True
        Me.rdbNeuf.Location = New System.Drawing.Point(180, 53)
        Me.rdbNeuf.Name = "rdbNeuf"
        Me.rdbNeuf.Size = New System.Drawing.Size(48, 17)
        Me.rdbNeuf.TabIndex = 28
        Me.rdbNeuf.TabStop = True
        Me.rdbNeuf.Text = "Neuf"
        Me.rdbNeuf.UseVisualStyleBackColor = True
        '
        'rdbOcc3a5
        '
        Me.rdbOcc3a5.AutoSize = True
        Me.rdbOcc3a5.Location = New System.Drawing.Point(180, 99)
        Me.rdbOcc3a5.Name = "rdbOcc3a5"
        Me.rdbOcc3a5.Size = New System.Drawing.Size(132, 17)
        Me.rdbOcc3a5.TabIndex = 30
        Me.rdbOcc3a5.TabStop = True
        Me.rdbOcc3a5.Text = "Occasion de 3 à 5 ans"
        Me.rdbOcc3a5.UseVisualStyleBackColor = True
        '
        'rdbOcc3
        '
        Me.rdbOcc3.AutoSize = True
        Me.rdbOcc3.Location = New System.Drawing.Point(180, 76)
        Me.rdbOcc3.Name = "rdbOcc3"
        Me.rdbOcc3.Size = New System.Drawing.Size(114, 17)
        Me.rdbOcc3.TabIndex = 29
        Me.rdbOcc3.TabStop = True
        Me.rdbOcc3.Text = "Occasion de 3 ans"
        Me.rdbOcc3.UseVisualStyleBackColor = True
        '
        'txtPuissance
        '
        Me.txtPuissance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULEBindingSource1, "puissance", True))
        Me.txtPuissance.Location = New System.Drawing.Point(677, 260)
        Me.txtPuissance.Name = "txtPuissance"
        Me.txtPuissance.Size = New System.Drawing.Size(100, 20)
        Me.txtPuissance.TabIndex = 26
        '
        'VEHICULEBindingSource
        '
        Me.VEHICULEBindingSource.DataMember = "VEHICULE"
        '
        'txtNumSérie
        '
        Me.txtNumSérie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULEBindingSource1, "numSerie", True))
        Me.txtNumSérie.Location = New System.Drawing.Point(542, 260)
        Me.txtNumSérie.Name = "txtNumSérie"
        Me.txtNumSérie.Size = New System.Drawing.Size(100, 20)
        Me.txtNumSérie.TabIndex = 25
        '
        'txtNumImmat
        '
        Me.txtNumImmat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULEBindingSource1, "numImmat", True))
        Me.txtNumImmat.Location = New System.Drawing.Point(386, 260)
        Me.txtNumImmat.Name = "txtNumImmat"
        Me.txtNumImmat.Size = New System.Drawing.Size(100, 20)
        Me.txtNumImmat.TabIndex = 24
        '
        'txtAnnéeModèle
        '
        Me.txtAnnéeModèle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULEBindingSource1, "anneeModele", True))
        Me.txtAnnéeModèle.Location = New System.Drawing.Point(204, 260)
        Me.txtAnnéeModèle.Name = "txtAnnéeModèle"
        Me.txtAnnéeModèle.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnéeModèle.TabIndex = 23
        '
        'txtDatePremImmat
        '
        Me.txtDatePremImmat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULEBindingSource1, "datePremImmat", True))
        Me.txtDatePremImmat.Location = New System.Drawing.Point(39, 260)
        Me.txtDatePremImmat.Name = "txtDatePremImmat"
        Me.txtDatePremImmat.Size = New System.Drawing.Size(100, 20)
        Me.txtDatePremImmat.TabIndex = 22
        '
        'cmd_Credit
        '
        Me.cmd_Credit.Location = New System.Drawing.Point(597, 376)
        Me.cmd_Credit.Name = "cmd_Credit"
        Me.cmd_Credit.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Credit.TabIndex = 21
        Me.cmd_Credit.Text = "Credit"
        Me.cmd_Credit.UseVisualStyleBackColor = True
        '
        'cmd_Introduction
        '
        Me.cmd_Introduction.Location = New System.Drawing.Point(347, 376)
        Me.cmd_Introduction.Name = "cmd_Introduction"
        Me.cmd_Introduction.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Introduction.TabIndex = 20
        Me.cmd_Introduction.Text = "Introduction"
        Me.cmd_Introduction.UseVisualStyleBackColor = True
        '
        'cmd_Enregistrer
        '
        Me.cmd_Enregistrer.Location = New System.Drawing.Point(213, 376)
        Me.cmd_Enregistrer.Name = "cmd_Enregistrer"
        Me.cmd_Enregistrer.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Enregistrer.TabIndex = 19
        Me.cmd_Enregistrer.Text = "J'enregistre"
        Me.cmd_Enregistrer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(688, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "puissance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(539, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "numéro de la série"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "numéro d'immatriculation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "année modèle"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "date de la 1ère immatriculation"
        '
        'cmd_Client
        '
        Me.cmd_Client.Location = New System.Drawing.Point(474, 376)
        Me.cmd_Client.Name = "cmd_Client"
        Me.cmd_Client.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Client.TabIndex = 28
        Me.cmd_Client.Text = "Client"
        Me.cmd_Client.UseVisualStyleBackColor = True
        '
        'CreditCelesteDataSet
        '
        Me.CreditCelesteDataSet.DataSetName = "creditCelesteDataSet"
        Me.CreditCelesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VEHICULEBindingSource1
        '
        Me.VEHICULEBindingSource1.DataMember = "VEHICULE"
        Me.VEHICULEBindingSource1.DataSource = Me.CreditCelesteDataSet
        '
        'VEHICULETableAdapter
        '
        Me.VEHICULETableAdapter.ClearBeforeFill = True
        '
        'frmVoiture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmd_Client)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPuissance)
        Me.Controls.Add(Me.txtNumSérie)
        Me.Controls.Add(Me.txtNumImmat)
        Me.Controls.Add(Me.txtAnnéeModèle)
        Me.Controls.Add(Me.txtDatePremImmat)
        Me.Controls.Add(Me.cmd_Credit)
        Me.Controls.Add(Me.cmd_Introduction)
        Me.Controls.Add(Me.cmd_Enregistrer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVoiture"
        Me.Text = "frmVoiture"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VEHICULEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VEHICULEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPuissance As TextBox
    Friend WithEvents txtNumSérie As TextBox
    Friend WithEvents txtNumImmat As TextBox
    Friend WithEvents txtAnnéeModèle As TextBox
    Friend WithEvents txtDatePremImmat As TextBox
    Friend WithEvents cmd_Credit As Button
    Friend WithEvents cmd_Introduction As Button
    Friend WithEvents cmd_Enregistrer As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gpbAge As Label
    Friend WithEvents rdbOcc5 As RadioButton
    Friend WithEvents rdbNeuf As RadioButton
    Friend WithEvents rdbOcc3a5 As RadioButton
    Friend WithEvents rdbOcc3 As RadioButton
    Friend WithEvents cmd_Client As Button
    Friend WithEvents VEHICULEBindingSource As BindingSource
    Friend WithEvents CreditCelesteDataSet As creditCelesteDataSet
    Friend WithEvents VEHICULEBindingSource1 As BindingSource
    Friend WithEvents VEHICULETableAdapter As creditCelesteDataSetTableAdapters.VEHICULETableAdapter
End Class
