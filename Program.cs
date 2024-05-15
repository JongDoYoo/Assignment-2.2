namespace Assignment_2._2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            do
            {

                Console.WriteLine("Please choose a shape to find area: Circle , Square, Rectangle");

                string inputResult = Console.ReadLine();

                switch (inputResult)
                {
                    case "Circle":
                    case "circle":
                        Console.WriteLine("Please enter the radius of the circle: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle myCircle = new Circle();
                        myCircle.CalculateArea(radius);
                        Console.WriteLine();
                        break;
                    case "Square":
                    case "square":
                        Console.WriteLine("Please enter value of one side: ");
                        double sideValue = Convert.ToDouble(Console.ReadLine());
                        Square mySquare = new Square();
                        mySquare.CalculateArea(sideValue);
                        Console.WriteLine();
                        break;
                    case "Rectangle":
                    case "rectangle":
                        Console.WriteLine("Please enter the length of the rectangle: ");
                        double lengthOfRect = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the width of the rectangle: ");
                        double widthOfRect = Convert.ToDouble(Console.ReadLine());
                        Rectangle myRectangle = new Rectangle();
                        myRectangle.CalculateArea(lengthOfRect, widthOfRect);
                        Console.WriteLine();
                        break;
                }
            }while (true);  
        }
    }
    public enum ColorValues { Red, Blue, Green }


    public class Shape  //this is parent
    {
        public string ShapeId { get; set; }
        public string ShapeName { get; set; }
        public string ShapeDescription { get; set; }
        public ColorValues Color { get; set; }
        public virtual void CalculateArea()
        {
            Console.WriteLine("This shape has an area.");
        }

    }
    public class Square : Shape //the child (inherit)
    {
        public double LengthOfSide { get; set; }
        public void CalculateArea(double LengthOfSide)
        {
            Console.WriteLine("The area of a square is: " + Math.Pow(LengthOfSide, 2));
        }

    }
    public class Circle : Shape   //the child (inherit)
    {
        public double Radius { get; set; }

        public void CalculateArea(double radius)
        {
            Console.WriteLine("The circle has the radius of: " + Math.PI * Math.Pow(radius, 2));
        }


    }     
    public class Rectangle : Shape   //the child (inherit)
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public void CalculateArea(double width, double length)
        {
            Console.WriteLine("The area of a rectangle is: " + (width * length));
        }
    }
}


