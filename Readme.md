<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/160682012/16.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830489)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# LookUpEdit - How to support multiple row selection with CheckBoxes

Our **LookUpEdit** supports multiple row selection out of the box. For this, it's sufficient to set its [StyleSettings](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit.StyleSettings.property) property to one of corresponding StyleSettings objects (see: [LookUpEdit operation modes](https://documentation.devexpress.com/WPF/116556/Controls-and-Libraries/Data-Editors/Common-Features/Editor-Operation-Modes/LookUpEdit)). 

This example illustrates how to show the [Selector Column](https://documentation.devexpress.com/WPF/17808/Controls-and-Libraries/Data-Grid/Visual-Elements/Table-View-Elements/Selector-Column) in the GridControl from LookUpEdit's popup when multiple row selection is enabled. To do this, it's sufficient to define a custom ControlTemplate with the **PART_GridControl** GridControl in LookUpEdit's [PopupContentTemplate](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate.property) property, and set the [GridControl.SelectionMode](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.SelectionMode.property) and [TableView.ShowCheckBoxSelectorColumn](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.ShowCheckBoxSelectorColumn.property) properties to **Row** (or MultipleRow) and **True** respectively: 

````XAML
<dxg:LookUpEdit ...>
    <dxg:LookUpEdit.PopupContentTemplate>
        <ControlTemplate>
            <dxg:GridControl x:Name="PART_GridControl"
                                SelectionMode="Row">
                <dxg:GridControl.View>
                    <dxg:TableView ShowCheckBoxSelectorColumn="True"/>
                </dxg:GridControl.View>
            </dxg:GridControl>
        </ControlTemplate>
    </dxg:LookUpEdit.PopupContentTemplate>
    <dxg:LookUpEdit.StyleSettings>
        <dxg:MultiSelectLookUpEditStyleSettings/>
    </dxg:LookUpEdit.StyleSettings>
</dxg:LookUpEdit>
````
