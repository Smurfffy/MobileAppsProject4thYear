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
using HabitHero.Model;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HabitHero.AppPages
{
    public sealed partial class HabitForm : UserControl
    {
        public event EventHandler<Habit> onHabitSaved;

        public HabitForm()
        {
            this.InitializeComponent();
        }

        private void addHabitBtn_Click(object sender, RoutedEventArgs e)
        {
            //This saves the details of our habit to our object in the habit class
            var newHabit = new Habit();
            newHabit.Name = habitTxtBox.Text;
            newHabit.Info = infoTxtBox.Text;
            fireOnHabitSaved(newHabit);
            ClearTxt();
            Visibility = Visibility.Collapsed;
        }

        private void exitFormBtn_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
            ClearTxt();
        }

        private void ClearTxt()
        {
            // will clear the text boxes in the form
            habitTxtBox.Text = String.Empty;
            infoTxtBox.Text = String.Empty;
        }

        private void fireOnHabitSaved(Habit newHabit)
        {
            onHabitSaved?.Invoke(null, newHabit);
        }
    }
}
