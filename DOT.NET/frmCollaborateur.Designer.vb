<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollaborateur
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.COLLABORATEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditCelesteDataSet = New CreditCeleste.creditCelesteDataSet()
        Me.COLLABORATEURTableAdapter = New CreditCeleste.creditCelesteDataSetTableAdapters.COLLABORATEURTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NumColDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivColDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomColDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomColDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumSecteurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumAgenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLLABORATEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Madame", "Monsieur"})
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COLLABORATEURBindingSource, "civCol", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Madame", "Monsieur"})
        Me.ComboBox1.Location = New System.Drawing.Point(117, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Prénom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Civilité :"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COLLABORATEURBindingSource, "prenomCol", True))
        Me.TextBox3.Location = New System.Drawing.Point(117, 136)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COLLABORATEURBindingSource, "nomCol", True))
        Me.TextBox2.Location = New System.Drawing.Point(117, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumColDataGridViewTextBoxColumn, Me.CivColDataGridViewTextBoxColumn, Me.NomColDataGridViewTextBoxColumn, Me.PrenomColDataGridViewTextBoxColumn, Me.NumSecteurDataGridViewTextBoxColumn, Me.NumAgenceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.COLLABORATEURBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(340, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'COLLABORATEURBindingSource
        '
        Me.COLLABORATEURBindingSource.DataMember = "COLLABORATEUR"
        Me.COLLABORATEURBindingSource.DataSource = Me.CreditCelesteDataSet
        '
        'CreditCelesteDataSet
        '
        Me.CreditCelesteDataSet.DataSetName = "creditCelesteDataSet"
        Me.CreditCelesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COLLABORATEURTableAdapter
        '
        Me.COLLABORATEURTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(180, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NumColDataGridViewTextBoxColumn
        '
        Me.NumColDataGridViewTextBoxColumn.DataPropertyName = "numCol"
        Me.NumColDataGridViewTextBoxColumn.HeaderText = "numCol"
        Me.NumColDataGridViewTextBoxColumn.Name = "NumColDataGridViewTextBoxColumn"
        Me.NumColDataGridViewTextBoxColumn.Visible = False
        '
        'CivColDataGridViewTextBoxColumn
        '
        Me.CivColDataGridViewTextBoxColumn.DataPropertyName = "civCol"
        Me.CivColDataGridViewTextBoxColumn.HeaderText = "civCol"
        Me.CivColDataGridViewTextBoxColumn.Name = "CivColDataGridViewTextBoxColumn"
        '
        'NomColDataGridViewTextBoxColumn
        '
        Me.NomColDataGridViewTextBoxColumn.DataPropertyName = "nomCol"
        Me.NomColDataGridViewTextBoxColumn.HeaderText = "nomCol"
        Me.NomColDataGridViewTextBoxColumn.Name = "NomColDataGridViewTextBoxColumn"
        '
        'PrenomColDataGridViewTextBoxColumn
        '
        Me.PrenomColDataGridViewTextBoxColumn.DataPropertyName = "prenomCol"
        Me.PrenomColDataGridViewTextBoxColumn.HeaderText = "prenomCol"
        Me.PrenomColDataGridViewTextBoxColumn.Name = "PrenomColDataGridViewTextBoxColumn"
        '
        'NumSecteurDataGridViewTextBoxColumn
        '
        Me.NumSecteurDataGridViewTextBoxColumn.DataPropertyName = "numSecteur"
        Me.NumSecteurDataGridViewTextBoxColumn.HeaderText = "numSecteur"
        Me.NumSecteurDataGridViewTextBoxColumn.Name = "NumSecteurDataGridViewTextBoxColumn"
        '
        'NumAgenceDataGridViewTextBoxColumn
        '
        Me.NumAgenceDataGridViewTextBoxColumn.DataPropertyName = "numAgence"
        Me.NumAgenceDataGridViewTextBoxColumn.HeaderText = "numAgence"
        Me.NumAgenceDataGridViewTextBoxColumn.Name = "NumAgenceDataGridViewTextBoxColumn"
        '
        'frmCollaborateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 340)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmCollaborateur"
        Me.Text = "frmCollaborateur"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLLABORATEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CreditCelesteDataSet As creditCelesteDataSet
    Friend WithEvents COLLABORATEURBindingSource As BindingSource
    Friend WithEvents COLLABORATEURTableAdapter As creditCelesteDataSetTableAdapters.COLLABORATEURTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents NumColDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CivColDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomColDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrenomColDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumSecteurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumAgenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
