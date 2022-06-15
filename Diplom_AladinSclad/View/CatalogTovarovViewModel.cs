using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Diplom_AladinSclad.DB;

namespace Diplom_AladinSclad.View
{
    class CatalogTovarovViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Tovar> Tovar { get; set; }
        public CatalogTovarovViewModel()
        {
            Tovar = new ObservableCollection<Tovar>();
            SectionFilters = new ObservableCollection<SectionFilter>(DataBase.GetContext().Category_tovarov.Select(p => new SectionFilter() { Category_Of_Tovar = p }));
            UpdateDishesList();
        }
        public ObservableCollection<SectionFilter> SectionFilters { get; private set; }
        public void UpdateDishesList()
        {
            try
            {
                // Dishes = new ObservableCollection<Dishes>(DataBase.GetContext().Dishes);
                Tovar.Clear();
                List<Category_tovarov> categories = SectionFilters.Where(p => p.IsChecked).Select(p => p.Category_Of_Tovar).ToList();
                List<Tovar> dishes = DataBase.GetContext().Tovar.ToList();
                // фильтрация
                if (categories.Count != 0)
                {
                    dishes = dishes.Where(p => categories.Contains(p.Category_tovarov)).ToList();

                }

             

            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка:" + e.Message);
            }
        }
    }
}
