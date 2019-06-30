using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;
using XamarinUniverse.Mobile.Models;
using XamarinUniverse.Mobile.Services;
using XamarinUniverse.Mobile.Views;

namespace XamarinUniverse.Mobile.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public DataService _dataservice;
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            _dataservice = new DataService();
            Title = "Browse";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(() => ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);

                _dataservice.Insert(newItem);
                // await DataStore.AddItemAsync(newItem);
            });
        }

        void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                //  var items = await DataStore.GetItemsAsync(true);
                //var items = _dataservice.Get<Item>(false);
                //foreach (var item in items)
                //{
                //    Items.Add(item);
                //}
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