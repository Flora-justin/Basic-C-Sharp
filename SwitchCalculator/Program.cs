using System;
namespace SwitchCalculator{
    class Program{
        public static void Main(string[] args)
        {Console.WriteLine("enter a number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("press + or - or * or / or %");
            char symbol=char.Parse(Console.ReadLine());
            switch(symbol){
                case '+':
                {
                  Console.WriteLine(num1+num2);
                  break;
                }
                case '-':
                {
                  Console.WriteLine(num1-num2);
                   break;
                }
                case '*':
                {
                  Console.WriteLine(num1*num2);
                   break;
                }
                case '/':
                {
                  Console.WriteLine(num1/num2);
                   break;
                }
                case '%':
                {
                  Console.WriteLine(num1%num2);
                   break;
                }
                default:
                {
                   Console.WriteLine("Operation is invalid"); 
                    break;
                }
                
            }


        }

    }
}
