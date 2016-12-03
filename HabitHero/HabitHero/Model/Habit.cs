using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitHero.Model
{
    [Table("Habit")]
    public class Habit
    {
        //This is or object for the habits
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HabitId { get; set; } // This is the key for our database

        public string Name { get; set; } //This stores the name of the users habit. user inputed

        public string Info { get; set; } // This contanes info of why the user wants to quit. User inputted

        public DateTime Date { get; set; } // This contains the date the habit object was created.
    }
}
