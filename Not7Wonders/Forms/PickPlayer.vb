Public Class PickPlayer

    Public Sub New()

        InitializeComponent()
        CheckPickingPlayer()
        ButtonP1.Text = _ActivePlayer.Name
        ButtonP2.Text = _InactivePlayer.Name

    End Sub

    Private Sub CheckPickingPlayer()

        If _ActivePlayer.Position = 1 Then
            If _MilitaryProgress < 10 Then
                LabelExplain.Text = _InactivePlayer.Name & " choisit qui commence la manche suivante."
            ElseIf _MilitaryProgress > 10 Then
                LabelExplain.Text = _ActivePlayer.Name & " choisit qui commence la manche suivante."
            ElseIf _MilitaryProgress = 10 Then
                LabelExplain.Text = _ActivePlayer.Name & " choisit qui commence la manche suivante."
            End If
        ElseIf _InactivePlayer.Position = 1 Then
            If _MilitaryProgress < 10 Then
                LabelExplain.Text = _ActivePlayer.Name & " choisit qui commence la manche suivante."
            ElseIf _MilitaryProgress > 10 Then
                LabelExplain.Text = _InactivePlayer.Name & " choisit qui commence la manche suivante."
            ElseIf _MilitaryProgress = 10 Then
                LabelExplain.Text = _ActivePlayer.Name & " choisit qui commence la manche suivante."
            End If
        End If

    End Sub

    Private Sub ButtonP1_Click(sender As Object, e As EventArgs) Handles ButtonP1.Click

        If _ActivePlayer.Name = ButtonP1.Text Then
            Me.Close()
        Else
            Dim TempPlayer As New Player("", 0)
            TempPlayer = _ActivePlayer
            _ActivePlayer = _InactivePlayer
            _InactivePlayer = TempPlayer
            Me.Close()
        End If

    End Sub

    Private Sub ButtonP2_Click(sender As Object, e As EventArgs) Handles ButtonP2.Click

        If _ActivePlayer.Name = ButtonP2.Text Then
            Me.Close()
        Else
            Dim TempPlayer As New Player("", 0)
            TempPlayer = _ActivePlayer
            _ActivePlayer = _InactivePlayer
            _InactivePlayer = TempPlayer
            Me.Close()
        End If

    End Sub

End Class