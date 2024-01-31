namespace PrviZadatakRjesenje
{
    /*Dajte prijedloge preimenovanja za imena u danom izlistanju koda za koje smatrate da imaju nedostatke*/
    enum Shapes { Circle, Square }
    class Cake
    {
        public int Layers { get; private set; }
        public Shapes Shape { get; private set; }
        public bool Frosting { get; private set; }
        public Cake(int layers, Shapes shape, bool frosting)
        {
            Layers = layers;
            Shape = shape;
            Frosting = frosting;
        }
    }

    class CakeFactory
    {
        public static Cake CreateCake(string type)
        {
            switch (type)
            {
                case "standard": return new Cake(2, Shapes.Square, false);
                case "fancy": return new Cake(4, Shapes.Circle, false);
                case "wedding": return new Cake(6, Shapes.Circle, true);
                default: return null;
            }
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {

        }
    }
}