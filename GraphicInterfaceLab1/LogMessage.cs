using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace GraphicInterfaceLab1
{
    public class LogMessage
    {
        public Image Image {  get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public int Tunnel { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
    }
    public class LimitedCollection<T> : BindingList<T>
    {
        private readonly int _maxItems;
        public LimitedCollection(int _maxItems)
        {
            this._maxItems = _maxItems;
        }
        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index,item);
            while (Count > this._maxItems) {
                RemoveAt(0);
            }
            
        }

    }
    
}
