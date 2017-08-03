using System;

namespace tutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            var input1 = Console.ReadLine();
            var number1 = 0;
            var isNumber = int.TryParse(input1, out number1);
            var Count = 1;
           do{

           
            Console.WriteLine(number1 + " Times " + Count + " = "+ number1*Count);
            Count++;
            } while(Count < 13);
        }
    }
}
