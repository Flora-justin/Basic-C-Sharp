using System;
using System.Linq;
namespace ArrayAssi{
 class Program{
    public static void Main(string[] args)
    {
        string [] names=new string[5];
        names[0]="Flora";
        names[1]="justin";
        names [2]="suganthi";
        names [3]="jessy";
        names [4]="Joy";
        bool check=false;
        for(int i=0;i<names.Length;i++){
            Console.WriteLine(names[i]);

        }
        Console.WriteLine("enter name to search");
        string find=Console.ReadLine();
        for(int i=0;i<names.Length;i++){
            if(names[i]==find){
                Console.WriteLine("The name is present in array");
                check=true;
            }
           
        }
         if(!check)
         {
             Console.WriteLine("The name is not present in array");

         }  
         
         foreach(string name in names ){
            if(name==find){
                Console.WriteLine("The name is present in array");
                check=true;
            }
           
        }
         if(!check)
         {
             Console.WriteLine("The name is not present in array");

         }    
            



    }
 }
}