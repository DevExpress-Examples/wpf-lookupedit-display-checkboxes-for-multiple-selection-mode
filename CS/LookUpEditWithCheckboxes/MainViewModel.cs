using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using System.Linq;

namespace LookUpEditWithCheckboxes {
    public class MainViewModel : ViewModelBase {
        public MainViewModel() {
            Items = new ObservableCollection<Item>(Enumerable.Range(0, 15).Select(c => new Item() { 
                ID = c, 
                Name = "Item #" + c 
            }));
        }
        public ObservableCollection<Item> Items { get; set; }
    }
}
