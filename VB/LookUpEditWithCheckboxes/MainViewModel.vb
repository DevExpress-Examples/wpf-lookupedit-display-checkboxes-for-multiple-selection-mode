Imports System.Collections.ObjectModel
Imports System.Linq

Namespace LookUpEditWithCheckboxes
    Public Class MainViewModel


        Protected _Items As ObservableCollection(Of Item)
        Public ReadOnly Property Items() As ObservableCollection(Of Item)
            Get
                If Me._Items Is Nothing Then
                    Me._Items = New ObservableCollection(Of Item)(Enumerable.Range(0, 15).Select(Function(c) New Item() With { _
                        .ID = c, _
                        .Name = "Item #" & c _
                    }))
                End If

                Return Me._Items
            End Get
        End Property

    End Class
End Namespace
