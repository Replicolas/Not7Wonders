Module MarvelManager

    Public Function CreateMarvelDeck() As List(Of MarvelCard)

        Dim UnshuffledMarvelDeck As New List(Of MarvelCard)
        Dim Card1 As New MarvelCard("Le Grand Phare", My.Resources.Grand_Phare, 1, 0, 1, 0, 2, 0, 4, 0, False, False, False, False, False, False, True, False,
                                    "Cette merveille produit à chaque tour, pour le joueur, une unité d'une des ressources présentées (Pierre, Argile ou Bois)." & vbCrLf & "Cette Merveille rapporte 4 points de victoire.")
        Dim Card2 As New MarvelCard("Le Pirée", My.Resources.Piree, 2, 1, 1, 0, 0, 0, 2, 0, False, False, False, False, False, True, False, True,
                                    "Cette merveille produit à chaque tour, pour le joueur, une unité d'une des ressources présentées (Verre ou Papyrus)." & vbCrLf & "Le joueur rejoue immédiatement un tour." & vbCrLf & "Cette Merveille rapporte 2 points de victoire.")
        Dim Card3 As New MarvelCard("Le Mausolée", My.Resources.Mausolee, 0, 2, 0, 2, 1, 0, 2, 0, True, False, False, False, False, False, False, False,
                                    "Le joueur prend toutes les cartes défaussées depuis le début de la partie et en construit gratuitement une au choix." & vbCrLf & "Cette Merveille rapporte 2 points de victoire.")
        Dim Card4 As New MarvelCard("La Grande Bibliothèque", My.Resources.Grande_Bibliotheque, 3, 0, 0, 1, 1, 0, 4, 0, False, True, False, False, False, False, False, False,
                                    "Le joueur tire aléatoirement 3 jetons Progrès parmi ceux écartés au début de partie. Il en choisit 1 et remet les deux autres dans la boîte." & vbCrLf & "Cette Merveille rapporte 4 points de victoire.")
        Dim Card5 As New MarvelCard("La Statue de Zeus", My.Resources.Statue_Zeus, 1, 1, 1, 0, 2, 0, 3, 1, False, False, False, False, True, False, False, False,
                                    "Le joueur place dans la défausse une carte marron (matière première) de son choix construite par son adversaire." & vbCrLf & "Cette Merveille rapporte 1 bouclier." & vbCrLf & "Cette Merveille rapporte 3 points de victoire.")
        Dim Card6 As New MarvelCard("Le Circus Maximus", My.Resources.Circus_Maximus, 1, 0, 2, 1, 0, 0, 3, 1, False, False, False, True, False, False, False, False,
                                    "Le joueur place dans la défausse une carte grise (produit manufacturé) de son choix construite par son adversaire." & vbCrLf & "Cette Merveille rapporte 1 bouclier." & vbCrLf & "Cette Merveille rapporte 3 points de victoire.")
        Dim Card7 As New MarvelCard("Le Colosse", My.Resources.Colosse, 0, 3, 0, 1, 0, 0, 3, 2, False, False, False, False, False, False, False, False,
                                    "Cette Merveille rapporte 2 boucliers." & vbCrLf & "Cette Merveille rapporte 3 points de victoire.")
        Dim Card8 As New MarvelCard("La Via Appia", My.Resources.Via_Appia, 0, 2, 2, 0, 1, 3, 3, 0, False, False, True, False, False, False, False, True,
                                    "Le joueur prend 3 pièces de la banque." & vbCrLf & "L'adversaire perd 3 pièces qui sont remises à la banque." & vbCrLf & "Le joueur rejoue immédiatement un tour." & vbCrLf & "Cette Merveille rapporte 3 points de victoire.")
        Dim Card9 As New MarvelCard("Les Jardins Suspendus", My.Resources.Jardins_Suspendus, 2, 0, 0, 1, 1, 6, 3, 0, False, False, False, False, False, False, False, True,
                                    "Le joueur prend immédiatement 6 pièces à la banque." & vbCrLf & "Le joueur rejoue immédiatement un tour." & vbCrLf & "Cette Merveille rapporte 3 points de victoire.")
        Dim Card10 As New MarvelCard("Le Temple d'Artemis", My.Resources.Temple_Artemis, 1, 0, 1, 1, 1, 12, 0, 0, False, False, False, False, False, False, False, True,
                                     "Le joueur prend immédiatement 12 pièces à la banque." & vbCrLf & "Le joueur rejoue immédiatement un tour.")
        Dim Card11 As New MarvelCard("Les Pyramides", My.Resources.Pyramide, 0, 0, 3, 0, 1, 0, 9, 0, False, False, False, False, False, False, False, False,
                                     "Cette Merveille rapporte 9 points de victoire.")
        Dim Card12 As New MarvelCard("Le Sphinx", My.Resources.Sphinx, 0, 1, 1, 2, 0, 0, 6, 0, False, False, False, False, False, False, False, True,
                                     "Le joueur rejoue immédiatement un tour." & vbCrLf & "Cette Merveille rapporte 6 points de victoire.")
        UnshuffledMarvelDeck.AddRange({Card1, Card2, Card3, Card4, Card5, Card6, Card7, Card8, Card9, Card10, Card11, Card12})

        Dim Shuffle1 As List(Of MarvelCard) = ShuffleDeck(UnshuffledMarvelDeck)
        Dim Shuffle2 As List(Of MarvelCard) = ShuffleDeck(Shuffle1)
        Dim Shuffle3 As List(Of MarvelCard) = ShuffleDeck(Shuffle2)
        Dim Shuffle4 As List(Of MarvelCard) = ShuffleDeck(Shuffle3)
        Dim Shuffle5 As List(Of MarvelCard) = ShuffleDeck(Shuffle4)
        Dim Shuffle6 As List(Of MarvelCard) = ShuffleDeck(Shuffle5)
        Dim Shuffle7 As List(Of MarvelCard) = ShuffleDeck(Shuffle6)
        Dim Shuffle8 As List(Of MarvelCard) = ShuffleDeck(Shuffle7)
        Dim ShuffledMarvelDeck As List(Of MarvelCard) = ShuffleDeck(Shuffle8)

        Return ShuffledMarvelDeck

    End Function

    Public Function GetUnselectedMarvels(ByVal AllMarvels As List(Of MarvelCard), ByVal SelectedMarvels As List(Of MarvelCard)) As List(Of MarvelCard)

        Dim SelectedMarvelsNames As New List(Of String)
        For Each SelectedMarvel As MarvelCard In SelectedMarvels
            SelectedMarvelsNames.Add(SelectedMarvel.Name)
        Next
        Dim UnselectedMarvels As New List(Of MarvelCard)
        For Each Marvel As MarvelCard In AllMarvels
            If Not SelectedMarvelsNames.Contains(Marvel.Name) Then
                UnselectedMarvels.Add(Marvel)
            End If
        Next
        Return UnselectedMarvels

    End Function

End Module
