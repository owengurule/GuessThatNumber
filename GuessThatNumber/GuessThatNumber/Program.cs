using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessThatNumber();

            Console.ReadKey();
        }
        static void GuessThatNumber()
        
        {



            Random rng = new Random();
        
        
        int userNum;
            Console.WriteLine("Enter a number.");
                userNum = Convert.ToInt32(Console.ReadLine());

            int randomNum = rng.Next(1, 101);
            Console.WriteLine(randomNum);

                if (userNum == randomNum)
                {
                    Console.WriteLine("Your number " + userNum + " matches");
                }
                else if (userNum > randomNum)
                {
                    Console.WriteLine("Your number " + userNum + " is to great");
                }
                else if (userNum < randomNum)
                {
                    Console.WriteLine("Your number " + userNum + "is lower than " + randomNum);
                }
       




        
        }


    }
}
