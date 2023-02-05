using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace KinoTheaterProject.Models
{
    internal class Tickets : Entity
    {
        internal Seans[] sessions = new Seans[4];
        internal decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} Ticket count : {10} Ticket Cost :{Price}";
        }
    }
}
