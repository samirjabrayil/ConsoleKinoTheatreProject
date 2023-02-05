using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoTheaterProject.Models
{
    internal class Hall : Entity
    {

        internal string Name { get; set; }
        internal int hallraw { get; set; }
        internal int hallcolumn { get; set; }
        public override string ToString()
        {
            return $"{Id} Zal adi: {Name}\nZal olcusu:{hallcolumn} x {hallcolumn}\nTutumu {hallraw * hallcolumn} nefer\n";
        }

    }
}
