Public Class ItemPlayerBoardUC

    Private _ItemName As String

    Public Sub New(ByVal ItemName As String)

        InitializeComponent()
        _ItemName = ItemName
        GetBackgroundImage

    End Sub

    Private Sub GetBackGroundImage()

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
        Else
        End If

    End Sub

End Class
