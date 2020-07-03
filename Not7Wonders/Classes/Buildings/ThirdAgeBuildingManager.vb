Module ThirdAgeBuildingManager

    Public Function CreateThirdAgeDeck() As List(Of BuildingCard)

        Dim UnshuffledThirdAgeDeck As New List(Of BuildingCard)
        Dim Card1 As New BuildingCard(BuildingCard.CardColor.Red, "Arsenal", BuildingCard.CardAge.III, 0, 3, 2, 0, 0, 0, BuildingCard.Symbol.None, 3, BuildingCard.Symbol.None)
        Dim Card2 As New BuildingCard(BuildingCard.CardColor.Red, "Prétoire", BuildingCard.CardAge.III, 8, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 3, BuildingCard.Symbol.None)
        Dim Card3 As New BuildingCard(BuildingCard.CardColor.Red, "Fortifications", BuildingCard.CardAge.III, 0, 1, 0, 2, 0, 1, BuildingCard.Symbol.Tower, 2, BuildingCard.Symbol.None)
        Dim Card4 As New BuildingCard(BuildingCard.CardColor.Red, "Atelier de siege", BuildingCard.CardAge.III, 0, 0, 3, 0, 1, 0, BuildingCard.Symbol.Target, 2, BuildingCard.Symbol.None)
        Dim Card5 As New BuildingCard(BuildingCard.CardColor.Red, "Cirque", BuildingCard.CardAge.III, 0, 2, 0, 2, 0, 0, BuildingCard.Symbol.Helmet, 2, BuildingCard.Symbol.None)
        Dim Card6 As New BuildingCard(BuildingCard.CardColor.Blue, "Palace", BuildingCard.CardAge.III, 1, 1, 1, 2, 0, BuildingCard.Symbol.None, 7, BuildingCard.Symbol.None)
        Dim Card7 As New BuildingCard(BuildingCard.CardColor.Blue, "Hôtel de ville", BuildingCard.CardAge.III, 0, 2, 3, 0, 0, BuildingCard.Symbol.None, 7, BuildingCard.Symbol.None)
        Dim Card8 As New BuildingCard(BuildingCard.CardColor.Blue, "Obélisque", BuildingCard.CardAge.III, 0, 0, 2, 1, 0, BuildingCard.Symbol.None, 5, BuildingCard.Symbol.None)
        Dim Card9 As New BuildingCard(BuildingCard.CardColor.Blue, "Jardins", BuildingCard.CardAge.III, 2, 2, 0, 0, 0, BuildingCard.Symbol.Pillar, 6, BuildingCard.Symbol.None)
        Dim Card10 As New BuildingCard(BuildingCard.CardColor.Blue, "Panthéon", BuildingCard.CardAge.III, 1, 1, 0, 0, 2, BuildingCard.Symbol.Sun, 6, BuildingCard.Symbol.None)
        Dim Card11 As New BuildingCard(BuildingCard.CardColor.Blue, "Sénat", BuildingCard.CardAge.III, 2, 0, 1, 0, 1, BuildingCard.Symbol.Palace, 5, BuildingCard.Symbol.None)
        Dim Card12 As New BuildingCard(BuildingCard.CardColor.Green, "Académie", BuildingCard.CardAge.III, 0, 0, 1, 1, 2, 0, BuildingCard.Symbol.None, 3, BuildingCard.Item.Sundial, BuildingCard.Symbol.None)
        Dim Card13 As New BuildingCard(BuildingCard.CardColor.Green, "Etude", BuildingCard.CardAge.III, 0, 0, 2, 0, 1, 1, BuildingCard.Symbol.None, 3, BuildingCard.Item.Sundial, BuildingCard.Symbol.None)
        Dim Card14 As New BuildingCard(BuildingCard.CardColor.Green, "Université", BuildingCard.CardAge.III, 0, 1, 0, 0, 1, 1, BuildingCard.Symbol.Harp, 2, BuildingCard.Item.Globe, BuildingCard.Symbol.None)
        Dim Card15 As New BuildingCard(BuildingCard.CardColor.Green, "Observatoire", BuildingCard.CardAge.III, 0, 0, 0, 1, 0, 2, BuildingCard.Symbol.Lamp, 2, BuildingCard.Item.Globe, BuildingCard.Symbol.None)
        Dim Card16 As New BuildingCard(BuildingCard.CardColor.Yellow, "Chambre de commerce", BuildingCard.CardAge.III, 0, 0, 0, 0, 0, 2, BuildingCard.Symbol.None, 0, 3, False, False, False, False, False, False, False, False, True, False, False, BuildingCard.Symbol.None)
        Dim Card17 As New BuildingCard(BuildingCard.CardColor.Yellow, "Port", BuildingCard.CardAge.III, 0, 0, 1, 0, 1, 1, BuildingCard.Symbol.None, 0, 3, False, False, False, False, False, False, False, False, False, False, True, BuildingCard.Symbol.None)
        Dim Card18 As New BuildingCard(BuildingCard.CardColor.Yellow, "Armurerie", BuildingCard.CardAge.III, 0, 0, 0, 2, 1, 0, BuildingCard.Symbol.None, 0, 3, False, False, False, False, False, False, False, True, False, False, False, BuildingCard.Symbol.None)
        Dim Card19 As New BuildingCard(BuildingCard.CardColor.Yellow, "Phare", BuildingCard.CardAge.III, 0, 2, 0, 0, 1, 0, BuildingCard.Symbol.Amphora, 0, 3, False, False, False, False, False, False, False, False, False, True, False, BuildingCard.Symbol.None)
        Dim Card20 As New BuildingCard(BuildingCard.CardColor.Yellow, "Arène", BuildingCard.CardAge.III, 0, 1, 1, 1, 0, 0, BuildingCard.Symbol.Barrel, 0, 3, False, False, False, False, False, False, True, False, False, False, False, BuildingCard.Symbol.None)
        UnshuffledThirdAgeDeck.AddRange({Card1, Card2, Card3, Card4, Card5, Card6, Card7, Card8, Card9, Card10, Card11, Card12, Card13, Card14, Card15, Card16, Card17, Card18, Card19, Card20})

        Dim Shuffle1 As List(Of BuildingCard) = ShuffleDeck(UnshuffledThirdAgeDeck)
        Dim Shuffle2 As List(Of BuildingCard) = ShuffleDeck(Shuffle1)
        Dim Shuffle3 As List(Of BuildingCard) = ShuffleDeck(Shuffle2)
        Dim Shuffle4 As List(Of BuildingCard) = ShuffleDeck(Shuffle3)
        Dim Shuffle5 As List(Of BuildingCard) = ShuffleDeck(Shuffle4)
        Dim Shuffle6 As List(Of BuildingCard) = ShuffleDeck(Shuffle5)
        Dim Shuffle7 As List(Of BuildingCard) = ShuffleDeck(Shuffle6)
        Dim Shuffle8 As List(Of BuildingCard) = ShuffleDeck(Shuffle7)
        Dim ShuffledThirdAgeDeck As List(Of BuildingCard) = ShuffleDeck(Shuffle8)

        RemoveRandomCardInDeck(ShuffledThirdAgeDeck)
        RemoveRandomCardInDeck(ShuffledThirdAgeDeck)
        RemoveRandomCardInDeck(ShuffledThirdAgeDeck)

        Dim UnshuffledGuildDeck As New List(Of BuildingCard)
        Dim Card24 As New BuildingCard(BuildingCard.CardColor.Purple, "Guilde des commerçants", BuildingCard.CardAge.III, 1, 1, 0, 1, 1, False, False, False, True, False, False, False)
        Dim Card25 As New BuildingCard(BuildingCard.CardColor.Purple, "Guilde des armateurs", BuildingCard.CardAge.III, 1, 0, 1, 1, 1, False, False, True, False, False, False, False)
        Dim Card26 As New BuildingCard(BuildingCard.CardColor.Purple, "Guilde des bâtisseurs", BuildingCard.CardAge.III, 1, 1, 2, 1, 0, True, False, False, False, False, False, False)
        Dim Card27 As New BuildingCard(BuildingCard.CardColor.Purple, "Guilde des magistrats", BuildingCard.CardAge.III, 1, 2, 0, 0, 1, False, False, False, False, False, True, False)
        Dim Card28 As New BuildingCard(BuildingCard.CardColor.Purple, "Guilde des scientifiques", BuildingCard.CardAge.III, 2, 2, 0, 0, 0, False, False, False, False, True, False, False)
        Dim Card29 As New BuildingCard(BuildingCard.CardColor.Purple, "Guilde des usuriers", BuildingCard.CardAge.III, 0, 2, 2, 0, 0, False, False, False, False, False, False, True)
        Dim Card30 As New BuildingCard(BuildingCard.CardColor.Purple, "Guilde des tacticiens", BuildingCard.CardAge.III, 1, 0, 2, 0, 1, False, True, False, False, False, False, False)
        UnshuffledGuildDeck.AddRange({Card24, Card25, Card26, Card27, Card28, Card29, Card30})

        Dim Shuffle9 As List(Of BuildingCard) = ShuffleDeck(UnshuffledGuildDeck)
        Dim Shuffle10 As List(Of BuildingCard) = ShuffleDeck(Shuffle9)
        Dim Shuffle11 As List(Of BuildingCard) = ShuffleDeck(Shuffle10)
        Dim Shuffle12 As List(Of BuildingCard) = ShuffleDeck(Shuffle11)
        Dim Shuffle13 As List(Of BuildingCard) = ShuffleDeck(Shuffle12)
        Dim Shuffle14 As List(Of BuildingCard) = ShuffleDeck(Shuffle13)
        Dim Shuffle15 As List(Of BuildingCard) = ShuffleDeck(Shuffle14)
        Dim Shuffle16 As List(Of BuildingCard) = ShuffleDeck(Shuffle15)
        Dim ShuffledGuildDeck As List(Of BuildingCard) = ShuffleDeck(Shuffle16)

        RemoveRandomCardInDeck(ShuffledGuildDeck)
        RemoveRandomCardInDeck(ShuffledGuildDeck)
        RemoveRandomCardInDeck(ShuffledGuildDeck)
        RemoveRandomCardInDeck(ShuffledGuildDeck)

        For Each GuildCard As BuildingCard In ShuffledGuildDeck
            ShuffledThirdAgeDeck.Add(GuildCard)
        Next

        Dim Shuffle17 As List(Of BuildingCard) = ShuffleDeck(ShuffledThirdAgeDeck)
        Dim Shuffle18 As List(Of BuildingCard) = ShuffleDeck(Shuffle17)
        Dim Shuffle19 As List(Of BuildingCard) = ShuffleDeck(Shuffle18)
        Dim Shuffle20 As List(Of BuildingCard) = ShuffleDeck(Shuffle19)
        Dim Shuffle21 As List(Of BuildingCard) = ShuffleDeck(Shuffle20)
        Dim Shuffle22 As List(Of BuildingCard) = ShuffleDeck(Shuffle21)
        Dim Shuffle23 As List(Of BuildingCard) = ShuffleDeck(Shuffle22)
        Dim Shuffle24 As List(Of BuildingCard) = ShuffleDeck(Shuffle23)
        Dim ThirdAgeDeck As List(Of BuildingCard) = ShuffleDeck(Shuffle24)

        Return ThirdAgeDeck

    End Function

End Module
