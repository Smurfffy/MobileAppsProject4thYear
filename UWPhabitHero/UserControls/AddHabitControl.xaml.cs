using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPhabitHero.DataModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UWPhabitHero.UserControls
{
    public sealed partial class AddHabitControl : UserControl
    {
        public event EventHandler<Habit> OnHabitSaved;

        public AddHabitControl()
        {
            this.InitializeComponent();
        }

        private void SaveHabitBtn_Click(object sender, RoutedEventArgs e)
        {
            //fire event for data
            var newHabit = new Habit();
            newHabit.Name = HabitNameTxtBox.Text;
            newHabit.Rating = Convert.ToInt32(RatingTxtBox.Text);
            newHabit.Reason = ReasonTxtBox.Text;

            FireOnHabitSaved(newHabit);
            
            ClearTxtBoxes();
            Visibility = Visibility.Collapsed;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
            ClearTxtBoxes();
        }

        private void ClearTxtBoxes()
        {
            // Clears the text boxes
            HabitNameTxtBox.Text = string.Empty;
            RatingTxtBox.Text = string.Empty;
            ReasonTxtBox.Text = string.Empty;
        }

        private void FireOnHabitSaved(Habit newHabit)
        {
            OnHabitSaved?.Invoke(null, newHabit);
        }
    }
}
