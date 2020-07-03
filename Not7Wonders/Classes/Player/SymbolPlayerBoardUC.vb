Public Class SymbolPlayerBoardUC

    Private _SymbolName As String

    Public Sub New(ByVal SymbolName As String)

        InitializeComponent()
        _SymbolName = SymbolName
        GetBackGroundImage()

    End Sub

    Private Sub GetBackGroundImage()

        If _SymbolName = "Amphora" Then
            Me.BackgroundImage = My.Resources.Amphora
        ElseIf _SymbolName = "Barrel" Then
            Me.BackgroundImage = My.Resources.Barrel
        ElseIf _SymbolName = "Mask" Then
            Me.BackgroundImage = My.Resources.Mask
        ElseIf _SymbolName = "Palace" Then
            Me.BackgroundImage = My.Resources.Palace
        ElseIf _SymbolName = "Sun" Then
            Me.BackgroundImage = My.Resources.Sun
        ElseIf _SymbolName = "Drop" Then
            Me.BackgroundImage = My.Resources.Drop
        ElseIf _SymbolName = "Pillar" Then
            Me.BackgroundImage = My.Resources.Pillar
        ElseIf _SymbolName = "Moon" Then
            Me.BackgroundImage = My.Resources.Moon
        ElseIf _SymbolName = "Target" Then
            Me.BackgroundImage = My.Resources.Target
        ElseIf _SymbolName = "Helmet" Then
            Me.BackgroundImage = My.Resources.Helmet
        ElseIf _SymbolName = "Horseshoe" Then
            Me.BackgroundImage = My.Resources.Horseshoe
        ElseIf _SymbolName = "Sword" Then
            Me.BackgroundImage = My.Resources.Sword
        ElseIf _SymbolName = "Tower" Then
            Me.BackgroundImage = My.Resources.Tower
        ElseIf _SymbolName = "Harp" Then
            Me.BackgroundImage = My.Resources.Harp
        ElseIf _SymbolName = "Gear" Then
            Me.BackgroundImage = My.Resources.Gear
        ElseIf _SymbolName = "Book" Then
            Me.BackgroundImage = My.Resources.Book
        ElseIf _SymbolName = "Lamp" Then
            Me.BackgroundImage = My.Resources.Lamp
        End If

    End Sub

End Class
