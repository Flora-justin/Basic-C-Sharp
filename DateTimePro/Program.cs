using System;
namespace DateTimePro;
class Project{
    public static void Main(string[] args)
    // {
    //     DateTime date1= new DateTime(2021,08,10,10,40,32);
    //    Console.WriteLine("Year"+date1.Year);
    //    Console.WriteLine("Day"+date1.Day);
    //    Console.WriteLine("Month"+date1.Month);
    //    Console.WriteLine("Hour" +date1.Hour);
    //    Console.WriteLine("Minute"+date1.Minute);
    //    Console.WriteLine("Second"+date1.Second);
       
    //    string date2=date1.ToString("yyyy/MM/dd/hh/mm/ss");
    //    string[] rev=date2.Split('/');
    //    for(int i=rev.Length-1;i>0;i--){
    //     Console.WriteLine(rev[i]);
    //    }
    {
   //     DateTime newdate=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss:tt",null);
   //     Console.WriteLine("year = "+newdate.Year);
   //     Console.WriteLine("month = "+newdate.Month);
   //     Console.WriteLine("day = "+newdate.Day);
   //     Console.WriteLine("hour = "+newdate.Hour);
   //     Console.WriteLine("minute = "+newdate.Minute);
   //     Console.WriteLine("second = "+newdate.Second);
   //     Console.WriteLine("millisecond = "+newdate.Millisecond);

   //--------------------------------------------------------------------------------------
    //  DateTime toDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
    //     string date1=toDate.ToString("dd/MM/yyyy");
    //     DateTime addedDate= toDate.AddDays(40);

    //     Console.WriteLine("Date:"+ toDate.AddDays(40));
    //     Console.WriteLine("Day:"+addedDate.DayOfWeek);
     DateTime date1= DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
       DateTime beforeDate= date1.AddYears(15);
       DateTime afterDate=date1.AddYears(-15);
       string bfdate=beforeDate.ToString("dd/MM/yyyy");
       string afdate=afterDate.ToString("dd/MM/yyyy");
       Console.WriteLine("15 year before date is: "+bfdate);
       Console.WriteLine("After the date is:" +afdate);
    }


        

    }
