using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.Entities
{
    public class Table
    {
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public int CountOfSeats { get; set; }
        public Location Location { get; set; }
    }
}
