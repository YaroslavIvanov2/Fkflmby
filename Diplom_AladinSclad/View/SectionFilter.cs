using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom_AladinSclad.DB;

namespace Diplom_AladinSclad.View
{
    class SectionFilter : INotifyPropertyChanged
    {
        public bool _isChecked = false;
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                if (_isChecked != value)
                {
                    _isChecked = value;
                    PropertyChange("IsChecked");
                }
            }
        }
        public Category_tovarov Category_Of_Tovar { get; set; }
       
        public event PropertyChangedEventHandler PropertyChanged;
        public void PropertyChange(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
