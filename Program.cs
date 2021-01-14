using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers= new [] {12.5,10.3,6.11};
            var result = 0.0;
            foreach (var number in numbers)
            {
              result = result +number  
            }
            Console.WriteLine(result);

            if(args.Length > 0) 
            {
            Console.WriteLine($"Hello {args[0]}");
            }
            else
            {
                Console.WriteLine("Hello!");
            }

        }
    }
}
