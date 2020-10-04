using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID_Principles.SRP.Good
{
    public class Logger
    {
        public void LogFile(string filePath, string log)
        {
            File.WriteAllText(filePath,log);
        }

        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Date: ");
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("Information: ").Append(information);

            return sb.ToString();
        }
            

    }
}
