using System;
namespace ReadAndWrite;// file scoped namespace
class Program{
    static void add(){
        Console.WriteLine();
    }
    public static void Main(string[] args){
    add();
        //ask user to enter name
        Console.WriteLine("Enter your name");
        //get user name
         string userName=Console.ReadLine();
        //ask user to enter father name
        Console.WriteLine("Enter your fathers name");
        //get fathers name
        string fathersName=Console.ReadLine();
        // print the name
        Console.WriteLine("name :"+userName+" \n"+"Father Name :"+fathersName);
        //placeholder
        Console.WriteLine("name : {0}\n Father Name : {1}",userName, fathersName);
        //interpolation
        Console.WriteLine($"Name : {userName}\n Father Name :{fathersName}");
        double num=Convert.ToDouble(18/100*100+100);
        Console.WriteLine(num);

    }
}