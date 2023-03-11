using System;

public class Program
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Triangle calculator");
        
        Console.WriteLine("");


        double xA, yA, xB, yB, xC, yC;

        //Ask the user to type numbers
        Console.WriteLine("Enter coordinate x of dot A:");
        Double.TryParse(Console.ReadLine(), out xA);

        //Invalid number check
        //while (!Double.TryParse(Console.ReadLine(), out xA))
        //{
        //    Console.WriteLine("Invalid number given, try again:");
        //}


        Console.WriteLine("Enter coordinate y of dot A:");
        Double.TryParse(Console.ReadLine(), out yA);

        Console.WriteLine("Enter coordinate x of dot B:");
        Double.TryParse(Console.ReadLine(), out xB);

        Console.WriteLine("Enter coordinate y of dot B:");
        Double.TryParse(Console.ReadLine(), out yB);

        Console.WriteLine("Enter coordinate x of dot C:");
        Double.TryParse(Console.ReadLine(), out xC);

        Console.WriteLine("Enter coordinate y of dot C:");
        Double.TryParse(Console.ReadLine(), out yC);

        
        Console.WriteLine("");


        //Calculate sides
        double calcAB = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
        double calcBC = Math.Sqrt(Math.Pow((xC - xB), 2) + Math.Pow((yC - yB), 2));
        double calcAC = Math.Sqrt(Math.Pow((xC - xA), 2) + Math.Pow((yC - yA), 2));

        Console.WriteLine($"Length of AB is: '{calcAB}'");
        Console.WriteLine($"Length of BC is: '{calcBC}'");
        Console.WriteLine($"Length of AC is: '{calcAC}'");


        Console.WriteLine("");


        /*
       isoscales - równoramienny
       right triangle - prostokątny
       equilateral - równoboczny
       scalene - różnoboczny
       */


        //Set triangle type
        bool equiliteral = calcAB == calcBC && calcBC == calcAC && calcAB == calcAC;
        bool isoscales = calcAB == calcBC || calcBC == calcAC || calcAB == calcAC;
        bool scalene = calcAB != calcBC && calcBC != calcAC && calcAB != calcAC;
        bool pythagorean = Math.Abs(Math.Pow(calcBC, 2) - (Math.Pow(calcAB, 2) + Math.Pow(calcAC, 2))) <= Math.Pow(0.1, 10) || 
                            Math.Pow(calcAB, 2) + Math.Pow(calcBC, 2) == Math.Pow(calcAC, 2) ||
                            Math.Pow(calcBC, 2) + Math.Pow(calcAC, 2) == Math.Pow(calcAB, 2) ||
                            Math.Pow(calcAB, 2) + Math.Pow(calcAC, 2) == Math.Pow(calcBC, 2);

        //Check triangle type
       Console.WriteLine($"Triangle {(equiliteral ? "IS" : "IS NOT")} 'Equiliteral'");
        
       Console.WriteLine($"Triangle {(isoscales ? "IS" : "IS NOT")} 'Isoscales'");       
       
       Console.WriteLine($"Triangle {(scalene ? "IS" : "IS NOT")} 'Scalene'");
       
       Console.WriteLine($"Triangle {(pythagorean ? "IS" : "IS NOT")} 'Right'");


       Console.WriteLine("");


        //Perimeter
        double calcP = (calcAB + calcBC + calcAC);
        Console.WriteLine($"Perimeter is: {calcP}");

        Console.WriteLine("");


        //Parity numbers
        Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");

        for (int i = 0; i < calcP; i+=2)
        {
           Console.WriteLine(i);
        }

       
    }
}

