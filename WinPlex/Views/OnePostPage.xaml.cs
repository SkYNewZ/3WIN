using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using WinPlex.Models;
using WinPlex.Services;
using System.Threading.Tasks;

namespace WinPlex.Views
{
    public sealed partial class OnePostPage : Page, INotifyPropertyChanged
    {
        public Post CurrentPost;

        public OnePostPage()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            CurrentPost = await PostService.GetPost(); // I CAN'T GET THE CONTENT HERE but it is defined in the service...
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
    }
}
