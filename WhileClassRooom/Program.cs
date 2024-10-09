using System;
using System.Runtime.InteropServices;
namespace WhileClassRoom{
    class Program{
        public static void Main(string[] args)
        {//get number
           string check;
            do{
            Console.WriteLine("Enter a number");
            int number=int.Parse(Console.ReadLine());
            
            if(number%2==0){
                Console.WriteLine("even"); //check odd or even

            }
            else{
                Console.WriteLine("odd");
            }
            Console.WriteLine(" Do you want to repeat the process type yes or no");
             check=Console.ReadLine();//get yes or no
            
            
            
            while(check!="yes" && check!="no"){
                Console.WriteLine("enter valid data");
                check=Console.ReadLine();
            }
            

            
            
            }
            while(check=="yes");

        }

    }
}