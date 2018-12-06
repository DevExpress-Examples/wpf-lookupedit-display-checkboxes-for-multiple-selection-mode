using DevExpress.Mvvm;

namespace LookUpEditWithCheckboxes {
    public class Item : BindableBase{

        protected int _ID;
        public int ID
        {
            get { return this._ID; }
            set { this.SetProperty(ref this._ID, value, "ID"); }
        }


        protected string _Name;
        public string Name
        {
            get { return this._Name; }
            set { this.SetProperty(ref this._Name, value, "Name"); }
        }
    }
}
