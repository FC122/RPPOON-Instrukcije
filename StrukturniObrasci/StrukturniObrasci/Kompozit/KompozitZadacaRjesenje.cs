namespace KompozitZadacaRjesenje
{

    public interface IDisplayable
    {
        void Display();
    }


    public class Folder : IDisplayable
    {
        private List<IDisplayable> displayables = new List<IDisplayable>();
        string name;
        public Folder(string name) { this.name = name; }
        public void Add(IDisplayable component) { displayables.Add(component); }
        public void Remove(IDisplayable component) { displayables.Remove(component); }
        public void Display()
        {
            Console.WriteLine($"Display {name}");
            foreach (var displayable in displayables)
            {
                displayable.Display();
            }
        }
    }

    public class File : IDisplayable
    {
        string name;

        public File(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Display {name}");
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            Folder cDisc = new Folder("C");

            cDisc.Add(new Folder("Program data"));

            cDisc.Add(new File("Image.jpg"));

            cDisc.Display();
        }
    }

}