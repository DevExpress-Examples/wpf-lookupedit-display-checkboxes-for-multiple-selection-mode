Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace LookUpEditWithCheckboxes

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Sub New()
            Items = New ObservableCollection(Of Item)(Enumerable.Range(0, 15).[Select](Function(c) New Item() With {.ID = c, .Name = "Item #" & c}))
        End Sub

        Public Property Items As ObservableCollection(Of Item)
    End Class
End Namespace
