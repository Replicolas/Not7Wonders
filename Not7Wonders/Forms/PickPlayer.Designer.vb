<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PickPlayer
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
        Me.ButtonP1 = New System.Windows.Forms.Button()
        Me.ButtonP2 = New System.Windows.Forms.Button()
        Me.LabelExplain = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelExplain, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(527, 119)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonP1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonP2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(521, 80)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ButtonP1
        '
        Me.ButtonP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonP1.Location = New System.Drawing.Point(3, 3)
        Me.ButtonP1.Name = "ButtonP1"
        Me.ButtonP1.Size = New System.Drawing.Size(254, 74)
        Me.ButtonP1.TabIndex = 0
        Me.ButtonP1.Text = "Button1"
        Me.ButtonP1.UseVisualStyleBackColor = True
        '
        'ButtonP2
        '
        Me.ButtonP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonP2.Location = New System.Drawing.Point(263, 3)
        Me.ButtonP2.Name = "ButtonP2"
        Me.ButtonP2.Size = New System.Drawing.Size(255, 74)
        Me.ButtonP2.TabIndex = 1
        Me.ButtonP2.Text = "Button2"
        Me.ButtonP2.UseVisualStyleBackColor = True
        '
        'LabelExplain
        '
        Me.LabelExplain.AutoSize = True
        Me.LabelExplain.BackColor = System.Drawing.Color.DarkGray
        Me.LabelExplain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelExplain.Location = New System.Drawing.Point(3, 3)
        Me.LabelExplain.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelExplain.Name = "LabelExplain"
        Me.LabelExplain.Size = New System.Drawing.Size(521, 27)
        Me.LabelExplain.TabIndex = 1
        Me.LabelExplain.Text = "Label3"
        Me.LabelExplain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PickPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 119)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PickPlayer"
        Me.Text = "PickPlayer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelExplain As Label
    Friend WithEvents ButtonP1 As Button
    Friend WithEvents ButtonP2 As Button
End Class
