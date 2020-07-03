<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SciencePick
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelScience1 = New System.Windows.Forms.Panel()
        Me.PanelScience2 = New System.Windows.Forms.Panel()
        Me.PanelScience3 = New System.Windows.Forms.Panel()
        Me.PanelScience4 = New System.Windows.Forms.Panel()
        Me.PanelScience5 = New System.Windows.Forms.Panel()
        Me.Label = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.5082!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.49181!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(594, 161)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PanelScience1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelScience2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelScience3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelScience4, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelScience5, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 50)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(588, 108)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'PanelScience1
        '
        Me.PanelScience1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelScience1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelScience1.Location = New System.Drawing.Point(3, 3)
        Me.PanelScience1.Name = "PanelScience1"
        Me.PanelScience1.Size = New System.Drawing.Size(111, 102)
        Me.PanelScience1.TabIndex = 0
        '
        'PanelScience2
        '
        Me.PanelScience2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelScience2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelScience2.Location = New System.Drawing.Point(120, 3)
        Me.PanelScience2.Name = "PanelScience2"
        Me.PanelScience2.Size = New System.Drawing.Size(111, 102)
        Me.PanelScience2.TabIndex = 1
        '
        'PanelScience3
        '
        Me.PanelScience3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelScience3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelScience3.Location = New System.Drawing.Point(237, 3)
        Me.PanelScience3.Name = "PanelScience3"
        Me.PanelScience3.Size = New System.Drawing.Size(111, 102)
        Me.PanelScience3.TabIndex = 2
        '
        'PanelScience4
        '
        Me.PanelScience4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelScience4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelScience4.Location = New System.Drawing.Point(354, 3)
        Me.PanelScience4.Name = "PanelScience4"
        Me.PanelScience4.Size = New System.Drawing.Size(111, 102)
        Me.PanelScience4.TabIndex = 3
        '
        'PanelScience5
        '
        Me.PanelScience5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelScience5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelScience5.Location = New System.Drawing.Point(471, 3)
        Me.PanelScience5.Name = "PanelScience5"
        Me.PanelScience5.Size = New System.Drawing.Size(114, 102)
        Me.PanelScience5.TabIndex = 4
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Silver
        Me.Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(3, 3)
        Me.Label.Margin = New System.Windows.Forms.Padding(3)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(588, 41)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Label"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SciencePick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 161)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SciencePick"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Not7Wonders"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PanelScience1 As Panel
    Friend WithEvents PanelScience2 As Panel
    Friend WithEvents PanelScience3 As Panel
    Friend WithEvents PanelScience4 As Panel
    Friend WithEvents PanelScience5 As Panel
    Friend WithEvents Label As Label
End Class
