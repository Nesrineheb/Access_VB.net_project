<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nom_etud = New System.Windows.Forms.Label()
        Me.prenom_etud = New System.Windows.Forms.Label()
        Me.Promo = New System.Windows.Forms.Label()
        Me.Groupe = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(100, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 260)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(524, 260)
        Me.DataGridView1.TabIndex = 0
        '
        'nom_etud
        '
        Me.nom_etud.AutoSize = True
        Me.nom_etud.Location = New System.Drawing.Point(162, 58)
        Me.nom_etud.Name = "nom_etud"
        Me.nom_etud.Size = New System.Drawing.Size(0, 13)
        Me.nom_etud.TabIndex = 1
        '
        'prenom_etud
        '
        Me.prenom_etud.AutoSize = True
        Me.prenom_etud.Location = New System.Drawing.Point(286, 58)
        Me.prenom_etud.Name = "prenom_etud"
        Me.prenom_etud.Size = New System.Drawing.Size(0, 13)
        Me.prenom_etud.TabIndex = 2
        '
        'Promo
        '
        Me.Promo.AutoSize = True
        Me.Promo.Location = New System.Drawing.Point(415, 60)
        Me.Promo.Name = "Promo"
        Me.Promo.Size = New System.Drawing.Size(0, 13)
        Me.Promo.TabIndex = 3
        '
        'Groupe
        '
        Me.Groupe.AutoSize = True
        Me.Groupe.Location = New System.Drawing.Point(527, 62)
        Me.Groupe.Name = "Groupe"
        Me.Groupe.Size = New System.Drawing.Size(0, 13)
        Me.Groupe.TabIndex = 4
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Groupe)
        Me.Controls.Add(Me.Promo)
        Me.Controls.Add(Me.prenom_etud)
        Me.Controls.Add(Me.nom_etud)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nom_etud As Label
    Friend WithEvents prenom_etud As Label
    Friend WithEvents Promo As Label
    Friend WithEvents Groupe As Label
End Class
