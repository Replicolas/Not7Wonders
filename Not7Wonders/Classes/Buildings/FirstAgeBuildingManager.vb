Module FirstAgeBuildingManager

    Public Function CreateFirstAgeDeck() As List(Of BuildingCard)

        Dim UnshuffledFirstAgeDeck As New List(Of BuildingCard)
        Dim Card1 As New BuildingCard(BuildingCard.CardColor.Brown, "Chantier", BuildingCard.CardAge.I, 0, 0, 1, 0)
        Dim Card2 As New BuildingCard(BuildingCard.CardColor.Brown, "Exploitation", BuildingCard.CardAge.I, 1, 0, 1, 0)
        Dim Card3 As New BuildingCard(BuildingCard.CardColor.Brown, "Bassin argileux", BuildingCard.CardAge.I, 0, 1, 0, 0)
        Dim Card4 As New BuildingCard(BuildingCard.CardColor.Brown, "Cavité", BuildingCard.CardAge.I, 1, 1, 0, 0)
        Dim Card5 As New BuildingCard(BuildingCard.CardColor.Brown, "Gisement", BuildingCard.CardAge.I, 0, 0, 0, 1)
        Dim Card6 As New BuildingCard(BuildingCard.CardColor.Brown, "Mine", BuildingCard.CardAge.I, 1, 0, 0, 1)
        Dim Card7 As New BuildingCard(BuildingCard.CardColor.Gray, "Verrerie", BuildingCard.CardAge.I, 1, 1, 0)
        Dim Card8 As New BuildingCard(BuildingCard.CardColor.Gray, "Presse", BuildingCard.CardAge.I, 1, 0, 1)
        Dim Card9 As New BuildingCard(BuildingCard.CardColor.Red, "Tour de garde", BuildingCard.CardAge.I, 0, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 1, BuildingCard.Symbol.None)
        Dim Card10 As New BuildingCard(BuildingCard.CardColor.Red, "Ecurie", BuildingCard.CardAge.I, 0, 0, 1, 0, 0, 0, BuildingCard.Symbol.None, 1, BuildingCard.Symbol.Horseshoe)
        Dim Card11 As New BuildingCard(BuildingCard.CardColor.Red, "Caserne", BuildingCard.CardAge.I, 0, 1, 0, 0, 0, 0, BuildingCard.Symbol.None, 1, BuildingCard.Symbol.Sword)
        Dim Card12 As New BuildingCard(BuildingCard.CardColor.Red, "Palissade", BuildingCard.CardAge.I, 2, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 1, BuildingCard.Symbol.Tower)
        Dim Card13 As New BuildingCard(BuildingCard.CardColor.Blue, "Théâtre", BuildingCard.CardAge.I, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 3, BuildingCard.Symbol.Mask)
        Dim Card14 As New BuildingCard(BuildingCard.CardColor.Blue, "Autel", BuildingCard.CardAge.I, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 3, BuildingCard.Symbol.Moon)
        Dim Card15 As New BuildingCard(BuildingCard.CardColor.Blue, "Bains", BuildingCard.CardAge.I, 0, 0, 1, 0, 0, BuildingCard.Symbol.None, 3, BuildingCard.Symbol.Drop)
        Dim Card16 As New BuildingCard(BuildingCard.CardColor.Green, "Atelier", BuildingCard.CardAge.I, 0, 0, 0, 0, 0, 1, BuildingCard.Symbol.None, 1, BuildingCard.Item.Pendulum, BuildingCard.Symbol.None)
        Dim Card17 As New BuildingCard(BuildingCard.CardColor.Green, "Apothicaire", BuildingCard.CardAge.I, 0, 0, 0, 0, 1, 0, BuildingCard.Symbol.None, 1, BuildingCard.Item.Wheel, BuildingCard.Symbol.None)
        Dim Card18 As New BuildingCard(BuildingCard.CardColor.Green, "Scriptorium", BuildingCard.CardAge.I, 2, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 0, BuildingCard.Item.Balance, BuildingCard.Symbol.Book)
        Dim Card19 As New BuildingCard(BuildingCard.CardColor.Green, "Officine", BuildingCard.CardAge.I, 2, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 0, BuildingCard.Item.Mortar, BuildingCard.Symbol.Gear)
        Dim Card20 As New BuildingCard(BuildingCard.CardColor.Yellow, "Dépôt de pierre", BuildingCard.CardAge.I, 3, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 0, 0, False, True, False, False, False, False, False, False, False, False, False, BuildingCard.Symbol.None)
        Dim Card21 As New BuildingCard(BuildingCard.CardColor.Yellow, "Dépôt d'argile", BuildingCard.CardAge.I, 3, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 0, 0, False, False, True, False, False, False, False, False, False, False, False, BuildingCard.Symbol.None)
        Dim Card22 As New BuildingCard(BuildingCard.CardColor.Yellow, "Dépôt de bois", BuildingCard.CardAge.I, 3, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 0, 0, True, False, False, False, False, False, False, False, False, False, False, BuildingCard.Symbol.None)
        Dim Card23 As New BuildingCard(BuildingCard.CardColor.Yellow, "Taverne", BuildingCard.CardAge.I, 0, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 4, 0, False, False, False, False, False, False, False, False, False, False, False, BuildingCard.Symbol.Amphora)
        UnshuffledFirstAgeDeck.AddRange({Card1, Card2, Card3, Card4, Card5, Card6, Card7, Card8, Card9, Card10, Card11, Card12, Card13, Card14, Card15, Card16, Card17, Card18, Card19, Card20, Card21, Card22, Card23})

        Dim Shuffle1 As List(Of BuildingCard) = ShuffleDeck(UnshuffledFirstAgeDeck)
        Dim Shuffle2 As List(Of BuildingCard) = ShuffleDeck(Shuffle1)
        Dim Shuffle3 As List(Of BuildingCard) = ShuffleDeck(Shuffle2)
        Dim Shuffle4 As List(Of BuildingCard) = ShuffleDeck(Shuffle3)
        Dim Shuffle5 As List(Of BuildingCard) = ShuffleDeck(Shuffle4)
        Dim Shuffle6 As List(Of BuildingCard) = ShuffleDeck(Shuffle5)
        Dim Shuffle7 As List(Of BuildingCard) = ShuffleDeck(Shuffle6)
        Dim Shuffle8 As List(Of BuildingCard) = ShuffleDeck(Shuffle7)
        Dim ShuffledFirstAgeDeck As List(Of BuildingCard) = ShuffleDeck(Shuffle8)

        RemoveRandomCardInDeck(ShuffledFirstAgeDeck)
        RemoveRandomCardInDeck(ShuffledFirstAgeDeck)
        RemoveRandomCardInDeck(ShuffledFirstAgeDeck)

        Dim Shuffle9 As List(Of BuildingCard) = ShuffleDeck(ShuffledFirstAgeDeck)
        Dim Shuffle10 As List(Of BuildingCard) = ShuffleDeck(Shuffle9)
        Dim Shuffle11 As List(Of BuildingCard) = ShuffleDeck(Shuffle10)
        Dim Shuffle12 As List(Of BuildingCard) = ShuffleDeck(Shuffle11)
        Dim Shuffle13 As List(Of BuildingCard) = ShuffleDeck(Shuffle12)
        Dim Shuffle14 As List(Of BuildingCard) = ShuffleDeck(Shuffle13)
        Dim Shuffle15 As List(Of BuildingCard) = ShuffleDeck(Shuffle14)
        Dim Shuffle16 As List(Of BuildingCard) = ShuffleDeck(Shuffle15)
        Dim FirstAgeDeck As List(Of BuildingCard) = ShuffleDeck(Shuffle16)

        Return FirstAgeDeck

    End Function

End Module
