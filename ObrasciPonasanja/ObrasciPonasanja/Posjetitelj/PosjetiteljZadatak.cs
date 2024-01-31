using System.Security.Cryptography.X509Certificates;

namespace PosjetiteljZadatak
{

    public interface IInstructions
    {
        public void Teach();
    }

    public class RPPOONOnline : IInstructions
    {
        public string teacher { get; private set; }

        public RPPOONOnline(string teacher)
        {
            this.teacher = teacher;
        }

        public void Teach()
        {
            Console.WriteLine("Teach RPPOON Online");
        }
    }

    public class RPPOONLive : IInstructions
    {
        public string teacher { get; private set; }

        public RPPOONLive(string teacher)
        {
            this.teacher = teacher;
        }

        public void Teach()
        {
            Console.WriteLine("Teach RPPOON Live");
        }
    }

    public class MathematicsOnline : IInstructions
    {
        public string teacher { get; private set; }

        public MathematicsOnline(string teacher)
        {
            this.teacher = teacher;
        }

        public void Teach()
        {
            Console.WriteLine("Teach Math Online");
        }
    }

    public class MathematicsLive : IInstructions
    {
        public string teacher { get; private set; }

        public MathematicsLive(string teacher)
        {
            this.teacher = teacher;
        }

        public void Teach()
        {
            Console.WriteLine("Teach Math Live");
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            string input = Console.ReadLine();
            if (input == "Live")
            {
                new MathematicsLive("Antun");
                new RPPOONLive("Filip");
            }
            else
            {
                new RPPOONOnline("Filip");
                new MathematicsOnline("Antun");
            }
        }
    }

}