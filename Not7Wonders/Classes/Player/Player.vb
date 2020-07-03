Public Class Player

#Region "Properties"

    'Infos
    Public Property Name As String
    Public Property Position As Integer
    Public Property ListOfCards As List(Of BuildingCard)
    Public Property ListOfScience As List(Of ScienceCard)
    Public Property ListOfMarvels As List(Of MarvelCard)
    Public Property ListOfItems As List(Of String)
    Public Property ListOfSymbols As List(Of String)

    Public Property WoodRule As Boolean
    Public Property ClayRule As Boolean
    Public Property StoneRule As Boolean
    Public Property GlassPaperRule As Boolean
    Public Property TripleCardCount As Integer
    Public Property DoubleCardCount As Integer

    Public Property BrownCardCount As Integer
    Public Property GrayCardCount As Integer
    Public Property RedCardCount As Integer
    Public Property BlueCardCount As Integer
    Public Property GreenCardCount As Integer
    Public Property YellowCardCount As Integer
    Public Property PurpleCardCount As Integer
    Public Property CompletedMarvelsCount As Integer

    Public Property MarvelVictoryGain As Boolean
    Public Property RedCardGoldVictoryGain As Boolean
    Public Property GrayBrownCardGoldVictoryGain As Boolean
    Public Property YellowCardGoldVictoryGain As Boolean
    Public Property GreenCardGoldVictoryGain As Boolean
    Public Property BlueCardGoldVictoryGain As Boolean
    Public Property GoldVictoryGain As Boolean

    Public Property ScienceAgriculture As Boolean
    Public Property ScienceArchitecture As Boolean
    Public Property ScienceEconomie As Boolean
    Public Property ScienceMaconnerie As Boolean
    Public Property ScienceMathematiques As Boolean
    Public Property SciencePhilosophie As Boolean
    Public Property ScienceStrategie As Boolean
    Public Property ScienceTheologie As Boolean
    Public Property ScienceUrbanisme As Boolean

    'Points
    Public Property GoldCount As Integer

    Public Property Military2Points As Boolean
    Public Property Military5Points As Boolean
    Public Property Military10Points As Boolean

    'Ressources
    Public Property StoneCount As Integer
    Public Property ClayCount As Integer
    Public Property WoodCount As Integer
    Public Property GlassCount As Integer
    Public Property PaperCount As Integer

    'Victory
    Public Property TotalScore As Integer
    Public Property BlueCardVictoryPoints As Integer
    Public Property GreenCardVictoryPoints As Integer
    Public Property YellowCardVictoryPoints As Integer
    Public Property PurpleCardVictoryPoints As Integer
    Public Property MarvelVictoryPoints As Integer
    Public Property ScienceVictoryPoints As Integer
    Public Property GoldVictoryPoints As Integer
    Public Property MilitaryVictoryPoints As Integer

    Public Property ScienceVictory As Boolean
    Public Property MilitaryVictory As Boolean

#End Region

#Region "Constructor"

    Public Sub New(ByVal sName As String, ByVal iPosition As Integer)

        Name = sName
        Position = iPosition
        ListOfCards = New List(Of BuildingCard)
        ListOfScience = New List(Of ScienceCard)
        ListOfMarvels = New List(Of MarvelCard)
        ListOfItems = New List(Of String)
        ListOfSymbols = New List(Of String)
        WoodRule = False
        ClayRule = False
        StoneRule = False
        GlassPaperRule = False
        TripleCardCount = 0
        DoubleCardCount = 0
        BrownCardCount = 0
        GrayCardCount = 0
        RedCardCount = 0
        BlueCardCount = 0
        GreenCardCount = 0
        YellowCardCount = 0
        PurpleCardCount = 0
        CompletedMarvelsCount = 0
        GoldCount = 7
        StoneCount = 0
        ClayCount = 0
        WoodCount = 0
        GlassCount = 0
        PaperCount = 0
        TotalScore = 0
        BlueCardVictoryPoints = 0
        GreenCardVictoryPoints = 0
        YellowCardVictoryPoints = 0
        PurpleCardVictoryPoints = 0
        MarvelVictoryPoints = 0
        ScienceVictoryPoints = 0
        GoldVictoryPoints = 0
        MilitaryVictoryPoints = 0
        MarvelVictoryGain = False
        RedCardGoldVictoryGain = False
        GrayBrownCardGoldVictoryGain = False
        YellowCardGoldVictoryGain = False
        GreenCardGoldVictoryGain = False
        BlueCardGoldVictoryGain = False
        GoldVictoryGain = False
        Military2Points = False
        Military5Points = False
        Military10Points = False
        ScienceAgriculture = False
        ScienceArchitecture = False
        ScienceEconomie = False
        ScienceMaconnerie = False
        ScienceMathematiques = False
        SciencePhilosophie = False
        ScienceStrategie = False
        ScienceTheologie = False
        ScienceUrbanisme = False

    End Sub

#End Region

End Class
