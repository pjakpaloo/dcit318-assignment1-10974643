namespace Grade_Calculator;

internal class Program
{
    static void Main()
    {
        double grade;

        Console.WriteLine("Please enter your score: ");

        grade = Convert.ToInt32((Console.ReadLine()));

        while (grade < 0 || grade > 100)
        {
            Console.WriteLine("Your grade range must be in the range 0 - 100");
            Console.WriteLine("Please enter your score: ");
            grade = Convert.ToInt32(Console.ReadLine());
        } 
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80 && grade <= 89)
        {
            Console.WriteLine("B");
        }
        else if ((grade >= 70 && grade <= 79))
        {
            Console.WriteLine("C");
        }
        else if (((grade >= 60 &&  grade <= 69)))
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}