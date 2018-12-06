using System.Collections.ObjectModel;
using System.Linq;

namespace LookUpEditWithCheckboxes {
    public class MainViewModel {


        protected ObservableCollection<Item> _Items;
        public ObservableCollection<Item> Items
        {
            get
            {
                if(this._Items == null)
                {
                    this._Items = new ObservableCollection<Item>(Enumerable.Range(0, 15).Select(c => new Item() { ID = c, Name = "Item #" + c }));
                }

                return this._Items;
            }
        }

    }
}
