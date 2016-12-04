using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPhabitHero.DataModel;

namespace UWPhabitHero.ViewModel
{
    public class MainPageViewModel : BaseViewModel // gets the base view model
    {
        private ObservableCollection<Habit> _habitList; //Observes the habitlist privatly
        public ObservableCollection<Habit> HabitList // public observable 
        {
            get { return _habitList; }
            set
            {
                _habitList = value;
                NotifyPropertyChanged("HabitList");
            }
        }

        public MainPageViewModel()
        {
            _habitList = new ObservableCollection<Habit>();
        }

        public void AddNewHabit(Habit newHabit) // adds the new habit to the list
        {
            HabitList.Add(newHabit);
        }
    }
}
