using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static string timeConversion(string s)
    {
        string thetime = "";
        string[] newtime = new string[10];
        for (int i = 0; i < 8; i++)
            {
            newtime[i] = Convert.ToString(s[i]);
        }
      
        int a = Convert.ToInt32(newtime[0]);
        int b = Convert.ToInt32(newtime[1]);

        if (a==1 & b==2 & s.Contains("A"))
        {
            int c = 10 * a + b + 12;
            if (c == 24) c = 0;
            newtime[0] = Convert.ToString(c / 10);
            newtime[1] = Convert.ToString(c % 10);
            for (int i = 0; i < 8; i++)
            {
                thetime += Convert.ToString(newtime[i]);
            }
            return thetime;
        }
        else if (s.Contains("A"))
            return s.Remove(s.Length - 2);

        else if (a==1 & b==2)
            return s.Remove(s.Length - 2);

        else
        {
            int c = 10 * a + b + 12;
            if (c == 24) c = 0;
            newtime[0] = Convert.ToString(c / 10);
            newtime[1] = Convert.ToString(c % 10);
            for (int i = 0; i < 8; i++)
            {
                thetime += Convert.ToString(newtime[i]);
            }
            return thetime;
        }


    }

        static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);

    }
}