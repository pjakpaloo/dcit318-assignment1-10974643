namespace Ticket_Price_Calculator;
internal class Program
{
   static void Main()
    {
        double price, discountedPrice;
        int age;

        price = 10.00;
        discountedPrice = 7.00;

        Console.WriteLine("Please Enter Your Age: ");

        age = Convert.ToInt32(Console.ReadLine());

        while (age < 0) {
            Console.WriteLine("The number you entered is invalid");
            Console.WriteLine("Enter your right age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        if (age >= 65 || age <= 12)
        {
            Console.WriteLine("Price of the ticket is GH₵ " + discountedPrice);
        }
        else
        {
            Console.WriteLine("Price of ticket is GH₵ " + price);
        }
    }
    
}
