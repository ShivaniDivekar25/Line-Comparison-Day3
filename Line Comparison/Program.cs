namespace Line_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 for Welcome Message program\nEnter 1 for Distance between line UC1");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    Console.WriteLine("Welcomw! to Line Comparison Pragram");
                    break;
                case 1:
                    Console.WriteLine("Please enter X1 and Y1 coordinates");
                    var X1 = Convert.ToDouble(Console.ReadLine());
                    var Y1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter X2 and Y2 coordinates");
                    var X2 = Convert.ToDouble(Console.ReadLine());
                    var Y2 = Convert.ToDouble(Console.ReadLine());
                    var finalResult = DistanceBetweenLine.Distance(X1, X2, Y1, Y2);

                    Console.WriteLine("Distance between coordinates {0},{1} and {2},{3} is {4}", X1, Y1, X2, Y2, finalResult);
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}