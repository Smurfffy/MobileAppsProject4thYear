using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPhabitHero.DataModel
{
    public class Habit //The HAbit item that the user will store values to
    {
        public string Name { get; set; } // The name of the habit

        public int Rating { get; set; } // The users rating out of ten

        public string Reason { get; set; } // why they want to quit
    }
}
