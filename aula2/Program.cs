using System;
namespace aula2;

class Program
{
     static void Main(string[] args)
     {
        int n1 = default;
        int? n1Null = default;

        DateTime date = default;
        DateTime? dateNull = default;

        System.Console.WriteLine($"N1 sem ? {n1}");
        System.Console.WriteLine($"N1 com ? {n1Null}");

        System.Console.WriteLine($"Date sem ? {date}");
        System.Console.WriteLine($"Date com ? {dateNull}");
        

     }

}