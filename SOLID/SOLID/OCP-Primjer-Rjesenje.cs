namespace OCPPrimjerRjesenje { 
    public interface IShape {
        public double CalculateArea();
    }

    public class Rectangle: IShape {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Circle : IShape
    {
        public double Radius{get;set;}
        public double CalculateArea()
        {
            return Radius * Radius * 3.14;
        }
    }

    public class AreaCalculator { 
        public double Calculate(IShape shape) {
            return shape.CalculateArea();
	    }
    }
    /*
    public class Example { 
        public static void Main() {
            IShape shape = new Rectangle();
            shape.CalculateArea();
        }
    }
    */
}