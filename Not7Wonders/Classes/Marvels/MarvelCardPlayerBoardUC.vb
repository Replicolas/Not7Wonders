Public Class MarvelCardPlayerBoardUC

    Private _MarvelCard As MarvelCard

    Public Sub New(ByVal MarvelCard As MarvelCard)

        InitializeComponent()
        _MarvelCard = MarvelCard
        Me.BackgroundImage = _MarvelCard.Image
        ToolTipMarvel.SetToolTip(Me, _MarvelCard.Description)

    End Sub

End Class
