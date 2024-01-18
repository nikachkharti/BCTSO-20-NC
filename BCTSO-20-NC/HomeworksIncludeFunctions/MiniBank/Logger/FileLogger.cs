namespace Homeworks.MiniBank.Logger
{
    public static class FileLogger /*: ILogger*/
    {
        private static readonly string _filePath = @"../../../Homeworks/MiniBank/Logger/log.txt";
        public static void Log(string message)
        {
            File.AppendAllText(_filePath, message);
        }
    }
}
