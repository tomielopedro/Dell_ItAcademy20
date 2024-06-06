using System;
using System.Globalization;
using System.Linq.Expressions;


namespace Laboratorio2;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5] { 10, 20, 30, 40, 50 };
        int i;

        for (i = 0; i < 5; i++)
        {
            System.Console.WriteLine($"Indice = {i} Valor = {array[i]}");
        }

        System.Console.WriteLine("========================================== \n");

        string[] str = new string[3];
        int iString;
        str[0] = "Um";
        str[1] = "Dois";
        str[2] = "Três";

        for (iString = 0; iString < 3; iString++)
        {
            System.Console.WriteLine($"Indice = {iString} Valor = {str[iString]}");
        }

        System.Console.WriteLine("========================================== \n");

        DateTime[] dt = new DateTime[2];
        int iDate;
        dt[0] = new DateTime(2002, 5, 1);
        dt[1] = new DateTime(2002, 6, 1);

        for (iDate = 0; iDate < 2; iDate++)
        {
            System.Console.WriteLine($"Indice = {iDate} Valor = {dt[iDate]}");
        }

        System.Console.WriteLine("========================================== \n");

        int[] num = new int[5] { 100, 200, 300, 400, 500 };
        var culture = new CultureInfo("pt-Br");


        foreach (int numero in num)
        {
            System.Console.WriteLine(numero);

        }

        System.Console.WriteLine("========================================== \n");

        int[] array1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] array2 = new int[10];

        System.Console.WriteLine(array1[0]);
        System.Console.WriteLine(array2[0]);

        System.Console.WriteLine(array2[0]);

        foreach (var item in array1)
        {
            System.Console.WriteLine("Array1 " + item);

        }


        foreach (var item in array2)
        {
            System.Console.WriteLine("Array2 " + item);

        }

        array2 = (int[])array1.Clone();

        foreach (var item in array2)
        {
            System.Console.WriteLine("Array2 " + item);

        }

        array1[0] = 1000;
        foreach (var item in array2)
        {
            System.Console.WriteLine("Array2 " + item);

        }

        foreach (var item in array1)
        {
            System.Console.WriteLine("Array1 " + item);

        }





    }
}