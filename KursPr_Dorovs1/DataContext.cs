using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KursPr_Dorovs
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Kursova1.db");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<StudentRoom> StudentRooms { get; set; }
        public DbSet<AmountPayment> Payments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentRoom>(entity =>
            {
                entity.HasOne(sr => sr.Student)
                      .WithMany(s => s.StudentRooms)
                      .HasForeignKey(sr => sr.StudId);

                entity.HasOne(sr => sr.Room)
                      .WithMany(r => r.StudentRooms)
                      .HasForeignKey(sr => sr.RoomId);
            });

            modelBuilder.Entity<AmountPayment>()
                .HasOne(p => p.Student)
                .WithOne(s => s.AmountPayment)
                .HasForeignKey<AmountPayment>(p => p.StudId);
        }
    }
}
