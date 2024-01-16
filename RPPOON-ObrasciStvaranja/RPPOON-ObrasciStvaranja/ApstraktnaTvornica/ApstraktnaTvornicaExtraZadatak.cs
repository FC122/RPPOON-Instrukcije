namespace ApstraktnaTvornicaExtraZadatak
{
    public class DellTV
    {
        public void UseDellInterface() { }
    }

    public class SamsungTV
    {
        public void UseSamsungInterface() { }
    }

    public class DellDisplay
    {
        public void UseDellInterface() { }
    }

    public class SamsungDisplay
    {
        public void UseSamsungInterface() { }
    }

    public class App
    {
        SamsungDisplay sd;
        DellDisplay dd;
        SamsungTV stv;
        DellTV dtv;

        public App()
        {
            sd = new SamsungDisplay();
            dd = new DellDisplay();
            stv = new SamsungTV();
            dtv = new DellTV();
        }

        public void SellDellTV()
        {
        }
        public void SellDellDisplay()
        {
        }
        public void SellSamsungTV()
        {
        }
        public void SellSamsungDisplay()
        {
        }
    }
}