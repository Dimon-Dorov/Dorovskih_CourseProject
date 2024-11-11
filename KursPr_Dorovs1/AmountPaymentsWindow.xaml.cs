using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для AmountPaymentsWindow.xaml
    /// </summary>
    public partial class AmountPaymentsWindow : Window
    {
        private DataContext context;
        private decimal CurrentCost;
        private DateTime LastDeductionDate;

        public AmountPaymentsWindow()
        {
            InitializeComponent();
            context = new DataContext();
            LoadConfAndCost();
            LoadPayments();
        }
        private void LoadPayments()
        {
            AmountPaymentItemList.ItemsSource = context.Payments.Include(p => p.Student).ToList();
        }

        private void LoadConfAndCost()
        {
            var (lastPaymentDate, livingCost) = FileForSave.LoadConfig();
            LastDeductionDate = lastPaymentDate;
            CurrentCost = livingCost;
            CostTextBox.Text = CurrentCost.ToString();

            var today = DateTime.Today;
            if (LastDeductionDate.Year == today.Year && LastDeductionDate.Month == today.Month)
            {
                return;
            }

            foreach (var payment in context.Payments)
            {
                payment.Payment -= CurrentCost;
            }

            LastDeductionDate = today;
            FileForSave.SaveConfig(LastDeductionDate, CurrentCost);
            context.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(CostTextBox.Text, out decimal newCost))
            {
                CurrentCost = newCost;
                FileForSave.SaveConfig(LastDeductionDate, CurrentCost);
                MessageBox.Show("Вартість проживання змінено");
            }
            else
            {
                MessageBox.Show("Введіть коректну вартість проживання!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (AmountPaymentItemList.SelectedItem is AmountPayment selectedPayment)
            {
                if (decimal.TryParse(PaymentTextBox.Text, out decimal additionalAmount))
                {
                    selectedPayment.Payment += additionalAmount;
                    context.SaveChanges();

                    LoadPayments();
                }
                else
                {
                    MessageBox.Show("Введіть коректну суму для додавання!");
                }
            }
            else
            {
                MessageBox.Show("Виберіть студента для додавання внеску!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (AmountPaymentItemList.SelectedItem is AmountPayment selectedPayment)
            {
                if (decimal.TryParse(PaymentTextBox.Text, out decimal updatedPayment))
                {
                    selectedPayment.Payment = updatedPayment;
                    context.SaveChanges();
                    LoadPayments();
                }
                else
                {
                    MessageBox.Show("Введіть коректну суму внеску!");
                }
            }
            else
            {
                MessageBox.Show("Виберіть студента для оновлення внеску!");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
