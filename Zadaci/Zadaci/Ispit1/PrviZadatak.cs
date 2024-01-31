namespace PrviZadatak
{
    enum ShapesOptions { Circle, Square }
    class CakeClass
    {
        public int cakeLayersCount { get; private set; }
        public ShapesOptions cakeShapeDescription { get; private set; }
        public bool frostedCake { get; private set; }
        public CakeClass(int layers, ShapesOptions shape, bool frostedOrNot)
        {
            cakeLayersCount = layers;
            cakeShapeDescription = shape;
            frostedCake = frostedOrNot;
        }
    }

    class SimpleCakeObjectFactory
    {
        public static CakeClass CreateCake(string cakeType)
        {
            switch (cakeType)
            {
                case "standard": return new CakeClass(2, ShapesOptions.Square, false);
                case "fancy": return new CakeClass(4, ShapesOptions.Circle, false);
                case "wedding": return new CakeClass(6, ShapesOptions.Circle, true);
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