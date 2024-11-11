using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KursPr_Dorovs
{
    internal class StudentRoom
    {
        [Key]
        public int StudRoomId { get; set; }
        public int StudId { get; set; }
        public int RoomId { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public Student Student { get; set; }
        public Room Room { get; set; }
    }
}
