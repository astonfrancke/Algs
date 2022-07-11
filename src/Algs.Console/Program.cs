// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string a = "1";
string b = null;
string c = "2";

var sl = new List<string>();

sl.Add(a);
sl.Add(b);
sl.Add(c);

foreach (var s in sl)
{
    Console.WriteLine(s);
}

