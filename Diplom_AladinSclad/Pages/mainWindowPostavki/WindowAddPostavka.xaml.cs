using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Diplom_AladinSclad.DB;

namespace Diplom_AladinSclad.Pages.mainWindowPostavki
{
    
    /// <summary>
    /// Логика взаимодействия для WindowAddPostavka.xaml
    /// </summary>
    public partial class WindowAddPostavka : Window
    {
        Postavki order;
        private Action update;
        public WindowAddPostavka(Action update)
        {
            InitializeComponent();
            this.update = update;
            order = new Postavki();
            DataContext = order;
            postavshikbox.ItemsSource = DataBase.GetContext().Postavshik.ToList();
            var eatslist = DataBase.GetContext().Tovar.ToList();
            var eatslists = new List<Its>();
            eatslist.ForEach(x => eatslists.Add(new Its() { Name = x.Naimenovanie_tovara, IsCheched = false, Id = x.ID_Tovar, colichestvo = 1 }));
            dishcombobox.ItemsSource = eatslists;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!DataBase.GetContext().Postavki.ToList().Contains(order))
                {
                    DataBase.GetContext().Postavki.Add(order);
                }
                //добавление товара
                var selectedItems = new List<Its>();
                for (int i = 0; i < dishcombobox.Items.Count; i++)
                {
                    var item = (Its)dishcombobox.Items[i];
                    if (item.IsCheched)
                    {

                        selectedItems.Add(item);
                    }
                }
                // с помощью данного метода связываем данные из таблицы товары с combobox
                selectedItems.ForEach(x => {
                    DataBase.GetContext().Postavki_Tovar.Add(new Postavki_Tovar()
                    {
                        ID_Postavki = order.ID_Postavki,
                        ID_Tovata = x.Id,
                        Amount = x.colichestvo
                    });
                });
                DataBase.GetContext().SaveChanges();
                update();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public class Its
    {
        public int Id;
        public int colichestvo { get; set; }
        public string Name { get; set; }
        public bool IsCheched { get; set; }
    }
}
