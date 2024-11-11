using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KursPr_Dorovs
{
    internal class Room
    {
        [Key]
        public int RoomId { get; set; }
        public int SleepCount { get; set; }
        public List<StudentRoom> StudentRooms { get; set; }
    }
}
