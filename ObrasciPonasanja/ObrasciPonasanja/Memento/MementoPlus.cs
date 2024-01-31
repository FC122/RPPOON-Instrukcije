// namespace MementoPlus{

// class Document
// {
//     public string Content { get; set; }

//     public Document(string content)
//     {
//         Content = content;
//     }
//     public DocumentTrace CreateTrace()
//     {
//         return new DocumentTrace(Content);
//     }

//     public void RestoreFromTrace(DocumentTrace trace)
//     {
//         Content = trace.GetSavedContent();
//     }

//     public void Print()
//     {
//         Console.WriteLine($"Document content: {Content}");
//     }
// }

// class DocumentTrace
// {
//     private readonly string content;

//     public DocumentTrace(string content)
//     {
//         this.content = content;
//     }

//     public string GetSavedContent()
//     {
//         return content;
//     }
// }

// class DocumentHistory
// {
//     private readonly Stack<DocumentMemento> history = new Stack<DocumentMemento>();

//     public void SaveVersion(Document document)
//     {
//         history.Push(document.CreateTrace());
//     }

//     public void Undo(Document document)
//     {
//         if (history.Count > 0)
//         {
//             var trace = history.Pop();
//             document.RestoreFromTrace(trace);
//         }
//         else
//         {
//             Console.WriteLine("No more versions to undo.");
//         }
//     }
// }


// }