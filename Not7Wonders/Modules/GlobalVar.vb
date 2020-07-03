Module GlobalVar

    Public _ActivePlayer As Player
    Public _InactivePlayer As Player

    Public _Turn As Integer
    Public _MilitaryProgress As Integer

    'BuildingCards
    Public _BuildingCardsUC As List(Of BuildingCardBoardUC)
    Public _ListOfSoldBuildingCards As List(Of BuildingCard)

    'Marvel Cards
    Public _FirstMarvelDraw As List(Of MarvelCard)
    Public _SecondMarvelDraw As List(Of MarvelCard)
    Public _AllMarvels As List(Of MarvelCard)
    Public _SelectedMarvels As List(Of MarvelCard)
    Public _UnselectedMarvels As List(Of MarvelCard)

    'ScienceCards
    Public _AllScienceCards As List(Of ScienceCard)
    Public _SelectedScienceCards As List(Of ScienceCard)
    Public _UnselectedScienceCards As List(Of ScienceCard)

End Module
