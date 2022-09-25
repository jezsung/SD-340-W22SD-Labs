Directory.SetCurrentDirectory("C:\\Users\\jezsu\\Downloads");
string path = Directory.GetCurrentDirectory();
ReplaceDotToStop(path, "theMachineStops.txt", "TelegramCopy.txt");

void ReplaceDotToStop(string path, string inputFilename, string outputFilename)
{
    string text = File.ReadAllText(path + $"\\{inputFilename}");
    string result = text.Replace(".", "STOP");
    File.WriteAllText(path + $"\\{outputFilename}", result);
}
