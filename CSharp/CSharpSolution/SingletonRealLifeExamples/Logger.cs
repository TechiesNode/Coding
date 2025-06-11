using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonRealLifeExamples
{
    public sealed class Logger
    {
        private static  Logger _logInstance = null;
        private static readonly object _lock = new object();
        private  readonly string _logFilepath;

        private Logger()
        {
            _logFilepath = "D:\\Study\\Coding\\CSharp\\CSharpSolution\\TextFile3.txt";
        }

        public static Logger Instance
        {
            get 
            {
                if (_logInstance == null)
                {
                    lock (_lock)
                    {
                        if (_logInstance == null)
                        { 
                            _logInstance = new Logger();
                        }
                    }
                }
                return _logInstance;
            }
            
        }

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now}: {message}";
            Console.WriteLine(logEntry);
            File.AppendAllText(_logFilepath, logEntry + Environment.NewLine);
        }
    }

    
}
