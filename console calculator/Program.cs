using System;

namespace console_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the operator(add,sub,mul,div):");
            string cal = Console.ReadLine();
            Console.WriteLine("first Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            switch(cal.ToLower())
            {
                case "add":
                    c = a + b;
                    break;
                case "sub":
                    c = a - b;
                        break ;
                    case "mul":
                    c = a * b;
                        break ;
                    case "div":
                    c = a / b ;
                        break ;
                default:
                    Console.WriteLine("Invalid");
                    return;


            }
            Console.WriteLine($"The Result is : {c}");
            Console.ReadKey();
        }
    }
}
