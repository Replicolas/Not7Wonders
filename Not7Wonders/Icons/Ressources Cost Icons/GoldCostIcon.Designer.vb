<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GoldCostIcon
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
        Me.LabelCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelCost
        '
        Me.LabelCost.AutoSize = True
        Me.LabelCost.BackColor = System.Drawing.Color.Transparent
        Me.LabelCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCost.Location = New System.Drawing.Point(4, 1)
        Me.LabelCost.Name = "LabelCost"
        Me.LabelCost.Size = New System.Drawing.Size(14, 13)
        Me.LabelCost.TabIndex = 0
        Me.LabelCost.Text = "1"
        Me.LabelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GoldCostIcon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Not7Wonders.My.Resources.Resources.Gold
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.LabelCost)
        Me.DoubleBuffered = True
        Me.Name = "GoldCostIcon"
        Me.Size = New System.Drawing.Size(18, 16)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCost As Label
End Class
