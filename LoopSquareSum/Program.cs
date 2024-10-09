using System;
using System.Data.Common;
namespace LoopSquareSum{
    class Program{
        public static void Main(string[] args)
        {// get 2 numbers
            Console.WriteLine("enter a number");
            int startNum=int.Parse(Console.ReadLine());
             Console.WriteLine("enter a number");
            int endNum=int.Parse(Console.ReadLine());
            int sum=0;
            //get inbetween number
            for(int i=startNum+1;i<endNum;i++){
                int sqr=1;
            //find square and sum
                sqr=i*i;
                sum=sum+sqr;
                 

            }
            Console.WriteLine($"sum of squares inbetween: {startNum}: and:{endNum}= {sum}");
           

        }
    }
}