Public Class GoldPlayerBoardUC

    Private _GoldCount As Integer

    Public Sub New(ByVal GoldCount As Integer)

        InitializeComponent()
        _GoldCount = GoldCount
        LabelGoldCount.Text = GoldCount

    End Sub

End Class
