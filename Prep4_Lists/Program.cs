using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>();

        names.Add("Ana");
        names.Add("Luis");
        names.Add("Carlos");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
