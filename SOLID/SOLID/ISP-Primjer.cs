namespace ISPPrimjer { 
    public interface IMamal {
        public void breathe();
        public void walk();
        public void swim();
        public void feed();
    }

    public class Human : IMamal
    {
        public void breathe()
        {
            Console.WriteLine("Breathe");
        }

        public void feed()
        {
            Console.WriteLine("Feed");
        }

        public void swim()
        {
            Console.WriteLine("Swim");
        }

        public void walk()
        {
            Console.WriteLine("Walk");
        }
    }

    public class Whale: IMamal {
        public void breathe()
        {
            Console.WriteLine("Breathe");
        }

        public void feed()
        {
            Console.WriteLine("Feed");
        }

        public void swim()
        {
            Console.WriteLine("Swim");
        }

        public void walk()
        {
            throw new Exception();
        }
    }
}