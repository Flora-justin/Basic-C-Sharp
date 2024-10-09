
using System;
namespace WhileClassRoom{
    class Program{
        public static void Main(string[] args)
        {
            int i=0;
            while(i<=25){
                if(i%2==0){
                
                    Console.WriteLine(i);

                    }
                    i++;
            }
            
            Console.WriteLine("enter a number");
            bool res=int.TryParse(Console.ReadLine(), out int result);
            while(!res){
                Console.WriteLine("Invalid input. please enter valid number input");
                res=int.TryParse(Console.ReadLine(),out result);
            }
            Console.WriteLine(result);
        }
    }

}