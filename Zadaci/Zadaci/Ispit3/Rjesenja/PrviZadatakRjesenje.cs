/*Dajte prijedloge preimenovanja za imena u danom 
izlistanju koda za koja smatrate da imaju nedostatke*/
namespace PrviZadatakRjesenjeIspit3
{
    class RandomDataGenerator
    {
        private static RandomDataGenerator randomDataGenerator;
        private Random random;

        private RandomDataGenerator()
        {
            this.random = new Random();
        }
        public static RandomDataGenerator Instance()
        {
            if (randomDataGenerator == null)
            {
                randomDataGenerator = new RandomDataGenerator();
            }
            return randomDataGenerator;
        }

        public int GenerateInteger()
        {
            return this.random.Next();
        }

        public int GenerateInteger(int a, int b)
        {
            return this.random.Next() % (b - a + 1);
        }

        public double GenerateDouble(double a, double b)
        {
            return a + (this.random.NextDouble() * (b - a));
        }
    }
}