using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPhabitHero.ViewModel
{
    class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<TodoItem> _habitList;
        public ObservableCollection<TodoItem> HabitList
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
            _habitList = new ObservableCollection<TodoItem>();
        }

        public void AddNewHAbit(TodoItem newHabit)
        {
            HabitList.Add(newHabit);
        }
    }
}
