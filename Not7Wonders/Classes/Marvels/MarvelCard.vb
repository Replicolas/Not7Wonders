Public Class MarvelCard

#Region "Properties"

    'Infos
    Public Property Name As String
    Public Property Image As Image
    Public Property Description As String
    Public Property IsCompleted As Boolean

    'Costs
    Public Property WoodCost As Integer
    Public Property ClayCost As Integer
    Public Property StoneCost As Integer
    Public Property GlassCost As Integer
    Public Property PaperCost As Integer

    'Gains
    Public Property GoldGain As Integer
    Public Property VictoryGain As Integer
    Public Property ShieldGain As Integer
    Public Property CardPick As Boolean
    Public Property SciencePick As Boolean
    Public Property GoldDestruction As Integer
    Public Property GrayCardDestruction As Boolean
    Public Property BrownCardDestruction As Boolean
    Public Property GlassPaperGain As Boolean
    Public Property WoodStoneClayGain As Boolean
    Public Property Replay As Boolean

#End Region

#Region "Constructors"

    Public Sub New(ByVal sName As String, ByVal iImage As Image,
                   ByVal iWoodCost As Integer, ByVal iClayCost As Integer, ByVal iStoneCost As Integer, ByVal iGlassCost As Integer, ByVal iPaperCost As Integer,
                   ByVal iGoldGain As Integer, ByVal iVictoryGain As Integer, ByVal iShieldGain As Integer,
                   ByVal bCardPick As Boolean, ByVal bSciencePick As Boolean, ByVal bGoldDestruction As Boolean, ByVal bGrayCardDestruction As Boolean,
                   ByVal bBrownCardDestruction As Boolean, ByVal bGlassPaperGain As Boolean, ByVal bWoodStoneClayGain As Boolean, ByVal bReplay As Boolean,
                   ByVal sInfos As String)

        Name = sName
        Image = iImage
        WoodCost = iWoodCost
        ClayCost = iClayCost
        StoneCost = iStoneCost
        GlassCost = iGlassCost
        PaperCost = iPaperCost
        GoldGain = iGoldGain
        VictoryGain = iVictoryGain
        ShieldGain = iShieldGain
        CardPick = bCardPick
        SciencePick = bSciencePick
        GoldDestruction = bGoldDestruction
        GrayCardDestruction = bGrayCardDestruction
        BrownCardDestruction = bBrownCardDestruction
        GlassPaperGain = bGlassPaperGain
        WoodStoneClayGain = bWoodStoneClayGain
        Replay = bReplay
        Description = sInfos
        IsCompleted = False

    End Sub

#End Region

End Class