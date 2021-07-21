using System;
using System.IO;

namespace AppPatronesDiseño.Patrones_creacionales._4.Singleton
{
    public static class LoggerSingleton
    {
        private static Lazy<Logger> _instance => new Lazy<Logger>(() => new Logger());

        public static Logger Instance = _instance.Value;

        public class Logger
        {
            private static readonly string FilePath = Directory.GetCurrentDirectory();
            private static readonly string FileName = "Logger-{0}.txt";

            public Logger()
            {
            }

            public void Log(string message)
            {
                // Recalculate file name with actual date
                var fileName = string.Format(FileName, DateTime.Now.ToString("dd-MM-yyyy"));
                // Using stream writer for create or append text to file
                using (var sw = new StreamWriter(File.Open($"{FilePath}/{fileName}", System.IO.FileMode.Append)))
                    sw.WriteLine(message);
            }
        }
    }
}