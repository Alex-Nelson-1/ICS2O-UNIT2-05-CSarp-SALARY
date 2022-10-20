// Created by: Alex Nelson
// Created on: Oct 2022
//
// This program calculates salary
using System;

class Program
{
    public static void Main(string[] args)
    {
        double hours;
        double wage;
        double TAX_RATE = 0.18;
        double pay;
        double taxes;
        Console.WriteLine("This program calculates your salary");
        Console.WriteLine("");
        //Input
        Console.WriteLine("Enter your amount of hours worked");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your wage");
        wage = Convert.ToInt32(Console.ReadLine());
        //Process
        pay = hours * wage * (1 - TAX_RATE);
        taxes = hours * wage * TAX_RATE;
        //Output
        Console.WriteLine("Your pay will be: " + pay.ToString("0.00") + ". ");
        Console.WriteLine("The government takes: " + taxes.ToString("0.00") + ". ");
        Console.WriteLine("\nDone");
    }
}
