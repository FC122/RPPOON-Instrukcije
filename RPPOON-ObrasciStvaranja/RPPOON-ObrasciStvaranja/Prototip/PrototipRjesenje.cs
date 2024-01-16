namespace PrototipRjesenje
{
    interface IClonable
    {
        public object Clone();
    }
    public class Cat : IClonable
    {
        public string name;
        public string weight;
        private string type;
        public Cat(string name, string weight, string type)
        {
            this.name = name;
            this.weight = weight;
            this.type = type;
        }
        public Cat(Cat cat) : this(cat.name, cat.weight, cat.type) { }
        public object Clone()
        {
            return new Cat(this);
        }
        public void doStuff()
        {
            Console.WriteLine($"{name},{weight},{type}");
        }
    }


    public class ClientCode
    {
        public static void Run()
        {
            Cat cat = new Cat("Carli", "50", "Lion");
            Cat catClone = (Cat)cat.Clone();
            Cat anotherCatClone = new Cat(cat);
            cat.doStuff();
            catClone.doStuff();
            anotherCatClone.doStuff();
        }
    }
}