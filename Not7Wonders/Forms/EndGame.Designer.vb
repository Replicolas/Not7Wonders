<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndGame
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
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.LabelWinnerName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelNameP1 = New System.Windows.Forms.Label()
        Me.LabelBlueP1 = New System.Windows.Forms.Label()
        Me.LabelGreenP1 = New System.Windows.Forms.Label()
        Me.LabelYellowP1 = New System.Windows.Forms.Label()
        Me.LabelPurpleP1 = New System.Windows.Forms.Label()
        Me.LabelMarvelP1 = New System.Windows.Forms.Label()
        Me.LabelScienceP1 = New System.Windows.Forms.Label()
        Me.LabelGoldP1 = New System.Windows.Forms.Label()
        Me.LabelShieldP1 = New System.Windows.Forms.Label()
        Me.LabelTotalP1 = New System.Windows.Forms.Label()
        Me.LabelMilitaryVictoryP1 = New System.Windows.Forms.Label()
        Me.LabelScientificVictoryP1 = New System.Windows.Forms.Label()
        Me.LabelNameP2 = New System.Windows.Forms.Label()
        Me.LabelBlueP2 = New System.Windows.Forms.Label()
        Me.LabelGreenP2 = New System.Windows.Forms.Label()
        Me.LabelYellowP2 = New System.Windows.Forms.Label()
        Me.LabelPurpleP2 = New System.Windows.Forms.Label()
        Me.LabelMarvelP2 = New System.Windows.Forms.Label()
        Me.LabelScienceP2 = New System.Windows.Forms.Label()
        Me.LabelGoldP2 = New System.Windows.Forms.Label()
        Me.LabelShieldP2 = New System.Windows.Forms.Label()
        Me.LabelTotalP2 = New System.Windows.Forms.Label()
        Me.LabelMilitaryVictoryP2 = New System.Windows.Forms.Label()
        Me.LabelScientificVictoryP2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelWinnerName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(575, 507)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonQuit, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 450)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(569, 54)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ButtonQuit
        '
        Me.ButtonQuit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuit.Location = New System.Drawing.Point(3, 3)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(563, 48)
        Me.ButtonQuit.TabIndex = 1
        Me.ButtonQuit.Text = "Quitter"
        Me.ButtonQuit.UseVisualStyleBackColor = True
        '
        'LabelWinnerName
        '
        Me.LabelWinnerName.AutoSize = True
        Me.LabelWinnerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelWinnerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWinnerName.Location = New System.Drawing.Point(3, 390)
        Me.LabelWinnerName.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelWinnerName.Name = "LabelWinnerName"
        Me.LabelWinnerName.Size = New System.Drawing.Size(569, 54)
        Me.LabelWinnerName.TabIndex = 1
        Me.LabelWinnerName.Text = "Winner"
        Me.LabelWinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 10)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 11)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelNameP1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelBlueP1, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelGreenP1, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelYellowP1, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelPurpleP1, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelMarvelP1, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelScienceP1, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelGoldP1, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelShieldP1, 1, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelTotalP1, 1, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelMilitaryVictoryP1, 1, 10)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelScientificVictoryP1, 1, 11)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelNameP2, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelBlueP2, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelGreenP2, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelYellowP2, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelPurpleP2, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelMarvelP2, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelScienceP2, 2, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelGoldP2, 2, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelShieldP2, 2, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelTotalP2, 2, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelMilitaryVictoryP2, 2, 10)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelScientificVictoryP2, 2, 11)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 12
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(569, 381)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SkyBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cartes Bleues"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PaleGreen
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cartes Vertes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cartes Jaunes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lavender
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cartes Violettes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 156)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Merveilles"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 187)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 30)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Science"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Moccasin
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 218)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 30)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Or"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightSalmon
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1, 249)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 30)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Boucliers"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 280)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 30)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "TOTAL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.IndianRed
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1, 311)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 30)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Victoire Militaire"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.YellowGreen
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1, 342)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(183, 38)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Victoire Scientifique"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNameP1
        '
        Me.LabelNameP1.AutoSize = True
        Me.LabelNameP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNameP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameP1.Location = New System.Drawing.Point(185, 1)
        Me.LabelNameP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNameP1.Name = "LabelNameP1"
        Me.LabelNameP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelNameP1.TabIndex = 12
        Me.LabelNameP1.Text = "Label13"
        Me.LabelNameP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelBlueP1
        '
        Me.LabelBlueP1.AutoSize = True
        Me.LabelBlueP1.BackColor = System.Drawing.Color.SkyBlue
        Me.LabelBlueP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelBlueP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBlueP1.Location = New System.Drawing.Point(185, 32)
        Me.LabelBlueP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelBlueP1.Name = "LabelBlueP1"
        Me.LabelBlueP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelBlueP1.TabIndex = 13
        Me.LabelBlueP1.Text = "Label14"
        Me.LabelBlueP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelGreenP1
        '
        Me.LabelGreenP1.AutoSize = True
        Me.LabelGreenP1.BackColor = System.Drawing.Color.PaleGreen
        Me.LabelGreenP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelGreenP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGreenP1.Location = New System.Drawing.Point(185, 63)
        Me.LabelGreenP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelGreenP1.Name = "LabelGreenP1"
        Me.LabelGreenP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelGreenP1.TabIndex = 14
        Me.LabelGreenP1.Text = "Label15"
        Me.LabelGreenP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelYellowP1
        '
        Me.LabelYellowP1.AutoSize = True
        Me.LabelYellowP1.BackColor = System.Drawing.Color.LemonChiffon
        Me.LabelYellowP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelYellowP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelYellowP1.Location = New System.Drawing.Point(185, 94)
        Me.LabelYellowP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelYellowP1.Name = "LabelYellowP1"
        Me.LabelYellowP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelYellowP1.TabIndex = 15
        Me.LabelYellowP1.Text = "Label16"
        Me.LabelYellowP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPurpleP1
        '
        Me.LabelPurpleP1.AutoSize = True
        Me.LabelPurpleP1.BackColor = System.Drawing.Color.Lavender
        Me.LabelPurpleP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPurpleP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPurpleP1.Location = New System.Drawing.Point(185, 125)
        Me.LabelPurpleP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPurpleP1.Name = "LabelPurpleP1"
        Me.LabelPurpleP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelPurpleP1.TabIndex = 16
        Me.LabelPurpleP1.Text = "Label17"
        Me.LabelPurpleP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMarvelP1
        '
        Me.LabelMarvelP1.AutoSize = True
        Me.LabelMarvelP1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabelMarvelP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelMarvelP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMarvelP1.Location = New System.Drawing.Point(185, 156)
        Me.LabelMarvelP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelMarvelP1.Name = "LabelMarvelP1"
        Me.LabelMarvelP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelMarvelP1.TabIndex = 17
        Me.LabelMarvelP1.Text = "Label18"
        Me.LabelMarvelP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelScienceP1
        '
        Me.LabelScienceP1.AutoSize = True
        Me.LabelScienceP1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LabelScienceP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelScienceP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScienceP1.Location = New System.Drawing.Point(185, 187)
        Me.LabelScienceP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelScienceP1.Name = "LabelScienceP1"
        Me.LabelScienceP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelScienceP1.TabIndex = 18
        Me.LabelScienceP1.Text = "Label19"
        Me.LabelScienceP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelGoldP1
        '
        Me.LabelGoldP1.AutoSize = True
        Me.LabelGoldP1.BackColor = System.Drawing.Color.Moccasin
        Me.LabelGoldP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelGoldP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGoldP1.Location = New System.Drawing.Point(185, 218)
        Me.LabelGoldP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelGoldP1.Name = "LabelGoldP1"
        Me.LabelGoldP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelGoldP1.TabIndex = 19
        Me.LabelGoldP1.Text = "Label20"
        Me.LabelGoldP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelShieldP1
        '
        Me.LabelShieldP1.AutoSize = True
        Me.LabelShieldP1.BackColor = System.Drawing.Color.LightSalmon
        Me.LabelShieldP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelShieldP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelShieldP1.Location = New System.Drawing.Point(185, 249)
        Me.LabelShieldP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelShieldP1.Name = "LabelShieldP1"
        Me.LabelShieldP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelShieldP1.TabIndex = 20
        Me.LabelShieldP1.Text = "Label21"
        Me.LabelShieldP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTotalP1
        '
        Me.LabelTotalP1.AutoSize = True
        Me.LabelTotalP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelTotalP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalP1.Location = New System.Drawing.Point(185, 280)
        Me.LabelTotalP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTotalP1.Name = "LabelTotalP1"
        Me.LabelTotalP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelTotalP1.TabIndex = 21
        Me.LabelTotalP1.Text = "Label22"
        Me.LabelTotalP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMilitaryVictoryP1
        '
        Me.LabelMilitaryVictoryP1.AutoSize = True
        Me.LabelMilitaryVictoryP1.BackColor = System.Drawing.Color.IndianRed
        Me.LabelMilitaryVictoryP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelMilitaryVictoryP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMilitaryVictoryP1.Location = New System.Drawing.Point(185, 311)
        Me.LabelMilitaryVictoryP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelMilitaryVictoryP1.Name = "LabelMilitaryVictoryP1"
        Me.LabelMilitaryVictoryP1.Size = New System.Drawing.Size(191, 30)
        Me.LabelMilitaryVictoryP1.TabIndex = 22
        Me.LabelMilitaryVictoryP1.Text = "Label23"
        Me.LabelMilitaryVictoryP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelScientificVictoryP1
        '
        Me.LabelScientificVictoryP1.AutoSize = True
        Me.LabelScientificVictoryP1.BackColor = System.Drawing.Color.YellowGreen
        Me.LabelScientificVictoryP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelScientificVictoryP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScientificVictoryP1.Location = New System.Drawing.Point(185, 342)
        Me.LabelScientificVictoryP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelScientificVictoryP1.Name = "LabelScientificVictoryP1"
        Me.LabelScientificVictoryP1.Size = New System.Drawing.Size(191, 38)
        Me.LabelScientificVictoryP1.TabIndex = 23
        Me.LabelScientificVictoryP1.Text = "Label24"
        Me.LabelScientificVictoryP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNameP2
        '
        Me.LabelNameP2.AutoSize = True
        Me.LabelNameP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNameP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameP2.Location = New System.Drawing.Point(377, 1)
        Me.LabelNameP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNameP2.Name = "LabelNameP2"
        Me.LabelNameP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelNameP2.TabIndex = 24
        Me.LabelNameP2.Text = "Label25"
        Me.LabelNameP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelBlueP2
        '
        Me.LabelBlueP2.AutoSize = True
        Me.LabelBlueP2.BackColor = System.Drawing.Color.SkyBlue
        Me.LabelBlueP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelBlueP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBlueP2.Location = New System.Drawing.Point(377, 32)
        Me.LabelBlueP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelBlueP2.Name = "LabelBlueP2"
        Me.LabelBlueP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelBlueP2.TabIndex = 25
        Me.LabelBlueP2.Text = "Label26"
        Me.LabelBlueP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelGreenP2
        '
        Me.LabelGreenP2.AutoSize = True
        Me.LabelGreenP2.BackColor = System.Drawing.Color.PaleGreen
        Me.LabelGreenP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelGreenP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGreenP2.Location = New System.Drawing.Point(377, 63)
        Me.LabelGreenP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelGreenP2.Name = "LabelGreenP2"
        Me.LabelGreenP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelGreenP2.TabIndex = 26
        Me.LabelGreenP2.Text = "Label27"
        Me.LabelGreenP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelYellowP2
        '
        Me.LabelYellowP2.AutoSize = True
        Me.LabelYellowP2.BackColor = System.Drawing.Color.LemonChiffon
        Me.LabelYellowP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelYellowP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelYellowP2.Location = New System.Drawing.Point(377, 94)
        Me.LabelYellowP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelYellowP2.Name = "LabelYellowP2"
        Me.LabelYellowP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelYellowP2.TabIndex = 27
        Me.LabelYellowP2.Text = "Label28"
        Me.LabelYellowP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPurpleP2
        '
        Me.LabelPurpleP2.AutoSize = True
        Me.LabelPurpleP2.BackColor = System.Drawing.Color.Lavender
        Me.LabelPurpleP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPurpleP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPurpleP2.Location = New System.Drawing.Point(377, 125)
        Me.LabelPurpleP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPurpleP2.Name = "LabelPurpleP2"
        Me.LabelPurpleP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelPurpleP2.TabIndex = 28
        Me.LabelPurpleP2.Text = "Label29"
        Me.LabelPurpleP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMarvelP2
        '
        Me.LabelMarvelP2.AutoSize = True
        Me.LabelMarvelP2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabelMarvelP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelMarvelP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMarvelP2.Location = New System.Drawing.Point(377, 156)
        Me.LabelMarvelP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelMarvelP2.Name = "LabelMarvelP2"
        Me.LabelMarvelP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelMarvelP2.TabIndex = 29
        Me.LabelMarvelP2.Text = "Label30"
        Me.LabelMarvelP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelScienceP2
        '
        Me.LabelScienceP2.AutoSize = True
        Me.LabelScienceP2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LabelScienceP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelScienceP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScienceP2.Location = New System.Drawing.Point(377, 187)
        Me.LabelScienceP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelScienceP2.Name = "LabelScienceP2"
        Me.LabelScienceP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelScienceP2.TabIndex = 30
        Me.LabelScienceP2.Text = "Label31"
        Me.LabelScienceP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelGoldP2
        '
        Me.LabelGoldP2.AutoSize = True
        Me.LabelGoldP2.BackColor = System.Drawing.Color.Moccasin
        Me.LabelGoldP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelGoldP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGoldP2.Location = New System.Drawing.Point(377, 218)
        Me.LabelGoldP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelGoldP2.Name = "LabelGoldP2"
        Me.LabelGoldP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelGoldP2.TabIndex = 31
        Me.LabelGoldP2.Text = "Label32"
        Me.LabelGoldP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelShieldP2
        '
        Me.LabelShieldP2.AutoSize = True
        Me.LabelShieldP2.BackColor = System.Drawing.Color.LightSalmon
        Me.LabelShieldP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelShieldP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelShieldP2.Location = New System.Drawing.Point(377, 249)
        Me.LabelShieldP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelShieldP2.Name = "LabelShieldP2"
        Me.LabelShieldP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelShieldP2.TabIndex = 32
        Me.LabelShieldP2.Text = "Label33"
        Me.LabelShieldP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTotalP2
        '
        Me.LabelTotalP2.AutoSize = True
        Me.LabelTotalP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelTotalP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalP2.Location = New System.Drawing.Point(377, 280)
        Me.LabelTotalP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTotalP2.Name = "LabelTotalP2"
        Me.LabelTotalP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelTotalP2.TabIndex = 33
        Me.LabelTotalP2.Text = "Label34"
        Me.LabelTotalP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMilitaryVictoryP2
        '
        Me.LabelMilitaryVictoryP2.AutoSize = True
        Me.LabelMilitaryVictoryP2.BackColor = System.Drawing.Color.IndianRed
        Me.LabelMilitaryVictoryP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelMilitaryVictoryP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMilitaryVictoryP2.Location = New System.Drawing.Point(377, 311)
        Me.LabelMilitaryVictoryP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelMilitaryVictoryP2.Name = "LabelMilitaryVictoryP2"
        Me.LabelMilitaryVictoryP2.Size = New System.Drawing.Size(191, 30)
        Me.LabelMilitaryVictoryP2.TabIndex = 34
        Me.LabelMilitaryVictoryP2.Text = "Label35"
        Me.LabelMilitaryVictoryP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelScientificVictoryP2
        '
        Me.LabelScientificVictoryP2.AutoSize = True
        Me.LabelScientificVictoryP2.BackColor = System.Drawing.Color.YellowGreen
        Me.LabelScientificVictoryP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelScientificVictoryP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScientificVictoryP2.Location = New System.Drawing.Point(377, 342)
        Me.LabelScientificVictoryP2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelScientificVictoryP2.Name = "LabelScientificVictoryP2"
        Me.LabelScientificVictoryP2.Size = New System.Drawing.Size(191, 38)
        Me.LabelScientificVictoryP2.TabIndex = 35
        Me.LabelScientificVictoryP2.Text = "Label36"
        Me.LabelScientificVictoryP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EndGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 507)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "EndGame"
        Me.Text = "Not7Wonders"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ButtonQuit As Button
    Friend WithEvents LabelWinnerName As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelNameP1 As Label
    Friend WithEvents LabelBlueP1 As Label
    Friend WithEvents LabelGreenP1 As Label
    Friend WithEvents LabelYellowP1 As Label
    Friend WithEvents LabelPurpleP1 As Label
    Friend WithEvents LabelMarvelP1 As Label
    Friend WithEvents LabelScienceP1 As Label
    Friend WithEvents LabelGoldP1 As Label
    Friend WithEvents LabelShieldP1 As Label
    Friend WithEvents LabelTotalP1 As Label
    Friend WithEvents LabelMilitaryVictoryP1 As Label
    Friend WithEvents LabelScientificVictoryP1 As Label
    Friend WithEvents LabelNameP2 As Label
    Friend WithEvents LabelBlueP2 As Label
    Friend WithEvents LabelGreenP2 As Label
    Friend WithEvents LabelYellowP2 As Label
    Friend WithEvents LabelPurpleP2 As Label
    Friend WithEvents LabelMarvelP2 As Label
    Friend WithEvents LabelScienceP2 As Label
    Friend WithEvents LabelGoldP2 As Label
    Friend WithEvents LabelShieldP2 As Label
    Friend WithEvents LabelTotalP2 As Label
    Friend WithEvents LabelMilitaryVictoryP2 As Label
    Friend WithEvents LabelScientificVictoryP2 As Label
End Class
