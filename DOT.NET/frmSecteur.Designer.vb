<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecteur
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CreditCelesteDataSet = New CreditCeleste.creditCelesteDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.NumSecteurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomSecteurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECTEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SECTEURTableAdapter = New CreditCeleste.creditCelesteDataSetTableAdapters.SECTEURTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SECTEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(147, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumSecteurDataGridViewTextBoxColumn, Me.NomSecteurDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SECTEURBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(406, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'CreditCelesteDataSet
        '
        Me.CreditCelesteDataSet.DataSetName = "creditCelesteDataSet"
        Me.CreditCelesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(147, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Location = New System.Drawing.Point(54, 91)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(35, 13)
        Me.Label0.TabIndex = 4
        Me.Label0.Text = "Num :"
        '
        'NumSecteurDataGridViewTextBoxColumn
        '
        Me.NumSecteurDataGridViewTextBoxColumn.DataPropertyName = "numSecteur"
        Me.NumSecteurDataGridViewTextBoxColumn.HeaderText = "numSecteur"
        Me.NumSecteurDataGridViewTextBoxColumn.Name = "NumSecteurDataGridViewTextBoxColumn"
        '
        'NomSecteurDataGridViewTextBoxColumn
        '
        Me.NomSecteurDataGridViewTextBoxColumn.DataPropertyName = "nomSecteur"
        Me.NomSecteurDataGridViewTextBoxColumn.HeaderText = "nomSecteur"
        Me.NomSecteurDataGridViewTextBoxColumn.Name = "NomSecteurDataGridViewTextBoxColumn"
        '
        'SECTEURBindingSource
        '
        Me.SECTEURBindingSource.DataMember = "SECTEUR"
        Me.SECTEURBindingSource.DataSource = Me.CreditCelesteDataSet
        '
        'SECTEURTableAdapter
        '
        Me.SECTEURTableAdapter.ClearBeforeFill = True
        '
        'frmSecteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 349)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSecteur"
        Me.Text = "frmSecteur"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SECTEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CreditCelesteDataSet As creditCelesteDataSet
    Friend WithEvents SECTEURBindingSource As BindingSource
    Friend WithEvents SECTEURTableAdapter As creditCelesteDataSetTableAdapters.SECTEURTableAdapter
    Friend WithEvents NumSecteurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomSecteurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label0 As Label
End Class
