using System.IO;


int k, n;
string[] lines = File.ReadAllLines("input.txt");
string[] line = lines[0].Split(' ');
k = Convert.ToInt32(line[0]);
n = Convert.ToInt32(line[1]);

File.WriteAllText("output.txt", (n / k).ToString());
