namespace ST10441678_IceTask3
{
    internal class Program
    {
        //Creating a Shape Area Calculator Program
        static void Main(string[] args)
        {
           ICalculateArea rectangle = new Rectangle("Rectangle", 10, 20);
            rectangle.Display();

            ICalculateArea circle = new Circle("Circle", 10);
            circle.Display();
        }
    }
}
