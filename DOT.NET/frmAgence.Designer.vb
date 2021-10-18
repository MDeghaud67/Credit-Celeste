<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgence
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumAgenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomAgenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGENCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditCelesteDataSet = New CreditCeleste.creditCelesteDataSet()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGENCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(137, 70)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nom :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumAgenceDataGridViewTextBoxColumn, Me.NomAgenceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AGENCEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(337, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 152)
        Me.DataGridView1.TabIndex = 8
        '
        'NumAgenceDataGridViewTextBoxColumn
        '
        Me.NumAgenceDataGridViewTextBoxColumn.DataPropertyName = "numAgence"
        Me.NumAgenceDataGridViewTextBoxColumn.HeaderText = "numAgence"
        Me.NumAgenceDataGridViewTextBoxColumn.Name = "NumAgenceDataGridViewTextBoxColumn"
        Me.NumAgenceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomAgenceDataGridViewTextBoxColumn
        '
        Me.NomAgenceDataGridViewTextBoxColumn.DataPropertyName = "nomAgence"
        Me.NomAgenceDataGridViewTextBoxColumn.HeaderText = "nomAgence"
        Me.NomAgenceDataGridViewTextBoxColumn.Name = "NomAgenceDataGridViewTextBoxColumn"
        '
        'AGENCEBindingSource
        '
        Me.AGENCEBindingSource.DataMember = "AGENCE"
        Me.AGENCEBindingSource.DataSource = Me.CreditCelesteDataSet
        '
        'CreditCelesteDataSet
        '
        Me.CreditCelesteDataSet.DataSetName = "creditCelesteDataSet"
        Me.CreditCelesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmAgence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 349)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmAgence"
        Me.Text = "frmAgence"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGENCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditCelesteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CreditCelesteDataSet As creditCelesteDataSet
    Friend WithEvents AGENCEBindingSource As BindingSource
    Friend WithEvents NumAgenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CivAgenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomAgenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
