using System;

string input;
var numbers = new List<int>();
var operations = new List<char>();
var digits = new List<char>();
do
{
    Console.WriteLine("Enter ariphmetical expression: ");
    input = Console.ReadLine();
    Console.Clear();
    try
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new Exception($"{nameof(input)} CAN'T BE EMPTY!");
        }
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '-')
            {
                numbers.Add(int.Parse(digits.ToArray()));
                digits.Clear();
                operations.Add(input[i]);
            }
            else if (input[i] == '+')
            {
                numbers.Add(int.Parse(digits.ToArray()));
                digits.Clear();
                operations.Add(input[i]);
            }
            else
            {
                digits.Add(input[i]);
            }
        }
        numbers.Add(int.Parse(digits.ToArray()));
        int result = numbers[0];
        int count = 1;
        for (int i = 0; i < operations.Count; i++)
        {
            if (operations[i] == '+')
            {
                result += numbers[count]; count++;
            }
            else
            {
                result -= numbers[count]; count++;
            }
        }
        Console.WriteLine($"{input} = {result}");
        numbers.Clear();
        digits.Clear();
        operations.Clear();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
    }
}
while (true);