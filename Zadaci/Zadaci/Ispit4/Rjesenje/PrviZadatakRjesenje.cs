namespace PrviZadatakRjesenjeIspit4
{
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Creation { get; private set; }

        public Note(string title, string text)
        {
            Title = title;
            Text = text;
            Creation = DateTime.Now;
        }
    }

    public class NoteCollection
    {
        public string Author { get; private set; }
        public List<Note> Notes { get; private set; }

        public NoteCollection(string author)
        {
            Author = author;
            Notes = new List<Note>();
        }

        public void AddNoteToCollection(Note note)
        {
            Notes.Add(note);
        }
    }

}