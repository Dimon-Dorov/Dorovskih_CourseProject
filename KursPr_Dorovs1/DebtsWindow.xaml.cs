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

namespace KursPr_Dorovs
{
    /// <summary>
    /// Логика взаимодействия для DebtsWindow.xaml
    /// </summary>
    public partial class DebtsWindow : Window
    {
        private DataContext context;

        public DebtsWindow()
        {
            InitializeComponent();
            context = new DataContext();
            LoadDebts();
        }

        private void LoadDebts()
        {
            var debts = context.Payments
                .Where(p => p.Payment < 0)
                .Select(p => new
                {
                    Student = p.Student,
                    Payment = p.Payment
                })
                .ToList();

            DebtsItemList.ItemsSource = debts;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
