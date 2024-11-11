using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KursPr_Dorovs
{
    internal class AmountPayment
    {
        [Key]
        public int AmountId { get; set; }
        public int StudId { get; set; }
        public decimal Payment { get; set; }
        public Student Student { get; set; }
    }
}
