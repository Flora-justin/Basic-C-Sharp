using System;
namespace MethodsPrac{
    class Project{
        public static void Main(string[] args)
        {
            // getting two numbers
            // give swicth case to choose the operation
            //do while loop to repeate the operation
            string opinion="";
            do{
                Console.WriteLine("enter a number");
                Console.WriteLine("enter a number");
                int number1=int.Parse(Console.ReadLine());
                int number2=int.Parse(Console.ReadLine());
                Console.WriteLine("Select a option: /n 1.Addition /n 2.Subtraction /n 3.Multiplication /n 4. Division");
                int option=int.Parse(Console.ReadLine());
                switch(option){
                    case 1:{
                        
                        Console.WriteLine(Addition(number1,number2));
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine (Subtraction(number1, number2));
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine (Product(number1, number2));
                        break;
                    }
                    case 4:
                    { 
                         Console.WriteLine (Division(number1, number2));
                    break;

                    }
                }
                int Addition(int num1,int num2){
                   return(num1+num2);
                   
                }
                int Subtraction(int num1,int num2)
                {
                    return(num1-num2);
                }
                int Product(int num1, int num2){
                    return(num1*num2);
                }
                int Division(int num1, int num2){
                    return(num1/num2);
                }
                Console.WriteLine("Do you want to repeate this process");
                 opinion=Console.ReadLine();
                while(opinion=="no"){
                    Console.WriteLine("End Process");
                }

                
            }
            while(opinion=="yes");

          
           
           




    }
    }}
