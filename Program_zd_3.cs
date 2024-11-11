

using System.IO;


int n;
string[] lines = File.ReadAllLines("input.txt");
n = Convert.ToInt32(lines[0]);
string[] line = lines[1].Split(' ');


List<int> list = new List<int>();
List<int> sorted = new List<int>();

foreach (string i in line)
{
    list.Add(Convert.ToInt32(i));
    sorted.Add(Convert.ToInt32(i));
}


sorted.Sort();
sorted.Reverse();

foreach (int i in sorted)
{
    Console.WriteLine(i);
}

StreamWriter writer = File.CreateText("output.txt");

for (int i = 0; i < sorted.Count; i+= 2)
{
    int first = sorted[i];
    int second = sorted[i + 1];
    int firstpos = 0;
    int secondpos = 0;
    for (int j = 0; j < list.Count; j++)
    {
        if (first == list[j])
        {
            firstpos = j + 1;
        }
        if (second == list[j])
        {
            secondpos = j + 1;
        }
    }
    writer.WriteLine($"{firstpos} {secondpos}");

}


writer.Close();