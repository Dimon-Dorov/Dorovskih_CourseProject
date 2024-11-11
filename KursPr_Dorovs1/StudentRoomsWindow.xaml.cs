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
    /// Логика взаимодействия для StudentRoomsWindow.xaml
    /// </summary>
    public partial class StudentRoomsWindow : Window
    {
        private DataContext context;
        public StudentRoomsWindow()
        {
            InitializeComponent();
            context = new DataContext();
            LoadStudentRooms();
        }

        private void LoadStudentRooms()
        {
            StudentRoomsItemList.ItemsSource = context.StudentRooms
                .Include(sr => sr.Student)
                .Include(sr => sr.Room)
                .ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (StudentRoomsItemList.SelectedItem is StudentRoom selectedRoom)
            {
                selectedRoom.DateIn = DateTime.Parse(DateInTextBox.Text);
                selectedRoom.DateOut = string.IsNullOrEmpty(DateOutTextBox.Text) ? null : DateTime.Parse(DateOutTextBox.Text);

                context.SaveChanges();
                LoadStudentRooms();
                MessageBox.Show("Запис про проживання студента змінено");
            }
            else
            {
                MessageBox.Show("Виберіть запис для редагування!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (StudentRoomsItemList.SelectedItem is StudentRoom selectedRoom)
            {
                context.StudentRooms.Remove(selectedRoom);
                context.SaveChanges();
                LoadStudentRooms();
                MessageBox.Show("Запис видалено");
            }
            else
            {
                MessageBox.Show("Виберіть запис для видалення!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var changeRoomWindow = new ChangeStudentRoomWindow();
            changeRoomWindow.ShowDialog();
            LoadStudentRooms();
        }
    }
}
