﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        enum week
        {
            lundi,
            mardi,
            mercredi,
            jeudi,
            vendredi,
            saemdi,
            dimanche
        }
        static void Main(string[] args)
        {
        // foreach (int i in Enum.GetValues(typeof(week)))
        foreach (string i in Enum.GetNames(typeof(week)))
        Console.WriteLine(i);
        Console.ReadKey();
        Console.WriteLine(Enum.GetName(typeof(week),4));
        }
    }
}
