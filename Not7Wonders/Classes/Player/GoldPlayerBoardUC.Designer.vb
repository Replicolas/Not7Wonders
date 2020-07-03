<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoldPlayerBoardUC
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.LabelGoldCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelGoldCount
        '
        Me.LabelGoldCount.AutoSize = True
        Me.LabelGoldCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGoldCount.Location = New System.Drawing.Point(13, 12)
        Me.LabelGoldCount.Name = "LabelGoldCount"
        Me.LabelGoldCount.Size = New System.Drawing.Size(25, 25)
        Me.LabelGoldCount.TabIndex = 0
        Me.LabelGoldCount.Text = "1"
        '
        'GoldPlayerBoardUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Not7Wonders.My.Resources.Resources.Gold
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.LabelGoldCount)
        Me.DoubleBuffered = True
        Me.Name = "GoldPlayerBoardUC"
        Me.Size = New System.Drawing.Size(50, 47)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelGoldCount As Label
End Class
