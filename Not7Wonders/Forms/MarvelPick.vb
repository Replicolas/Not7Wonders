Public Class MarvelPick

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub MarvelPick_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _AllMarvels = CreateMarvelDeck()
        _SelectedMarvels = CreateMarvelDeck()
        RemoveRandomCardInDeck(_SelectedMarvels)
        RemoveRandomCardInDeck(_SelectedMarvels)
        RemoveRandomCardInDeck(_SelectedMarvels)
        RemoveRandomCardInDeck(_SelectedMarvels)
        _UnselectedMarvels = GetUnselectedMarvels(_AllMarvels, _SelectedMarvels)

        Dim FirstDraw As New List(Of MarvelCard)
        FirstDraw.Add(_SelectedMarvels.Item(0))
        FirstDraw.Add(_SelectedMarvels.Item(1))
        FirstDraw.Add(_SelectedMarvels.Item(2))
        FirstDraw.Add(_SelectedMarvels.Item(3))
        _FirstMarvelDraw = FirstDraw

        Panel0.Controls.Add(New MarvelCardPickUC(_FirstMarvelDraw.Item(0), Me))
        Panel1.Controls.Add(New MarvelCardPickUC(_FirstMarvelDraw.Item(1), Me))
        Panel2.Controls.Add(New MarvelCardPickUC(_FirstMarvelDraw.Item(2), Me))
        Panel3.Controls.Add(New MarvelCardPickUC(_FirstMarvelDraw.Item(3), Me))

        LabelActivePlayerName.Text = _ActivePlayer.Name
        LabelPhase.Text = "Phase 1/2"

    End Sub

    Public Sub EndFirstMarvelDraw()

        Dim SecondDraw As New List(Of MarvelCard)
        SecondDraw.Add(_SelectedMarvels.Item(4))
        SecondDraw.Add(_SelectedMarvels.Item(5))
        SecondDraw.Add(_SelectedMarvels.Item(6))
        SecondDraw.Add(_SelectedMarvels.Item(7))
        _SecondMarvelDraw = SecondDraw

        Panel0.Controls.Add(New MarvelCardPickUC(_SecondMarvelDraw.Item(0), Me))
        Panel1.Controls.Add(New MarvelCardPickUC(_SecondMarvelDraw.Item(1), Me))
        Panel2.Controls.Add(New MarvelCardPickUC(_SecondMarvelDraw.Item(2), Me))
        Panel3.Controls.Add(New MarvelCardPickUC(_SecondMarvelDraw.Item(3), Me))

        LabelPhase.Text = "Phase 2/2"

    End Sub

    Public Sub EndSecondMarvelDraw()

        Dim NewBoard = New Board
        NewBoard.Show()
        Me.Hide()

    End Sub

End Class