Public Class BuildingCardBoardUC

    Private ReadOnly _BuildingCard As BuildingCard
    Private ReadOnly _LocationType As LocationType
    Public _Visibility As VisibilityType
    Public _Clicked As Boolean
    Private ReadOnly _Board As Board
    Public _Parents As List(Of BuildingCardBoardUC)

    Public Enum LocationType
        Board
        WindowDestruction
        WindowGain
        WindowDisplay
    End Enum

    Public Enum VisibilityType
        Visible
        Invisible
    End Enum

    Public Sub New(ByVal BuildingCard As BuildingCard, ByVal LocationType As LocationType, ByVal Visibility As VisibilityType, ByVal Parents As List(Of BuildingCardBoardUC), ByVal Board As Board)

        InitializeComponent()
        _Parents = Parents
        _BuildingCard = BuildingCard
        _LocationType = LocationType
        _Board = Board
        _Visibility = Visibility
        If _Visibility = VisibilityType.Visible Then
            Me.LabelName.Text = _BuildingCard.Name
            AddRessourcesCosts()
            AddSymbolCosts()
            AddSymbolGains()
            ChangeColor()
        Else
            MakeInvisible()
        End If

    End Sub

    Private Sub MakeInvisible()

        LabelName.Text = ""
        FLP_Costs.BackColor = Color.LightGray
        FLP_Gains.BackColor = Color.DimGray
        FLP_Symbols.BackColor = Color.LightGray
        LabelName.BackColor = Color.DimGray

    End Sub

    Private Sub ChangeColor()

        FLP_Costs.BackColor = Color.DarkGray
        FLP_Symbols.BackColor = Color.DarkGray
        LabelName.BackColor = Color.DimGray

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

    Private Sub AddRessourcesCosts()

        If Not _BuildingCard.GoldCost = 0 Then
            Dim Gold As New GoldCostIcon
            FLP_Costs.Controls.Add(Gold)
            Gold.LabelCost.Text = _BuildingCard.GoldCost
        End If

        If _BuildingCard.ClayCost = 1 Then
            FLP_Costs.Controls.Add(New ClayCostIcon)
        End If

        If _BuildingCard.ClayCost = 2 Then
            FLP_Costs.Controls.Add(New ClayCostIcon)
            FLP_Costs.Controls.Add(New ClayCostIcon)
        End If

        If _BuildingCard.ClayCost = 3 Then
            FLP_Costs.Controls.Add(New ClayCostIcon)
            FLP_Costs.Controls.Add(New ClayCostIcon)
            FLP_Costs.Controls.Add(New ClayCostIcon)
        End If

        If _BuildingCard.WoodCost = 1 Then
            FLP_Costs.Controls.Add(New WoodCostIcon)
        End If

        If _BuildingCard.WoodCost = 2 Then
            FLP_Costs.Controls.Add(New WoodCostIcon)
            FLP_Costs.Controls.Add(New WoodCostIcon)
        End If

        If _BuildingCard.WoodCost = 3 Then
            FLP_Costs.Controls.Add(New WoodCostIcon)
            FLP_Costs.Controls.Add(New WoodCostIcon)
            FLP_Costs.Controls.Add(New WoodCostIcon)
        End If

        If _BuildingCard.StoneCost = 1 Then
            FLP_Costs.Controls.Add(New StoneCostIcon)
        End If

        If _BuildingCard.StoneCost = 2 Then
            FLP_Costs.Controls.Add(New StoneCostIcon)
            FLP_Costs.Controls.Add(New StoneCostIcon)
        End If

        If _BuildingCard.StoneCost = 3 Then
            FLP_Costs.Controls.Add(New StoneCostIcon)
            FLP_Costs.Controls.Add(New StoneCostIcon)
            FLP_Costs.Controls.Add(New StoneCostIcon)
        End If

        If _BuildingCard.GlassCost = 1 Then
            FLP_Costs.Controls.Add(New GlassCostIcon)
        End If

        If _BuildingCard.GlassCost = 2 Then
            FLP_Costs.Controls.Add(New GlassCostIcon)
            FLP_Costs.Controls.Add(New GlassCostIcon)
        End If

        If _BuildingCard.PaperCost = 1 Then
            FLP_Costs.Controls.Add(New PaperCostIcon)
        End If

        If _BuildingCard.PaperCost = 2 Then
            FLP_Costs.Controls.Add(New PaperCostIcon)
            FLP_Costs.Controls.Add(New PaperCostIcon)
        End If

    End Sub

    Private Sub AddSymbolCosts()

        If _BuildingCard.SymbolCost = BuildingCard.Symbol.None Then
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Amphora Then
            FLP_Symbols.Controls.Add(New AmphoraCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Barrel Then
            FLP_Symbols.Controls.Add(New BarrelCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Book Then
            FLP_Symbols.Controls.Add(New BookCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Drop Then
            FLP_Symbols.Controls.Add(New DropCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Gear Then
            FLP_Symbols.Controls.Add(New GearCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Harp Then
            FLP_Symbols.Controls.Add(New HarpCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Helmet Then
            FLP_Symbols.Controls.Add(New HelmetCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Horseshoe Then
            FLP_Symbols.Controls.Add(New HorseshoeCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Lamp Then
            FLP_Symbols.Controls.Add(New LampCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Mask Then
            FLP_Symbols.Controls.Add(New MaskCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Moon Then
            FLP_Symbols.Controls.Add(New MoonCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Palace Then
            FLP_Symbols.Controls.Add(New PalaceCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Pillar Then
            FLP_Symbols.Controls.Add(New PillarCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Sun Then
            FLP_Symbols.Controls.Add(New SunCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Sword Then
            FLP_Symbols.Controls.Add(New SwordCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Target Then
            FLP_Symbols.Controls.Add(New TargetCostIcon)
        ElseIf _BuildingCard.SymbolCost = BuildingCard.Symbol.Tower Then
            FLP_Symbols.Controls.Add(New TowerCostIcon)
        End If

    End Sub

    Private Sub AddSymbolGains()

        If _BuildingCard.SymbolGain = BuildingCard.Symbol.None Then
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Amphora Then
            FLP_Gains.Controls.Add(New AmphoraGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Barrel Then
            FLP_Gains.Controls.Add(New BarrelGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Book Then
            FLP_Gains.Controls.Add(New BookGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Drop Then
            FLP_Gains.Controls.Add(New DropGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Gear Then
            FLP_Gains.Controls.Add(New GearGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Harp Then
            FLP_Gains.Controls.Add(New HarpGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Helmet Then
            FLP_Gains.Controls.Add(New HelmetGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Horseshoe Then
            FLP_Gains.Controls.Add(New HorseshoeGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Lamp Then
            FLP_Gains.Controls.Add(New LampGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Mask Then
            FLP_Gains.Controls.Add(New MaskGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Moon Then
            FLP_Gains.Controls.Add(New MoonGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Palace Then
            FLP_Gains.Controls.Add(New PalaceGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Pillar Then
            FLP_Gains.Controls.Add(New PillarGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Sun Then
            FLP_Gains.Controls.Add(New SunGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Sword Then
            FLP_Gains.Controls.Add(New SwordGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Target Then
            FLP_Gains.Controls.Add(New TargetGainIcon)
        ElseIf _BuildingCard.SymbolGain = BuildingCard.Symbol.Tower Then
            FLP_Gains.Controls.Add(New TowerGainIcon)
        End If

    End Sub

    Public Sub CheckParents()

        If _Parents Is Nothing Then
        ElseIf _Parents.Count = 1 Then
            If _Parents.Item(0)._Clicked = True Then
                If Me._Visibility = VisibilityType.Invisible Then
                    Me._Visibility = VisibilityType.Visible
                    Me.LabelName.Text = _BuildingCard.Name
                    AddRessourcesCosts()
                    AddSymbolCosts()
                    AddSymbolGains()
                    ChangeColor()
                End If
            End If
        ElseIf _Parents.Count = 2 Then
            If _Parents.Item(0)._Clicked = True AndAlso _Parents.Item(1)._Clicked = True Then
                If Me._Visibility = VisibilityType.Invisible Then
                    Me._Visibility = VisibilityType.Visible
                    Me.LabelName.Text = _BuildingCard.Name
                    AddRessourcesCosts()
                    AddSymbolCosts()
                    AddSymbolGains()
                    ChangeColor()
                End If
            End If
        End If

    End Sub

    Private Sub Card_Click(sender As Object, e As EventArgs) Handles LabelName.Click, FLP_Costs.Click, FLP_Gains.Click, FLP_Symbols.Click

        If _LocationType = LocationType.Board Then

            If _Parents Is Nothing Then
                Dim ActionForm = New ActionForm(_BuildingCard, Me, _Board)
                ActionForm.Show()
            ElseIf _Parents.Count = 1 Then
                If _Parents.Item(0)._Clicked = True Then
                    Dim ActionForm = New ActionForm(_BuildingCard, Me, _Board)
                    ActionForm.Show()
                End If
            ElseIf _Parents.Count = 2 Then
                If _Parents.Item(0)._Clicked = True AndAlso _Parents.Item(1)._Clicked = True Then
                    Dim ActionForm = New ActionForm(_BuildingCard, Me, _Board)
                    ActionForm.Show()
                End If
            ElseIf _Parents.Count = 6 Then
                If _Parents.Item(0)._Clicked = True AndAlso _Parents.Item(1)._Clicked = True AndAlso _Parents.Item(2)._Clicked = True AndAlso _Parents.Item(3)._Clicked = True AndAlso _Parents.Item(4)._Clicked = True AndAlso _Parents.Item(5)._Clicked = True Then
                    Dim ActionForm = New ActionForm(_BuildingCard, Me, _Board)
                    ActionForm.Show()
                End If
            End If

        ElseIf _LocationType = LocationType.WindowDestruction Then

            _InactivePlayer.ListOfCards.Remove(_BuildingCard)
            _InactivePlayer.ClayCount -= _BuildingCard.ClayGain
            _InactivePlayer.StoneCount -= _BuildingCard.StoneGain
            _InactivePlayer.WoodCount -= _BuildingCard.WoodGain
            _InactivePlayer.GlassCount -= _BuildingCard.GlassGain
            _InactivePlayer.PaperCount -= _BuildingCard.PaperGain

            If _BuildingCard.Color = BuildingCard.CardColor.Brown Then
                _InactivePlayer.BrownCardCount -= 1
            ElseIf _BuildingCard.Color = BuildingCard.CardColor.Gray Then
                _InactivePlayer.GrayCardCount -= 1
            End If




        ElseIf _LocationType = LocationType.WindowGain Then

            'Ajouter la carte à la main du joueur
            _ActivePlayer.ListOfCards.Add(_BuildingCard)

            If _BuildingCard.Color = BuildingCard.CardColor.Brown Then
                _ActivePlayer.BrownCardCount += 1
            ElseIf _BuildingCard.Color = BuildingCard.CardColor.Gray Then
                _ActivePlayer.GrayCardCount += 1
            ElseIf _BuildingCard.Color = BuildingCard.CardColor.Red Then
                _ActivePlayer.RedCardCount += 1
            ElseIf _BuildingCard.Color = BuildingCard.CardColor.Blue Then
                _ActivePlayer.BlueCardCount += 1
            ElseIf _BuildingCard.Color = BuildingCard.CardColor.Green Then
                _ActivePlayer.GreenCardCount += 1
            ElseIf _BuildingCard.Color = BuildingCard.CardColor.Yellow Then
                _ActivePlayer.YellowCardCount += 1
            ElseIf _BuildingCard.Color = BuildingCard.CardColor.Purple Then
                _ActivePlayer.PurpleCardCount += 1
            End If

            'Récupérer les ressources de la carte
            _ActivePlayer.GoldCount += _BuildingCard.GoldGain
            _ActivePlayer.WoodCount += _BuildingCard.WoodGain
            _ActivePlayer.ClayCount += _BuildingCard.ClayGain
            _ActivePlayer.StoneCount += _BuildingCard.StoneGain
            _ActivePlayer.GlassCount += _BuildingCard.GlassGain
            _ActivePlayer.PaperCount += _BuildingCard.PaperGain

            'Points militaires
            If _ActivePlayer.Position = 1 Then
                _MilitaryProgress += _BuildingCard.ShieldGain
            ElseIf _ActivePlayer.Position = 2 Then
                _MilitaryProgress -= _BuildingCard.ShieldGain
            End If

            'récupération des symboles
            _ActivePlayer.ListOfSymbols.Add(_BuildingCard.SymbolGain.ToString)

            'Récupération des items
            If Not _BuildingCard.ItemGain = Nothing Then
                If _ActivePlayer.ListOfItems.Contains(_BuildingCard.ItemGain.ToString) Then
                    Dim ChooseScienceCoin = New SciencePick(SciencePick.ScienceDeckType.Played)
                    ChooseScienceCoin.Show()
                Else
                    _ActivePlayer.ListOfItems.Add(_BuildingCard.ItemGain.ToString)
                End If

                If _ActivePlayer.ListOfItems.Count = 6 Then
                    _ActivePlayer.ScienceVictory = True
                    Dim NewEndgame = New EndGame
                    NewEndgame.Show()
                End If
            End If

            'Si Carte Jaune
            _ActivePlayer.WoodRule = _BuildingCard.WoodRuleUpdate
            _ActivePlayer.ClayRule = _BuildingCard.ClayRuleUpdate
            _ActivePlayer.StoneRule = _BuildingCard.StoneRuleUpdate
            _ActivePlayer.GlassPaperRule = _BuildingCard.PaperGlassRuleUpdate
            If _BuildingCard.TripleGain = True Then
                _ActivePlayer.TripleCardCount += 1
            End If
            If _BuildingCard.DoubleGain = True Then
                _ActivePlayer.DoubleCardCount += 1
            End If
            If _BuildingCard.MarvelGoldGain = True Then
                _ActivePlayer.GoldCount += 2 * _ActivePlayer.CompletedMarvelsCount
            End If
            If _BuildingCard.RedCardGoldGain = True Then
                _ActivePlayer.GoldCount += 1 * _ActivePlayer.RedCardCount
            End If
            If _BuildingCard.GrayCardGoldGain = True Then
                _ActivePlayer.GoldCount += 3 * _ActivePlayer.GrayCardCount
            End If
            If _BuildingCard.YellowCardGoldGain = True Then
                _ActivePlayer.GoldCount += 1 * _ActivePlayer.YellowCardCount
            End If
            If _BuildingCard.BrownCardGoldGain = True Then
                _ActivePlayer.GoldCount += 2 * _ActivePlayer.BrownCardCount
            End If

            'Si Carte Violette
            _ActivePlayer.MarvelVictoryGain = _BuildingCard.MarvelVictoryGain
            _ActivePlayer.RedCardGoldVictoryGain = _BuildingCard.RedCardGoldVictoryGain
            _ActivePlayer.GrayBrownCardGoldVictoryGain = _BuildingCard.GrayBrownCardGoldVictoryGain
            _ActivePlayer.YellowCardGoldVictoryGain = _BuildingCard.YellowCardGoldVictoryGain
            _ActivePlayer.GreenCardGoldVictoryGain = _BuildingCard.GreenCardGoldVictoryGain
            _ActivePlayer.BlueCardGoldVictoryGain = _BuildingCard.BlueCardGoldVictoryGain
            _ActivePlayer.GoldVictoryGain = _BuildingCard.GoldVictoryGain

            If _BuildingCard.GrayBrownCardGoldVictoryGain = True Then
                Dim TempList As New List(Of Integer)
                TempList.AddRange({_ActivePlayer.GrayCardCount + _ActivePlayer.BrownCardCount, _InactivePlayer.GrayCardCount + _InactivePlayer.BrownCardCount})
                Dim BestOfPlayers As Integer = TempList.Max
                _ActivePlayer.GoldCount += BestOfPlayers
            End If
            If _BuildingCard.YellowCardGoldVictoryGain = True Then
                Dim TempList As New List(Of Integer)
                TempList.AddRange({_ActivePlayer.YellowCardCount, _InactivePlayer.YellowCardCount})
                Dim BestOfPlayers As Integer = TempList.Max
                _ActivePlayer.GoldCount += BestOfPlayers
            End If
            If _BuildingCard.BlueCardGoldVictoryGain = True Then
                Dim TempList As New List(Of Integer)
                TempList.AddRange({_ActivePlayer.BlueCardCount, _InactivePlayer.BlueCardCount})
                Dim BestOfPlayers As Integer = TempList.Max
                _ActivePlayer.GoldCount += BestOfPlayers
            End If
            If _BuildingCard.RedCardGoldVictoryGain = True Then
                Dim TempList As New List(Of Integer)
                TempList.AddRange({_ActivePlayer.RedCardCount, _InactivePlayer.RedCardCount})
                Dim BestOfPlayers As Integer = TempList.Max
                _ActivePlayer.GoldCount += BestOfPlayers
            End If
            If _BuildingCard.GreenCardGoldVictoryGain = True Then
                Dim TempList As New List(Of Integer)
                TempList.AddRange({_ActivePlayer.GreenCardCount, _InactivePlayer.GreenCardCount})
                Dim BestOfPlayers As Integer = TempList.Max
                _ActivePlayer.GoldCount += BestOfPlayers
            End If

        End If

    End Sub

End Class
