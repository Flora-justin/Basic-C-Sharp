using System;
namespace IfConditionClassRoom{
class Program{
    public static void Main(string[] args)
    { Console.WriteLine("enter mark");
        int mark=Convert.ToInt32(Console.ReadLine());
        if(mark>80 && mark<100)
        {
            Console.WriteLine("Grade A");
        }
        else if(mark<=80 && mark>60){
            
                 Console.WriteLine("Grade B");
            
        }
         else if(mark<=60 && mark>36)
         {
            
                 Console.WriteLine("Grade c");
            
        }
        else 
        {
            
                 Console.WriteLine("Invalid data");
            
        }
        

    }
       

    }
}

