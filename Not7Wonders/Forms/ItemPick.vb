Public Class ItemPick

    Public Sub New()

        InitializeComponent()
        AddItems()
        Label.Text = _ActivePlayer.Name & " sélectionne un item"

    End Sub

    Private Sub AddItems()

        Panel1.Controls.Add(New ItemPickUC("Globe"))
        Panel2.Controls.Add(New ItemPickUC("Wheel"))
        Panel3.Controls.Add(New ItemPickUC("Sundial"))
        Panel4.Controls.Add(New ItemPickUC("Mortar"))
        Panel5.Controls.Add(New ItemPickUC("Pendulum"))
        Panel6.Controls.Add(New ItemPickUC("Balance"))

    End Sub

End Class