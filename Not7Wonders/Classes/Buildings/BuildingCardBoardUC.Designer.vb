<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuildingCardBoardUC
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.FLP_Costs = New System.Windows.Forms.FlowLayoutPanel()
        Me.FLP_Symbols = New System.Windows.Forms.FlowLayoutPanel()
        Me.FLP_Gains = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FLP_Costs, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FLP_Symbols, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FLP_Gains, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelName, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(120, 136)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FLP_Costs
        '
        Me.FLP_Costs.BackColor = System.Drawing.Color.DarkGray
        Me.FLP_Costs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Costs.Location = New System.Drawing.Point(3, 40)
        Me.FLP_Costs.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.FLP_Costs.Name = "FLP_Costs"
        Me.FLP_Costs.Size = New System.Drawing.Size(114, 33)
        Me.FLP_Costs.TabIndex = 0
        '
        'FLP_Symbols
        '
        Me.FLP_Symbols.BackColor = System.Drawing.Color.DarkGray
        Me.FLP_Symbols.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Symbols.Location = New System.Drawing.Point(3, 73)
        Me.FLP_Symbols.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.FLP_Symbols.Name = "FLP_Symbols"
        Me.FLP_Symbols.Size = New System.Drawing.Size(114, 33)
        Me.FLP_Symbols.TabIndex = 1
        '
        'FLP_Gains
        '
        Me.FLP_Gains.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Gains.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FLP_Gains.Location = New System.Drawing.Point(3, 3)
        Me.FLP_Gains.Name = "FLP_Gains"
        Me.FLP_Gains.Size = New System.Drawing.Size(114, 34)
        Me.FLP_Gains.TabIndex = 2
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.Color.DimGray
        Me.LabelName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelName.Location = New System.Drawing.Point(3, 109)
        Me.LabelName.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(114, 24)
        Me.LabelName.TabIndex = 3
        Me.LabelName.Text = "Label1"
        Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BuildingCardUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(120, 136)
        Me.MinimumSize = New System.Drawing.Size(120, 136)
        Me.Name = "BuildingCardUC"
        Me.Size = New System.Drawing.Size(120, 136)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FLP_Costs As FlowLayoutPanel
    Friend WithEvents FLP_Symbols As FlowLayoutPanel
    Friend WithEvents FLP_Gains As FlowLayoutPanel
    Friend WithEvents LabelName As Label
End Class
