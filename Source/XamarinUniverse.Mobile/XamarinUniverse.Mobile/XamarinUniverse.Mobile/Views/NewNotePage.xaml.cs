using System;

using Xamarin.Forms;

using XamarinUniverse.Mobile.Models;

namespace XamarinUniverse.Mobile.Views
{
    public partial class NewNotePage : ContentPage
    {
        public Note Note { get; set; }

        public NewNotePage()
        {
            InitializeComponent();

            Note = new Note
            {
                NoteHeader = "Note Header",
                NoteBody = "This is an Note Body."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddNote", Note);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}