using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace XamarinUniverse.Mobile.ViewModels
{
    public class NotesViewModel : BaseViewModel
    {
        public DataService _dataservice;
        public ObservableCollection<Note> Notes { get; set; }
        public Command LoadNotesCommand { get; set; }

        public NotesViewModel()
        {
            _dataservice = new DataService();
            Title = "Browse";
            Notes = new ObservableCollection<Note>();
            LoadNotesCommand = new Command(() => ExecuteLoadNotesCommand());

            MessagingCenter.Subscribe<NewNotePage, Note>(this, "AddNote", (obj, item) =>
            {
                var newItem = item as Note;
                Notes.Add(newItem);
                _dataservice.Insert(newItem);
            });
        }

        void ExecuteLoadNotesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Notes.Clear();
                //var notes = _dataservice.Get<Note>(false);
                //foreach (var item in notes)
                //{
                //    Notes.Add(item);
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