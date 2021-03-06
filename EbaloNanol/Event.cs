﻿using System;
// <copyright file="Event.cs">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Sorokin Dmitrii</author>
// <date>08/30/2018 12:10:53 AM </date>
// <summary>Event class</summary>
namespace Life
{
    class Event
    {
        private int evType;
        private string text;

        public void print()
        {
            switch (this.evType)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkRed; ;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public Event(int evType, string text)
        {
            this.evType = evType;
            this.text = text;
        }
    }
}
