using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Windows.ApplicationModel;
using Windows.UI.Xaml;
using WinPlex.Helpers;
using WinPlex.Services;

namespace WinPlex.Views
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Singleton<ToastNotificationsService>.Instance.ShowToastNotificationCustom("coucou");
            Console.Write(postName.Text);
            Console.Write(postContent.Text);
            Console.Write(postImage.Text);
        }

    }
}
