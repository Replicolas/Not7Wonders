Public Class PlayerBoard

    Private ReadOnly _Player As Player

    Public Sub New(ByVal Player As Player)

        InitializeComponent()
        _Player = Player
        DisplayMarvels

    End Sub

    Private Sub DisplayMarvels()

        PanelMarvel1.BackgroundImage = _Player.ListOfMarvels.Item(0).Image
        PanelMarvel2.BackgroundImage = _Player.ListOfMarvels.Item(1).Image
        PanelMarvel3.BackgroundImage = _Player.ListOfMarvels.Item(2).Image
        PanelMarvel4.BackgroundImage = _Player.ListOfMarvels.Item(3).Image

    End Sub

End Class
