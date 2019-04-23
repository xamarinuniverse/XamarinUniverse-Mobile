using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using WordPressRestApiStandard.Models;
using Xamarin.Forms;
using XamarinUniverse.Mobile.Services;

namespace XamarinUniverse.Mobile.ViewModels
{
    public class PostsViewModel : BaseViewModel
    {
        public ObservableCollection<Post> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        private readonly WordPressService wpService;
        public PostsViewModel()
        {
            wpService = new WordPressService();
            Title = "Posts";
            Items = new ObservableCollection<Post>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await wpService.GetLatestPostAsync(10);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}