Public Class ScienceCardPlayerBoardUC

    Private _ScienceCard As ScienceCard

    Public Sub New(ByVal ScienceCard As ScienceCard)

        InitializeComponent()
        _ScienceCard = ScienceCard
        Me.BackgroundImage = ScienceCard.Image

    End Sub

End Class
