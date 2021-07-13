using SkillEx.Repository.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillEx.Repository.Helpers.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
