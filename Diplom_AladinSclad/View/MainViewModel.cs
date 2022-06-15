using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Diplom_AladinSclad.DB;
using Diplom_AladinSclad.Pages.mainWindowInvertarizasia;
using Diplom_AladinSclad.Pages.mainWindowTovar;
using Diplom_AladinSclad.Pages.mainWindowPostavki;

namespace Diplom_AladinSclad.View
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private void PropertyChange(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        public event PropertyChangedEventHandler PropertyChanged;
        public Sotrudnik admin { get; private set; }
        public ObservableCollection<Page> PageCollection { get; private set; }
        private Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                if (_currentPage != value)
                {
                    _currentPage = value;
                    PropertyChange("CurrentPage");
                }
            }
        }
        internal void UpdateVrach()
        {
            throw new NotImplementedException();
        }
        public MainViewModel(Sotrudnik admin)
        {
            this.admin = admin;
            PageCollection = new ObservableCollection<Page>();
            PageCollection.Add(new PageInvertarizasia());
            PageCollection.Add(new PageTovar());
            PageCollection.Add(new PagePostavki());
            CurrentPage = PageCollection[0];
        }
    }
}
