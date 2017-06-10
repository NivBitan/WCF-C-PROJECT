
using System.Collections.Generic;


namespace WcfDuplexServiceClient
{
    class UpdatedListEventArgs
    {
        private List<string> _items;

        public List<string> ItemList
        {
            get { return _items; }
            set { _items = value; }
        }

        public UpdatedListEventArgs(List<string> items)
        {
            _items = items;
        }
    }
}
