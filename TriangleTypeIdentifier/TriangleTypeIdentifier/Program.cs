namespace Triangle_Type_Identifier;

internal class Program
{
    static void Main()
    {
        double sideOne, sideTwo, sideThree;
        bool isEquilateral, isIsosceles, isScalene;

        Console.WriteLine("Enter the first side: ");
        sideOne = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second side: ");
        sideTwo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the third side: ");
        sideThree = Convert.ToDouble(Console.ReadLine());

        if (IsValidTriangle(sideOne, sideTwo, sideThree))
        {
            isEquilateral = sideOne == sideTwo && sideOne == sideThree;
            isIsosceles = (sideOne == sideTwo && sideOne != sideThree) ||
                          (sideOne == sideThree && sideTwo != sideOne) ||
                          (sideTwo == sideThree && sideTwo != sideOne);
            isScalene = sideOne != sideTwo && sideOne != sideThree && sideTwo != sideThree;

            if (isEquilateral)
            {
                Console.WriteLine("Equilateral");
            }
            else if (isIsosceles)
            {
                Console.WriteLine("Isosceles");
            }
            else if (isScalene)
            {
                Console.WriteLine("Scalene");
            }
        }
        else
        {
            Console.WriteLine("The entered sides do not form a valid triangle.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}