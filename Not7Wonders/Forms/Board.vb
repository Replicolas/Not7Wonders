Imports Microsoft.Win32

Public Class Board

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub Board_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim FirstAgeDeck As New List(Of BuildingCard)
        FirstAgeDeck = CreateFirstAgeDeck()
        'Rang 1
        Dim BuildingCardUC0 As New BuildingCardBoardUC(FirstAgeDeck.Item(0), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Nothing, Me)
        Dim BuildingCardUC1 As New BuildingCardBoardUC(FirstAgeDeck.Item(1), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Nothing, Me)
        Dim BuildingCardUC2 As New BuildingCardBoardUC(FirstAgeDeck.Item(2), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Nothing, Me)
        Dim BuildingCardUC3 As New BuildingCardBoardUC(FirstAgeDeck.Item(3), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Nothing, Me)
        Dim BuildingCardUC4 As New BuildingCardBoardUC(FirstAgeDeck.Item(4), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Nothing, Me)
        Dim BuildingCardUC5 As New BuildingCardBoardUC(FirstAgeDeck.Item(5), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Nothing, Me)
        'Rang 2
        Dim Temp1 As New List(Of BuildingCardBoardUC)
        Temp1.AddRange({BuildingCardUC0, BuildingCardUC1})
        Dim BuildingCardUC6 As New BuildingCardBoardUC(FirstAgeDeck.Item(6), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp1, Me)
        Dim Temp2 As New List(Of BuildingCardBoardUC)
        Temp2.AddRange({BuildingCardUC2, BuildingCardUC1})
        Dim BuildingCardUC7 As New BuildingCardBoardUC(FirstAgeDeck.Item(7), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp2, Me)
        Dim Temp3 As New List(Of BuildingCardBoardUC)
        Temp3.AddRange({BuildingCardUC3, BuildingCardUC2})
        Dim BuildingCardUC8 As New BuildingCardBoardUC(FirstAgeDeck.Item(8), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp3, Me)
        Dim Temp4 As New List(Of BuildingCardBoardUC)
        Temp4.AddRange({BuildingCardUC4, BuildingCardUC3})
        Dim BuildingCardUC9 As New BuildingCardBoardUC(FirstAgeDeck.Item(9), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp4, Me)
        Dim Temp5 As New List(Of BuildingCardBoardUC)
        Temp5.AddRange({BuildingCardUC5, BuildingCardUC4})
        Dim BuildingCardUC10 As New BuildingCardBoardUC(FirstAgeDeck.Item(10), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp5, Me)
        'Rang 3
        Dim Temp6 As New List(Of BuildingCardBoardUC)
        Temp6.AddRange({BuildingCardUC7, BuildingCardUC6})
        Dim BuildingCardUC11 As New BuildingCardBoardUC(FirstAgeDeck.Item(11), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp6, Me)
        Dim Temp7 As New List(Of BuildingCardBoardUC)
        Temp7.AddRange({BuildingCardUC8, BuildingCardUC7})
        Dim BuildingCardUC12 As New BuildingCardBoardUC(FirstAgeDeck.Item(12), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp7, Me)
        Dim Temp8 As New List(Of BuildingCardBoardUC)
        Temp8.AddRange({BuildingCardUC9, BuildingCardUC8})
        Dim BuildingCardUC13 As New BuildingCardBoardUC(FirstAgeDeck.Item(13), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp8, Me)
        Dim Temp9 As New List(Of BuildingCardBoardUC)
        Temp9.AddRange({BuildingCardUC10, BuildingCardUC9})
        Dim BuildingCardUC14 As New BuildingCardBoardUC(FirstAgeDeck.Item(14), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp9, Me)
        'Rang 4
        Dim Temp10 As New List(Of BuildingCardBoardUC)
        Temp10.AddRange({BuildingCardUC12, BuildingCardUC11})
        Dim BuildingCardUC15 As New BuildingCardBoardUC(FirstAgeDeck.Item(15), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp10, Me)
        Dim Temp11 As New List(Of BuildingCardBoardUC)
        Temp11.AddRange({BuildingCardUC13, BuildingCardUC12})
        Dim BuildingCardUC16 As New BuildingCardBoardUC(FirstAgeDeck.Item(16), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp11, Me)
        Dim Temp12 As New List(Of BuildingCardBoardUC)
        Temp12.AddRange({BuildingCardUC14, BuildingCardUC13})
        Dim BuildingCardUC17 As New BuildingCardBoardUC(FirstAgeDeck.Item(17), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp12, Me)
        'Rang 5
        Dim Temp13 As New List(Of BuildingCardBoardUC)
        Temp13.AddRange({BuildingCardUC16, BuildingCardUC15})
        Dim BuildingCardUC18 As New BuildingCardBoardUC(FirstAgeDeck.Item(18), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp13, Me)
        Dim Temp14 As New List(Of BuildingCardBoardUC)
        Temp14.AddRange({BuildingCardUC17, BuildingCardUC16})
        Dim BuildingCardUC19 As New BuildingCardBoardUC(FirstAgeDeck.Item(19), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp14, Me)
        'Ajout au plateau
        Panel0.Controls.Add(BuildingCardUC0)
        Panel1.Controls.Add(BuildingCardUC1)
        Panel2.Controls.Add(BuildingCardUC2)
        Panel3.Controls.Add(BuildingCardUC3)
        Panel4.Controls.Add(BuildingCardUC4)
        Panel5.Controls.Add(BuildingCardUC5)
        Panel6.Controls.Add(BuildingCardUC6)
        Panel7.Controls.Add(BuildingCardUC7)
        Panel8.Controls.Add(BuildingCardUC8)
        Panel9.Controls.Add(BuildingCardUC9)
        Panel10.Controls.Add(BuildingCardUC10)
        Panel11.Controls.Add(BuildingCardUC11)
        Panel12.Controls.Add(BuildingCardUC12)
        Panel13.Controls.Add(BuildingCardUC13)
        Panel14.Controls.Add(BuildingCardUC14)
        Panel15.Controls.Add(BuildingCardUC15)
        Panel16.Controls.Add(BuildingCardUC16)
        Panel17.Controls.Add(BuildingCardUC17)
        Panel18.Controls.Add(BuildingCardUC18)
        Panel19.Controls.Add(BuildingCardUC19)

        Dim SecondAgeDeck As New List(Of BuildingCard)
        SecondAgeDeck = CreateSecondAgeDeck()
        'Rang 1
        Dim Temp15 As New List(Of BuildingCardBoardUC)
        Temp15.AddRange({BuildingCardUC19, BuildingCardUC18})
        Dim BuildingCardUC20 As New BuildingCardBoardUC(SecondAgeDeck.Item(0), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp15, Me)
        Dim Temp16 As New List(Of BuildingCardBoardUC)
        Temp16.AddRange({BuildingCardUC19, BuildingCardUC18})
        Dim BuildingCardUC21 As New BuildingCardBoardUC(SecondAgeDeck.Item(1), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp16, Me)
        'Rang 2
        Dim Temp17 As New List(Of BuildingCardBoardUC)
        Temp17.AddRange({BuildingCardUC20})
        Dim BuildingCardUC22 As New BuildingCardBoardUC(SecondAgeDeck.Item(2), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp17, Me)
        Dim Temp18 As New List(Of BuildingCardBoardUC)
        Temp18.AddRange({BuildingCardUC21, BuildingCardUC20})
        Dim BuildingCardUC23 As New BuildingCardBoardUC(SecondAgeDeck.Item(3), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp18, Me)
        Dim Temp19 As New List(Of BuildingCardBoardUC)
        Temp19.AddRange({BuildingCardUC21})
        Dim BuildingCardUC24 As New BuildingCardBoardUC(SecondAgeDeck.Item(4), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp19, Me)
        'Rang 3
        Dim Temp20 As New List(Of BuildingCardBoardUC)
        Temp20.AddRange({BuildingCardUC22})
        Dim BuildingCardUC25 As New BuildingCardBoardUC(SecondAgeDeck.Item(5), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp20, Me)
        Dim Temp21 As New List(Of BuildingCardBoardUC)
        Temp21.AddRange({BuildingCardUC23, BuildingCardUC22})
        Dim BuildingCardUC26 As New BuildingCardBoardUC(SecondAgeDeck.Item(6), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp21, Me)
        Dim Temp22 As New List(Of BuildingCardBoardUC)
        Temp22.AddRange({BuildingCardUC24, BuildingCardUC23})
        Dim BuildingCardUC27 As New BuildingCardBoardUC(SecondAgeDeck.Item(7), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp22, Me)
        Dim Temp23 As New List(Of BuildingCardBoardUC)
        Temp23.AddRange({BuildingCardUC24})
        Dim BuildingCardUC28 As New BuildingCardBoardUC(SecondAgeDeck.Item(8), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp23, Me)
        'Rang 4
        Dim Temp24 As New List(Of BuildingCardBoardUC)
        Temp24.AddRange({BuildingCardUC25})
        Dim BuildingCardUC29 As New BuildingCardBoardUC(SecondAgeDeck.Item(9), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp24, Me)
        Dim Temp25 As New List(Of BuildingCardBoardUC)
        Temp25.AddRange({BuildingCardUC26, BuildingCardUC25})
        Dim BuildingCardUC30 As New BuildingCardBoardUC(SecondAgeDeck.Item(10), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp25, Me)
        Dim Temp26 As New List(Of BuildingCardBoardUC)
        Temp26.AddRange({BuildingCardUC27, BuildingCardUC26})
        Dim BuildingCardUC31 As New BuildingCardBoardUC(SecondAgeDeck.Item(11), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp26, Me)
        Dim Temp27 As New List(Of BuildingCardBoardUC)
        Temp27.AddRange({BuildingCardUC28, BuildingCardUC27})
        Dim BuildingCardUC32 As New BuildingCardBoardUC(SecondAgeDeck.Item(12), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp27, Me)
        Dim Temp28 As New List(Of BuildingCardBoardUC)
        Temp28.AddRange({BuildingCardUC28})
        Dim BuildingCardUC33 As New BuildingCardBoardUC(SecondAgeDeck.Item(13), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp28, Me)
        'Rang 5
        Dim Temp29 As New List(Of BuildingCardBoardUC)
        Temp29.AddRange({BuildingCardUC29})
        Dim BuildingCardUC34 As New BuildingCardBoardUC(SecondAgeDeck.Item(14), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp29, Me)
        Dim Temp30 As New List(Of BuildingCardBoardUC)
        Temp30.AddRange({BuildingCardUC30, BuildingCardUC29})
        Dim BuildingCardUC35 As New BuildingCardBoardUC(SecondAgeDeck.Item(15), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp30, Me)
        Dim Temp31 As New List(Of BuildingCardBoardUC)
        Temp31.AddRange({BuildingCardUC31, BuildingCardUC30})
        Dim BuildingCardUC36 As New BuildingCardBoardUC(SecondAgeDeck.Item(16), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp31, Me)
        Dim Temp32 As New List(Of BuildingCardBoardUC)
        Temp32.AddRange({BuildingCardUC32, BuildingCardUC31})
        Dim BuildingCardUC37 As New BuildingCardBoardUC(SecondAgeDeck.Item(17), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp32, Me)
        Dim Temp33 As New List(Of BuildingCardBoardUC)
        Temp33.AddRange({BuildingCardUC33, BuildingCardUC32})
        Dim BuildingCardUC38 As New BuildingCardBoardUC(SecondAgeDeck.Item(18), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp33, Me)
        Dim Temp34 As New List(Of BuildingCardBoardUC)
        Temp34.AddRange({BuildingCardUC33})
        Dim BuildingCardUC39 As New BuildingCardBoardUC(SecondAgeDeck.Item(19), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp34, Me)
        'Ajout au plateau
        Panel20.Controls.Add(BuildingCardUC20)
        Panel21.Controls.Add(BuildingCardUC21)
        Panel22.Controls.Add(BuildingCardUC22)
        Panel23.Controls.Add(BuildingCardUC23)
        Panel24.Controls.Add(BuildingCardUC24)
        Panel25.Controls.Add(BuildingCardUC25)
        Panel26.Controls.Add(BuildingCardUC26)
        Panel27.Controls.Add(BuildingCardUC27)
        Panel28.Controls.Add(BuildingCardUC28)
        Panel29.Controls.Add(BuildingCardUC29)
        Panel30.Controls.Add(BuildingCardUC30)
        Panel31.Controls.Add(BuildingCardUC31)
        Panel32.Controls.Add(BuildingCardUC32)
        Panel33.Controls.Add(BuildingCardUC33)
        Panel34.Controls.Add(BuildingCardUC34)
        Panel35.Controls.Add(BuildingCardUC35)
        Panel36.Controls.Add(BuildingCardUC36)
        Panel37.Controls.Add(BuildingCardUC37)
        Panel38.Controls.Add(BuildingCardUC38)
        Panel39.Controls.Add(BuildingCardUC39)

        Dim ThirdAgeDeck As New List(Of BuildingCard)
        ThirdAgeDeck = CreateThirdAgeDeck()
        'Rang 1
        Dim Temp35 As New List(Of BuildingCardBoardUC)
        Temp35.AddRange({BuildingCardUC34, BuildingCardUC35, BuildingCardUC36, BuildingCardUC37, BuildingCardUC38, BuildingCardUC39})
        Dim BuildingCardUC40 As New BuildingCardBoardUC(ThirdAgeDeck.Item(0), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp35, Me)
        Dim Temp36 As New List(Of BuildingCardBoardUC)
        Temp36.AddRange({BuildingCardUC34, BuildingCardUC35, BuildingCardUC36, BuildingCardUC37, BuildingCardUC38, BuildingCardUC39})
        Dim BuildingCardUC41 As New BuildingCardBoardUC(ThirdAgeDeck.Item(1), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp36, Me)
        'Rang 2
        Dim Temp37 As New List(Of BuildingCardBoardUC)
        Temp37.AddRange({BuildingCardUC40})
        Dim BuildingCardUC42 As New BuildingCardBoardUC(ThirdAgeDeck.Item(2), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp37, Me)
        Dim Temp38 As New List(Of BuildingCardBoardUC)
        Temp38.AddRange({BuildingCardUC41, BuildingCardUC40})
        Dim BuildingCardUC43 As New BuildingCardBoardUC(ThirdAgeDeck.Item(3), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp38, Me)
        Dim Temp39 As New List(Of BuildingCardBoardUC)
        Temp39.AddRange({BuildingCardUC41})
        Dim BuildingCardUC44 As New BuildingCardBoardUC(ThirdAgeDeck.Item(4), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp39, Me)
        'Rang 3
        Dim Temp40 As New List(Of BuildingCardBoardUC)
        Temp40.AddRange({BuildingCardUC42})
        Dim BuildingCardUC45 As New BuildingCardBoardUC(ThirdAgeDeck.Item(5), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp40, Me)
        Dim Temp41 As New List(Of BuildingCardBoardUC)
        Temp41.AddRange({BuildingCardUC43, BuildingCardUC42})
        Dim BuildingCardUC46 As New BuildingCardBoardUC(ThirdAgeDeck.Item(6), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp41, Me)
        Dim Temp42 As New List(Of BuildingCardBoardUC)
        Temp42.AddRange({BuildingCardUC44, BuildingCardUC43})
        Dim BuildingCardUC47 As New BuildingCardBoardUC(ThirdAgeDeck.Item(7), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp42, Me)
        Dim Temp43 As New List(Of BuildingCardBoardUC)
        Temp43.AddRange({BuildingCardUC44})
        Dim BuildingCardUC48 As New BuildingCardBoardUC(ThirdAgeDeck.Item(8), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp43, Me)
        'Rang 4
        Dim Temp44 As New List(Of BuildingCardBoardUC)
        Temp44.AddRange({BuildingCardUC46, BuildingCardUC45})
        Dim BuildingCardUC49 As New BuildingCardBoardUC(ThirdAgeDeck.Item(9), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp44, Me)
        Dim Temp45 As New List(Of BuildingCardBoardUC)
        Temp45.AddRange({BuildingCardUC48, BuildingCardUC47})
        Dim BuildingCardUC50 As New BuildingCardBoardUC(ThirdAgeDeck.Item(10), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp45, Me)
        'Rang 5
        Dim Temp46 As New List(Of BuildingCardBoardUC)
        Temp46.AddRange({BuildingCardUC49})
        Dim BuildingCardUC51 As New BuildingCardBoardUC(ThirdAgeDeck.Item(11), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp46, Me)
        Dim Temp47 As New List(Of BuildingCardBoardUC)
        Temp47.AddRange({BuildingCardUC49})
        Dim BuildingCardUC52 As New BuildingCardBoardUC(ThirdAgeDeck.Item(12), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp47, Me)
        Dim Temp48 As New List(Of BuildingCardBoardUC)
        Temp48.AddRange({BuildingCardUC50})
        Dim BuildingCardUC53 As New BuildingCardBoardUC(ThirdAgeDeck.Item(13), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp48, Me)
        Dim Temp49 As New List(Of BuildingCardBoardUC)
        Temp49.AddRange({BuildingCardUC50})
        Dim BuildingCardUC54 As New BuildingCardBoardUC(ThirdAgeDeck.Item(14), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp49, Me)
        'Rang 6
        Dim Temp50 As New List(Of BuildingCardBoardUC)
        Temp50.AddRange({BuildingCardUC52, BuildingCardUC51})
        Dim BuildingCardUC55 As New BuildingCardBoardUC(ThirdAgeDeck.Item(15), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp50, Me)
        Dim Temp51 As New List(Of BuildingCardBoardUC)
        Temp51.AddRange({BuildingCardUC53, BuildingCardUC52})
        Dim BuildingCardUC56 As New BuildingCardBoardUC(ThirdAgeDeck.Item(16), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp51, Me)
        Dim Temp52 As New List(Of BuildingCardBoardUC)
        Temp52.AddRange({BuildingCardUC54, BuildingCardUC53})
        Dim BuildingCardUC57 As New BuildingCardBoardUC(ThirdAgeDeck.Item(17), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Invisible, Temp52, Me)
        'Rang 7
        Dim Temp53 As New List(Of BuildingCardBoardUC)
        Temp53.AddRange({BuildingCardUC56, BuildingCardUC55})
        Dim BuildingCardUC58 As New BuildingCardBoardUC(ThirdAgeDeck.Item(18), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp53, Me)
        Dim Temp54 As New List(Of BuildingCardBoardUC)
        Temp54.AddRange({BuildingCardUC57, BuildingCardUC56})
        Dim BuildingCardUC59 As New BuildingCardBoardUC(ThirdAgeDeck.Item(19), BuildingCardBoardUC.LocationType.Board, BuildingCardBoardUC.VisibilityType.Visible, Temp54, Me)
        'Ajout au plateau
        Panel40.Controls.Add(BuildingCardUC40)
        Panel41.Controls.Add(BuildingCardUC41)
        Panel42.Controls.Add(BuildingCardUC42)
        Panel43.Controls.Add(BuildingCardUC43)
        Panel44.Controls.Add(BuildingCardUC44)
        Panel45.Controls.Add(BuildingCardUC45)
        Panel46.Controls.Add(BuildingCardUC46)
        Panel47.Controls.Add(BuildingCardUC47)
        Panel48.Controls.Add(BuildingCardUC48)
        Panel49.Controls.Add(BuildingCardUC49)
        Panel50.Controls.Add(BuildingCardUC50)
        Panel51.Controls.Add(BuildingCardUC51)
        Panel52.Controls.Add(BuildingCardUC52)
        Panel53.Controls.Add(BuildingCardUC53)
        Panel54.Controls.Add(BuildingCardUC54)
        Panel55.Controls.Add(BuildingCardUC55)
        Panel56.Controls.Add(BuildingCardUC56)
        Panel57.Controls.Add(BuildingCardUC57)
        Panel58.Controls.Add(BuildingCardUC58)
        Panel59.Controls.Add(BuildingCardUC59)

        'Ajout à la liste globale
        _BuildingCardsUC.AddRange({BuildingCardUC0, BuildingCardUC1, BuildingCardUC2, BuildingCardUC3, BuildingCardUC4, BuildingCardUC5, BuildingCardUC6, BuildingCardUC7,
                           BuildingCardUC8, BuildingCardUC9, BuildingCardUC10, BuildingCardUC11, BuildingCardUC12, BuildingCardUC13, BuildingCardUC14, BuildingCardUC15,
                           BuildingCardUC16, BuildingCardUC17, BuildingCardUC18, BuildingCardUC19,
                           BuildingCardUC20, BuildingCardUC21, BuildingCardUC22, BuildingCardUC23, BuildingCardUC24, BuildingCardUC25, BuildingCardUC26, BuildingCardUC27,
                           BuildingCardUC28, BuildingCardUC29, BuildingCardUC30, BuildingCardUC31, BuildingCardUC32, BuildingCardUC33, BuildingCardUC34, BuildingCardUC35,
                           BuildingCardUC36, BuildingCardUC37, BuildingCardUC38, BuildingCardUC39,
                           BuildingCardUC40, BuildingCardUC41, BuildingCardUC42, BuildingCardUC43, BuildingCardUC44, BuildingCardUC45, BuildingCardUC46, BuildingCardUC47,
                           BuildingCardUC48, BuildingCardUC49, BuildingCardUC50, BuildingCardUC51, BuildingCardUC52, BuildingCardUC53, BuildingCardUC54, BuildingCardUC55,
                           BuildingCardUC56, BuildingCardUC57, BuildingCardUC58, BuildingCardUC59})

        _AllScienceCards = CreateScienceDeck()
        _SelectedScienceCards = CreateScienceDeck()
        RemoveRandomCardInDeck(_SelectedScienceCards)
        RemoveRandomCardInDeck(_SelectedScienceCards)
        RemoveRandomCardInDeck(_SelectedScienceCards)
        RemoveRandomCardInDeck(_SelectedScienceCards)
        _UnselectedScienceCards = GetUnselectedScienceCards(_AllScienceCards, _SelectedScienceCards)

        If _ActivePlayer.Position = 1 AndAlso _InactivePlayer.Position = 2 Then
            Label1.Text = _ActivePlayer.Name
            PanelMarvel11.Controls.Add(New MarvelCardPlayerBoardUC(_ActivePlayer.ListOfMarvels.Item(0)))
            PanelMarvel21.Controls.Add(New MarvelCardPlayerBoardUC(_ActivePlayer.ListOfMarvels.Item(1)))
            PanelMarvel31.Controls.Add(New MarvelCardPlayerBoardUC(_ActivePlayer.ListOfMarvels.Item(2)))
            PanelMarvel41.Controls.Add(New MarvelCardPlayerBoardUC(_ActivePlayer.ListOfMarvels.Item(3)))
            Label2.Text = _InactivePlayer.Name
            PanelMarvel12.Controls.Add(New MarvelCardPlayerBoardUC(_InactivePlayer.ListOfMarvels.Item(0)))
            PanelMarvel22.Controls.Add(New MarvelCardPlayerBoardUC(_InactivePlayer.ListOfMarvels.Item(1)))
            PanelMarvel32.Controls.Add(New MarvelCardPlayerBoardUC(_InactivePlayer.ListOfMarvels.Item(2)))
            PanelMarvel42.Controls.Add(New MarvelCardPlayerBoardUC(_InactivePlayer.ListOfMarvels.Item(3)))
        ElseIf _ActivePlayer.Position = 2 AndAlso _InactivePlayer.Position = 1 Then
            Label1.Text = _InactivePlayer.Name
            PanelMarvel11.Controls.Add(New MarvelCardPlayerBoardUC(_InactivePlayer.ListOfMarvels.Item(0)))
            PanelMarvel21.Controls.Add(New MarvelCardPlayerBoardUC(_InactivePlayer.ListOfMarvels.Item(1)))
            PanelMarvel31.Controls.Add(New MarvelCardPlayerBoardUC(_InactivePlayer.ListOfMarvels.Item(2)))
            PanelMarvel41.Controls.Add(New MarvelCardPlayerBoardUC(_InactivePlayer.ListOfMarvels.Item(3)))
            Label2.Text = _ActivePlayer.Name
            PanelMarvel12.Controls.Add(New MarvelCardPlayerBoardUC(_ActivePlayer.ListOfMarvels.Item(0)))
            PanelMarvel22.Controls.Add(New MarvelCardPlayerBoardUC(_ActivePlayer.ListOfMarvels.Item(1)))
            PanelMarvel32.Controls.Add(New MarvelCardPlayerBoardUC(_ActivePlayer.ListOfMarvels.Item(2)))
            PanelMarvel42.Controls.Add(New MarvelCardPlayerBoardUC(_ActivePlayer.ListOfMarvels.Item(3)))
        End If

        UpdatePlayersBoardAndMilitaryBoardAndscienceBoard()

    End Sub

    Public Sub UpdatePlayersBoardAndMilitaryBoardAndscienceBoard()

        MoveMilitaryCoin()

        If _ActivePlayer.Position = 1 AndAlso _InactivePlayer.Position = 2 Then
            FillFirstSpot(_ActivePlayer)
            FillSecondSpot(_InactivePlayer)
        ElseIf _ActivePlayer.Position = 2 AndAlso _InactivePlayer.Position = 1 Then
            FillFirstSpot(_InactivePlayer)
            FillSecondSpot(_ActivePlayer)
        End If

        Panel60.Controls.Clear()
        Panel61.Controls.Clear()
        Panel62.Controls.Clear()
        Panel63.Controls.Clear()
        Panel64.Controls.Clear()
        If _SelectedScienceCards.Item(0).IsSelected = False Then
            Panel60.Controls.Add(New ScienceCardPlayerBoardUC(_SelectedScienceCards.Item(0)))
        End If
        If _SelectedScienceCards.Item(1).IsSelected = False Then
            Panel61.Controls.Add(New ScienceCardPlayerBoardUC(_SelectedScienceCards.Item(1)))
        End If
        If _SelectedScienceCards.Item(2).IsSelected = False Then
            Panel62.Controls.Add(New ScienceCardPlayerBoardUC(_SelectedScienceCards.Item(2)))
        End If
        If _SelectedScienceCards.Item(3).IsSelected = False Then
            Panel63.Controls.Add(New ScienceCardPlayerBoardUC(_SelectedScienceCards.Item(3)))
        End If
        If _SelectedScienceCards.Item(4).IsSelected = False Then
            Panel64.Controls.Add(New ScienceCardPlayerBoardUC(_SelectedScienceCards.Item(4)))
        End If

        If _ActivePlayer.Position = 1 Then
            Label1.BackColor = Color.LightGreen
            Label2.BackColor = Color.LightGray
        Else
            Label1.BackColor = Color.LightGray
            Label2.BackColor = Color.LightGreen
        End If

    End Sub

    Public Sub LoadSecondAge()

        TabControl1.SelectedIndex = 1

    End Sub

    Public Sub LoadThirdAge()

        TabControl1.SelectedIndex = 2

    End Sub

    Private Sub MoveMilitaryCoin()

        Panel81.Controls.Clear()
        Panel82.Controls.Clear()
        Panel83.Controls.Clear()
        Panel84.Controls.Clear()
        Panel85.Controls.Clear()
        Panel86.Controls.Clear()
        Panel87.Controls.Clear()
        Panel88.Controls.Clear()
        Panel89.Controls.Clear()
        Panel90.Controls.Clear()
        Panel91.Controls.Clear()
        Panel92.Controls.Clear()
        Panel93.Controls.Clear()
        Panel94.Controls.Clear()
        Panel95.Controls.Clear()
        Panel96.Controls.Clear()
        Panel97.Controls.Clear()
        Panel98.Controls.Clear()
        Panel99.Controls.Clear()

        If _MilitaryProgress <= 1 Then
            Panel81.Controls.Add(New MilitaryCoinUC)
            _ActivePlayer.MilitaryVictory = True
            Dim NewEndgame = New EndGame
            NewEndgame.Show()
        ElseIf _MilitaryProgress = 2 Then
            Panel82.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress = 3 Then
            Panel83.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress = 4 Then
            Panel84.Controls.Add(New MilitaryCoinUC)
            If _ActivePlayer.Position = 1 Then
                If _InactivePlayer.Military10Points = False Then
                    Panel101.BackgroundImage = Nothing
                    _InactivePlayer.Military10Points = True
                    If _ActivePlayer.GoldCount >= 5 Then
                        _ActivePlayer.GoldCount -= 5
                    Else
                        _ActivePlayer.GoldCount = 0
                    End If
                End If
            ElseIf _InactivePlayer.Position = 1 Then
                If _ActivePlayer.Military10Points = False Then
                    Panel101.BackgroundImage = Nothing
                    _ActivePlayer.Military10Points = True
                    If _InactivePlayer.GoldCount >= 5 Then
                        _InactivePlayer.GoldCount -= 5
                    Else
                        _InactivePlayer.GoldCount = 0
                    End If
                End If
            End If
        ElseIf _MilitaryProgress = 5 Then
            Panel85.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress = 6 Then
            Panel86.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress = 7 Then
            Panel87.Controls.Add(New MilitaryCoinUC)
            If _ActivePlayer.Position = 1 Then
                If _InactivePlayer.Military5Points = False Then
                    Panel102.BackgroundImage = Nothing
                    _InactivePlayer.Military5Points = True
                    If _ActivePlayer.GoldCount >= 2 Then
                        _ActivePlayer.GoldCount -= 2
                    Else
                        _ActivePlayer.GoldCount = 0
                    End If
                End If
            ElseIf _InactivePlayer.Position = 1 Then
                If _ActivePlayer.Military5Points = False Then
                    Panel102.BackgroundImage = Nothing
                    _ActivePlayer.Military5Points = True
                    If _InactivePlayer.GoldCount >= 2 Then
                        _InactivePlayer.GoldCount -= 2
                    Else
                        _InactivePlayer.GoldCount = 0
                    End If
                End If
            End If
        ElseIf _MilitaryProgress = 8 Then
            Panel88.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress = 9 Then
            Panel89.Controls.Add(New MilitaryCoinUC)
            If _ActivePlayer.Position = 1 Then
                If _InactivePlayer.Military2Points = False Then
                    _InactivePlayer.Military2Points = True
                End If
            ElseIf _InactivePlayer.Position = 1 Then
                If _ActivePlayer.Military2Points = False Then
                    _ActivePlayer.Military2Points = True
                End If
            End If
        ElseIf _MilitaryProgress = 10 Then
            Panel90.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress = 11 Then
            Panel91.Controls.Add(New MilitaryCoinUC)
            If _ActivePlayer.Position = 2 Then
                If _InactivePlayer.Military2Points = False Then
                    _InactivePlayer.Military2Points = True
                End If
            ElseIf _InactivePlayer.Position = 2 Then
                If _ActivePlayer.Military2Points = False Then
                    _ActivePlayer.Military2Points = True
                End If
            End If
        ElseIf _MilitaryProgress = 12 Then
            Panel92.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress = 13 Then
            Panel93.Controls.Add(New MilitaryCoinUC)
            If _ActivePlayer.Position = 2 Then
                If _InactivePlayer.Military5Points = False Then
                    Panel106.BackgroundImage = Nothing
                    _InactivePlayer.Military5Points = True
                    If _ActivePlayer.GoldCount >= 2 Then
                        _ActivePlayer.GoldCount -= 2
                    Else
                        _ActivePlayer.GoldCount = 0
                    End If
                End If
            ElseIf _InactivePlayer.Position = 2 Then
                If _ActivePlayer.Military5Points = False Then
                    Panel106.BackgroundImage = Nothing
                    _ActivePlayer.Military5Points = True
                    If _InactivePlayer.GoldCount >= 2 Then
                        _InactivePlayer.GoldCount -= 2
                    Else
                        _InactivePlayer.GoldCount = 0
                    End If
                End If
            End If
        ElseIf _MilitaryProgress = 14 Then
            Panel94.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress = 15 Then
            Panel95.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress = 16 Then
            Panel96.Controls.Add(New MilitaryCoinUC)
            If _ActivePlayer.Position = 2 Then
                If _InactivePlayer.Military10Points = False Then
                    Panel107.BackgroundImage = Nothing
                    _InactivePlayer.Military10Points = True
                    If _ActivePlayer.GoldCount >= 5 Then
                        _ActivePlayer.GoldCount -= 5
                    Else
                        _ActivePlayer.GoldCount = 0
                    End If
                End If
            ElseIf _InactivePlayer.Position = 2 Then
                If _ActivePlayer.Military10Points = False Then
                    Panel107.BackgroundImage = Nothing
                    _ActivePlayer.Military10Points = True
                    If _InactivePlayer.GoldCount >= 5 Then
                        _InactivePlayer.GoldCount -= 5
                    Else
                        _InactivePlayer.GoldCount = 0
                    End If
                End If
            End If
        ElseIf _MilitaryProgress = 17 Then
            Panel97.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress = 18 Then
            Panel98.Controls.Add(New MilitaryCoinUC)
        ElseIf _MilitaryProgress >= 19 Then
            Panel99.Controls.Add(New MilitaryCoinUC)
            _ActivePlayer.MilitaryVictory = True
            Dim NewEndgame = New EndGame
            NewEndgame.Show()
        End If

    End Sub

    Private Sub FillFirstSpot(ByVal FirstSpotPlayer As Player)

        FLPBrownCard1.Controls.Clear()
        FLPGrayCard1.Controls.Clear()
        FLPRedCard1.Controls.Clear()
        FLPBlueCard1.Controls.Clear()
        FLPGreenCard1.Controls.Clear()
        FLPYellowCard1.Controls.Clear()
        FLPPurpleCard1.Controls.Clear()
        For Each BuildCard As BuildingCard In FirstSpotPlayer.ListOfCards
            If BuildCard.Color = BuildingCard.CardColor.Brown Then
                FLPBrownCard1.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Gray Then
                FLPGrayCard1.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Red Then
                FLPRedCard1.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Blue Then
                FLPBlueCard1.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Green Then
                FLPGreenCard1.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Yellow Then
                FLPYellowCard1.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Purple Then
                FLPPurpleCard1.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            End If
        Next

        If FirstSpotPlayer.ListOfMarvels.Item(0).IsCompleted = True Then
            PanelMarvel11Completed.BackColor = Color.Green
        End If
        If FirstSpotPlayer.ListOfMarvels.Item(1).IsCompleted = True Then
            PanelMarvel21Completed.BackColor = Color.Green
        End If
        If FirstSpotPlayer.ListOfMarvels.Item(2).IsCompleted = True Then
            PanelMarvel31Completed.BackColor = Color.Green
        End If
        If FirstSpotPlayer.ListOfMarvels.Item(3).IsCompleted = True Then
            PanelMarvel41Completed.BackColor = Color.Green
        End If

        PanelGold1.Controls.Clear()
        PanelGold1.Controls.Add(New GoldPlayerBoardUC(FirstSpotPlayer.GoldCount))

        FLPScience1.Controls.Clear()
        For Each ScienceCard As ScienceCard In FirstSpotPlayer.ListOfScience
            FLPScience1.Controls.Add(New ScienceCardPlayerBoardUC(ScienceCard))
        Next

        FLPItem1.Controls.Clear()
        For Each ItemName As String In FirstSpotPlayer.ListOfItems
            If Not ItemName = "None" Then
                FLPItem1.Controls.Add(New ItemPlayerBoardUC(ItemName))
            End If
        Next

        FLPSymbol1.Controls.Clear()
        For Each SymbolName As String In FirstSpotPlayer.ListOfSymbols
            If Not SymbolName = "None" Then
                FLPSymbol1.Controls.Add(New SymbolPlayerBoardUC(SymbolName))
            End If
        Next

    End Sub

    Private Sub FillSecondSpot(ByVal SecondSpotPlayer As Player)

        FLPBrownCard2.Controls.Clear()
        FLPGrayCard2.Controls.Clear()
        FLPRedCard2.Controls.Clear()
        FLPBlueCard2.Controls.Clear()
        FLPGreenCard2.Controls.Clear()
        FLPYellowCard2.Controls.Clear()
        FLPPurpleCard2.Controls.Clear()
        For Each BuildCard As BuildingCard In SecondSpotPlayer.ListOfCards
            If BuildCard.Color = BuildingCard.CardColor.Brown Then
                FLPBrownCard2.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Gray Then
                FLPGrayCard2.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Red Then
                FLPRedCard2.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Blue Then
                FLPBlueCard2.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Green Then
                FLPGreenCard2.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Yellow Then
                FLPYellowCard2.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            ElseIf BuildCard.Color = BuildingCard.CardColor.Purple Then
                FLPPurpleCard2.Controls.Add(New BuildingCardPlayerBoardUC(BuildCard))
            End If
        Next

        If SecondSpotPlayer.ListOfMarvels.Item(0).IsCompleted = True Then
            PanelMarvel12Completed.BackColor = Color.Green
        End If
        If SecondSpotPlayer.ListOfMarvels.Item(1).IsCompleted = True Then
            PanelMarvel22Completed.BackColor = Color.Green
        End If
        If SecondSpotPlayer.ListOfMarvels.Item(2).IsCompleted = True Then
            PanelMarvel32Completed.BackColor = Color.Green
        End If
        If SecondSpotPlayer.ListOfMarvels.Item(3).IsCompleted = True Then
            PanelMarvel42Completed.BackColor = Color.Green
        End If

        PanelGold2.Controls.Clear()
        PanelGold2.Controls.Add(New GoldPlayerBoardUC(SecondSpotPlayer.GoldCount))

        FLPScience2.Controls.Clear()
        For Each ScienceCard As ScienceCard In SecondSpotPlayer.ListOfScience
            FLPScience2.Controls.Add(New ScienceCardPlayerBoardUC(ScienceCard))
        Next

        FLPItem2.Controls.Clear()
        For Each ItemName As String In SecondSpotPlayer.ListOfItems
            If Not ItemName = "None" Then
                FLPItem2.Controls.Add(New ItemPlayerBoardUC(ItemName))
            End If
        Next

        FLPSymbol2.Controls.Clear()
        For Each SymbolName As String In SecondSpotPlayer.ListOfSymbols
            If Not SymbolName = "None" Then
                FLPSymbol2.Controls.Add(New SymbolPlayerBoardUC(SymbolName))
            End If
        Next

    End Sub

End Class