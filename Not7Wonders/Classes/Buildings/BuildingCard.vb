Public Class BuildingCard

#Region "Enums"

    Public Enum CardAge
        I
        II
        III
    End Enum

    Public Enum Symbol
        None
        Amphora
        Barrel
        Mask
        Palace
        Sun
        Drop
        Pillar
        Moon
        Target
        Helmet
        Horseshoe
        Sword
        Tower
        Harp
        Gear
        Book
        Lamp
    End Enum

    Public Enum Item
        None
        Globe
        Wheel
        Sundial
        Mortar
        Pendulum
        Balance
    End Enum

    Public Enum CardColor
        Brown
        Gray
        Red
        Blue
        Green
        Yellow
        Purple
    End Enum

#End Region

#Region "Properties"

    'Infos
    Public Property Color As CardColor
    Public Property Name As String
    Public Property Age As CardAge

    Public Property IsVisible As Boolean
    Public Property Parent As List(Of BuildingCard)

    'Costs
    Public Property GoldCost As Integer
    Public Property ClayCost As Integer
    Public Property WoodCost As Integer
    Public Property StoneCost As Integer
    Public Property GlassCost As Integer
    Public Property PaperCost As Integer
    Public Property SymbolCost As Symbol

    'Gains
    Public Property ClayGain As Integer
    Public Property WoodGain As Integer
    Public Property StoneGain As Integer
    Public Property GlassGain As Integer
    Public Property PaperGain As Integer
    Public Property ShieldGain As Integer

    Public Property VictoryGain As Integer
    Public Property SymbolGain As Symbol
    Public Property ItemGain As Item
    Public Property GoldGain As Integer

    Public Property WoodRuleUpdate As Boolean
    Public Property StoneRuleUpdate As Boolean
    Public Property ClayRuleUpdate As Boolean
    Public Property PaperGlassRuleUpdate As Boolean

    Public Property TripleGain As Boolean
    Public Property DoubleGain As Boolean

    Public Property MarvelGoldGain As Boolean
    Public Property RedCardGoldGain As Boolean
    Public Property GrayCardGoldGain As Boolean
    Public Property YellowCardGoldGain As Boolean
    Public Property BrownCardGoldGain As Boolean

    Public Property MarvelVictoryGain As Boolean
    Public Property RedCardGoldVictoryGain As Boolean
    Public Property GrayBrownCardGoldVictoryGain As Boolean
    Public Property YellowCardGoldVictoryGain As Boolean
    Public Property GreenCardGoldVictoryGain As Boolean
    Public Property BlueCardGoldVictoryGain As Boolean
    Public Property GoldVictoryGain As Boolean

#End Region

#Region "Constructor"

    ''' <summary>
    ''' Brown Card
    ''' </summary>
    Public Sub New(ByVal eColor As CardColor, ByVal sName As String, ByVal eAge As CardAge,
                   ByVal iGoldCost As Integer, ByVal iClayGain As Integer, ByVal iWoodGain As Integer, ByVal iStoneGain As Integer)

        Color = eColor
        Name = sName
        Age = eAge
        GoldCost = iGoldCost
        ClayGain = iClayGain
        WoodGain = iWoodGain
        StoneGain = iStoneGain

    End Sub

    ''' <summary>
    ''' Grey Card
    ''' </summary>
    Public Sub New(ByVal eColor As CardColor, ByVal sName As String, ByVal eAge As CardAge,
                   ByVal iGoldCost As Integer, ByVal iGlassGain As Integer, ByVal iPaperGain As Integer)

        Color = eColor
        Name = sName
        Age = eAge
        GoldCost = iGoldCost
        GlassGain = iGlassGain
        PaperGain = iPaperGain

    End Sub

    ''' <summary>
    ''' Red Car
    ''' </summary>
    Public Sub New(ByVal eColor As CardColor, ByVal sName As String, ByVal eAge As CardAge,
                   ByVal iGoldCost As Integer, ByVal iClayCost As Integer, ByVal iWoodCost As Integer, ByVal iStoneCost As Integer,
                   ByVal iGlassCost As Integer, ByVal iPaperCost As Integer, ByVal eSymbolCost As Symbol,
                   ByVal iShieldGain As Integer, ByVal eSymbolGain As Symbol)

        Color = eColor
        Name = sName
        Age = eAge
        GoldCost = iGoldCost
        ClayCost = iClayCost
        WoodCost = iWoodCost
        StoneCost = iStoneCost
        GlassCost = iGlassCost
        PaperCost = iPaperCost
        SymbolCost = eSymbolCost
        ShieldGain = iShieldGain
        SymbolGain = eSymbolGain

    End Sub

    ''' <summary>
    ''' Blue Card
    ''' </summary>
    Public Sub New(ByVal eColor As CardColor, ByVal sName As String, ByVal eAge As CardAge,
                   ByVal iClayCost As Integer, ByVal iWoodCost As Integer, ByVal iStoneCost As Integer,
                   ByVal iGlassCost As Integer, ByVal iPaperCost As Integer, ByVal eSymbolCost As Symbol,
                   ByVal iVictoryGain As Integer, ByVal eSymbolGain As Symbol)

        Color = eColor
        Name = sName
        Age = eAge
        ClayCost = iClayCost
        WoodCost = iWoodCost
        StoneCost = iStoneCost
        GlassCost = iGlassCost
        PaperCost = iPaperCost
        SymbolCost = eSymbolCost
        VictoryGain = iVictoryGain
        SymbolGain = eSymbolGain

    End Sub

    ''' <summary>
    ''' Green Card
    ''' </summary>
    Public Sub New(ByVal eColor As CardColor, ByVal sName As String, ByVal eAge As CardAge,
                   ByVal iGoldCost As Integer, ByVal iClayCost As Integer, ByVal iWoodCost As Integer, ByVal iStoneCost As Integer,
                   ByVal iGlassCost As Integer, ByVal iPaperCost As Integer, ByVal eSymbolCost As Symbol,
                   ByVal iVictoryGain As Integer, ByVal eItemGain As Item, ByVal eSymbolGain As Symbol)

        Color = eColor
        Name = sName
        Age = eAge
        GoldCost = iGoldCost
        ClayCost = iClayCost
        WoodCost = iWoodCost
        StoneCost = iStoneCost
        GlassCost = iGlassCost
        PaperCost = iPaperCost
        SymbolCost = eSymbolCost
        VictoryGain = iVictoryGain
        ItemGain = eItemGain
        SymbolGain = eSymbolGain

    End Sub

    ''' <summary>
    ''' Yellow Card
    ''' </summary>
    Public Sub New(ByVal eColor As CardColor, ByVal sName As String, ByVal eAge As CardAge,
                   ByVal iGoldCost As Integer, ByVal iClayCost As Integer, ByVal iWoodCost As Integer, ByVal iStoneCost As Integer,
                   ByVal iGlassCost As Integer, ByVal iPaperCost As Integer, ByVal eSymbolCost As Symbol,
                   ByVal iGoldGain As Integer, ByVal iVictoryGain As Integer, ByVal bWoodRuleUpdate As Boolean, ByVal bStoneRuleUpdate As Boolean, ByVal bClayRuleUpdate As Boolean,
                   ByVal bPaperGlassRuleUpdate As Boolean, ByVal bClayStoneWoodGain As Boolean, ByVal bGlassPaperGain As Boolean,
                   ByVal bMarvelGoldGain As Boolean, ByVal bRedCardGoldGain As Boolean, ByVal bGreyCardGoldGain As Boolean,
                   ByVal bYellowCardGoldGain As Boolean, ByVal bBrownCardGoldGain As Boolean, ByVal eSymbolGain As Symbol)

        Color = eColor
        Name = sName
        Age = eAge
        GoldCost = iGoldCost
        ClayCost = iClayCost
        WoodCost = iWoodCost
        StoneCost = iStoneCost
        GlassCost = iGlassCost
        PaperCost = iPaperCost
        SymbolCost = eSymbolCost
        GoldGain = iGoldGain
        VictoryGain = iVictoryGain
        WoodRuleUpdate = bWoodRuleUpdate
        StoneRuleUpdate = bStoneRuleUpdate
        ClayRuleUpdate = bClayRuleUpdate
        PaperGlassRuleUpdate = bPaperGlassRuleUpdate
        TripleGain = bClayStoneWoodGain
        DoubleGain = bGlassPaperGain
        MarvelGoldGain = bMarvelGoldGain
        RedCardGoldGain = bRedCardGoldGain
        GrayCardGoldGain = bGreyCardGoldGain
        YellowCardGoldGain = bYellowCardGoldGain
        BrownCardGoldGain = bBrownCardGoldGain
        SymbolGain = eSymbolGain

    End Sub

    ''' <summary>
    ''' Purple Card
    ''' </summary>
    Public Sub New(ByVal eColor As CardColor, ByVal sName As String, ByVal eAge As CardAge,
                   ByVal iClayCost As Integer, ByVal iWoodCost As Integer, ByVal iStoneCost As Integer,
                   ByVal iGlassCost As Integer, ByVal iPaperCost As Integer,
                   ByVal bMarvelVictoryGain As Boolean, ByVal bRedCardGoldVictoryGain As Boolean, ByVal bGreyBrownCardGoldVictoryGain As Boolean,
                   ByVal bYellowCardGoldVictoryGain As Boolean, ByVal bGreenCardGoldVictoryGain As Boolean, ByVal bBlueCardGoldVictoryGain As Boolean,
                   ByVal bGoldVictoryGain As Boolean)

        Color = eColor
        Name = sName
        Age = eAge
        ClayCost = iClayCost
        WoodCost = iWoodCost
        StoneCost = iStoneCost
        GlassCost = iGlassCost
        PaperCost = iPaperCost
        MarvelVictoryGain = bMarvelVictoryGain
        RedCardGoldVictoryGain = bRedCardGoldVictoryGain
        GrayBrownCardGoldVictoryGain = bGreyBrownCardGoldVictoryGain
        YellowCardGoldVictoryGain = bYellowCardGoldVictoryGain
        GreenCardGoldVictoryGain = bGreenCardGoldVictoryGain
        BlueCardGoldVictoryGain = bBlueCardGoldVictoryGain
        GoldVictoryGain = bGoldVictoryGain

    End Sub

#End Region

End Class
