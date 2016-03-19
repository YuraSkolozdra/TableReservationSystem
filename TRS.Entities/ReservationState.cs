using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.Entities
{
    class CurrentReservationState
    {
        public int ReservationId { get; set; }
        public int TableId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public decimal Cost { get; set; }
    }
}
