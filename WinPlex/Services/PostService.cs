using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPlex.Models;
using WinPlex.Helpers;
using Windows.Storage;

namespace WinPlex.Services
{
    public static class PostService
    {
        public static async void SaveNewPost(Post post)
        {
            await SettingsStorageExtensions.SaveAsync(ApplicationData.Current.LocalFolder, "post", post);
        }

        public static Task<Post> GetPost()
        {
            return SettingsStorageExtensions.ReadAsync<Post>(ApplicationData.Current.LocalFolder, "post"); // CONTENT IS HERE
        }
    }
}
