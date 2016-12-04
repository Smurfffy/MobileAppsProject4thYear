using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPhabitHero.DataModel;

namespace UWPhabitHero.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<Habit> _habitList;
        public ObservableCollection<Habit> HabitList
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

        public void AddNewHabit(Habit newHabit)
        {
            HabitList.Add(newHabit);
        }
    }
}
