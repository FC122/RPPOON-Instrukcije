using System.Security.Cryptography.X509Certificates;

namespace PosjetiteljZadatak
{

    public interface IInstructions
    {
        public void Teach();
    }

    public class RPPOONOnline : IInstructions
    {
        public void Teach()
        {
            Console.WriteLine("Teach RPPOON Online");
        }
    }

    public class RPPOONClassroom : IInstructions
    {
        public void Teach()
        {
            Console.WriteLine("Teach RPPOON Classroom");
        }
    }

    public class OnlineMathematics : IInstructions
    {
        public void Teach()
        {
            Console.WriteLine("Teach Math Online");
        }
    }

    public class ClassroomMathematics : IInstructions
    {
        public void Teach()
        {
            Console.WriteLine("Teach Math Classroom");
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            IInstructions instructions;
            string input = Console.ReadLine();
            if (input == "Online")
            {
                instructions =
            }
            else ...
        }
    }

}