Public Class ItemPickUC

    Private _ItemName As String

    Public Sub New(ByVal ItemName As String)

        InitializeComponent()
        _ItemName = ItemName
        GetImage

    End Sub

    Private Sub GetImage()

        If _ItemName = "Globe" Then
            Me.BackgroundImage = My.Resources.Globe
        ElseIf _ItemName = "Wheel" Then
            Me.BackgroundImage = My.Resources.Wheel
        ElseIf _ItemName = "Sundial" Then
            Me.BackgroundImage = My.Resources.Sundial
        ElseIf _ItemName = "Mortar" Then
            Me.BackgroundImage = My.Resources.Mortar
        ElseIf _ItemName = "Pendulum" Then
            Me.BackgroundImage = My.Resources.Pendulum
        ElseIf _ItemName = "Balance" Then
            Me.BackgroundImage = My.Resources.Balance
        End If

    End Sub

    Private Sub ItemPickUC_Load(sender As Object, e As EventArgs) Handles MyBase.Click

        If _ActivePlayer.ListOfItems.Contains(_ItemName) Then
            Dim ChooseScienceCoin = New SciencePick(SciencePick.ScienceDeckType.Played)
            ChooseScienceCoin.Show()
        Else
            _ActivePlayer.ListOfItems.Add(_ItemName)
        End If

        If _ActivePlayer.ListOfItems.Count = 6 Then
            _ActivePlayer.ScienceVictory = True
            Dim NewEndgame = New EndGame
            NewEndgame.Show()
        End If

    End Sub

End Class
