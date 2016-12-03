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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UWPhabitHero.Common
{
    public sealed partial class AddHabitControl : UserControl
    {
        public AddHabitControl()
        {
            this.InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {


            ClearTextBoxes();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            HabitNameTextBox.Text = string.Empty;
            QuitingTextBox.Text = string.Empty;
        }
    }
}
