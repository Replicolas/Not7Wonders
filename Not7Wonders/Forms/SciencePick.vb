Public Class SciencePick

    Private ReadOnly _ScienceDeckType As ScienceDeckType

    Public Enum ScienceDeckType
        Played
        Dispatched
    End Enum

    Public Sub New(ByVal ScienceDeckType As ScienceDeckType)

        InitializeComponent()
        _ScienceDeckType = ScienceDeckType
        DisplayDeck()
        Label.Text = _ActivePlayer.Name & " sélectionne un jeton de progrès"

    End Sub

    Private Sub DisplayDeck()

        If _ScienceDeckType = ScienceDeckType.Played Then

            If _SelectedScienceCards.Item(0).IsSelected = False Then
                PanelScience1.Controls.Add(New ScienceCardPickUC(_SelectedScienceCards.Item(0), ScienceCardPickUC.ScienceCardLocation.Pick, Me))
            End If
            If _SelectedScienceCards.Item(1).IsSelected = False Then
                PanelScience2.Controls.Add(New ScienceCardPickUC(_SelectedScienceCards.Item(1), ScienceCardPickUC.ScienceCardLocation.Pick, Me))
            End If
            If _SelectedScienceCards.Item(2).IsSelected = False Then
                PanelScience3.Controls.Add(New ScienceCardPickUC(_SelectedScienceCards.Item(2), ScienceCardPickUC.ScienceCardLocation.Pick, Me))
            End If
            If _SelectedScienceCards.Item(3).IsSelected = False Then
                PanelScience4.Controls.Add(New ScienceCardPickUC(_SelectedScienceCards.Item(3), ScienceCardPickUC.ScienceCardLocation.Pick, Me))
            End If
            If _SelectedScienceCards.Item(4).IsSelected = False Then
                PanelScience5.Controls.Add(New ScienceCardPickUC(_SelectedScienceCards.Item(4), ScienceCardPickUC.ScienceCardLocation.Pick, Me))
            End If

        ElseIf _ScienceDeckType = ScienceDeckType.Dispatched Then

            If _UnselectedScienceCards.Item(0).IsSelected = False Then
                PanelScience2.Controls.Add(New ScienceCardPickUC(_SelectedScienceCards.Item(0), ScienceCardPickUC.ScienceCardLocation.Pick, Me))
            End If
            If _UnselectedScienceCards.Item(1).IsSelected = False Then
                PanelScience3.Controls.Add(New ScienceCardPickUC(_SelectedScienceCards.Item(1), ScienceCardPickUC.ScienceCardLocation.Pick, Me))
            End If
            If _UnselectedScienceCards.Item(2).IsSelected = False Then
                PanelScience4.Controls.Add(New ScienceCardPickUC(_SelectedScienceCards.Item(2), ScienceCardPickUC.ScienceCardLocation.Pick, Me))
            End If

        End If

    End Sub

End Class