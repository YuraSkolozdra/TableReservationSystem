using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public Table Table { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public int Status { get; set; }
        public decimal Cost { get; set; }
        public int UserId { get; set; }
    }
}
