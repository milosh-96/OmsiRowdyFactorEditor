using RowdyFactor.Processing.Models;
using System;
using System.IO;

namespace RowdyFactor.Processing
{
    public class FileHandler
    {
        public OmsiVehicle Process(string filePath)
        {
            string[] lines = GetFileContents(filePath);
            return new OmsiVehicle() { RowdyFactor = GetRowdyFactor(lines),FilePath=filePath};
        }

        private OmsiRowdyFactor GetRowdyFactor(string[] lines)
        {
            int? foundOnIndex = this.GetRowdyFactorIndex(lines);
            if(foundOnIndex != null)
            {
                try
                {
                    //read next two lines after the rowdy factor line, the first one is from value, the second one is to value //
                    double rowdyFactorFrom = double.Parse(lines[(foundOnIndex.Value + 1)]); 
                    double rowdyFactorTo = double.Parse(lines[(foundOnIndex.Value + 2)]);

                    return new OmsiRowdyFactor(rowdyFactorFrom, rowdyFactorTo);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Could not parse from & to values from the rowdy factor block");
                }
            }
            return null;


        }

        public void WriteRowdyFactor(OmsiVehicle vehicle)
        {
            string[] lines = GetFileContents(vehicle.FilePath);

            int? rowdyIndex = GetRowdyFactorIndex(lines);

            if(rowdyIndex != null)
            {
                lines[rowdyIndex.Value + 1] = vehicle.RowdyFactor.From.ToString();
                lines[rowdyIndex.Value + 2] = vehicle.RowdyFactor.To.ToString();

                File.WriteAllLines(vehicle.FilePath, lines,System.Text.Encoding.UTF8);
            }
            else
            {
                File.AppendText("[rowdy_factor]");
                File.AppendText(vehicle.RowdyFactor.From.ToString());
                File.AppendText(vehicle.RowdyFactor.To.ToString());
            }
        }


        public int? GetRowdyFactorIndex(string[] lines)
        {
            int? foundOnIndex = null;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("[rowdy_factor]"))
                {
                    foundOnIndex = i;
                    break;
                }
            }
            return foundOnIndex;
        }

        private string[] GetFileContents(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            return lines;
        }
    }
}
