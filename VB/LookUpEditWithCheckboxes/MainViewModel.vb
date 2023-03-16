Imports System.Collections.ObjectModel
Imports System.Linq

Namespace LookUpEditWithCheckboxes

    Public Class MainViewModel

        Protected _Items As ObservableCollection(Of Item)

        Public ReadOnly Property Items As ObservableCollection(Of Item)
            Get
                If _Items Is Nothing Then
                    _Items = New ObservableCollection(Of Item)(Enumerable.Range(0, 15).[Select](Function(c) New Item() With {.ID = c, .Name = "Item #" & c}))
                End If

                Return _Items
            End Get
        End Property
    End Class
End Namespace
