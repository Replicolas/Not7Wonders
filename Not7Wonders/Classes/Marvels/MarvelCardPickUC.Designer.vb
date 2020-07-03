<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MarvelCardPickUC
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMarvel = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        '
        'MarvelCardUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.MaximumSize = New System.Drawing.Size(500, 325)
        Me.MinimumSize = New System.Drawing.Size(500, 325)
        Me.Name = "MarvelCardUC"
        Me.Size = New System.Drawing.Size(500, 325)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTipMarvel As ToolTip
End Class
