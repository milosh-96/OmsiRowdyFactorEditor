﻿using RowdyFactor.Processing.Models;
using System;
using System.IO;

namespace RowdyFactor.Processing
{
    public class FileHandler
    {
        public OmsiVehicle Process(string filePath)
        {
            string[] lines = GetFileContents(filePath);
            OmsiVehicle vehicle = new OmsiVehicle() { FilePath=filePath,InvalidVehicle = true};
            if(lines != null)
            {
                if (GetRowdyFactorIndex(lines) != null)
                {
                    OmsiRowdyFactor rowdyFactor = GetRowdyFactor(lines);
                    if (rowdyFactor != null)
                    {
                        vehicle.RowdyFactor = GetRowdyFactor(lines);
                        vehicle.InvalidVehicle = false;

                    }

                }
            }
            return vehicle;
        }

        private OmsiRowdyFactor GetRowdyFactor(string[] lines)
        {
            int? foundOnIndex = this.GetRowdyFactorIndex(lines);
            if(foundOnIndex != null)
            {
                try
                {
                    return CreateRowdyFactor(lines, foundOnIndex.Value);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Could not parse from & to values from the rowdy factor block");
                }
            }
            return null;


        }

        public OmsiRowdyFactor CreateRowdyFactor(string[] lines, int attributeIndex)
        {
            if(lines == null)
            {
                throw new ArgumentException("no lines", "lines");
            }
            else if(lines.Length < (attributeIndex+1) + 2)
            {
                throw new ArgumentException("not enough lines to work with", "lines");
            }
            //read next two lines after the rowdy factor line, the first one is from value, the second one is to value //
            double rowdyFactorFrom = double.Parse(lines[(attributeIndex + 1)]);
            double rowdyFactorTo = double.Parse(lines[(attributeIndex + 2)]);

            return new OmsiRowdyFactor(rowdyFactorFrom, rowdyFactorTo);
        }

        public void WriteRowdyFactor(OmsiVehicle vehicle)
        {
            string[] lines = GetFileContents(vehicle.FilePath);

            int? rowdyIndex = GetRowdyFactorIndex(lines);

            if(rowdyIndex != null)
            {
                lines[rowdyIndex.Value + 1] = vehicle.RowdyFactor.From.ToString();
                lines[rowdyIndex.Value + 2] = vehicle.RowdyFactor.To.ToString();

                File.WriteAllLines(vehicle.FilePath, lines,System.Text.Encoding.GetEncoding("iso-8859-1"));
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
                var line = lines[i].Trim();
                if (line.StartsWith("[rowdy_factor]"))
                {
                    foundOnIndex = i;
                    break;
                }
            }
            return foundOnIndex;
        }

        private string[] GetFileContents(string filePath)
        {
            string[] lines = null;
            lines = System.IO.File.ReadAllLines(filePath, System.Text.Encoding.GetEncoding("iso-8859-1"));           
            return lines;
        }
    }
}
