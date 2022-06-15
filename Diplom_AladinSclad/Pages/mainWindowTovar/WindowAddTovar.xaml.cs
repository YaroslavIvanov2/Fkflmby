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

namespace Diplom_AladinSclad.Pages.mainWindowTovar
{
    /// <summary>
    /// Логика взаимодействия для WindowAddTovar.xaml
    /// </summary>
    public partial class WindowAddTovar : Window
    {
        Tovar tovar;
        private Action update;
        public WindowAddTovar(Action update)
        {
            InitializeComponent();
            this.update = update;
            tovar = new Tovar();
            DataContext = tovar;
            categoriaTovarBox.ItemsSource = DataBase.GetContext().Category_tovarov.ToList();
        }
        public WindowAddTovar(Tovar tovar2)
        {
            InitializeComponent();
            tovar = tovar2;
            DataContext = tovar;
            categoriaTovarBox.ItemsSource = DataBase.GetContext().Category_tovarov.ToList();
        }

        private void AddTovar_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (categoriaTovarBox.SelectedItem == null)
                errors.AppendLine("Выберите категорию товара!");
            if (dateBox.SelectedDate == null)
                errors.AppendLine("Выберите дату!");
            if (NumberBOx.Text == null)
                errors.AppendLine("Введите номер товара!");
            if (NameBox.Text == null)
                errors.AppendLine("Введите название товара!");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            try
            {
                if (!DataBase.GetContext().Tovar.ToList().Contains(tovar))
                {
                    DataBase.GetContext().Tovar.Add(tovar);
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
