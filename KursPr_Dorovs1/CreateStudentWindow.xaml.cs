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
    /// Логика взаимодействия для CreateStudentWindow.xaml
    /// </summary>
    public partial class CreateStudentWindow : Window
    {
        private DataContext context;

        public CreateStudentWindow()
        {
            InitializeComponent();
            context = new DataContext();
            LoadRooms();
        }

        private void LoadRooms()
        {
            RoomIdItemList.ItemsSource = context.Rooms.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedRoom = RoomIdItemList.SelectedItem as Room;
            var currentOccupants = context.StudentRooms.Count(sr => sr.RoomId == selectedRoom.RoomId && sr.DateOut == null);
            if (currentOccupants >= selectedRoom.SleepCount)
            {
                MessageBox.Show("В обраній кімнаті немає вільних місць!");
                return;
            }

            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(PhoneTextBox.Text) ||
                string.IsNullOrEmpty(GroupTextBox.Text) || RoomIdItemList.SelectedItem == null)
            {
                MessageBox.Show("Заповніть всі необхідні поля!");
                return;
            }

            if (!int.TryParse(GroupTextBox.Text, out int group))
            {
                MessageBox.Show("Номер групи повинен бути числом!");
                return;
            }

            var newStudent = new Student
            {
                StName = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Group = group,
                Note = NoteTextBox.Text
            };

            context.Students.Add(newStudent);
            context.SaveChanges();

            var studentRoom = new StudentRoom
            {
                StudId = newStudent.StudId,
                RoomId = selectedRoom.RoomId,
                DateIn = DateTime.Now,
                DateOut = null
            };

            context.StudentRooms.Add(studentRoom);
            context.SaveChanges();

            var newStudentPayment = new AmountPayment
            {
                StudId = newStudent.StudId,
                Payment = 0
            };

            context.Payments.Add(newStudentPayment);
            context.SaveChanges();

            MessageBox.Show("Студента створено та заселено до кімнати");
            this.Close();
        }
    }
}
