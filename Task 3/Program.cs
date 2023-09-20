using System;

string input;
var output = new char[char.MaxValue];
Console.WriteLine("Input text: ");
input = Console.ReadLine();
Console.WriteLine("Press left arrow to encrypt text, right arrow to decrypt text: ");
output = input.ToCharArray();
switch (Console.ReadKey().Key)
{
    case ConsoleKey.LeftArrow:
        for (int i = 0; i < output.Length; i++)
        {
            output[i] += (char)3;
        }
        break;
    case ConsoleKey.RightArrow:
        for (int i = 0; i < output.Length; i++)
        {
            output[i] -= (char)3;
        }
        break;
}
output.ToString();
Console.WriteLine(output);
