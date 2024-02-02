/*
Za primjer dan izlistanjem kôda odredite obrazac 
o kojem je riječ i njegovu skupinu. Dopunite kôd 
implementacijom koja nedostaje te napišite 
klijentski kôd za ovaj primjer.
*/
/*Memento*/
namespace SestiRjesenje
{
    class Document
    {
        public string Content { get; set; }

        public Document(string content)
        {
            Content = content;
        }

        public DocumentTrace CreateTrace()
        {
            return new DocumentTrace(Content);
        }

        public void RestoreFromTrace(DocumentTrace trace)
        {
            Content = trace.GetSavedContent();
        }

        public void Print()
        {
            Console.WriteLine($"Document content: {Content}");
        }
    }

    class DocumentTrace
    {
        private readonly string content;

        public DocumentTrace(string content)
        {
            this.content = content;
        }

        public string GetSavedContent()
        {
            return content;
        }
    }

    class DocumentHistory
    {
        private readonly Stack<DocumentTrace> history = new Stack<DocumentTrace>();

        public void SaveVersion(Document document)
        {
            history.Push(document.CreateTrace());
        }

        public void Undo(Document document)
        {
            if (history.Count > 0)
            {
                var trace = history.Pop();
                document.RestoreFromTrace(trace);
            }
            else
            {
                Console.WriteLine("No more versions to undo.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Klijentski kod
            Document document = new Document("Initial content");
            DocumentHistory history = new DocumentHistory();

            document.Print(); // Ispisuje: Document content: Initial content

            // Dodajemo verziju dokumenta u povijest
            history.SaveVersion(document);

            // Mijenjamo sadržaj dokumenta
            document.Content = "Modified content";
            document.Print(); // Ispisuje: Document content: Modified content

            // Vraćamo se na prethodnu verziju
            history.Undo(document);
            document.Print(); // Ispisuje: Document content: Initial content
        }
    }
}