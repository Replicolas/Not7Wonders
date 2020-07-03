Public Class BuildingCardPlayerBoardUC

    Private _BuildingCard As BuildingCard

    Public Sub New(ByVal BuildingCard As BuildingCard)

        InitializeComponent()
        _BuildingCard = BuildingCard
        FillCard()

    End Sub

    Private Sub FillCard()

        If _BuildingCard.Color = BuildingCard.CardColor.Brown Then
            FLP_Gains.BackColor = Color.SaddleBrown
            If _BuildingCard.ClayGain = 1 Then
                FLP_Gains.Controls.Add(New ClayGainIcon)
            ElseIf _BuildingCard.ClayGain = 2 Then
                FLP_Gains.Controls.Add(New ClayGainIcon)
                FLP_Gains.Controls.Add(New ClayGainIcon)
            ElseIf _BuildingCard.WoodGain = 1 Then
                FLP_Gains.Controls.Add(New WoodGainIcon)
            ElseIf _BuildingCard.WoodGain = 2 Then
                FLP_Gains.Controls.Add(New WoodGainIcon)
                FLP_Gains.Controls.Add(New WoodGainIcon)
            ElseIf _BuildingCard.StoneGain = 1 Then
                FLP_Gains.Controls.Add(New StoneGainIcon)
            ElseIf _BuildingCard.StoneGain = 2 Then
                FLP_Gains.Controls.Add(New StoneGainIcon)
                FLP_Gains.Controls.Add(New StoneGainIcon)
            End If
        ElseIf _BuildingCard.Color = BuildingCard.CardColor.Gray Then
            FLP_Gains.BackColor = Color.Gray
            If _BuildingCard.GlassGain = 1 Then
                FLP_Gains.Controls.Add(New GlassGainIcon)
            ElseIf _BuildingCard.PaperGain = 1 Then
                FLP_Gains.Controls.Add(New PaperGainIcon)
            End If
        ElseIf _BuildingCard.Color = BuildingCard.CardColor.Red Then
            FLP_Gains.BackColor = Color.Red
            If _BuildingCard.ShieldGain = 1 Then
                FLP_Gains.Controls.Add(New ShieldGainIcon)
            ElseIf _BuildingCard.ShieldGain = 2 Then
                FLP_Gains.Controls.Add(New ShieldGainIcon)
                FLP_Gains.Controls.Add(New ShieldGainIcon)
            ElseIf _BuildingCard.ShieldGain = 3 Then
                FLP_Gains.Controls.Add(New ShieldGainIcon)
                FLP_Gains.Controls.Add(New ShieldGainIcon)
                FLP_Gains.Controls.Add(New ShieldGainIcon)
            End If
        ElseIf _BuildingCard.Color = BuildingCard.CardColor.Blue Then
            FLP_Gains.BackColor = Color.DodgerBlue
            If Not _BuildingCard.VictoryGain = 0 Then
                Dim Victory As New VictoryGainIcon
                FLP_Gains.Controls.Add(Victory)
                Victory.Label.Text = _BuildingCard.VictoryGain
            End If
        ElseIf _BuildingCard.Color = BuildingCard.CardColor.Green Then
            FLP_Gains.BackColor = Color.Green
            If Not _BuildingCard.VictoryGain = 0 Then
                Dim Victory As New VictoryGainIcon
                FLP_Gains.Controls.Add(Victory)
                Victory.Label.Text = _BuildingCard.VictoryGain
            End If
            If _BuildingCard.ItemGain = BuildingCard.Item.None Then
            ElseIf _BuildingCard.ItemGain = BuildingCard.Item.Balance Then
                FLP_Gains.Controls.Add(New BalanceIcon)
            ElseIf _BuildingCard.ItemGain = BuildingCard.Item.Globe Then
                FLP_Gains.Controls.Add(New GlobeIcon)
            ElseIf _BuildingCard.ItemGain = BuildingCard.Item.Mortar Then
                FLP_Gains.Controls.Add(New MortarIcon)
            ElseIf _BuildingCard.ItemGain = BuildingCard.Item.Pendulum Then
                FLP_Gains.Controls.Add(New PendulumIcon)
            ElseIf _BuildingCard.ItemGain = BuildingCard.Item.Sundial Then
                FLP_Gains.Controls.Add(New SundialIcon)
            ElseIf _BuildingCard.ItemGain = BuildingCard.Item.Wheel Then
                FLP_Gains.Controls.Add(New WheelIcon)
            End If
        ElseIf _BuildingCard.Color = BuildingCard.CardColor.Yellow Then
            FLP_Gains.BackColor = Color.Gold
            If Not _BuildingCard.VictoryGain = 0 Then
                Dim Victory As New VictoryGainIcon
                FLP_Gains.Controls.Add(Victory)
                Victory.Label.Text = _BuildingCard.VictoryGain
            End If
            If _BuildingCard.StoneRuleUpdate = True Then
                FLP_Gains.Controls.Add(New StoneRuleUpdateIcon)
            ElseIf _BuildingCard.ClayRuleUpdate = True Then
                FLP_Gains.Controls.Add(New ClayRuleUpdateIcon)
            ElseIf _BuildingCard.WoodRuleUpdate = True Then
                FLP_Gains.Controls.Add(New WoodRuleUpdateIcon)
            ElseIf _BuildingCard.DoubleGain = True Then
                FLP_Gains.Controls.Add(New GlassPaperGainIcon)
            ElseIf _BuildingCard.TripleGain = True Then
                FLP_Gains.Controls.Add(New ClayStoneWoodGainIcon)
            ElseIf _BuildingCard.PaperGlassRuleUpdate = True Then
                FLP_Gains.Controls.Add(New PaperGlassRuleUpdateIcon)
            ElseIf _BuildingCard.GrayCardGoldGain = True Then
                FLP_Gains.Controls.Add(New GreyCardGoldGainIcon)
            ElseIf _BuildingCard.BrownCardGoldGain = True Then
                FLP_Gains.Controls.Add(New BrownCardGoldGainIcon)
            ElseIf _BuildingCard.RedCardGoldGain = True Then
                FLP_Gains.Controls.Add(New RedCardGoldGainIcon)
            ElseIf _BuildingCard.YellowCardGoldGain = True Then
                FLP_Gains.Controls.Add(New YellowCardGoldGainIcon)
            ElseIf _BuildingCard.MarvelGoldGain = True Then
                FLP_Gains.Controls.Add(New MarvelGoldGainIcon)
            ElseIf Not _BuildingCard.GoldGain = 0 Then
                Dim Gold As New GoldGainIcon
                FLP_Gains.Controls.Add(Gold)
                Gold.Label.Text = _BuildingCard.GoldGain
            End If
        ElseIf _BuildingCard.Color = BuildingCard.CardColor.Purple Then
            FLP_Gains.BackColor = Color.Purple
            If _BuildingCard.YellowCardGoldVictoryGain = True Then
                FLP_Gains.Controls.Add(New YellowCardGoldVictoryGainIcon)
            ElseIf _BuildingCard.GrayBrownCardGoldVictoryGain = True Then
                FLP_Gains.Controls.Add(New GreyBrownCardGoldVictoryGainIcon)
            ElseIf _BuildingCard.MarvelVictoryGain = True Then
                FLP_Gains.Controls.Add(New MarvelVictoryGainIcon)
            ElseIf _BuildingCard.BlueCardGoldVictoryGain = True Then
                FLP_Gains.Controls.Add(New BlueCardGoldVictoryGainIcon)
            ElseIf _BuildingCard.GreenCardGoldVictoryGain = True Then
                FLP_Gains.Controls.Add(New GreenCardGoldVictoryGainIcon)
            ElseIf _BuildingCard.GoldVictoryGain = True Then
                FLP_Gains.Controls.Add(New GoldVictoryGainIcon)
            ElseIf _BuildingCard.RedCardGoldVictoryGain = True Then
                FLP_Gains.Controls.Add(New RedCardGoldVictoryGainIcon)
            End If
        End If

    End Sub

End Class
