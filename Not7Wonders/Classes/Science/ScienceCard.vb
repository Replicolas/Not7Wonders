Public Class ScienceCard

#Region "Properties"

    Property Name As String
    Property Image As Image
    Property IsSelected As Boolean

#End Region

#Region "Constructors"

    Public Sub New(ByVal sName As String, ByVal iImage As Image)

        Name = sName
        Image = iImage
        IsSelected = False

    End Sub

#End Region

End Class
