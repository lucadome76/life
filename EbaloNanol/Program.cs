using System;
using System.Globalization;
using System.Resources;
using System.Threading;
// <copyright file="Program.cs">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Sorokin Dmitrii</author>
// <date>08/30/2018 12:10:53 AM </date>
// <summary>Program entry point</summary>

namespace Life
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Life v1.0");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Choose language:");
            Console.WriteLine("1. русский");
            Console.WriteLine("2. English");
            Console.WriteLine("3. Italiano");
            string lang = Console.ReadLine();
            if (lang == "2")
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
            } else if (lang == "3")
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("it-IT");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("it-IT");
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("ru-RU");
            }
            Console.WriteLine("------------------------------------");

            string welcome1 = LifeNameSpace.Properties.Resources.Welcome1;
            Console.Write(welcome1);
            string mode = Console.ReadLine();
            while (mode != "0" && mode != "1") {
                Console.WriteLine(welcome1);
                mode = Console.ReadLine();
            }
            Game game = new Game(Convert.ToInt32(mode) );
        }
    }
}
