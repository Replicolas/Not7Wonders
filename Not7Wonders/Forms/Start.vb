Public Class Start

    Public Sub New()

        InitializeComponent()
        _Turn = 0
        _MilitaryProgress = 10
        _ListOfSoldBuildingCards = New List(Of BuildingCard)
        _FirstMarvelDraw = New List(Of MarvelCard)
        _SecondMarvelDraw = New List(Of MarvelCard)
        _AllMarvels = New List(Of MarvelCard)
        _SelectedMarvels = New List(Of MarvelCard)
        _UnselectedMarvels = New List(Of MarvelCard)
        _SelectedScienceCards = New List(Of ScienceCard)
        _UnselectedScienceCards = New List(Of ScienceCard)
        _BuildingCardsUC = New List(Of BuildingCardBoardUC)

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click

        Dim PlayerA As New Player(TextBoxPlayerA.Text, 1)
        Dim PlayerB As New Player(TextBoxPlayerB.Text, 2)

        Dim TempListOfPlayers As New List(Of Player)
        TempListOfPlayers.AddRange({PlayerA, PlayerB})

        Dim RandomPlayer As New Random
        Dim RandomNumber As Integer = RandomPlayer.Next(0, 2)
        Dim TempActivePlayer As Player = TempListOfPlayers.Item(RandomNumber)
        _ActivePlayer = TempActivePlayer
        TempListOfPlayers.Remove(TempListOfPlayers.Item(RandomNumber))
        _InactivePlayer = TempListOfPlayers.Last

        Dim NewMarvelPickPage = New MarvelPick
        NewMarvelPickPage.Show()
        Me.Hide()

    End Sub

End Class