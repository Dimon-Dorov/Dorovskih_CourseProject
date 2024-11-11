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
    /// Логика взаимодействия для ChangeStudentRoomWindow.xaml
    /// </summary>
    public partial class ChangeStudentRoomWindow : Window
    {
        private DataContext context;

        public ChangeStudentRoomWindow()
        {
            InitializeComponent();
            context = new DataContext();
            LoadStudents();
            LoadAvailableRooms();
        }

        private void LoadStudents()
        {
            StNameItemList.ItemsSource = context.Students.ToList();
        }

        private void LoadAvailableRooms()
        {
            RoomIdItemList.ItemsSource = context.Rooms.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (StNameItemList.SelectedItem is Student selectedStudent && RoomIdItemList.SelectedItem is Room newRoom)
            {
                int occupantsInNewRoom = context.StudentRooms.Count(sr => sr.RoomId == newRoom.RoomId && sr.DateOut == null);
                if (occupantsInNewRoom >= newRoom.SleepCount)
                {
                    MessageBox.Show("В обраній кімнаті немає вільних місць!");
                    return;
                }
                var currentStudentRoom = context.StudentRooms.FirstOrDefault(sr => sr.StudId == selectedStudent.StudId && sr.DateOut == null);
                if (currentStudentRoom != null)
                {
                    currentStudentRoom.DateOut = DateTime.Now;
                }
                var newStudentRoom = new StudentRoom
                {
                    StudId = selectedStudent.StudId,
                    RoomId = newRoom.RoomId,
                    DateIn = DateTime.Now
                };
                context.StudentRooms.Add(newStudentRoom);
                context.SaveChanges();
                MessageBox.Show("Кімнату студента успішно змінено.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Виберіть студента та нову кімнату для зміни!");
            }
        }
    }
}
