using System;
using System.Net;
using System.Globalization;

namespace Laboratorio1;

class Program
{
    static void Main(string[] args)
    {

        // Fundamentals types - byte; int; long

        System.Console.WriteLine("Fundamental Types \n");

        byte b;
        b = byte.MaxValue;
        System.Console.WriteLine($"Byte max value: {b}");

        int i;
        i = int.MaxValue;
        System.Console.WriteLine($"Int max value: {i}");

        long l;
        l = long.MaxValue;
        System.Console.WriteLine($"Long max value: {l}");

        System.Console.WriteLine("==========================");

        // STRINGS

        System.Console.WriteLine("Strings \n");

        string strFirst = "Hello ";
        string strSecond = "World";
        string strThird = strFirst + strSecond;
        System.Console.WriteLine($"String: {strThird}");

        int strSize = strThird.Length;
        System.Console.WriteLine($"Size of string: {strSize}");

        string strFourth = "Size = " + strSize.ToString();
        System.Console.WriteLine(strFourth);

        System.Console.WriteLine($"SubString Method = {strThird.Substring(0, 5)}");

        System.Console.WriteLine($"String -> {strThird} contains H? {strThird.Contains('H')}");

        System.Console.WriteLine($"String -> {strThird} end with d? {strThird.EndsWith('d')}");

        System.Console.WriteLine($"String -> {strThird} hashCode {strThird.GetHashCode()}");

        System.Console.WriteLine($"Replace o -> # - {strThird.Replace('o', '#')}");

        System.Console.WriteLine($"UPPER CASE: {strThird.ToUpper()}");
        System.Console.WriteLine($"lower case: {strThird.ToLower()}");


        System.Console.WriteLine("==========================");

        // Date Time
        DateTime dt = new DateTime(2002, 11, 06);
        string strFifith = dt.ToString();
        System.Console.WriteLine(strFifith);

        System.Console.WriteLine($"Data -> {dt.Date}");
        System.Console.WriteLine($"Dia -> {dt.Day}");
        System.Console.WriteLine($"Mes -> {dt.Month}");
        System.Console.WriteLine($"Ano -> {dt.Year}");
        System.Console.WriteLine($"Dia da semana -> {dt.DayOfWeek}");
        System.Console.WriteLine($"Dia do Ano -> {dt.DayOfWeek}");
        System.Console.WriteLine($"Data + 7 dias-> {dt.AddDays(7)}");
        System.Console.WriteLine($"Data + 2 meses-> {dt.AddMonths(2)}");
        System.Console.WriteLine($"Data + 1 ano-> {dt.AddYears(1)}");
        System.Console.WriteLine($"Dias no mes-> {DateTime.DaysInMonth(2002, 12)}");

        var culture = new CultureInfo("pt-Br");
        System.Console.WriteLine($"Data Formatada-> {dt.ToString(culture)}");



        System.Console.WriteLine($"Data de hoje -> {DateTime.Today}");
        System.Console.WriteLine($"Data e Hora de hoje -> {DateTime.Now}");

        System.Console.WriteLine("==========================");


        // FLOAT DOUBLE DECIMAL

        float f;
        f = float.MaxValue;
        System.Console.WriteLine($"Float max value: {f}");

        double d;
        d = double.MaxValue;
        System.Console.WriteLine($"Double max value: {d}");

        decimal dc;
        dc = decimal.MaxValue;
        System.Console.WriteLine($"Decimal max value: {dc}");
        System.Console.WriteLine("==========================");


        // Conversões
        System.Console.WriteLine("Conversões");
        int n = 10;
        float n1 = 0;
        n1 = n;
        System.Console.WriteLine(n1);
        n1 = 0.5f;
        n = (int)n1;
        System.Console.WriteLine(n);


        System.Console.WriteLine("Try Parse");

        string strInt = "123456789";
        int valorStrInt;
        bool conversao1 = Int32.TryParse(strInt, out valorStrInt);
        System.Console.WriteLine("Conversão Efetudada: " + conversao1 + " Valor: " + valorStrInt);

        string strBigInt = "999999999999999999999999999999";
        int valorStrBigInt;
        bool conversao2 = Int32.TryParse(strBigInt, out valorStrBigInt);
        System.Console.WriteLine("Conversão Efetudada: " + conversao2 + " Valor: " + valorStrBigInt);

        string strLeter = "abc";
        int valorStrLeter;
        bool conversao3 = Int32.TryParse(strLeter, out valorStrLeter);
        System.Console.WriteLine("Conversão Efetudada: " + conversao3 + " Valor: " + valorStrLeter);

        System.Console.WriteLine("\nArredondamentos");
        double valorFracionado = 4.7;
        int valorInteiro1 = (int)valorFracionado;
        int valorInteiro2 = Convert.ToInt32(valorFracionado);
        System.Console.WriteLine($"Numero: {valorFracionado}");
        System.Console.WriteLine("Conversão explicita: {0}", valorInteiro1);
        System.Console.WriteLine($"Conversão metodo Convert: {valorInteiro2}");









    }

}