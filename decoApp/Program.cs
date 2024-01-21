using System;
using System.IO;

string path = @"C:\descargas\temp\coding_qual_input.txt";
string Decode(string message_file)
{
    var linesUnsorted = File.ReadAllLines(message_file);
    var lines = linesUnsorted.OrderBy(line => int.Parse(line.Split(' ')[0]));
    var words = lines.Select(line => line.Split(' ').Last()).ToList();
    List <string> wordList = new List<string>();
    List<List<string>> pyramid = new List<List<string>>();
    for (int i = 0; i < words.Count; i++)
    {
        pyramid.Add(new List<string>());
        for (int j = 0; j <= i; j++)
        {
            pyramid[i].Add(words[j]);
        }
        wordList.Add(pyramid[i].Last());
        words.RemoveRange(0, i + 1);
    }
    var message = string.Join(" ", wordList);
    return message.ToLower().Trim();
}
string decodedMessage = Decode(path);
Console.WriteLine(decodedMessage);
Console.ReadKey();
