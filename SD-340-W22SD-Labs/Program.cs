using System.Text;

WordNumber concatenate = new WordNumber(Concatenate);
WordNumber removeLetters = new WordNumber(RemoveLetters);


Console.WriteLine(concatenate("Hello", 3));
Console.WriteLine(removeLetters("Hello", 3));


string Concatenate(string wordArg, int numArg)
{
    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < numArg; i++)
    {
        sb.Append(wordArg);
    }

    return sb.ToString();
}

string RemoveLetters(string wordArg, int numArg)
{
    if (wordArg.Length <= numArg)
    {
        return "";
    }

    return wordArg.Remove(wordArg.Length - numArg, numArg);
}

delegate string WordNumber(string wordArg, int numArg);