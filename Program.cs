const string logFileName = "args.log";
File.AppendAllText(logFileName, $"--- [{DateTime.Now}] Running with args ---" + Environment.NewLine);
foreach (var arg in args)
{
    File.AppendAllText(logFileName, arg + Environment.NewLine);
}
File.AppendAllText(logFileName, $"--- Finished ---" + Environment.NewLine);