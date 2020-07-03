Module Tools

#Region "Remove Functions"

    Public Sub RemoveRandomCardInDeck(ByVal CardDeck As List(Of BuildingCard))

        Dim CardIndex As Integer = GetRandomNumber(0, CardDeck.Count - 1)
        Dim SelectedCard As BuildingCard = CardDeck.Item(CardIndex)
        CardDeck.Remove(SelectedCard)

    End Sub

    Public Sub RemoveRandomCardInDeck(ByVal CardDeck As List(Of ScienceCard))

        Dim CardIndex As Integer = GetRandomNumber(0, CardDeck.Count - 1)
        Dim SelectedCard As ScienceCard = CardDeck.Item(CardIndex)
        CardDeck.Remove(SelectedCard)

    End Sub

    Public Sub RemoveRandomCardInDeck(ByVal CardDeck As List(Of MarvelCard))

        Dim CardIndex As Integer = GetRandomNumber(0, CardDeck.Count - 1)
        Dim SelectedCard As MarvelCard = CardDeck.Item(CardIndex)
        CardDeck.Remove(SelectedCard)

    End Sub

#End Region

#Region "Shuffle Functions"

    Public Function ShuffleDeck(ByVal UnshuffledDeck As List(Of BuildingCard)) As List(Of BuildingCard)

        Dim ShuffledCardDeck As New List(Of BuildingCard)
        While Not UnshuffledDeck.Count = 0
            Dim CardIndex As Integer = GetRandomNumber(0, UnshuffledDeck.Count)
            Dim SelectedCard As BuildingCard = UnshuffledDeck.Item(CardIndex)
            ShuffledCardDeck.Add(SelectedCard)
            UnshuffledDeck.Remove(SelectedCard)
        End While
        Return ShuffledCardDeck

    End Function

    Public Function ShuffleDeck(ByVal UnshuffledDeck As List(Of ScienceCard)) As List(Of ScienceCard)

        Dim ShuffledCardDeck As New List(Of ScienceCard)
        While Not UnshuffledDeck.Count = 0
            Dim CardIndex As Integer = GetRandomNumber(0, UnshuffledDeck.Count)
            Dim SelectedCard As ScienceCard = UnshuffledDeck.Item(CardIndex)
            ShuffledCardDeck.Add(SelectedCard)
            UnshuffledDeck.Remove(SelectedCard)
        End While
        Return ShuffledCardDeck

    End Function

    Public Function ShuffleDeck(ByVal UnshuffledDeck As List(Of MarvelCard)) As List(Of MarvelCard)

        Dim ShuffledCardDeck As New List(Of MarvelCard)
        While Not UnshuffledDeck.Count = 0
            Dim CardIndex As Integer = GetRandomNumber(0, UnshuffledDeck.Count)
            Dim SelectedCard As MarvelCard = UnshuffledDeck.Item(CardIndex)
            ShuffledCardDeck.Add(SelectedCard)
            UnshuffledDeck.Remove(SelectedCard)
        End While
        Return ShuffledCardDeck

    End Function

#End Region

    Public Function GetRandomNumber(ByVal iMinValue As Integer, ByVal iMaxValue As Integer) As Integer

        Dim RandomClass As New Random
        Dim RandomNumber As Integer = RandomClass.Next(iMinValue, iMaxValue)
        Return RandomNumber

    End Function

    Public Sub SwitchActivePlayer(ByVal Board As Board)

        Dim TempPlayer As New Player("", 0)
        TempPlayer = _ActivePlayer
        _ActivePlayer = _InactivePlayer
        _InactivePlayer = TempPlayer

    End Sub

End Module
