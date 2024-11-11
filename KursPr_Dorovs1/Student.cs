using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursPr_Dorovs
{
    internal class Student
    {
        [Key]
        public int StudId { get; set; }
        public string StName { get; set; }
        public string Phone { get; set; }
        public int Group { get; set; }
        public string Note { get; set; }
        public List<StudentRoom> StudentRooms { get; set; }
        public AmountPayment AmountPayment { get; set; }
    }
}
