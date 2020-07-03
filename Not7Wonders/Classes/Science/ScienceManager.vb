Module ScienceManager

    Public Function CreateScienceDeck() As List(Of ScienceCard)

        Dim UnshuffledScienceDeck As New List(Of ScienceCard)
        Dim Card1 As New ScienceCard("Architecture", My.Resources.Architecture)
        Dim Card2 As New ScienceCard("Maçonnerie", My.Resources.Masonry)
        Dim Card3 As New ScienceCard("Mathématiques", My.Resources.Mathematics)
        Dim Card4 As New ScienceCard("Philosophie", My.Resources.Philosophy)
        Dim Card5 As New ScienceCard("Loi", My.Resources.Law)
        Dim Card6 As New ScienceCard("Urbanisme", My.Resources.Urbanism)
        Dim Card7 As New ScienceCard("Economie", My.Resources.Economy)
        Dim Card8 As New ScienceCard("Agriculture", My.Resources.Agriculture)
        Dim Card9 As New ScienceCard("Stratégie", My.Resources.Strategy)
        Dim Card10 As New ScienceCard("Théologie", My.Resources.Theology)
        UnshuffledScienceDeck.AddRange({Card1, Card2, Card3, Card4, Card5, Card6, Card7, Card8, Card9, Card10})

        Dim Shuffle1 As List(Of ScienceCard) = ShuffleDeck(UnshuffledScienceDeck)
        Dim Shuffle2 As List(Of ScienceCard) = ShuffleDeck(Shuffle1)
        Dim Shuffle3 As List(Of ScienceCard) = ShuffleDeck(Shuffle2)
        Dim Shuffle4 As List(Of ScienceCard) = ShuffleDeck(Shuffle3)
        Dim Shuffle5 As List(Of ScienceCard) = ShuffleDeck(Shuffle4)
        Dim Shuffle6 As List(Of ScienceCard) = ShuffleDeck(Shuffle5)
        Dim Shuffle7 As List(Of ScienceCard) = ShuffleDeck(Shuffle6)
        Dim Shuffle8 As List(Of ScienceCard) = ShuffleDeck(Shuffle7)
        Dim ShuffledScienceDeck As List(Of ScienceCard) = ShuffleDeck(Shuffle8)

        Return ShuffledScienceDeck

    End Function

    Public Function GetUnselectedScienceCards(ByVal AllScienceCards As List(Of ScienceCard), ByVal SelectedScienceCards As List(Of ScienceCard)) As List(Of ScienceCard)

        Dim SelectedScienceCardsNames As New List(Of String)
        For Each SelectedScience As ScienceCard In SelectedScienceCards
            SelectedScienceCardsNames.Add(SelectedScience.Name)
        Next
        Dim UnselectedScienceCards As New List(Of ScienceCard)
        For Each Science As ScienceCard In AllScienceCards
            If Not SelectedScienceCardsNames.Contains(Science.Name) Then
                UnselectedScienceCards.Add(Science)
            End If
        Next
        Return UnselectedScienceCards

    End Function

End Module
