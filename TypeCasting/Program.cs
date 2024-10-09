
using System;
using Microsoft.Win32.SafeHandles;


namespace TypeCasting
{
    class TypeCasting{
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name= Console.ReadLine();
            Console.WriteLine("Enter age");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark of Subject1");
            int subject1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter mark of subject2");
            int subject2=int.Parse (Console.ReadLine());
            Console.WriteLine("enter mark of subject3");
            int subject3= int.Parse (Console.ReadLine());
            Console.WriteLine("enter mobile num");
            long mob=long.Parse(Console.ReadLine());
            Console.WriteLine("enter grade");
            char grade=char.Parse(Console.ReadLine());
            Console.WriteLine("enter mail ID");
            string email=Console .ReadLine();
            int total=subject1+subject2+subject3;
            double avg=(double)total/3;
            Console.WriteLine("Trainee Details are");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Mobile: {mob}");
            Console.WriteLine($"Marks1: {subject1}");
            Console.WriteLine($"Marks2: {subject2}");
            Console.WriteLine($"Marks3: {subject3}");
            Console.WriteLine($"total:{total}");
            Console.WriteLine($"average:{avg}");
            Console.WriteLine($"Grade:{grade}");
            Console.WriteLine($"Mail ID:{email}");


        }
    }
}
