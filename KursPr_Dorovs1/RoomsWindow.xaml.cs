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
    /// Логика взаимодействия для RoomsWindow.xaml
    /// </summary>
    public partial class RoomsWindow : Window
    {
        private DataContext context;
        public RoomsWindow()
        {
            InitializeComponent();
            context = new DataContext();
            LoadRooms();
        }
        private void LoadRooms()
        {
            RoomsItemList.ItemsSource = context.Rooms.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(RoomNumberTextBox.Text, out int roomNumber) && int.TryParse(BedCountTextBox.Text, out int bedCount))
            {
                if (context.Rooms.Any(r => r.RoomId == roomNumber))
                {
                    MessageBox.Show("Кімната з таким номер вже існує!");
                    return;
                }
                var newRoom = new Room
                {
                    RoomId = roomNumber,
                    SleepCount = bedCount
                };

                context.Rooms.Add(newRoom);
                context.SaveChanges();
                MessageBox.Show("Кімната успішно створена");
                LoadRooms();
            }
            else
            {
                MessageBox.Show("Введіть коректні дані!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (RoomsItemList.SelectedItem is Room selectedRoom && int.TryParse(BedCountTextBox.Text, out int bedCount))
            {
                int currentOccupants = context.StudentRooms.Count(sr => sr.RoomId == selectedRoom.RoomId && sr.DateOut == null);
                if (bedCount < currentOccupants)
                {
                    MessageBox.Show("Нова кількість ліжок не може бути меншою ніж кількість студентів які проживають в ній!");
                    return;
                }
                var roomToUpdate = context.Rooms.Find(selectedRoom.RoomId);
                if (roomToUpdate != null)
                {
                    roomToUpdate.SleepCount = bedCount;
                    context.SaveChanges();
                    MessageBox.Show("Інформацію про кімнату змінено");
                    LoadRooms();
                }
            }
            else
            {
                MessageBox.Show("Виберіть кімнату та введіть коректні дані для зміни!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (RoomsItemList.SelectedItem is Room selectedRoom)
            {
                var roomToDelete = context.Rooms.Include(r => r.StudentRooms).FirstOrDefault(r => r.RoomId == selectedRoom.RoomId);
                var roomToDelete2 = context.StudentRooms.Where(sr => sr.RoomId == selectedRoom.RoomId).ToList();

                if (roomToDelete.StudentRooms.Count == 0)
                {
                    context.StudentRooms.RemoveRange(roomToDelete2);
                    context.Rooms.Remove(roomToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Кімнату успішно видалено");
                    LoadRooms();
                }
                else
                {
                    MessageBox.Show("Неможливо видалити кімнату в якій проживають студенти!");
                }
            }
            else
            {
                MessageBox.Show("Виберіть кімнату для видалення!");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
