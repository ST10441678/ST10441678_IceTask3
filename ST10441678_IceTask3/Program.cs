namespace ST10441678_IceTask3
{
    internal class Program
    {
        //Creating a Shape Area Calculator Program
        static void Main(string[] args)
        {
            //Creating a Rectangle Object
            ICalculateArea rectangle = new Rectangle("Rectangle", 10, 20);
            rectangle.Display();

            //Creating a Circle Object
            ICalculateArea circle = new Circle("Circle", 10);
            circle.Display();
        }
    }
}
