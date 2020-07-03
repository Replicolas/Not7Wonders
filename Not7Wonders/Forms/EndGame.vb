Public Class EndGame

    Public Sub New()

        InitializeComponent()
        MakeCalculations(_ActivePlayer)
        MakeCalculations(_InactivePlayer)
        WriteResults()

    End Sub

    Private Sub MakeCalculations(ByVal Player As Player)

        For Each Card As BuildingCard In Player.ListOfCards
            If Card.Color = BuildingCard.CardColor.Blue Then
                Player.BlueCardVictoryPoints += Card.VictoryGain
            End If
        Next

        For Each Card As BuildingCard In Player.ListOfCards
            If Card.Color = BuildingCard.CardColor.Green Then
                Player.GreenCardVictoryPoints += Card.VictoryGain
            End If
        Next

        For Each Card As BuildingCard In Player.ListOfCards
            If Card.Color = BuildingCard.CardColor.Yellow Then
                Player.YellowCardVictoryPoints += Card.VictoryGain
            End If
        Next

        For Each Card As BuildingCard In Player.ListOfCards
            If Card.Color = BuildingCard.CardColor.Purple Then
                If Card.YellowCardGoldVictoryGain = True Then
                    Player.PurpleCardVictoryPoints += 1 * Player.YellowCardCount
                ElseIf Card.GrayBrownCardGoldVictoryGain = True Then
                    Player.PurpleCardVictoryPoints += 1 * Player.GrayCardCount + 1 * Player.BrownCardCount
                ElseIf Card.BlueCardGoldVictoryGain = True Then
                    Player.PurpleCardVictoryPoints += 1 * Player.BlueCardCount
                ElseIf Card.GreenCardGoldVictoryGain = True Then
                    Player.PurpleCardVictoryPoints += 1 * Player.GreenCardCount
                ElseIf Card.RedCardGoldVictoryGain = True Then
                    Player.PurpleCardVictoryPoints += 1 * Player.RedCardCount
                ElseIf Card.MarvelVictoryGain = True Then
                    Player.PurpleCardVictoryPoints += 2 * Player.CompletedMarvelsCount
                ElseIf Card.GoldVictoryGain = True Then
                    Dim TempNumb As String = (Player.GoldCount / 3)
                    Dim TempInt As List(Of String) = TempNumb.Split(",").ToList
                    Player.PurpleCardVictoryPoints += 1 * CType(TempInt.First, Integer)
                End If
            End If
        Next

        For Each Marvel As MarvelCard In Player.ListOfMarvels
            If Marvel.IsCompleted = True Then
                Player.MarvelVictoryPoints += Marvel.VictoryGain
            End If
        Next

        For Each ScienceCoin As ScienceCard In Player.ListOfScience
            If ScienceCoin.Name = "Agriculture" Then
                Player.ScienceVictoryPoints += 4
            ElseIf ScienceCoin.Name = "Mathématiques" Then
                Player.ScienceVictoryPoints += 3 * Player.ListOfScience.Count
            ElseIf ScienceCoin.Name = "Philosophie" Then
                Player.ScienceVictoryPoints += 7
            End If
        Next

        Dim TempNumber As String = (Player.GoldCount / 3)
        Dim TempInteger As List(Of String) = TempNumber.Split(",").ToList
        Player.GoldVictoryPoints += 1 * CType(TempInteger.First, Integer)

        If Player.Military2Points = True Then
            Player.MilitaryVictoryPoints += 2
        End If
        If Player.Military5Points = True Then
            Player.MilitaryVictoryPoints += 5
        End If
        If Player.Military10Points = True Then
            Player.MilitaryVictoryPoints += 10
        End If

        Player.TotalScore = Player.BlueCardVictoryPoints + Player.GreenCardVictoryPoints + Player.YellowCardVictoryPoints + Player.PurpleCardVictoryPoints + Player.MarvelVictoryPoints + Player.ScienceVictoryPoints + Player.GoldVictoryPoints + Player.MilitaryVictoryPoints

    End Sub

    Private Sub WriteResults()

        LabelNameP1.Text = _ActivePlayer.Name
        LabelNameP2.Text = _InactivePlayer.Name

        LabelBlueP1.Text = _ActivePlayer.BlueCardVictoryPoints
        LabelBlueP2.Text = _InactivePlayer.BlueCardVictoryPoints

        LabelGreenP1.Text = _ActivePlayer.GreenCardVictoryPoints
        LabelGreenP2.Text = _InactivePlayer.GreenCardVictoryPoints

        LabelYellowP1.Text = _ActivePlayer.YellowCardVictoryPoints
        LabelYellowP2.Text = _InactivePlayer.YellowCardVictoryPoints

        LabelPurpleP1.Text = _ActivePlayer.PurpleCardVictoryPoints
        LabelPurpleP2.Text = _InactivePlayer.PurpleCardVictoryPoints

        LabelMarvelP1.Text = _ActivePlayer.MarvelVictoryPoints
        LabelMarvelP2.Text = _InactivePlayer.MarvelVictoryPoints

        LabelScienceP1.Text = _ActivePlayer.ScienceVictoryPoints
        LabelScienceP2.Text = _InactivePlayer.ScienceVictoryPoints

        LabelGoldP1.Text = _ActivePlayer.GoldVictoryPoints
        LabelGoldP2.Text = _InactivePlayer.GoldVictoryPoints

        LabelShieldP1.Text = _ActivePlayer.MilitaryVictoryPoints
        LabelShieldP2.Text = _InactivePlayer.MilitaryVictoryPoints

        LabelTotalP1.Text = _ActivePlayer.TotalScore
        LabelTotalP2.Text = _InactivePlayer.TotalScore

        If _ActivePlayer.MilitaryVictory = True Then
            LabelMilitaryVictoryP1.Text = "X"
        Else
            LabelMilitaryVictoryP1.Text = ""
        End If
        If _InactivePlayer.MilitaryVictory = True Then
            LabelMilitaryVictoryP2.Text = "X"
        Else
            LabelMilitaryVictoryP2.Text = ""
        End If

        If _ActivePlayer.ScienceVictory = True Then
            LabelScientificVictoryP1.Text = "X"
        Else
            LabelScientificVictoryP1.Text = ""
        End If
        If _InactivePlayer.ScienceVictory = True Then
            LabelScientificVictoryP2.Text = "X"
        Else
            LabelScientificVictoryP2.Text = ""
        End If

        If _ActivePlayer.MilitaryVictory = True Then
            LabelWinnerName.Text = _ActivePlayer.Name & " gagne !"
        ElseIf _InactivePlayer.MilitaryVictory = True Then
            LabelWinnerName.Text = _InactivePlayer.Name & " gagne !"
        Else
            If _ActivePlayer.TotalScore > _InactivePlayer.TotalScore Then
                LabelWinnerName.Text = _ActivePlayer.Name & " gagne !"
            ElseIf _ActivePlayer.TotalScore < _InactivePlayer.TotalScore Then
                LabelWinnerName.Text = _InactivePlayer.Name & " gagne !"
            ElseIf _ActivePlayer.TotalScore = _InactivePlayer.TotalScore Then
                If _ActivePlayer.BlueCardVictoryPoints > _InactivePlayer.BlueCardVictoryPoints Then
                    LabelWinnerName.Text = _ActivePlayer.Name & " gagne !"
                ElseIf _ActivePlayer.BlueCardVictoryPoints < _InactivePlayer.BlueCardVictoryPoints Then
                    LabelWinnerName.Text = _InactivePlayer.Name & " gagne !"
                Else
                    LabelWinnerName.Text = "ex æquo"
                End If
            End If
        End If

    End Sub

    Private Sub ButtonQuit_Click(sender As Object, e As EventArgs) Handles ButtonQuit.Click

        Me.Close()

    End Sub

End Class