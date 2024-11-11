using System.IO;

int sizein, sizemain;
string[] lines = File.ReadAllLines("input.txt");
string[] line = lines[0].Split(' ');
sizein = Convert.ToInt32(line[0]);
sizemain = Convert.ToInt32(line[1]);
string inner = lines[1];
string main = lines[2];
List<Char> list = new List<char>();

foreach (Char ch in inner)
{
    foreach (Char ch2 in main)
    {
        if (ch == ch2)
        {
            list.Add(ch);
            break;
        }
    }
}

StreamWriter writer = File.CreateText("output.txt");
if (list.Count == inner.Length )
{
    writer.WriteLine("GOOD NOTE");
}
else
{
    foreach (char ch in inner)
    {
        if (!list.Contains(ch))
        {
            writer.WriteLine(ch);
        }
    }
}



writer.Close();