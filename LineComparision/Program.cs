internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome line comparision");
        double x1 = 1;
        double y1 = 1;
        double x2 = 5;
        double y2 = 5;
        double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        Console.WriteLine("distance btw two lines" + distance);
        Console.ReadLine();
    }
}
