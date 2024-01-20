namespace KompozitRjesenje
{
    public interface IElectrical
    {
        public void UseElectricity();
    }

    public class Computer : IElectrical
    {
        public List<IElectrical> electricals = new List<IElectrical>();
        public void UseElectricity()
        {
            electricals.ForEach(electrical =>
            {
                Thread.Sleep(1000);
                electrical.UseElectricity();
            });
            Console.WriteLine("PC is ON");
        }
    }

    public class MotherBoard : IElectrical
    {
        public List<IElectrical> electricals = new List<IElectrical>();
        public void UseElectricity()
        {
            electricals.ForEach(electrical =>
            {
                Thread.Sleep(1000);
                electrical.UseElectricity();
            });
            Console.WriteLine("MotherBoard is ON");
        }
    }

    public class Monitor : IElectrical
    {
        public void UseElectricity()
        {
            Console.WriteLine("Monitor is ON");
            Thread.Sleep(1000);
        }
    }

    public class GPU : IElectrical
    {
        public void UseElectricity()
        {
            Console.WriteLine("GPU is ON");
            Thread.Sleep(1000);
        }
    }

    public class CPU : IElectrical
    {
        public void UseElectricity()
        {
            Console.WriteLine("CPU is ON");
            Thread.Sleep(1000);
        }
    }

    public class RAMBoard : IElectrical
    {
        public List<IElectrical> rams = new List<IElectrical>();
        public void UseElectricity()
        {
            rams.ForEach(ram =>
            {
                ram.UseElectricity();
                Thread.Sleep(1000);
            });
            Console.WriteLine("RAM board works");
            Thread.Sleep(1000);
        }
    }

    public class Inputs : IElectrical
    {
        public List<IElectrical> inputs = new List<IElectrical>();
        public void UseElectricity()
        {
            inputs.ForEach(input =>
             {
                 Thread.Sleep(1000);
                 input.UseElectricity();
             });
            Console.WriteLine("Inputs are ON");
        }
    }

    public class HDMI : IElectrical
    {
        public void UseElectricity()
        {
            Console.WriteLine("HDMI is taking signal in");
            Thread.Sleep(1000);
        }
    }

    public class USB : IElectrical
    {
        public void UseElectricity()
        {
            Console.WriteLine("USB is taking signal in");
            Thread.Sleep(1000);
        }
    }

    public class RAM : IElectrical
    {
        public void UseElectricity()
        {
            Console.WriteLine("RAM works");
            Thread.Sleep(1000);
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            Computer computer = new Computer();
            MotherBoard motherBoard = new MotherBoard();
            Inputs inputs = new Inputs();
            RAMBoard ramBoard = new RAMBoard();

            ramBoard.rams.Add(new RAM());
            ramBoard.rams.Add(new RAM());
            ramBoard.rams.Add(new RAM());

            inputs.inputs.Add(new USB());
            inputs.inputs.Add(new HDMI());

            motherBoard.electricals.Add(inputs);
            motherBoard.electricals.Add(ramBoard);
            motherBoard.electricals.Add(new CPU());
            motherBoard.electricals.Add(new CPU());
            motherBoard.electricals.Add(new GPU());

            computer.electricals.Add(motherBoard);
            computer.electricals.Add(new Monitor());

            computer.UseElectricity();
        }
    }
}