namespace MementoExtraRjesenje
{
    public class File
    {
        public string FileData { get; private set; }

        public File()
        {
            FileData = "";
        }

        public void Apend(string data)
        {
            FileData += data;
        }

        public FileClipboard SaveDataToClipboard()
        {
            return new FileClipboard(FileData);
        }

        public void PasteFromClipboard(FileClipboard fileClipboard)
        {
            FileData = fileClipboard.GetClipboardData();
        }
    }

    public class FileClipboard
    {
        string fileData;
        public FileClipboard(string fileData)
        {
            this.fileData = fileData;
        }

        public string GetClipboardData()
        {
            return fileData;
        }
    }

    public class Cache
    {
        File file;

        public Cache(File file)
        {
            this.file = file;
        }

        List<FileClipboard> fileClipboards = new List<FileClipboard>();

        public void SaveToCache(FileClipboard fileClipboard)
        {
            fileClipboards.Add(fileClipboard);
        }

        public void Undo()
        {
            int count = fileClipboards.Count;
            if (count > 1)
            {
                file.PasteFromClipboard(fileClipboards.ElementAt(count - 2));
                fileClipboards.RemoveAt(count - 1);

            }
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            File file = new File();
            Cache cache = new Cache(file);
            cache.SaveToCache(new FileClipboard(file.FileData));

            file.Apend("Hello I am File");
            cache.SaveToCache(new FileClipboard(file.FileData));

            file.Apend(" I am here to File");
            cache.SaveToCache(new FileClipboard(file.FileData));

            Console.WriteLine(file.FileData);
            cache.Undo();
            Console.WriteLine(file.FileData);

            cache.Undo();
            Console.WriteLine(file.FileData);
        }
    }
}