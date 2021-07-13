﻿using SkillEx.Repository.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace SkillEx.Repository.Helpers.Loggers
{
    public class  FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (var stream = File.AppendText("log.txt"))
            {
                stream.WriteLine(message);
                stream.Flush();
            }
        }
    }
}
