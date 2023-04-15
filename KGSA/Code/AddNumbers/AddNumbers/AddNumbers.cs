using System;
using System.Diagnostics.CodeAnalysis;

class AddNumbers
{
    static void Main()
    {
        int num1, num2, sum;
        string num1String, num2String;

        Console.WriteLine("Please enter an integer number: ");
        num1String = Console.ReadLine();
        num1 = int.Parse(num1String);
        // num1 = 5;

        Console.WriteLine("Please enter another integer number: ");
        num2String = Console.ReadLine();
        num2 = int.Parse(num2String);
        //num2 = 3;

        sum = (num1 + num2);

        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum + ".");
    }
}