Public Class CardPick

    Private ReadOnly _CardDeck As List(Of BuildingCard)
    Private ReadOnly _DeckType As DeckType

    Public Enum DeckType
        BrownDeck
        GrayDeck
        SoldDeck
    End Enum

    Public Sub New(ByVal CardDeck As List(Of BuildingCard), ByVal DeckType As DeckType)

        InitializeComponent()
        _CardDeck = CardDeck
        _DeckType = DeckType
        CheckDeck()
        DisplayDeck()

    End Sub

    Private Sub CheckDeck()

        If _DeckType = DeckType.BrownDeck Then
            Label1.Text = _ActivePlayer.Name & " sélectionne et détruit une carte marron construite par " & _InactivePlayer.Name
        ElseIf _DeckType = DeckType.GrayDeck Then
            Label1.Text = _ActivePlayer.Name & " sélectionne et détruit une carte grise construite par " & _InactivePlayer.Name
        ElseIf _DeckType = DeckType.SoldDeck Then
            Label1.Text = _ActivePlayer.Name & " sélectionne et construit une carte défaussée au choix."
        End If

    End Sub

    Private Sub DisplayDeck()

        For Each Card As BuildingCard In _CardDeck
            If _DeckType = DeckType.BrownDeck Then
                FlowLayoutPanelCards.Controls.Add(New BuildingCardBoardUC(Card, BuildingCardBoardUC.LocationType.WindowDestruction, BuildingCardBoardUC.VisibilityType.Visible, Nothing, Nothing))
            ElseIf _DeckType = DeckType.GrayDeck Then
                FlowLayoutPanelCards.Controls.Add(New BuildingCardBoardUC(Card, BuildingCardBoardUC.LocationType.WindowDestruction, BuildingCardBoardUC.VisibilityType.Visible, Nothing, Nothing))
            ElseIf _DeckType = DeckType.SoldDeck Then
                FlowLayoutPanelCards.Controls.Add(New BuildingCardBoardUC(Card, BuildingCardBoardUC.LocationType.WindowGain, BuildingCardBoardUC.VisibilityType.Visible, Nothing, Nothing))
            End If
        Next

    End Sub

End Class