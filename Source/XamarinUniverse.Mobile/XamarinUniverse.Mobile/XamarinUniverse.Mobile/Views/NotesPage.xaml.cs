using System;

using Xamarin.Forms;

using XamarinUniverse.Mobile.Models;
using XamarinUniverse.Mobile.ViewModels;

namespace XamarinUniverse.Mobile.Views
{
    public partial class NotesPage : ContentPage
    {
        NotesViewModel viewModel;

        public NotesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new NotesViewModel();
        }

        void OnNoteSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Note;
            if (item == null)
                return;

            //  await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddNote_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewNotePage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Notes.Count == 0)
                viewModel.LoadNotesCommand.Execute(null);
        }
    }
}