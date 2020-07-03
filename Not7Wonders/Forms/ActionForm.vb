Imports System.Diagnostics.Eventing.Reader

Public Class ActionForm

    Private ReadOnly _Card As BuildingCard
    Private ReadOnly _CardUC As BuildingCardBoardUC
    Private Property _SellGoldCost As Integer
    Private Property _BuyGoldCost As Integer
    Private ReadOnly _Board As Board

    Public Sub New(ByVal Card As BuildingCard, ByVal CardUc As BuildingCardBoardUC, ByVal Board As Board)

        InitializeComponent()
        _Card = Card
        _CardUC = CardUc
        _Board = Board
        Dim DisplayedCard As New BuildingCardBoardUC(_Card, BuildingCardBoardUC.LocationType.WindowDisplay, BuildingCardBoardUC.VisibilityType.Visible, Nothing, Nothing)
        PanelCard.Controls.Add(DisplayedCard)
        DisplayedCard.Top = PanelCard.Height / 2 - DisplayedCard.Height / 2
        DisplayedCard.Left = PanelCard.Width / 2 - DisplayedCard.Width / 2
        CheckBuild()
        CheckSell()
        CheckMarvel()

    End Sub

    Private Sub CheckBuild()

        Dim BuildingCost As Integer
        If _ActivePlayer.ListOfSymbols.Contains(_Card.Name) Then
            BuildingCost = 0
        Else
            BuildingCost = GetTotalRessourceCost(_Card) + _Card.GoldCost
            ButtonBuild.Text = "Construire " & _Card.Name & " pour " & BuildingCost & " pièces."
            If BuildingCost > _ActivePlayer.GoldCount Then
                ButtonBuild.Enabled = False
            Else
                ButtonBuild.BackColor = Color.LightGreen
                ButtonBuild.Enabled = True
            End If
        End If
        _BuyGoldCost = BuildingCost

    End Sub

    Private Sub CheckSell()

        If _ActivePlayer.ListOfCards Is Nothing Then
            _SellGoldCost = 2
        Else
            Dim ListOfYellowCards As New List(Of BuildingCard)
            For Each Card As BuildingCard In _ActivePlayer.ListOfCards
                If Card.Color = BuildingCard.CardColor.Yellow Then
                    ListOfYellowCards.Add(Card)
                End If
            Next
            Dim YellowCardCount As Integer = ListOfYellowCards.Count
            _SellGoldCost = 2 + YellowCardCount
        End If
        ButtonSell.Text = "Vendre la carte pour " & _SellGoldCost & " pièces."
        ButtonSell.BackColor = Color.LightGreen

    End Sub

    Private Sub CheckMarvel()

        Dim MarvelNumber As Integer = _ActivePlayer.ListOfMarvels.Count + _InactivePlayer.ListOfMarvels.Count
        If Not MarvelNumber = 7 Then

            Dim Marvel1Cost As Integer = GetTotalRessourceCost(_ActivePlayer.ListOfMarvels.Item(0))
            ButtonMarvel1.Text = "Acheter " & _ActivePlayer.ListOfMarvels.Item(0).Name & " pour " & Marvel1Cost & " pièces."
            If Marvel1Cost > _ActivePlayer.GoldCount Then
                ButtonMarvel1.Enabled = False
            Else
                ButtonMarvel1.BackColor = Color.LightGreen
                ButtonMarvel1.Enabled = True
            End If

            Dim Marvel2Cost As Integer = GetTotalRessourceCost(_ActivePlayer.ListOfMarvels.Item(1))
            ButtonMarvel2.Text = "Acheter " & _ActivePlayer.ListOfMarvels.Item(1).Name & " pour " & Marvel2Cost & " pièces."
            If Marvel2Cost > _ActivePlayer.GoldCount Then
                ButtonMarvel2.Enabled = False
            Else
                ButtonMarvel2.BackColor = Color.LightGreen
                ButtonMarvel2.Enabled = True
            End If

            Dim Marvel3Cost As Integer = GetTotalRessourceCost(_ActivePlayer.ListOfMarvels.Item(2))
            ButtonMarvel3.Text = "Acheter " & _ActivePlayer.ListOfMarvels.Item(2).Name & " pour " & Marvel3Cost & " pièces."
            If Marvel3Cost > _ActivePlayer.GoldCount Then
                ButtonMarvel3.Enabled = False
            Else
                ButtonMarvel3.BackColor = Color.LightGreen
                ButtonMarvel3.Enabled = True
            End If

            Dim Marvel4Cost As Integer = GetTotalRessourceCost(_ActivePlayer.ListOfMarvels.Item(3))
            ButtonMarvel4.Text = "Acheter " & _ActivePlayer.ListOfMarvels.Item(3).Name & " pour " & Marvel4Cost & " pièces."
            If Marvel4Cost > _ActivePlayer.GoldCount Then
                ButtonMarvel4.Enabled = False
            Else
                ButtonMarvel4.BackColor = Color.LightGreen
                ButtonMarvel4.Enabled = True
            End If

        Else
            ButtonMarvel1.Enabled = False
            ButtonMarvel2.Enabled = False
            ButtonMarvel3.Enabled = False
            ButtonMarvel4.Enabled = False

        End If

    End Sub

    Private Sub ButtonBuild_Click(sender As Object, e As EventArgs) Handles ButtonBuild.Click

        _ActivePlayer.ListOfCards.Add(_Card)

        If _Card.Color = BuildingCard.CardColor.Brown Then
            _ActivePlayer.BrownCardCount += 1
        ElseIf _Card.Color = BuildingCard.CardColor.Gray Then
            _ActivePlayer.GrayCardCount += 1
        ElseIf _Card.Color = BuildingCard.CardColor.Red Then
            _ActivePlayer.RedCardCount += 1
        ElseIf _Card.Color = BuildingCard.CardColor.Blue Then
            _ActivePlayer.BlueCardCount += 1
        ElseIf _Card.Color = BuildingCard.CardColor.Green Then
            _ActivePlayer.GreenCardCount += 1
        ElseIf _Card.Color = BuildingCard.CardColor.Yellow Then
            _ActivePlayer.YellowCardCount += 1
        ElseIf _Card.Color = BuildingCard.CardColor.Purple Then
            _ActivePlayer.PurpleCardCount += 1
        End If

        'Payer prix de la carte
        _ActivePlayer.GoldCount -= _BuyGoldCost

        'Récupérer les ressources de la carte
        _ActivePlayer.GoldCount += _Card.GoldGain
        _ActivePlayer.WoodCount += _Card.WoodGain
        _ActivePlayer.ClayCount += _Card.ClayGain
        _ActivePlayer.StoneCount += _Card.StoneGain
        _ActivePlayer.GlassCount += _Card.GlassGain
        _ActivePlayer.PaperCount += _Card.PaperGain

        'Points militaires
        If _ActivePlayer.Position = 1 Then
            _MilitaryProgress += _Card.ShieldGain
        ElseIf _ActivePlayer.Position = 2 Then
            _MilitaryProgress -= _Card.ShieldGain
        End If

        'récupération des symboles
        _ActivePlayer.ListOfSymbols.Add(_Card.SymbolGain.ToString)

        'Récupération des items
        If Not _Card.ItemGain = Nothing Then
            If _ActivePlayer.ListOfItems.Contains(_Card.ItemGain.ToString) Then
                Dim ChooseScienceCoin = New SciencePick(SciencePick.ScienceDeckType.Played)
                ChooseScienceCoin.Show()
            Else
                _ActivePlayer.ListOfItems.Add(_Card.ItemGain.ToString)
            End If
        End If

        'Si Carte Jaune
        _ActivePlayer.WoodRule = _Card.WoodRuleUpdate
        _ActivePlayer.ClayRule = _Card.ClayRuleUpdate
        _ActivePlayer.StoneRule = _Card.StoneRuleUpdate
        _ActivePlayer.GlassPaperRule = _Card.PaperGlassRuleUpdate
        If _Card.TripleGain = True Then
            _ActivePlayer.TripleCardCount += 1
        End If
        If _Card.DoubleGain = True Then
            _ActivePlayer.DoubleCardCount += 1
        End If
        If _Card.MarvelGoldGain = True Then
            _ActivePlayer.GoldCount += 2 * _ActivePlayer.CompletedMarvelsCount
        End If
        If _Card.RedCardGoldGain = True Then
            _ActivePlayer.GoldCount += 1 * _ActivePlayer.RedCardCount
        End If
        If _Card.GrayCardGoldGain = True Then
            _ActivePlayer.GoldCount += 3 * _ActivePlayer.GrayCardCount
        End If
        If _Card.YellowCardGoldGain = True Then
            _ActivePlayer.GoldCount += 1 * _ActivePlayer.YellowCardCount
        End If
        If _Card.BrownCardGoldGain = True Then
            _ActivePlayer.GoldCount += 2 * _ActivePlayer.BrownCardCount
        End If

        'Si Carte Violette
        _ActivePlayer.MarvelVictoryGain = _Card.MarvelVictoryGain
        _ActivePlayer.RedCardGoldVictoryGain = _Card.RedCardGoldVictoryGain
        _ActivePlayer.GrayBrownCardGoldVictoryGain = _Card.GrayBrownCardGoldVictoryGain
        _ActivePlayer.YellowCardGoldVictoryGain = _Card.YellowCardGoldVictoryGain
        _ActivePlayer.GreenCardGoldVictoryGain = _Card.GreenCardGoldVictoryGain
        _ActivePlayer.BlueCardGoldVictoryGain = _Card.BlueCardGoldVictoryGain
        _ActivePlayer.GoldVictoryGain = _Card.GoldVictoryGain

        If _Card.GrayBrownCardGoldVictoryGain = True Then
            Dim TempList As New List(Of Integer)
            TempList.AddRange({_ActivePlayer.GrayCardCount + _ActivePlayer.BrownCardCount, _InactivePlayer.GrayCardCount + _InactivePlayer.BrownCardCount})
            Dim BestOfPlayers As Integer = TempList.Max
            _ActivePlayer.GoldCount += BestOfPlayers
        End If
        If _Card.YellowCardGoldVictoryGain = True Then
            Dim TempList As New List(Of Integer)
            TempList.AddRange({_ActivePlayer.YellowCardCount, _InactivePlayer.YellowCardCount})
            Dim BestOfPlayers As Integer = TempList.Max
            _ActivePlayer.GoldCount += BestOfPlayers
        End If
        If _Card.BlueCardGoldVictoryGain = True Then
            Dim TempList As New List(Of Integer)
            TempList.AddRange({_ActivePlayer.BlueCardCount, _InactivePlayer.BlueCardCount})
            Dim BestOfPlayers As Integer = TempList.Max
            _ActivePlayer.GoldCount += BestOfPlayers
        End If
        If _Card.RedCardGoldVictoryGain = True Then
            Dim TempList As New List(Of Integer)
            TempList.AddRange({_ActivePlayer.RedCardCount, _InactivePlayer.RedCardCount})
            Dim BestOfPlayers As Integer = TempList.Max
            _ActivePlayer.GoldCount += BestOfPlayers
        End If
        If _Card.GreenCardGoldVictoryGain = True Then
            Dim TempList As New List(Of Integer)
            TempList.AddRange({_ActivePlayer.GreenCardCount, _InactivePlayer.GreenCardCount})
            Dim BestOfPlayers As Integer = TempList.Max
            _ActivePlayer.GoldCount += BestOfPlayers
        End If

        NextTurn()

    End Sub

    Private Sub ButtonSell_Click(sender As Object, e As EventArgs) Handles ButtonSell.Click

        _ActivePlayer.GoldCount += _SellGoldCost
        _ListOfSoldBuildingCards.Add(_Card)
        NextTurn()

    End Sub

    Private Sub ButtonMarvel1_Click(sender As Object, e As EventArgs) Handles ButtonMarvel1.Click

        MarvelBuild(_ActivePlayer.ListOfMarvels.Item(0))
        NextTurn()

    End Sub

    Private Sub ButtonMarvel2_Click(sender As Object, e As EventArgs) Handles ButtonMarvel2.Click

        MarvelBuild(_ActivePlayer.ListOfMarvels.Item(1))
        NextTurn()

    End Sub

    Private Sub ButtonMarvel3_Click(sender As Object, e As EventArgs) Handles ButtonMarvel3.Click

        MarvelBuild(_ActivePlayer.ListOfMarvels.Item(2))
        NextTurn()

    End Sub

    Private Sub ButtonMarvel4_Click(sender As Object, e As EventArgs) Handles ButtonMarvel4.Click

        MarvelBuild(_ActivePlayer.ListOfMarvels.Item(3))
        NextTurn()

    End Sub

    Private Function GetTotalRessourceCost(ByVal Marvel As MarvelCard)

        Dim WoodClayStoneForMarvel As Integer
        If _ActivePlayer.TripleCardCount = 0 Then
            Dim WoodCostForMarvel0 As Integer = GetRessourceCost(Marvel.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel0 As Integer = GetRessourceCost(Marvel.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel0 As Integer = GetRessourceCost(Marvel.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel0 As Integer = WoodCostForMarvel0 + ClayCostForMarvel0 + StoneCostForMarvel0
            WoodClayStoneForMarvel = WoodClayStoneForMarvel0
        ElseIf _ActivePlayer.TripleCardCount = 1 Then
            Dim WoodCostForMarvel1 As Integer = GetRessourceCost(Marvel.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel1 As Integer = GetRessourceCost(Marvel.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel1 As Integer = GetRessourceCost(Marvel.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel1 As Integer = WoodCostForMarvel1 + ClayCostForMarvel1 + StoneCostForMarvel1
            Dim WoodCostForMarvel2 As Integer = GetRessourceCost(Marvel.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel2 As Integer = GetRessourceCost(Marvel.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel2 As Integer = GetRessourceCost(Marvel.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel2 As Integer = WoodCostForMarvel2 + ClayCostForMarvel2 + StoneCostForMarvel2
            Dim WoodCostForMarvel3 As Integer = GetRessourceCost(Marvel.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel3 As Integer = GetRessourceCost(Marvel.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel3 As Integer = GetRessourceCost(Marvel.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel3 As Integer = WoodCostForMarvel3 + ClayCostForMarvel3 + StoneCostForMarvel3
            Dim TempList As New List(Of Integer)
            TempList.AddRange({WoodClayStoneForMarvel1, WoodClayStoneForMarvel2, WoodClayStoneForMarvel3})
            WoodClayStoneForMarvel = TempList.Min
        ElseIf _ActivePlayer.TripleCardCount = 2 Then
            Dim WoodCostForMarvel1 As Integer = GetRessourceCost(Marvel.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel1 As Integer = GetRessourceCost(Marvel.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel1 As Integer = GetRessourceCost(Marvel.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel1 As Integer = WoodCostForMarvel1 + ClayCostForMarvel1 + StoneCostForMarvel1
            Dim WoodCostForMarvel2 As Integer = GetRessourceCost(Marvel.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel2 As Integer = GetRessourceCost(Marvel.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel2 As Integer = GetRessourceCost(Marvel.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel2 As Integer = WoodCostForMarvel2 + ClayCostForMarvel2 + StoneCostForMarvel2
            Dim WoodCostForMarvel3 As Integer = GetRessourceCost(Marvel.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel3 As Integer = GetRessourceCost(Marvel.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel3 As Integer = GetRessourceCost(Marvel.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel3 As Integer = WoodCostForMarvel3 + ClayCostForMarvel3 + StoneCostForMarvel3
            Dim WoodCostForMarvel4 As Integer = GetRessourceCost(Marvel.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel4 As Integer = GetRessourceCost(Marvel.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel4 As Integer = GetRessourceCost(Marvel.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel4 As Integer = WoodCostForMarvel4 + ClayCostForMarvel4 + StoneCostForMarvel4
            Dim WoodCostForMarvel5 As Integer = GetRessourceCost(Marvel.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel5 As Integer = GetRessourceCost(Marvel.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel5 As Integer = GetRessourceCost(Marvel.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel5 As Integer = WoodCostForMarvel5 + ClayCostForMarvel5 + StoneCostForMarvel5
            Dim WoodCostForMarvel6 As Integer = GetRessourceCost(Marvel.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel6 As Integer = GetRessourceCost(Marvel.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel6 As Integer = GetRessourceCost(Marvel.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel6 As Integer = WoodCostForMarvel6 + ClayCostForMarvel6 + StoneCostForMarvel6
            Dim TempList As New List(Of Integer)
            TempList.AddRange({WoodClayStoneForMarvel1, WoodClayStoneForMarvel2, WoodClayStoneForMarvel3, WoodClayStoneForMarvel4, WoodClayStoneForMarvel5, WoodClayStoneForMarvel6})
            WoodClayStoneForMarvel = TempList.Min
        End If

        Dim GlassPaperForMarvel As Integer
        If _ActivePlayer.DoubleCardCount = 0 Then
            Dim GlassForMarvel0 As Integer = GetRessourceCost(Marvel.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel0 As Integer = GetRessourceCost(Marvel.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel0 As Integer = GlassForMarvel0 + PaperForMarvel0
            GlassPaperForMarvel = GlassPaperForMarvel0
        ElseIf _ActivePlayer.DoubleCardCount = 1 Then
            Dim GlassForMarvel1 As Integer = GetRessourceCost(Marvel.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel1 As Integer = GetRessourceCost(Marvel.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel1 As Integer = GlassForMarvel1 + PaperForMarvel1
            Dim GlassForMarvel2 As Integer = GetRessourceCost(Marvel.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel2 As Integer = GetRessourceCost(Marvel.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel2 As Integer = GlassForMarvel2 + PaperForMarvel2
            Dim TempList As New List(Of Integer)
            TempList.AddRange({GlassPaperForMarvel1, GlassPaperForMarvel2})
            GlassPaperForMarvel = TempList.Min
        ElseIf _ActivePlayer.DoubleCardCount = 2 Then
            Dim GlassForMarvel1 As Integer = GetRessourceCost(Marvel.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel1 As Integer = GetRessourceCost(Marvel.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel1 As Integer = GlassForMarvel1 + PaperForMarvel1
            Dim GlassForMarvel2 As Integer = GetRessourceCost(Marvel.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel2 As Integer = GetRessourceCost(Marvel.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel2 As Integer = GlassForMarvel2 + PaperForMarvel2
            Dim GlassForMarvel3 As Integer = GetRessourceCost(Marvel.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel3 As Integer = GetRessourceCost(Marvel.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel3 As Integer = GlassForMarvel3 + PaperForMarvel3
            Dim TempList As New List(Of Integer)
            TempList.AddRange({GlassPaperForMarvel1, GlassPaperForMarvel2, GlassPaperForMarvel3})
            GlassPaperForMarvel = TempList.Min
        End If

        Dim TotalCost As Integer = WoodClayStoneForMarvel + GlassPaperForMarvel
        Return TotalCost

    End Function

    Private Function GetTotalRessourceCost(ByVal Building As BuildingCard)

        Dim WoodClayStoneForMarvel As Integer
        If _ActivePlayer.TripleCardCount = 0 Then
            Dim WoodCostForMarvel0 As Integer = GetRessourceCost(Building.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel0 As Integer = GetRessourceCost(Building.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel0 As Integer = GetRessourceCost(Building.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel0 As Integer = WoodCostForMarvel0 + ClayCostForMarvel0 + StoneCostForMarvel0
            WoodClayStoneForMarvel = WoodClayStoneForMarvel0
        ElseIf _ActivePlayer.TripleCardCount = 1 Then
            Dim WoodCostForMarvel1 As Integer = GetRessourceCost(Building.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel1 As Integer = GetRessourceCost(Building.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel1 As Integer = GetRessourceCost(Building.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel1 As Integer = WoodCostForMarvel1 + ClayCostForMarvel1 + StoneCostForMarvel1
            Dim WoodCostForMarvel2 As Integer = GetRessourceCost(Building.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel2 As Integer = GetRessourceCost(Building.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel2 As Integer = GetRessourceCost(Building.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel2 As Integer = WoodCostForMarvel2 + ClayCostForMarvel2 + StoneCostForMarvel2
            Dim WoodCostForMarvel3 As Integer = GetRessourceCost(Building.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel3 As Integer = GetRessourceCost(Building.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel3 As Integer = GetRessourceCost(Building.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel3 As Integer = WoodCostForMarvel3 + ClayCostForMarvel3 + StoneCostForMarvel3
            Dim TempList As New List(Of Integer)
            TempList.AddRange({WoodClayStoneForMarvel1, WoodClayStoneForMarvel2, WoodClayStoneForMarvel3})
            WoodClayStoneForMarvel = TempList.Min
        ElseIf _ActivePlayer.TripleCardCount = 2 Then
            Dim WoodCostForMarvel1 As Integer = GetRessourceCost(Building.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel1 As Integer = GetRessourceCost(Building.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel1 As Integer = GetRessourceCost(Building.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel1 As Integer = WoodCostForMarvel1 + ClayCostForMarvel1 + StoneCostForMarvel1
            Dim WoodCostForMarvel2 As Integer = GetRessourceCost(Building.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel2 As Integer = GetRessourceCost(Building.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel2 As Integer = GetRessourceCost(Building.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel2 As Integer = WoodCostForMarvel2 + ClayCostForMarvel2 + StoneCostForMarvel2
            Dim WoodCostForMarvel3 As Integer = GetRessourceCost(Building.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel3 As Integer = GetRessourceCost(Building.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel3 As Integer = GetRessourceCost(Building.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel3 As Integer = WoodCostForMarvel3 + ClayCostForMarvel3 + StoneCostForMarvel3
            Dim WoodCostForMarvel4 As Integer = GetRessourceCost(Building.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel4 As Integer = GetRessourceCost(Building.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel4 As Integer = GetRessourceCost(Building.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel4 As Integer = WoodCostForMarvel4 + ClayCostForMarvel4 + StoneCostForMarvel4
            Dim WoodCostForMarvel5 As Integer = GetRessourceCost(Building.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel5 As Integer = GetRessourceCost(Building.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel5 As Integer = GetRessourceCost(Building.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel5 As Integer = WoodCostForMarvel5 + ClayCostForMarvel5 + StoneCostForMarvel5
            Dim WoodCostForMarvel6 As Integer = GetRessourceCost(Building.WoodCost, _ActivePlayer.WoodRule, _ActivePlayer.WoodCount, _InactivePlayer.WoodCount, _ActivePlayer.TripleCardCount)
            Dim ClayCostForMarvel6 As Integer = GetRessourceCost(Building.ClayCost, _ActivePlayer.ClayRule, _ActivePlayer.ClayCount, _InactivePlayer.ClayCount, _ActivePlayer.TripleCardCount)
            Dim StoneCostForMarvel6 As Integer = GetRessourceCost(Building.StoneCost, _ActivePlayer.StoneRule, _ActivePlayer.StoneCount, _InactivePlayer.StoneCount, _ActivePlayer.TripleCardCount)
            Dim WoodClayStoneForMarvel6 As Integer = WoodCostForMarvel6 + ClayCostForMarvel6 + StoneCostForMarvel6
            Dim TempList As New List(Of Integer)
            TempList.AddRange({WoodClayStoneForMarvel1, WoodClayStoneForMarvel2, WoodClayStoneForMarvel3, WoodClayStoneForMarvel4, WoodClayStoneForMarvel5, WoodClayStoneForMarvel6})
            WoodClayStoneForMarvel = TempList.Min
        End If

        Dim GlassPaperForMarvel As Integer
        If _ActivePlayer.DoubleCardCount = 0 Then
            Dim GlassForMarvel0 As Integer = GetRessourceCost(Building.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel0 As Integer = GetRessourceCost(Building.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel0 As Integer = GlassForMarvel0 + PaperForMarvel0
            GlassPaperForMarvel = GlassPaperForMarvel0
        ElseIf _ActivePlayer.DoubleCardCount = 1 Then
            Dim GlassForMarvel1 As Integer = GetRessourceCost(Building.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel1 As Integer = GetRessourceCost(Building.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel1 As Integer = GlassForMarvel1 + PaperForMarvel1
            Dim GlassForMarvel2 As Integer = GetRessourceCost(Building.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel2 As Integer = GetRessourceCost(Building.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel2 As Integer = GlassForMarvel2 + PaperForMarvel2
            Dim TempList As New List(Of Integer)
            TempList.AddRange({GlassPaperForMarvel1, GlassPaperForMarvel2})
            GlassPaperForMarvel = TempList.Min
        ElseIf _ActivePlayer.DoubleCardCount = 2 Then
            Dim GlassForMarvel1 As Integer = GetRessourceCost(Building.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel1 As Integer = GetRessourceCost(Building.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel1 As Integer = GlassForMarvel1 + PaperForMarvel1
            Dim GlassForMarvel2 As Integer = GetRessourceCost(Building.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel2 As Integer = GetRessourceCost(Building.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel2 As Integer = GlassForMarvel2 + PaperForMarvel2
            Dim GlassForMarvel3 As Integer = GetRessourceCost(Building.GlassCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.GlassCount, _InactivePlayer.GlassCount, _ActivePlayer.GlassPaperRule)
            Dim PaperForMarvel3 As Integer = GetRessourceCost(Building.PaperCost, _ActivePlayer.GlassPaperRule, _ActivePlayer.PaperCount, _InactivePlayer.PaperCount, _ActivePlayer.GlassPaperRule)
            Dim GlassPaperForMarvel3 As Integer = GlassForMarvel3 + PaperForMarvel3
            Dim TempList As New List(Of Integer)
            TempList.AddRange({GlassPaperForMarvel1, GlassPaperForMarvel2, GlassPaperForMarvel3})
            GlassPaperForMarvel = TempList.Min
        End If

        Dim TotalCost As Integer = WoodClayStoneForMarvel + GlassPaperForMarvel
        Return TotalCost

    End Function

    Private Function GetRessourceCost(ByVal RessourcesNeeded As Integer, ByVal RessourceRule As Boolean, ByVal ActivePlayerRessourceCount As Integer, ByVal InactivePlayerRessourceCount As Integer, ByVal NumberOfMultipleCards As Integer) As Integer

        Dim RessourceCostForObject As Integer
        Dim Neededressource As Integer = RessourcesNeeded - ActivePlayerRessourceCount + NumberOfMultipleCards
        If Neededressource <= 0 Then
            RessourceCostForObject = 0
        Else
            If RessourceRule = True Then
                RessourceCostForObject = 1 * Neededressource
            Else
                RessourceCostForObject = (2 + InactivePlayerRessourceCount) * Neededressource
            End If
        End If
        Return RessourceCostForObject

    End Function

    Private Sub MarvelBuild(ByVal Marvel As MarvelCard)

        Marvel.IsCompleted = True
        _ActivePlayer.CompletedMarvelsCount += 1

        'Gain d'Or
        _ActivePlayer.GoldCount += Marvel.GoldGain

        'Carte double
        If Marvel.GlassPaperGain = True Then
            _ActivePlayer.DoubleCardCount += 1
        End If

        'Carte triple
        If Marvel.WoodStoneClayGain = True Then
            _ActivePlayer.TripleCardCount += 1
        End If

        'Destruction d'Or
        If _InactivePlayer.GoldCount >= Marvel.GoldDestruction Then
            _InactivePlayer.GoldCount -= Marvel.GoldDestruction
        Else
            _InactivePlayer.GoldCount = 0
        End If

        'Gain bouclier
        If _ActivePlayer.Position = 1 Then
            _MilitaryProgress += _Card.ShieldGain
        ElseIf _ActivePlayer.Position = 2 Then
            _MilitaryProgress -= _Card.ShieldGain
        End If

        'Selection jeton science
        If Marvel.SciencePick = True Then
            Dim ScienceCardPick = New SciencePick(SciencePick.ScienceDeckType.Dispatched)
            ScienceCardPick.Show()
        End If

        'Selection défausse
        If Marvel.CardPick = True Then
            Dim SoldCardPick = New CardPick(_ListOfSoldBuildingCards, CardPick.DeckType.SoldDeck)
            SoldCardPick.Show()
        End If

        'Destruction carte grise
        If Marvel.GrayCardDestruction = True Then
            Dim TempList As New List(Of BuildingCard)
            For Each Card As BuildingCard In _InactivePlayer.ListOfCards
                If Card.Color = BuildingCard.CardColor.Gray Then
                    TempList.Add(Card)
                End If
            Next
            Dim GrayDestructionPick = New CardPick(TempList, CardPick.DeckType.GrayDeck)
            GrayDestructionPick.Show()
        End If

        'Destruction carte marron
        If Marvel.BrownCardDestruction = True Then
            Dim TempList As New List(Of BuildingCard)
            For Each Card As BuildingCard In _InactivePlayer.ListOfCards
                If Card.Color = BuildingCard.CardColor.Brown Then
                    TempList.Add(Card)
                End If
            Next
            Dim BrownCardPick = New CardPick(TempList, CardPick.DeckType.BrownDeck)
            BrownCardPick.Show()
        End If

        'rejouer
        If Marvel.Replay = True Then
            Replay()
        End If

    End Sub

    Private Sub Replay()

        _CardUC.Hide()
        _CardUC._Clicked = True
        For Each Uc As BuildingCardBoardUC In _BuildingCardsUC
            Uc.CheckParents()
        Next
        Me.Close()
        TurnChanges()
        _Board.UpdatePlayersBoardAndMilitaryBoardAndscienceBoard()

    End Sub

    Private Sub NextTurn()

        _CardUC.Hide()
        _CardUC._Clicked = True
        For Each Uc As BuildingCardBoardUC In _BuildingCardsUC
            Uc.CheckParents()
        Next
        Me.Close()
        TurnChanges()
        SwitchActivePlayer(Board)
        _Board.UpdatePlayersBoardAndMilitaryBoardAndscienceBoard()

    End Sub

    Private Sub TurnChanges()

        _Turn += 1
        If _Turn = 20 Then
            _Board.LoadSecondAge()
            Dim ChangeStart = New PickPlayer
            ChangeStart.Show()
        ElseIf _Turn = 40 Then
            _Board.LoadThirdAge()
            Dim ChangeStart = New PickPlayer
            ChangeStart.Show()
        ElseIf _Turn = 60 Then
            Dim Endgame = New EndGame
            Endgame.Show()
        Else
        End If

    End Sub

End Class