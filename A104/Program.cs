using System;
using System.Collections.Generic;

namespace A104
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lstNames = new List<string>();
            lstNames.Add("dogs");
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Sort();
            foreach (string s in lstNames)
                Console.Write(s + " ");
            Console.WriteLine();

            string[] arrNames = new string[100];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[1] = "sheep";
            Array.Sort(arrNames);
            foreach (string s in lstNames)
                Console.Write(s + " ");
            Console.WriteLine();
         
        }
    }
}
