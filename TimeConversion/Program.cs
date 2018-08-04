using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static string timeConversion(string s)
    {
        string thetime = "";
        string time = s;
        string[] newtime = new string[10];
        if (s.Contains("PM"))
        {
            time = s;
            for (int i = 0; i < 10; i++)
            {
                newtime[i] = Convert.ToString(time[i]);
            }
            int a = Convert.ToInt32(newtime[0]);
            int b = Convert.ToInt32(newtime[1]);
            int c = 10 * a + b + 12;
            newtime[0] = Convert.ToString(c / 10);
            newtime[1] = Convert.ToString(c % 10);
        }
        else return s;
        for (int i = 0; i < 10; i++)
        {
            thetime += Convert.ToString(newtime[i]);
        }
        return thetime;
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);

    }
}