namespace LineComparision {
    public class Program
    {
        public static int x1, x2, x3, x4, y1, y2, y3, y4;
        public static double length1, length2;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome line comparision problems");
            FindLineComparision();
            Length1Calculate();
            Length2Calculate();
            Comparision();
            Console.ReadLine();
        }

        public static void FindLineComparision()
        {
            Console.WriteLine("\nEnter the value of x1, y1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the value of x2, y2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the value of x3, y3:");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the value of x4, y4:");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
        }

        public static void Length1Calculate()
        {
            length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("\nlength of line1 is:" + length1);
        }
        public static void Length2Calculate()
        {
            length2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            Console.WriteLine("\nlength of line2 is:" + length2);
        }

        public static void Comparision()
        {
            if (length1.CompareTo(length2)==1)
            {
                Console.WriteLine("\nThe Two lines are not equal");
                Console.WriteLine("\nLine 1 is greater than Line 2");
            }
            else if (length1.CompareTo(length2) == -1)
            {
                Console.WriteLine("\nThe Two lines are not equal");
                Console.WriteLine("\nLine 2 is greater than Line 1");
            }
            else
            {
                Console.WriteLine("\nThe Two lines are equal");
            }
        }
    }
}
