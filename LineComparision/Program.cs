internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome line comparision");
        Console.WriteLine("Enter the value x1 and y1:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value x2 and y2:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        Console.WriteLine("Length of the line" + distance);
        Console.ReadLine();
    }
}
