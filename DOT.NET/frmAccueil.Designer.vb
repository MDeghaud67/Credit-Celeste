<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccueil
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
        Me.cmdIntroduction = New System.Windows.Forms.Button()
        Me.cmdEtude = New System.Windows.Forms.Button()
        Me.cmdRelance = New System.Windows.Forms.Button()
        Me.BTN_Agence = New System.Windows.Forms.Button()
        Me.BTN_Secteur = New System.Windows.Forms.Button()
        Me.BTN_Concession = New System.Windows.Forms.Button()
        Me.BTN_Collabo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.Location = New System.Drawing.Point(134, 387)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntroduction.TabIndex = 0
        Me.cmdIntroduction.Text = "&Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = True
        '
        'cmdEtude
        '
        Me.cmdEtude.Location = New System.Drawing.Point(363, 387)
        Me.cmdEtude.Name = "cmdEtude"
        Me.cmdEtude.Size = New System.Drawing.Size(75, 23)
        Me.cmdEtude.TabIndex = 1
        Me.cmdEtude.Text = "&Etude"
        Me.cmdEtude.UseVisualStyleBackColor = True
        '
        'cmdRelance
        '
        Me.cmdRelance.Location = New System.Drawing.Point(529, 386)
        Me.cmdRelance.Name = "cmdRelance"
        Me.cmdRelance.Size = New System.Drawing.Size(75, 23)
        Me.cmdRelance.TabIndex = 2
        Me.cmdRelance.Text = "Relance"
        Me.cmdRelance.UseVisualStyleBackColor = True
        '
        'BTN_Agence
        '
        Me.BTN_Agence.Location = New System.Drawing.Point(691, 386)
        Me.BTN_Agence.Name = "BTN_Agence"
        Me.BTN_Agence.Size = New System.Drawing.Size(83, 23)
        Me.BTN_Agence.TabIndex = 3
        Me.BTN_Agence.Text = "Agence"
        Me.BTN_Agence.UseVisualStyleBackColor = True
        '
        'BTN_Secteur
        '
        Me.BTN_Secteur.Location = New System.Drawing.Point(691, 344)
        Me.BTN_Secteur.Name = "BTN_Secteur"
        Me.BTN_Secteur.Size = New System.Drawing.Size(83, 25)
        Me.BTN_Secteur.TabIndex = 4
        Me.BTN_Secteur.Text = "Secteur"
        Me.BTN_Secteur.UseVisualStyleBackColor = True
        '
        'BTN_Concession
        '
        Me.BTN_Concession.Location = New System.Drawing.Point(691, 295)
        Me.BTN_Concession.Name = "BTN_Concession"
        Me.BTN_Concession.Size = New System.Drawing.Size(83, 26)
        Me.BTN_Concession.TabIndex = 5
        Me.BTN_Concession.Text = "Concession"
        Me.BTN_Concession.UseVisualStyleBackColor = True
        '
        'BTN_Collabo
        '
        Me.BTN_Collabo.Location = New System.Drawing.Point(691, 250)
        Me.BTN_Collabo.Name = "BTN_Collabo"
        Me.BTN_Collabo.Size = New System.Drawing.Size(83, 26)
        Me.BTN_Collabo.TabIndex = 6
        Me.BTN_Collabo.Text = "Collaborateur"
        Me.BTN_Collabo.UseVisualStyleBackColor = True
        '
        'frmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_Collabo)
        Me.Controls.Add(Me.BTN_Concession)
        Me.Controls.Add(Me.BTN_Secteur)
        Me.Controls.Add(Me.BTN_Agence)
        Me.Controls.Add(Me.cmdRelance)
        Me.Controls.Add(Me.cmdEtude)
        Me.Controls.Add(Me.cmdIntroduction)
        Me.Name = "frmAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdIntroduction As Button
    Friend WithEvents cmdEtude As Button
    Friend WithEvents cmdRelance As Button
    Friend WithEvents BTN_Agence As Button
    Friend WithEvents BTN_Secteur As Button
    Friend WithEvents BTN_Concession As Button
    Friend WithEvents BTN_Collabo As Button
End Class
