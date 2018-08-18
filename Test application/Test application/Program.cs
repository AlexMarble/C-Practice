using System;

namespace Test_application
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0;
            var y = 1;

            var total = 0;

            Console.WriteLine("How Many Items in the Fibonacci Sequence do you want to display?");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(x);
            Console.WriteLine(y);

            

            for (int i = 2; i < size; i++)
            {
                total = x + y;
                Console.WriteLine(total);

                x = y;
                y = total;
            }




        }
    }
}
