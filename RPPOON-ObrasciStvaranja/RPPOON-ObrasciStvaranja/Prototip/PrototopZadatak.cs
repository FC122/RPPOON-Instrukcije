namespace PrototipZadatak
{
    public class Cat
    {
        public string name;
        public string weight;
        private string type;
        public Cat() { }
        public Cat(string name, string weight, string type)
        {
            this.name = name;
            this.weight = weight;
            this.type = type;
        }
        public void doStuff()
        {
            Console.WriteLine($"{name},{weight},{type}");
        }
    }
    public class CatLibrary
    {

    }

    public class ClientCode
    {
        public static void Run()
        {
            Cat cat = new Cat("Carli", "50", "Lion");
            Cat catClone = new Cat();
            catClone.weight = cat.weight;
            catClone.name = cat.name;
            cat.doStuff();
            catClone.doStuff();
        }
    }
}