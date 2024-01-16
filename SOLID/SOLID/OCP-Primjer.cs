public class Rectangle { 
    public double Width { get; set; }
    public double Height { get; set; }
}

public class AreaCalculator { 
    public double CalculateArea(Rectangle rectangle) {
        return rectangle.Width * rectangle.Height;
    }
}