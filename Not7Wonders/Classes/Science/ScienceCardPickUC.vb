Public Class ScienceCardPickUC

    Private _ScienceCard As ScienceCard
    Private _ScienceCardLocation As ScienceCardLocation
    Private _Form As Form

    Public Enum ScienceCardLocation
        Board
        Pick
    End Enum

    Public Sub New(ByVal ScienceCard As ScienceCard, ByVal ScienceCardLocation As ScienceCardLocation, ByVal Form As Form)

        InitializeComponent()
        _ScienceCard = ScienceCard
        _ScienceCardLocation = ScienceCardLocation
        _Form = Form
        Me.BackgroundImage = _ScienceCard.Image

    End Sub

    Private Sub ScienceCardPickUC_Click(sender As Object, e As EventArgs) Handles MyBase.Click

        If _ScienceCardLocation = ScienceCardLocation.Pick Then
            If _ScienceCard.Name = "Architecture" Then
                _ActivePlayer.ScienceArchitecture = True
            ElseIf _ScienceCard.Name = "Maçonnerie" Then
                _ActivePlayer.ScienceMaconnerie = True
            ElseIf _ScienceCard.Name = "Mathématiques" Then
                _ActivePlayer.ScienceMathematiques = True
            ElseIf _ScienceCard.Name = "Philosophie" Then
                _ActivePlayer.SciencePhilosophie = True
            ElseIf _ScienceCard.Name = "Loi" Then
                Dim NewItem = New ItemPick()
                NewItem.Show()
            ElseIf _ScienceCard.Name = "Urbanisme" Then
                _ActivePlayer.GoldCount += 6
                _ActivePlayer.ScienceUrbanisme = True
            ElseIf _ScienceCard.Name = "Economie" Then
                _ActivePlayer.ScienceEconomie = True
            ElseIf _ScienceCard.Name = "Agriculture" Then
                _ActivePlayer.GoldCount += 6
                _ActivePlayer.ScienceAgriculture = True
            ElseIf _ScienceCard.Name = "Stratégie" Then
                _ActivePlayer.ScienceStrategie = True
            ElseIf _ScienceCard.Name = "Théologie" Then
                _ActivePlayer.ScienceTheologie = True
            End If
            _ScienceCard.IsSelected = True
            _ActivePlayer.ListOfScience.Add(_ScienceCard)
            _Form.Close()
        End If

    End Sub

End Class
