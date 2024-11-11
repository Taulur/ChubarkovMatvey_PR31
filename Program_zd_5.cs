using System.IO;


int n, v, t, k;
string[] line = Console.ReadLine().Split(' ');
v = Convert.ToInt32(line[0]);
t = Convert.ToInt32(line[1]);
string[] lines = File.ReadAllLines("input.txt");
n = Convert.ToInt32(lines[0]);
k = v * t;
Console.WriteLine(n - k);
File.WriteAllText("output.txt",(n - k).ToString());