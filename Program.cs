﻿using System;

namespace TimeSpanDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            // CREATING

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; // Corrected the assignment operator
            Console.WriteLine("Duration: " + duration);

            // properties

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //ADD

            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString

            Console.WriteLine("ToString" + timeSpan.ToString());

            // PARSE

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
