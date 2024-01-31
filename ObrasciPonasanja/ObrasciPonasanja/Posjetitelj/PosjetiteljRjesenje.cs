using System.Security.Cryptography;

namespace PosjetiteljRjesenje
{


    public interface IMode
    {
        public void TeachRPPOON(RPPOON rppoon);
        public void TeachMathematics(Mathematics mathematics);
    }

    public class OnlineMode : IMode
    {
        public void TeachMathematics(Mathematics mathematics)
        {
            Console.WriteLine($"{mathematics.teacher} is teaching math online");
        }

        public void TeachRPPOON(RPPOON rppoon)
        {
            Console.WriteLine($"{rppoon.teacher} is teaching rppoon online");
        }
    }

    public class LiveMode : IMode
    {
        public void TeachMathematics(Mathematics mathematics)
        {
            Console.WriteLine($"{mathematics.teacher} is teaching math live"); Console.WriteLine($"{mathematics.teacher} is teaching math live"); Console.WriteLine($"{mathematics.teacher} is teaching math live"); Console.WriteLine($"{mathematics.teacher} is teaching math live");
        }

        public void TeachRPPOON(RPPOON rppoon)
        {
            rppoon.age
            Console.WriteLine($"{rppoon.teacher} is teaching rppoon live");
        }
        public void dsad(RPPOON rppoon)
        {
            rppoon.age
            Console.WriteLine($"{rppoon.teacher} is teaching rppoon live");
        }
    }

    public class RPPOON : IInstructions
    {
        public string teacher { get; private set; }

        public RPPOON(string teacher)
        {
            this.teacher = teacher;
        }

        public void Teach(IMode mode)
        {
            mode.TeachRPPOON(this);
        }
    }

    public class Mathematics : IInstructions
    {
        public string teacher { get; private set; }
        private int age;
        public Mathematics(string teacher)
        {
            this.teacher = teacher;
        }

        public void Teach(IMode mode)
        {
            mode.TeachMathematics(this);
        }
    }

    public class Mathematics : IInstructions
    {
        public string teacher { get; private set; }
        private int age;
        public Mathematics(string teacher)
        {
            this.teacher = teacher;
        }

        public void Teach(IMode mode)
        {
            mode.TeachMathematics(this);
        }
    }

    public static class InstructionsCoordinator
    {
        public static IMode StartInMode()
        {
            string input = Console.ReadLine();
            if (input == "Live")
            {
                return new LiveMode();
            }
            else
            {
                return new OnlineMode();
            }
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            string input = Console.ReadLine();
            List<IInstructions> instructions = new List<IInstructions>(){
                new Mathematics("Antun"),
                new RPPOON("Filip"),
                new RPPOON("Ana"),
                new RPPOON("Mihael")
            };

            instructions.ForEach(i =>
            {
                i.Teach(InstructionsCoordinator.StartInMode());
            });

        }
    }
}