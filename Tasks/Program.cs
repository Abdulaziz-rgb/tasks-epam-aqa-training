﻿// Function to return char for a given value
static char CharMapper(int num)
{
    if (num >= 0 && num <= 9)
        return (char)(num + 48);
    else
        return (char)(num - 10 + 65);
}

// Function to convert a number to a given base 
static string ConvertFromDecimal(int base1, int inputNum)
{
    string s = "";
    while (inputNum > 0)
    {
        s += CharMapper(inputNum % base1);
        inputNum /= base1;
    }
    char[] res = s.ToCharArray();

    Array.Reverse(res);
    return new String(res);
}

static void Main()
{
    int inputNum = 282, base1 = 16;
    Console.WriteLine("Equivalent of " + inputNum +
                      " in base "+base1+" is " +
                      ConvertFromDecimal(base1, inputNum));
}

Main();


 
 