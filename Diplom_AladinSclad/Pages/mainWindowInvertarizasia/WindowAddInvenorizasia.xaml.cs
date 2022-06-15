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

namespace Diplom_AladinSclad.Pages.mainWindowInvertarizasia
{
    /// <summary>
    /// Логика взаимодействия для WindowAddInvenorizasia.xaml
    /// </summary>
    public partial class WindowAddInvenorizasia : Window
    {
        Inventarizacia inventarizacia;
        private Action update;
        public WindowAddInvenorizasia(Action update)
        {
            InitializeComponent();
            this.update = update;
            inventarizacia = new Inventarizacia();
            DataContext = inventarizacia;
            SotrydnikBox.ItemsSource = DataBase.GetContext().Sotrudnik.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (SotrydnikBox.SelectedItem == null)
                errors.AppendLine("Выберите сотрудника!");
            if (DatePicker.SelectedDate == null)
                errors.AppendLine("Выберите дату!");
            if (NumberTextBox.Text == null)
                errors.AppendLine("Введите номер инвентаризации!");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            try
            {
                if (!DataBase.GetContext().Inventarizacia.ToList().Contains(inventarizacia))
                {
                    DataBase.GetContext().Inventarizacia.Add(inventarizacia);
                }
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
}
