using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SimbirSoft
{
    abstract class Logger
    {  
        public static void LogSomeError(Exception error)
        {
            if (!Directory.Exists("Errors"))
                Directory.CreateDirectory("Errors");

            using (StreamWriter sw = new StreamWriter($"Errors/{DateTime.Now.ToString("dd-MM-yy")}.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(error.ToString());
            }
        }
    }
}
