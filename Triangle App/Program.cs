using System;

public class Program
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Triangle game");

        double xA, yA, xB, yB, xC, yC;

        //Ask the user to type numbers.
        Console.WriteLine("Enter coordinate x of dot A:");
        xA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter coordinate y of dot A:");
        yA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter coordinate x of dot B:");
        xB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter coordinate y of dot B:");
        yB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter coordinate x of dot C:");
        xC = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter coordinate y of dot C:");
        yC = Convert.ToInt32(Console.ReadLine());

        //Calculate sides
        decimal calcAB = Math.Round((decimal)Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2)), MidpointRounding.ToEven);
        decimal calcBC = Math.Round((decimal)Math.Sqrt(Math.Pow((xC - xB), 2) + Math.Pow((yC - yB), 2)), MidpointRounding.ToEven);
        decimal calcAC = Math.Round((decimal)Math.Sqrt(Math.Pow((xC - xA), 2) + Math.Pow((yC - yA), 2)), MidpointRounding.ToEven);

        Console.WriteLine($"Length of AB is: '{calcAB}'");
        Console.WriteLine($"Length of BC is: '{calcBC}'");
        Console.WriteLine($"Length of AC is: '{calcAC}'");



        /*
       isoscales - równoramienny
       right triangle - prostokątny
       equilateral - równoboczny
       scalene - różnoboczny
       */


        //Check triangle type
        bool equiliteral = (calcAB == calcBC && calcBC == calcAC && calcAB == calcAC);
        bool isoscales = (calcAB == calcBC || calcBC == calcAC || calcAB == calcAC);
        bool pythagorean = (calcAB * calcAB + calcBC * calcBC == calcAC * calcAC || calcBC * calcBC + calcAC * calcAC == calcAB * calcAB || calcAB * calcAB + calcAC * calcAC == calcBC * calcBC);
        bool scalene = (calcAB != calcBC && calcBC != calcAC && calcAB != calcAC);

        //Jak zrobić żeby sprawdzało jeszcze warunek pitagorejski? kwestia zaokrąglenia wszystkich wartości odpowiednio

        if (equiliteral)

        {
            Console.WriteLine("Triangle IS 'Equiliteral'");
        }


        else if (isoscales && pythagorean)
        {
            Console.WriteLine("Triangle IS NOT 'Equilateral'");
            Console.WriteLine("Triangle IS NOT 'Scalene'");
            Console.WriteLine("Triangle IS 'Isoscales'");
            Console.WriteLine("Triangle IS 'Right'");

        }
       
        else if (isoscales)
        {
            Console.WriteLine("Triangle IS 'Isoscales'");
            Console.WriteLine("Triangle IS NOT 'Equilateral'");
            Console.WriteLine("Triangle IS NOT 'Scalene'");
           
        }

        else if (pythagorean)
        {
            Console.WriteLine("Triangle IS NOT 'Equilateral'");
            Console.WriteLine("Triangle IS NOT 'Scalene'");
            Console.WriteLine("Triangle IS 'Right'");
        }

        else if (scalene)
        {
            Console.WriteLine("Triangle IS 'Scalene'");
        }

        else if (scalene && pythagorean)
        {
            Console.WriteLine("Triangle IS 'Scalene'");
            Console.WriteLine("Triangle IS 'Right'");
        }

        //Perimeter
        decimal calcP = (calcAB + calcBC + calcAC);
        Console.WriteLine($"Perimeter is: {calcP}");

        //Parity numbers

        for (int i = 0; i < calcP; i++)
        {
            if (i % 2 == 0)
            Console.WriteLine(i);
        }

       
    }
}

/*
  if (calcAB == calcBC && calcBC == calcAC && calcAB == calcAC)

        {
            Console.WriteLine("Triangle IS 'Equiliteral'");
        }

        else if (calcAB == calcBC || calcBC == calcAC || calcAB == calcAC)
        {
            Console.WriteLine("Triangle IS 'Isoscales'");
            Console.WriteLine("Triangle IS NOT 'Equilateral'");
            Console.WriteLine("Triangle IS NOT 'Scalene'");
            Console.WriteLine("Triangle IS 'Right'");
        }


        else if (calcAB * calcAB + calcBC * calcBC == calcAC * calcAC || calcBC * calcBC + calcAC * calcAC  == calcAB * calcAB || calcAB * calcAB + calcAC * calcAC == calcBC * calcBC)
        {
            Console.WriteLine("Triangle IS NOT 'Equilateral'");
            Console.WriteLine("Triangle IS NOT 'Scalene'");
            Console.WriteLine("Triangle IS 'Isoscales'");
            Console.WriteLine("Triangle IS 'Right'");
        }

        else if (calcAB != calcBC && calcBC != calcAC && calcAB != calcAC)
        {
            Console.WriteLine("Triangle IS 'Scalene'");
        }
 */