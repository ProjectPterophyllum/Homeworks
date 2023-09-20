using System;
using System.Data;
using System.Text;

Console.WriteLine("Enter text: ");
string str;
try
{
    str = Console.ReadLine();
    if (!string.IsNullOrEmpty(str))
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(str[0].ToString().ToUpper());
        for (int i = 1; i < str.Length; i++)
        {
            if (char.IsLetter(str[i]) && char.IsWhiteSpace(str[i - 1]) && ".!?".IndexOf(str[i - 2]) != -1)
            {
                stringBuilder.Append(str[i].ToString().ToUpper());
            }
            else
            {
                stringBuilder.Append(str[i]);
            }
        }
        Console.WriteLine(stringBuilder.ToString());

    }
    else
        throw new ArgumentException("Text cant be empty!");
}
catch (Exception e)
{
    Console.WriteLine(e);
}