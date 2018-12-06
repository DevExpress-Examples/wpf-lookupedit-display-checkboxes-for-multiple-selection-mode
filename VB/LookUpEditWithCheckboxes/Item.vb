Imports DevExpress.Mvvm

Namespace LookUpEditWithCheckboxes
    Public Class Item
        Inherits BindableBase

        Protected _ID As Integer
        Public Property ID() As Integer
            Get
                Return Me._ID
            End Get
            Set(ByVal value As Integer)
                Me.SetProperty(Me._ID, value, "ID")
            End Set
        End Property


        Protected _Name As String
        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(ByVal value As String)
                Me.SetProperty(Me._Name, value, "Name")
            End Set
        End Property
    End Class
End Namespace
