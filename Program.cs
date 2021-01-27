using System;

namespace Qu3___2018_Paper_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0;
            int c;
            while ((Number < 1) || (Number > 10))
            {
                Console.WriteLine("Enter a positive whole number: ");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number > 10)
                {
                    Console.WriteLine("Number too large.");
                }
                else if(Number < 1)
                {
                    Console.WriteLine("Not a positive number.");
                }
                else
                {
                    //Do nothing
                }
            }
            //End while
            c = 1;
            //Start for
            for (int k = 0; k < Number; k++)
            {
                Console.WriteLine(Convert.ToString(c));
                c = (c * (Number - 1 - k)) / (k + 1);
            }
        }
    }
}
