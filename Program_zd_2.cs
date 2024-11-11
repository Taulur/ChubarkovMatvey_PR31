using System.IO;


int k, n;
string[] lines = File.ReadAllLines("input.txt");
n = Convert.ToInt32(lines[0]);
StreamWriter writer = File.CreateText("output.txt");
for (int i = 1; i < n + 1; i++)
{
    string reversed = null;
    for (int j = lines[i].Length - 1; j > -1; j--)
    {
        reversed += lines[i][j];
    }
    if (reversed.ToLower() == lines[i].ToLower())
    {

        writer.WriteLineAsync("YES");

    }
    else
    {

        writer.WriteLineAsync("NO");

    }

}

writer.Close();