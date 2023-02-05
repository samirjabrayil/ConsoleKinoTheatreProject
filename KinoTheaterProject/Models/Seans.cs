using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoTheaterProject.Models
{
    internal class Seans : Entity
    {

        internal string DateTime { get; set; }
        internal string Hall { get; set; }
        internal string Film { get; set; }

        public override string ToString()
        {
            return $"{Id} Film: {Film}\nHall: {Hall}\nTime: {DateTime}";
        }
    }
}
