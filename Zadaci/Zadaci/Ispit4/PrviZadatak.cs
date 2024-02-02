namespace PrviZadatakIspit4
{
    //Ispravi imenovanje
    public class NoteObject
    {
        public string title { get; set; }
        public string text { get; set; }
        public DateTime creation { get; private set; }

        public NoteObject(string titleString, string textString)
        {
            title = titleString;
            text = textString;
            creation = DateTime.Now;
        }
    }

    public class CollectionOfNotes
    {
        public string Author { get; private set; }
        public List<NoteObject> groupOfNotes;

        public CollectionOfNotes(string author)
        {
            Author = author;
            groupOfNotes = new List<NoteObject>();
        }

        public void AddNoteToCollection(NoteObject note)
        {
            groupOfNotes.Add(note);
        }
    }
}