/*Dajte prijedloge preimenovanja za imena u danom 
izlistanju koda za koja smatrate da imaju nedostatke*/
namespace PrviZadatakIspit3
{
    class Rndgen
    {
        private static Rndgen inst;
        private Random PRNG; //pseudo random number generator 

        // Private constructor
        private Rndgen()
        {
            this.PRNG = new Random();
        }

        // Singleton instance creation method
        public static Rndgen Instance()
        {
            if (inst == null)
            {
                inst = new Rndgen();
            }
            return inst;
        }

        public int Int1()
        {
            return this.PRNG.Next();
        }

        public int Int2(int a, int b)
        {
            return this.PRNG.Next() % (b - a + 1);
        }

        public double Double(double a, double b)
        {
            return a + (this.PRNG.NextDouble() * (b - a));
        }
    }

}