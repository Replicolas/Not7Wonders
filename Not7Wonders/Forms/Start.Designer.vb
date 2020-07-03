<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start
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
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelPlayerA = New System.Windows.Forms.Label()
        Me.LabelPlayerB = New System.Windows.Forms.Label()
        Me.TextBoxPlayerA = New System.Windows.Forms.TextBox()
        Me.TextBoxPlayerB = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonStart, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(514, 186)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonStart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonStart.Font = New System.Drawing.Font("Perpetua Titling MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.Location = New System.Drawing.Point(3, 97)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(508, 86)
        Me.ButtonStart.TabIndex = 0
        Me.ButtonStart.Text = "JOUER"
        Me.ButtonStart.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelPlayerA, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelPlayerB, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxPlayerA, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxPlayerB, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(508, 88)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'LabelPlayerA
        '
        Me.LabelPlayerA.AutoSize = True
        Me.LabelPlayerA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPlayerA.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPlayerA.Location = New System.Drawing.Point(3, 3)
        Me.LabelPlayerA.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelPlayerA.Name = "LabelPlayerA"
        Me.LabelPlayerA.Size = New System.Drawing.Size(248, 37)
        Me.LabelPlayerA.TabIndex = 0
        Me.LabelPlayerA.Text = "Nom du Joueur A :"
        Me.LabelPlayerA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPlayerB
        '
        Me.LabelPlayerB.AutoSize = True
        Me.LabelPlayerB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPlayerB.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPlayerB.Location = New System.Drawing.Point(3, 46)
        Me.LabelPlayerB.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelPlayerB.Name = "LabelPlayerB"
        Me.LabelPlayerB.Size = New System.Drawing.Size(248, 39)
        Me.LabelPlayerB.TabIndex = 1
        Me.LabelPlayerB.Text = "Nom du Joueur B :"
        Me.LabelPlayerB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxPlayerA
        '
        Me.TextBoxPlayerA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxPlayerA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPlayerA.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPlayerA.Location = New System.Drawing.Point(257, 3)
        Me.TextBoxPlayerA.Name = "TextBoxPlayerA"
        Me.TextBoxPlayerA.Size = New System.Drawing.Size(248, 38)
        Me.TextBoxPlayerA.TabIndex = 2
        Me.TextBoxPlayerA.Text = "JoueurA"
        '
        'TextBoxPlayerB
        '
        Me.TextBoxPlayerB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxPlayerB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPlayerB.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPlayerB.Location = New System.Drawing.Point(257, 46)
        Me.TextBoxPlayerB.Name = "TextBoxPlayerB"
        Me.TextBoxPlayerB.Size = New System.Drawing.Size(248, 38)
        Me.TextBoxPlayerB.TabIndex = 3
        Me.TextBoxPlayerB.Text = "JoueurB"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 186)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(530, 225)
        Me.MinimumSize = New System.Drawing.Size(530, 225)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Not7Wonders"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonStart As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelPlayerA As Label
    Friend WithEvents LabelPlayerB As Label
    Friend WithEvents TextBoxPlayerA As TextBox
    Friend WithEvents TextBoxPlayerB As TextBox
End Class
