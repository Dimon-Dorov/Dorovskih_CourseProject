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
    /// Логика взаимодействия для StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        private DataContext context;
        public StudentsWindow()
        {
            InitializeComponent();
            context = new DataContext();
            LoadStudents();
        }
        private void LoadStudents()
        {
            StudentsItemList.ItemsSource = context.Students.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var createStudentWindow = new CreateStudentWindow();
            createStudentWindow.ShowDialog();
            LoadStudents();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (var student in context.Students.ToList())
            {
                student.Group += 10;

                if (student.Group > 50)
                {
                    var studentRooms = context.StudentRooms.Where(sr => sr.StudId == student.StudId).ToList();
                    var amountPayments = context.Payments.Where(ap => ap.StudId == student.StudId).ToList();

                    context.StudentRooms.RemoveRange(studentRooms);
                    context.Payments.RemoveRange(amountPayments);
                    context.Students.Remove(student);
                }
            }
            context.SaveChanges();
            LoadStudents();
            MessageBox.Show("Студенти переведені в наступну групу");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (StudentsItemList.SelectedItem is Student selectedStudent)
            {
                var studentToDelete = context.Students.Find(selectedStudent.StudId);

                if (studentToDelete != null)
                {
                    var studentRooms = context.StudentRooms.Where(sr => sr.StudId == studentToDelete.StudId).ToList();
                    var amountPayments = context.Payments.Where(ap => ap.StudId == studentToDelete.StudId).ToList();

                    context.StudentRooms.RemoveRange(studentRooms);
                    context.Payments.RemoveRange(amountPayments);
                    context.Students.Remove(studentToDelete);

                    context.SaveChanges();
                    LoadStudents();
                    MessageBox.Show("Студента видалено");
                }
            }
            else
            {
                MessageBox.Show("Виберіть студента для видалення!");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (StudentsItemList.SelectedItem is Student selectedStudent)
            {
                var studentToUpdate = context.Students.Find(selectedStudent.StudId);

                if (studentToUpdate != null)
                {
                    studentToUpdate.StName = NameTextBox.Text;
                    studentToUpdate.Phone = PhoneTextBox.Text;
                    studentToUpdate.Group = int.Parse(GroupTextBox.Text);
                    studentToUpdate.Note = NoteTextBox.Text;

                    context.SaveChanges();
                    LoadStudents();
                    MessageBox.Show("Інформацію про студента змінено");
                }
            }
            else
            {
                MessageBox.Show("Виберіть студента для змінення інформації!");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
