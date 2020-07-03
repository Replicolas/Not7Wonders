Module SecondAgeBuildingManager

    Public Function CreateSecondAgeDeck() As List(Of BuildingCard)

        Dim UnshuffledSecondAgeDeck As New List(Of BuildingCard)
        Dim Card1 As New BuildingCard(BuildingCard.CardColor.Brown, "Scierie", BuildingCard.CardAge.II, 2, 0, 2, 0)
        Dim Card2 As New BuildingCard(BuildingCard.CardColor.Brown, "Briqueterie", BuildingCard.CardAge.II, 2, 2, 0, 0)
        Dim Card3 As New BuildingCard(BuildingCard.CardColor.Brown, "Carrière", BuildingCard.CardAge.II, 2, 0, 0, 2)
        Dim Card4 As New BuildingCard(BuildingCard.CardColor.Gray, "Soufflerie", BuildingCard.CardAge.II, 0, 1, 0)
        Dim Card5 As New BuildingCard(BuildingCard.CardColor.Gray, "Séchoir", BuildingCard.CardAge.II, 0, 0, 1)
        Dim Card6 As New BuildingCard(BuildingCard.CardColor.Red, "Muraille", BuildingCard.CardAge.II, 0, 0, 0, 2, 0, 0, BuildingCard.Symbol.None, 2, BuildingCard.Symbol.None)
        Dim Card7 As New BuildingCard(BuildingCard.CardColor.Red, "Haras", BuildingCard.CardAge.II, 0, 1, 1, 0, 0, 0, BuildingCard.Symbol.Horseshoe, 1, BuildingCard.Symbol.None)
        Dim Card8 As New BuildingCard(BuildingCard.CardColor.Red, "Baraquements", BuildingCard.CardAge.II, 3, 0, 0, 0, 0, 0, BuildingCard.Symbol.Sword, 1, BuildingCard.Symbol.None)
        Dim Card9 As New BuildingCard(BuildingCard.CardColor.Red, "Champs de tir", BuildingCard.CardAge.II, 0, 0, 1, 1, 0, 1, BuildingCard.Symbol.None, 2, BuildingCard.Symbol.Target)
        Dim Card10 As New BuildingCard(BuildingCard.CardColor.Red, "Place d'armes", BuildingCard.CardAge.II, 0, 2, 0, 0, 1, 0, BuildingCard.Symbol.None, 2, BuildingCard.Symbol.Helmet)
        Dim Card11 As New BuildingCard(BuildingCard.CardColor.Blue, "Tribunal", BuildingCard.CardAge.II, 0, 2, 0, 1, 0, BuildingCard.Symbol.None, 5, BuildingCard.Symbol.None)
        Dim Card12 As New BuildingCard(BuildingCard.CardColor.Blue, "Statue", BuildingCard.CardAge.II, 2, 0, 0, 0, 0, BuildingCard.Symbol.Mask, 4, BuildingCard.Symbol.Pillar)
        Dim Card13 As New BuildingCard(BuildingCard.CardColor.Blue, "Temple", BuildingCard.CardAge.II, 0, 1, 0, 0, 1, BuildingCard.Symbol.Moon, 4, BuildingCard.Symbol.Sun)
        Dim Card14 As New BuildingCard(BuildingCard.CardColor.Blue, "Aqueduc", BuildingCard.CardAge.II, 0, 0, 3, 0, 0, BuildingCard.Symbol.Drop, 5, BuildingCard.Symbol.None)
        Dim Card15 As New BuildingCard(BuildingCard.CardColor.Blue, "Rostres", BuildingCard.CardAge.II, 0, 1, 1, 0, 0, BuildingCard.Symbol.None, 4, BuildingCard.Symbol.Palace)
        Dim Card16 As New BuildingCard(BuildingCard.CardColor.Green, "Bibliothèque", BuildingCard.CardAge.II, 0, 0, 1, 1, 1, 0, BuildingCard.Symbol.Book, 2, BuildingCard.Item.Balance, BuildingCard.Symbol.None)
        Dim Card17 As New BuildingCard(BuildingCard.CardColor.Green, "Dispensaire", BuildingCard.CardAge.II, 0, 2, 0, 1, 0, 0, BuildingCard.Symbol.Gear, 2, BuildingCard.Item.Mortar, BuildingCard.Symbol.None)
        Dim Card18 As New BuildingCard(BuildingCard.CardColor.Green, "Ecole", BuildingCard.CardAge.II, 0, 0, 1, 0, 0, 2, BuildingCard.Symbol.None, 1, BuildingCard.Item.Wheel, BuildingCard.Symbol.Harp)
        Dim Card19 As New BuildingCard(BuildingCard.CardColor.Green, "Laboratoire", BuildingCard.CardAge.II, 0, 0, 1, 0, 2, 0, BuildingCard.Symbol.None, 1, BuildingCard.Item.Pendulum, BuildingCard.Symbol.Lamp)
        Dim Card20 As New BuildingCard(BuildingCard.CardColor.Yellow, "Forum", BuildingCard.CardAge.II, 3, 1, 0, 0, 0, 0, BuildingCard.Symbol.None, 0, 0, False, False, False, False, False, True, False, False, False, False, False, BuildingCard.Symbol.None)
        Dim Card21 As New BuildingCard(BuildingCard.CardColor.Yellow, "Caravansérail", BuildingCard.CardAge.II, 2, 0, 0, 0, 1, 1, BuildingCard.Symbol.None, 0, 0, False, False, False, False, True, False, False, False, False, False, False, BuildingCard.Symbol.None)
        Dim Card22 As New BuildingCard(BuildingCard.CardColor.Yellow, "Douane", BuildingCard.CardAge.II, 4, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 0, 0, False, False, False, True, False, False, False, False, False, False, False, BuildingCard.Symbol.None)
        Dim Card23 As New BuildingCard(BuildingCard.CardColor.Yellow, "Brasserie", BuildingCard.CardAge.II, 0, 0, 0, 0, 0, 0, BuildingCard.Symbol.None, 6, 0, False, False, False, False, False, False, False, False, False, False, False, BuildingCard.Symbol.Barrel)
        UnshuffledSecondAgeDeck.AddRange({Card1, Card2, Card3, Card4, Card5, Card6, Card7, Card8, Card9, Card10, Card11, Card12, Card13, Card14, Card15, Card16, Card17, Card18, Card19, Card20, Card21, Card22, Card23})

        Dim Shuffle1 As List(Of BuildingCard) = ShuffleDeck(UnshuffledSecondAgeDeck)
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
        Dim SecondAgeDeck As List(Of BuildingCard) = ShuffleDeck(Shuffle16)

        Return SecondAgeDeck

    End Function

End Module
