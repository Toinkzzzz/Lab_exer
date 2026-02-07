using System;

namespace DatatypesApp
{
    class DatatypesProgram
    {
        static void Main(string[] args)
        {
            int numofApples;
            double totalPrice;
            int conPrice;

            Console.Write("Enter the pieces of apple: ");
            numofApples = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter total price of " + numofApples + " apple(s): ");
            totalPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The total price of " + numofApples + " apple(s) is " + totalPrice);

            conPrice = (int)totalPrice;

            Console.WriteLine("The value of original price is " + totalPrice);
            Console.WriteLine("The value of converted price is " + conPrice);

            Console.WriteLine("Press any key to exit.....");
            Console.ReadKey();
        }
    }
}
