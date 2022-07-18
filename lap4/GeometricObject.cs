public abstract class GeometricObject
{
    protected string color;
    protected double weight;
    // Default construct
    protected GeometricObject()
    {
        color = "white";
        weight = 1.0;
    }
    // Construct a geometric object
    protected GeometricObject(string color, double weight)
    {
        this.color = color;
        this.weight = weight;
    }
    //properties
    public string PColor
    {

        get { return color; }
        set { color = value; }
    }
    public double PWeight
    {
        get { return weight; }
        set { weight = value; }
    }
    // Abstract method
    public abstract double findArea();
    // Abstract method
    public abstract double findPerimeter();
}
//Circle class extends GeometricObject class
public class Circle : GeometricObject
{
    private double radius;
    public Circle(double x)
    {
        this.radius = x;
    }
    public Circle(double x, string c, double w) : base(c, w)
    {
        this.radius = x;
    }
    public override String ToString()
    {
        return "Circle has: radius is " + radius + " ,color is " + PColor + " weight is " + PWeight;
    }
    public override double findArea() { return Math.PI * radius * radius; }
    public override double findPerimeter() { return 2 * Math.PI * radius; }
}
public class Program
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle(2.45, "Blue", 23);
        Console.WriteLine("Circle before change: " + c1.ToString());
        //using properties
        c1.PColor = "red";
        c1.PWeight = 2.56;
        Console.WriteLine("Circle after change: " + c1.ToString());
        Console.ReadLine();
    }
}