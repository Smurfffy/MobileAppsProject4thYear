using HabitHero.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitHero.ViewModel
{
    public class MainPageViewModel : HabitViewModel
    {
        private ObservableCollection<Habit> _habitList;
        public ObservableCollection<Habit> habitList
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

        public void addNewHabit(Habit newHabit)
        {
            habitList.Add(newHabit);
        }
    }
}
