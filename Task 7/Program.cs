using System;
using System.Text;
using System.Text.RegularExpressions;

string inputPath = "Text.txt";
string inputText;
string outputPath = "OutputText.txt";
string outputText;
try
{
    using (StreamReader sR = new StreamReader(inputPath))
    {
        inputText = sR.ReadToEnd();
        if(string.IsNullOrEmpty(inputText))
        {
            throw new Exception("File is empty");
        }
        sR.Close();
        Console.WriteLine("Input Text:\n");
        Console.WriteLine(inputText);
        StringBuilder sB = new StringBuilder();
        sB.Append(inputText);
        Regex find = new Regex("\\bdie\\b", RegexOptions.IgnoreCase);
        MatchCollection matches = find.Matches(inputText);
        sB.Replace("die", "***");
        outputText = sB.ToString();
        Console.WriteLine("\nOutput Text:\n");
        Console.WriteLine(outputText);
        if(matches.Count > 0)
        {
            Console.WriteLine($"\nWords replaced:{matches.Count}");
        }
        if (!File.Exists(outputPath)) {File.Create(outputPath);}
        using(StreamWriter sW = new StreamWriter(outputPath))
        {
            sW.WriteLine(outputText);
            sW.Close();
        }
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}
