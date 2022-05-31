using System;
using System.Collections.Generic;
using System.Text;

namespace RowdyFactor.Processing
{
    public class AiListsParser
    {
        public static List<string> ExtractAiGroup(string name, string[] fileContents)
        {
            List<string> vehicles = new List<string>();
            int? groupLineNumber = GetGroupLine(name, fileContents);

            if(groupLineNumber.HasValue)
            {
                for (int i = (groupLineNumber.Value+2); i < fileContents.Length; i++)
                {
                    string line = fileContents[i];
                    if (line.Contains(".ovh"))
                    {
                        line = line.Substring(0, (line.IndexOf(".ovh") + 4));
                    }
                    else if(line.Contains(".bus")) {
                        line = line.Substring(0, (line.IndexOf(".bus") + 4));
                    }
                   // Console.WriteLine(line);
                   
                    if(fileContents[i]=="[end]")
                    {
                        break;
                    }
                    vehicles.Add(line);
                }
               
            }
            return vehicles;
        }

        private static int? GetGroupLine(string name, string[] fileContents)
        {
            int index = 0;
            foreach (string line in fileContents)
            {
                if (line == name)
                {
                    return index;
                }
                index++;
            }

            return null;
        }
    }
}
