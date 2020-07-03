Public Class MarvelCardPickUC

    Private _MarvelCard As MarvelCard
    Private _Form As MarvelPick

    Public Sub New(ByVal MarvelCard As MarvelCard, ByVal MarvelPickForm As MarvelPick)

        InitializeComponent()
        _MarvelCard = MarvelCard
        _Form = MarvelPickForm
        Me.BackgroundImage = _MarvelCard.Image
        ToolTipMarvel.SetToolTip(Me, _MarvelCard.Description)

    End Sub

    Private Sub Marvel_Click(sender As Object, e As EventArgs) Handles Me.Click

        _ActivePlayer.ListOfMarvels.Add(_MarvelCard)
        Me.Hide()

        If _FirstMarvelDraw.Count = 4 Then
            _FirstMarvelDraw.Remove(_MarvelCard)
            SwitchActivePlayer(Nothing)
            _Form.LabelActivePlayerName.Text = _ActivePlayer.Name
        ElseIf _FirstMarvelDraw.Count = 3 Then
            _FirstMarvelDraw.Remove(_MarvelCard)
        ElseIf _FirstMarvelDraw.Count = 2 Then
            _FirstMarvelDraw.Remove(_MarvelCard)
            SwitchActivePlayer(Nothing)
            _Form.LabelActivePlayerName.Text = _ActivePlayer.Name
        ElseIf _FirstMarvelDraw.Count = 1 Then
            _FirstMarvelDraw.Remove(_MarvelCard)
            SwitchActivePlayer(Nothing)
            _Form.LabelActivePlayerName.Text = _ActivePlayer.Name
            _Form.EndFirstMarvelDraw()
        ElseIf _FirstMarvelDraw.Count = 0 AndAlso _SecondMarvelDraw.Count = 4 Then
            _SecondMarvelDraw.Remove(_MarvelCard)
            SwitchActivePlayer(Nothing)
            _Form.LabelActivePlayerName.Text = _ActivePlayer.Name
        ElseIf _FirstMarvelDraw.Count = 0 AndAlso _SecondMarvelDraw.Count = 3 Then
            _SecondMarvelDraw.Remove(_MarvelCard)
        ElseIf _FirstMarvelDraw.Count = 0 AndAlso _SecondMarvelDraw.Count = 2 Then
            _SecondMarvelDraw.Remove(_MarvelCard)
            SwitchActivePlayer(Nothing)
            _Form.LabelActivePlayerName.Text = _ActivePlayer.Name
        ElseIf _FirstMarvelDraw.Count = 0 AndAlso _SecondMarvelDraw.Count = 1 Then
            _SecondMarvelDraw.Remove(_MarvelCard)
            _Form.EndSecondMarvelDraw()
        End If

    End Sub

End Class
