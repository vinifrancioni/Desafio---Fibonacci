using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    static List<int> Fibonacci()
    {
        int a = 0;
        int b = 1;

        var list = new List<int>();

        while (a < 350)
        {
            int temp = a;
            a = b;
            b = temp + b;
            list.Add(a);
        }

        return list;
    }

    static void Main()
    {

        foreach (int valor in Fibonacci())
        {
            Console.WriteLine(valor);
        }

        Console.ReadLine();
    }

}