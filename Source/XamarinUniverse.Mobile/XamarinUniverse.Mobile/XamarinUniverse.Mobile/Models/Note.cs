namespace XamarinUniverse.Mobile.Models
{
    using SQLite;
    //using SQLite.Net.Attributes;
    public class Note
    {
        [PrimaryKey]
        public int NoteId { get; set; }

        public string NoteHeader { get; set; }

        public string NoteBody { get; set; }
    }
}
