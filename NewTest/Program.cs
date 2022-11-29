using System.Text.RegularExpressions;

Regex reg = new Regex("</?.*?>");
StreamReader file = new StreamReader("Readme.md");
string input = file.ReadToEnd();
input = reg.Replace(input, "").Replace(",", " ").Replace("  ", " ").Replace("\"", " ").Replace("    ", " ");
string[] line = input.Split(" ");

Console.Write(String.Join(",", line.Where(s => s.Length <= 3)));


