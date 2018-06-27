using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using WinPlex.Helpers;
using WinPlex.Services;
using WinPlex.Models;
using Windows.Devices.Geolocation;

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

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Geolocator geoLocator = new Geolocator();
            GeolocationAccessStatus accessStatus = await Geolocator.RequestAccessAsync();
            if (accessStatus == GeolocationAccessStatus.Allowed)
            {
                geoLocator.DesiredAccuracy = PositionAccuracy.Default;
                Geoposition pos = await geoLocator.GetGeopositionAsync();
                Post post = new Post(postName.Text, postImage.Text, pos.Coordinate.Point.Position.Latitude.ToString(), pos.Coordinate.Point.Position.Longitude.ToString(), postContent.Text, DateTime.Today);
                PostService.SaveNewPost(post);
                Singleton<ToastNotificationsService>.Instance.ShowToastNotificationCustom($"Post {postName.Text} successfully saved");
            }

            else if (accessStatus == GeolocationAccessStatus.Denied)
            {
                Singleton<ToastNotificationsService>.Instance.ShowToastNotificationCustom("You need to enable location in your windows");
            }
        }

    }
}
