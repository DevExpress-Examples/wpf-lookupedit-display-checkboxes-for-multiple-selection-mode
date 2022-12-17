Imports DevExpress.Mvvm

Namespace LookUpEditWithCheckboxes

    Public Class Item
        Inherits BindableBase

        Protected _ID As Integer

        Public Property ID As Integer
            Get
                Return _ID
            End Get

            Set(ByVal value As Integer)
                SetProperty(_ID, value, "ID")
            End Set
        End Property

        Protected _Name As String

        Public Property Name As String
            Get
                Return _Name
            End Get

            Set(ByVal value As String)
                SetProperty(_Name, value, "Name")
            End Set
        End Property
    End Class
End Namespace
