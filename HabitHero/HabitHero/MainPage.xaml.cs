using HabitHero.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HabitHero
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel _mainPageViewModel;
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            habitFormControl.onHabitSaved += HabitFormControl_onHabitSaved;

            if (_mainPageViewModel == null)
            {
                _mainPageViewModel = new MainPageViewModel();
                DataContext = _mainPageViewModel;
            }
        }

        private void HabitFormControl_onHabitSaved(object sender, Model.Habit e)
        {
            _mainPageViewModel.addNewHabit(e);
        }

        private void addHabitButton_Click(object sender, RoutedEventArgs e)
        {
            //opens the form for adding habits
            habitFormControl.Visibility = Visibility.Visible;
        }
    }
}
