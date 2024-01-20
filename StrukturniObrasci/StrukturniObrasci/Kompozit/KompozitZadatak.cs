namespace KompozitZadatak
{
    //dodaj Zvucnik i Tipkovnicu
    public class Computer
    {
        MotherBoard motherBoard;
        Monitor monitor;
        public Computer(MotherBoard motherBoard, Monitor monitor)
        {
            this.motherBoard = motherBoard;
            this.monitor = monitor;
        }
        public void UseElectricity()
        {
            motherBoard.UseElectricity();
            Thread.Sleep(1000);
            monitor.UseElectricity();
            Thread.Sleep(1000);
            Console.WriteLine("PC is ON");
        }
    }

    public class MotherBoard
    {
        RAMBoard ramBoard;
        GPU gpu;
        CPU cpu;
        Inputs inputs;
        public MotherBoard(RAMBoard ramBoard, GPU gpu, CPU cpu, Inputs inputs)
        {
            this.ramBoard = ramBoard;
            this.gpu = gpu;
            this.cpu = cpu;
            this.inputs = inputs;
        }
        public void UseElectricity()
        {
            ramBoard.UseElectricity();
            Thread.Sleep(1000);
            gpu.UseElectricity();
            Thread.Sleep(1000);
            cpu.UseElectricity();
            Thread.Sleep(1000);
            inputs.UseElectricity();
            Thread.Sleep(1000);
            Console.WriteLine("MotherBoard is ON");
        }
    }
    public class Monitor
    {
        public void UseElectricity()
        {
            Console.WriteLine("Monitor is ON");
            Thread.Sleep(1000);
        }
    }
    public class GPU
    {
        public void UseElectricity()
        {
            Console.WriteLine("GPU is ON");
            Thread.Sleep(1000);
        }
    }
    public class CPU
    {
        public void UseElectricity()
        {
            Console.WriteLine("CPU is ON");
            Thread.Sleep(1000);
        }
    }

    public class RAMBoard
    {
        public List<RAM> rams = new List<RAM>();
        public void UseElectricity()
        {
            rams.ForEach(ram =>
            {
                ram.UseElectricity();
            });
            Console.WriteLine("RAM board works");
            Thread.Sleep(1000);
        }
    }
    public class Inputs
    {
        HDMI hdmi;
        USB usb;
        public Inputs(HDMI hdmi, USB usb)
        {
            this.hdmi = hdmi;
            this.usb = usb;
        }
        public void UseElectricity()
        {
            hdmi.UseElectricity();
            Thread.Sleep(1000);
            usb.UseElectricity();
            Thread.Sleep(1000);
            Console.WriteLine("Inputs are ON");
        }
    }
    public class HDMI
    {
        public void UseElectricity()
        {
            Console.WriteLine("HDMI is taking signal in");
            Thread.Sleep(1000);
        }
    }

    public class USB
    {
        public void UseElectricity()
        {
            Console.WriteLine("USB is taking signal in");
            Thread.Sleep(1000);
        }
    }

    public class RAM
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
            RAMBoard ramBoard = new RAMBoard();
            ramBoard.rams.Add(new RAM());
            ramBoard.rams.Add(new RAM());
            new Computer(new MotherBoard(new RAMBoard(),
            new GPU(), new CPU(),
            new Inputs(new HDMI(), new USB())),
            new Monitor()).UseElectricity();
        }
    }
}