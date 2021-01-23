using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerServices : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanina Loglandi");
        }
    }
}
