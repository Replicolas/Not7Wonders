<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActionForm
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
        Me.PanelCard = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonBuild = New System.Windows.Forms.Button()
        Me.ButtonSell = New System.Windows.Forms.Button()
        Me.ButtonMarvel1 = New System.Windows.Forms.Button()
        Me.ButtonMarvel2 = New System.Windows.Forms.Button()
        Me.ButtonMarvel3 = New System.Windows.Forms.Button()
        Me.ButtonMarvel4 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelCard, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(550, 253)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelCard
        '
        Me.PanelCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCard.Location = New System.Drawing.Point(3, 3)
        Me.PanelCard.Name = "PanelCard"
        Me.PanelCard.Size = New System.Drawing.Size(214, 247)
        Me.PanelCard.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonBuild, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonSell, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonMarvel1, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonMarvel2, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonMarvel3, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonMarvel4, 0, 5)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(223, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(324, 247)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'ButtonBuild
        '
        Me.ButtonBuild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBuild.Location = New System.Drawing.Point(3, 3)
        Me.ButtonBuild.Name = "ButtonBuild"
        Me.ButtonBuild.Size = New System.Drawing.Size(318, 35)
        Me.ButtonBuild.TabIndex = 1
        Me.ButtonBuild.Text = "Button1"
        Me.ButtonBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuild.UseVisualStyleBackColor = True
        '
        'ButtonSell
        '
        Me.ButtonSell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSell.Location = New System.Drawing.Point(3, 44)
        Me.ButtonSell.Name = "ButtonSell"
        Me.ButtonSell.Size = New System.Drawing.Size(318, 35)
        Me.ButtonSell.TabIndex = 2
        Me.ButtonSell.Text = "Button1"
        Me.ButtonSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSell.UseVisualStyleBackColor = True
        '
        'ButtonMarvel1
        '
        Me.ButtonMarvel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonMarvel1.Location = New System.Drawing.Point(3, 85)
        Me.ButtonMarvel1.Name = "ButtonMarvel1"
        Me.ButtonMarvel1.Size = New System.Drawing.Size(318, 35)
        Me.ButtonMarvel1.TabIndex = 3
        Me.ButtonMarvel1.Text = "Button2"
        Me.ButtonMarvel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMarvel1.UseVisualStyleBackColor = True
        '
        'ButtonMarvel2
        '
        Me.ButtonMarvel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonMarvel2.Location = New System.Drawing.Point(3, 126)
        Me.ButtonMarvel2.Name = "ButtonMarvel2"
        Me.ButtonMarvel2.Size = New System.Drawing.Size(318, 35)
        Me.ButtonMarvel2.TabIndex = 4
        Me.ButtonMarvel2.Text = "Button3"
        Me.ButtonMarvel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMarvel2.UseVisualStyleBackColor = True
        '
        'ButtonMarvel3
        '
        Me.ButtonMarvel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonMarvel3.Location = New System.Drawing.Point(3, 167)
        Me.ButtonMarvel3.Name = "ButtonMarvel3"
        Me.ButtonMarvel3.Size = New System.Drawing.Size(318, 35)
        Me.ButtonMarvel3.TabIndex = 5
        Me.ButtonMarvel3.Text = "Button4"
        Me.ButtonMarvel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMarvel3.UseVisualStyleBackColor = True
        '
        'ButtonMarvel4
        '
        Me.ButtonMarvel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonMarvel4.Location = New System.Drawing.Point(3, 208)
        Me.ButtonMarvel4.Name = "ButtonMarvel4"
        Me.ButtonMarvel4.Size = New System.Drawing.Size(318, 36)
        Me.ButtonMarvel4.TabIndex = 6
        Me.ButtonMarvel4.Text = "Button5"
        Me.ButtonMarvel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMarvel4.UseVisualStyleBackColor = True
        '
        'ActionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 253)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(566, 292)
        Me.MinimumSize = New System.Drawing.Size(566, 292)
        Me.Name = "ActionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Not7Wonders"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelCard As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ButtonBuild As Button
    Friend WithEvents ButtonSell As Button
    Friend WithEvents ButtonMarvel1 As Button
    Friend WithEvents ButtonMarvel2 As Button
    Friend WithEvents ButtonMarvel3 As Button
    Friend WithEvents ButtonMarvel4 As Button
End Class
