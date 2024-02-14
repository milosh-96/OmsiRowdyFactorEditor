using RowdyFactor.Processing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RowdyFactor.Processing
{
    public class ValueEditor
    {
        public OmsiRowdyFactor EditRowdyFactor(OmsiVehicle vehicle,double from,double to) {
           try
            {
                if (vehicle.RowdyFactor == null)
                {
                    vehicle.RowdyFactor = new OmsiRowdyFactor(from, to);
                }
                else
                {
                    vehicle.RowdyFactor.From = from;
                    vehicle.RowdyFactor.To = to;
                }
                return vehicle.RowdyFactor;
            }
            catch(Exception e)
            {
                Console.WriteLine("could not set new values");
            }
            return null;
        } 
    }
}
