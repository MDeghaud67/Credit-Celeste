<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcession
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdConcessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomConcessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPConcessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VilleConcessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONCESSIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditCelesteDataSet = New CreditCeleste.creditCelesteDataSet()
        Me.CONCESSIONTableAdapter = New CreditCeleste.creditCelesteDataSetTableAdapters.CONCESSIONTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCESSIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adresse :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ville :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date de rattachement :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Concesssion concurrente :"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCESSIONBindingSource, "nomConcession", True))
        Me.TextBox1.Location = New System.Drawing.Point(208, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(208, 128)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(208, 203)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(208, 243)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(208, 281)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdConcessionDataGridViewTextBoxColumn, Me.NomConcessionDataGridViewTextBoxColumn, Me.CPConcessionDataGridViewTextBoxColumn, Me.VilleConcessionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CONCESSIONBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(388, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'IdConcessionDataGridViewTextBoxColumn
        '
        Me.IdConcessionDataGridViewTextBoxColumn.DataPropertyName = "idConcession"
        Me.IdConcessionDataGridViewTextBoxColumn.HeaderText = "idConcession"
        Me.IdConcessionDataGridViewTextBoxColumn.Name = "IdConcessionDataGridViewTextBoxColumn"
        '
        'NomConcessionDataGridViewTextBoxColumn
        '
        Me.NomConcessionDataGridViewTextBoxColumn.DataPropertyName = "nomConcession"
        Me.NomConcessionDataGridViewTextBoxColumn.HeaderText = "nomConcession"
        Me.NomConcessionDataGridViewTextBoxColumn.Name = "NomConcessionDataGridViewTextBoxColumn"
        '
        'CPConcessionDataGridViewTextBoxColumn
        '
        Me.CPConcessionDataGridViewTextBoxColumn.DataPropertyName = "CPConcession"
        Me.CPConcessionDataGridViewTextBoxColumn.HeaderText = "CPConcession"
        Me.CPConcessionDataGridViewTextBoxColumn.Name = "CPConcessionDataGridViewTextBoxColumn"
        '
        'VilleConcessionDataGridViewTextBoxColumn
        '
        Me.VilleConcessionDataGridViewTextBoxColumn.DataPropertyName = "villeConcession"
        Me.VilleConcessionDataGridViewTextBoxColumn.HeaderText = "villeConcession"
        Me.VilleConcessionDataGridViewTextBoxColumn.Name = "VilleConcessionDataGridViewTextBoxColumn"
        '
        'CONCESSIONBindingSource
        '
        Me.CONCESSIONBindingSource.DataMember = "CONCESSION"
        Me.CONCESSIONBindingSource.DataSource = Me.CreditCelesteDataSet
        '
        'CreditCelesteDataSet
        '
        Me.CreditCelesteDataSet.DataSetName = "creditCelesteDataSet"
        Me.CreditCelesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONCESSIONTableAdapter
        '
        Me.CONCESSIONTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmConcession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 369)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConcession"
        Me.Text = "frmConcession"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCESSIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CreditCelesteDataSet As creditCelesteDataSet
    Friend WithEvents CONCESSIONBindingSource As BindingSource
    Friend WithEvents CONCESSIONTableAdapter As creditCelesteDataSetTableAdapters.CONCESSIONTableAdapter
    Friend WithEvents IdConcessionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomConcessionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPConcessionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VilleConcessionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
