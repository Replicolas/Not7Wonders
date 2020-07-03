<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MarvelPick
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel0 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelActivePlayerName = New System.Windows.Forms.Label()
        Me.LabelInstructions = New System.Windows.Forms.Label()
        Me.LabelPhase = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1018.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1018, 729)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 506.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 506.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel0, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 63)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 331.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 331.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1012, 663)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel0
        '
        Me.Panel0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel0.Location = New System.Drawing.Point(3, 3)
        Me.Panel0.Name = "Panel0"
        Me.Panel0.Size = New System.Drawing.Size(500, 325)
        Me.Panel0.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(509, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 325)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 334)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 326)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(509, 334)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(500, 326)
        Me.Panel3.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.27506!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.72494!))
        Me.TableLayoutPanel3.Controls.Add(Me.LabelActivePlayerName, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelInstructions, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelPhase, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1006, 48)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'LabelActivePlayerName
        '
        Me.LabelActivePlayerName.AutoSize = True
        Me.LabelActivePlayerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelActivePlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelActivePlayerName.Location = New System.Drawing.Point(151, 4)
        Me.LabelActivePlayerName.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelActivePlayerName.Name = "LabelActivePlayerName"
        Me.LabelActivePlayerName.Size = New System.Drawing.Size(492, 40)
        Me.LabelActivePlayerName.TabIndex = 0
        Me.LabelActivePlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelInstructions
        '
        Me.LabelInstructions.AutoSize = True
        Me.LabelInstructions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInstructions.Location = New System.Drawing.Point(650, 4)
        Me.LabelInstructions.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelInstructions.Name = "LabelInstructions"
        Me.LabelInstructions.Size = New System.Drawing.Size(352, 40)
        Me.LabelInstructions.TabIndex = 1
        Me.LabelInstructions.Text = "Sélectionne une Merveille"
        Me.LabelInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPhase
        '
        Me.LabelPhase.AutoSize = True
        Me.LabelPhase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPhase.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhase.Location = New System.Drawing.Point(4, 4)
        Me.LabelPhase.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelPhase.Name = "LabelPhase"
        Me.LabelPhase.Size = New System.Drawing.Size(140, 40)
        Me.LabelPhase.TabIndex = 2
        Me.LabelPhase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MarvelPick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(1034, 768)
        Me.MinimumSize = New System.Drawing.Size(1034, 768)
        Me.Name = "MarvelPick"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Not7Wonders"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel0 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelActivePlayerName As Label
    Friend WithEvents LabelInstructions As Label
    Friend WithEvents LabelPhase As Label
End Class
