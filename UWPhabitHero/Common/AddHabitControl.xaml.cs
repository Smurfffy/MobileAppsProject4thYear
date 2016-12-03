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
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UWPhabitHero.Common
{
    public sealed partial class AddHabitControl : UserControl
    {
        public event EventHandler<TodoItem> OnHabitSaved;
        public AddHabitControl()
        {
            this.InitializeComponent();
        }

        private MobileServiceCollection<TodoItem, TodoItem> items;

        private IMobileServiceTable<TodoItem> todoTable = App.MobileService.GetTable<TodoItem>();

        private async Task InsertTodoItem(TodoItem todoItem)
        {
            // This code inserts a new TodoItem into the database. After the operation completes
            // and the mobile app backend has assigned an id, the item is added to the CollectionView.
            await todoTable.InsertAsync(todoItem);
            items.Add(todoItem);

#if OFFLINE_SYNC_ENABLED
            await App.MobileService.SyncContext.PushAsync(); // offline sync
#endif
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var todoItem = new TodoItem();
            todoItem.Text = HabitNameTextBox.Text;
            todoItem.Info = QuitingTextBox.Text;

            FireOnHabitSaved(todoItem);

            await InsertTodoItem(todoItem);

            ClearTextBoxes();
            Visibility = Visibility.Collapsed;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            HabitNameTextBox.Text = string.Empty;
            QuitingTextBox.Text = string.Empty;
        }

        private void FireOnHabitSaved(TodoItem todoItem)
        {
            OnHabitSaved?.Invoke(null, todoItem);
        }
    }
}
