namespace LSP_Primjer
{
    class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }

    class Square : Rectangle
    {
        private int side;

        public override int Width
        {
            get => side;
            set => side = value;
        }

        public override int Height
        {
            get => side;
            set => side = value;
        }
    }
    /*
    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");

            // Using Liskov Substitution Principle
            Rectangle squareAsRectangle = new Square();
            squareAsRectangle.Width = 4;
            squareAsRectangle.Height = 4;
            Console.WriteLine($"Square Area (as Rectangle): {squareAsRectangle.CalculateArea()}");
        }
    }
    */
}
