public class Program
{
    public static void Main(string[] args)
    {
        static double ComputeSide(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        static bool IsPythagorean(double hypotenuse, double rectangular1, double rectangular2)
        {
            return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(rectangular1, 2) + Math.Pow(rectangular2, 2))) <= Math.Pow(0.1, 10);
        }

        static double EnterCoords(string message)
        {
            Console.WriteLine(message);
            double number;
            while (!Double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid number given, try again:");
            }
            return number;
        }

        Console.WriteLine("Triangle calculator");

        Console.WriteLine("");

        //Ask user to type numbers
        double xA = EnterCoords("Enter coordinate x of dot A:");
        double yA = EnterCoords("Enter coordinate y of dot A:");
        double xB = EnterCoords("Enter coordinate x of dot B:");
        double yB = EnterCoords("Enter coordinate y of dot B:");
        double xC = EnterCoords("Enter coordinate x of dot C:");
        double yC = EnterCoords("Enter coordinate y of dot C:");

        Console.WriteLine("");

        //Calculate sides
        double a = ComputeSide(xA, yA, xB, yB);
        double b = ComputeSide(xB, yB, xC, yC);
        double c = ComputeSide(xA, yA, xC, yC);

        //Check triangle type
        bool equiliteral = a == b && b == c && a == c;
        bool isoscales = a == b || b == c || a == c;
        bool scalene = a != b && b != c && a != c;
        bool pythagorean = IsPythagorean(a, b, c) || IsPythagorean(b, c, a) || IsPythagorean(c, a, b);

        //Show informations
        if (a != 0 && b != 0 && c != 0)
        {
            //Show sides length
            Console.WriteLine($"Length of AB is: '{a}'");
            Console.WriteLine($"Length of BC is: '{b}'");
            Console.WriteLine($"Length of AC is: '{c}'");

            Console.WriteLine("");

            //Show triangle type
            Console.WriteLine($"Triangle {(equiliteral ? "IS" : "IS NOT")} 'Equiliteral'");
            Console.WriteLine($"Triangle {(isoscales ? "IS" : "IS NOT")} 'Isoscales'");
            Console.WriteLine($"Triangle {(scalene ? "IS" : "IS NOT")} 'Scalene'");
            Console.WriteLine($"Triangle {(pythagorean ? "IS" : "IS NOT")} 'Right'");

            Console.WriteLine("");

            //Calculate perimeter
            double p = (a + b + c);
            Console.WriteLine($"Perimeter is: {p}");

            Console.WriteLine("");

            //Calculate parity numbers
            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");

            for (int i = 0; i < p; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine($"You provided wrong input data, try again ;)");
        }

    }
}
