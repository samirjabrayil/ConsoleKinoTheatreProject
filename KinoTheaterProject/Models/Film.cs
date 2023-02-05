using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoTheaterProject.Models
{
    internal class Film : Entity
    {
        internal string Name { get; set; }
        internal string Director { get; set; }
        internal string Date { get; set; }
        internal string Genre { get; set; }

        public override string ToString()
        {
            return $"{Id} Film:{Name}\nDirector:{Director}\nRelease date:{Date}\nGenre:{Genre}\n";
        }
    }
}
