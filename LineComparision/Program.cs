internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome line comparision problems");
        Console.WriteLine("Enter the value of x1, y1:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of x2, y2:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        double length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

        Console.WriteLine("Welcome line comparision problems");
        Console.WriteLine("Enter the value of x3, y3:");
        int x3 = Convert.ToInt32(Console.ReadLine());
        int y3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of x4, y4:");
        int x4 = Convert.ToInt32(Console.ReadLine());
        int y4 = Convert.ToInt32(Console.ReadLine());
        double length2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));

        if(length1 == length2)
        {
            Console.WriteLine("The Two lines are equal");
        }
        else
        {
            Console.WriteLine("The Two lines are not equal");
        }
        Console.ReadLine();
    }
}
