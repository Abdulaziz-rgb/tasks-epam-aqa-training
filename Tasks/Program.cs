﻿static void Main()
{
    Console.Write("Enter a word to check: ");
    var input = Console.ReadLine();
    
    // Checks the input for null
    if (input.Length == 0) Console.Write("Value cannot be null. Please re-run the program with correct credential!");
    FindMaxUnequalConsecutiveChar(input);
}

//  Function to implement the main logic of the program -> checks the chars for max unequal consecutiveness
static void FindMaxUnequalConsecutiveChar(string words)
{
    var len = words.Length;
    var checkedChars = "";
    
    for (int i = 0; i < len; i++)
    {
        if (!checkedChars.Contains(words[i]))
        {
            checkedChars += words[i];
        }
        else
        {
            checkedChars = "";
            checkedChars += words[i];
        }
        
        Console.Write(
            $"Number of unequal consecutive character in line {i + 1} is {checkedChars.Length} -> {checkedChars}\n");
    }
}

Main();
