using RowdyFactor.Processing;
using RowdyFactor.Processing.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace RowdyFactor.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***WELCOME***\nThis program will load cars from NormalCars group and it will change their rowdy" +
                "factor.\n");

            string omsiVehiclesPath = @"C:\Program Files (x86)\Steam\steamapps\common\OMSI 2\";

            Console.WriteLine("Please enter the map folder: ");
            string map = Console.ReadLine().Trim();

        
            List<string> vehiclesPaths = AiListsParser.ExtractAllVehicles(
                File.ReadAllLines(omsiVehiclesPath + "/maps/" + map + "/ailists.cfg")
                );

            List<OmsiVehicle> vehicles = new List<OmsiVehicle>();
            foreach (string vehiclePath in vehiclesPaths) {
                OmsiVehicle vehicle = new FileHandler().Process(omsiVehiclesPath+vehiclePath);

                if (!vehicle.InvalidVehicle)
                {
                    vehicles.Add(vehicle);

                    string formatPattern = "{0}:{1}";
                    if (!String.IsNullOrEmpty(vehicle.Name.CarType))
                    {
                        formatPattern = formatPattern += " ({2})";
                    }
                    Console.WriteLine("Vehicle file:" + vehiclePath);
                    Console.WriteLine(String.Format(formatPattern, vehicle.Name.Brand, vehicle.Name.CarModel, vehicle.Name.CarType));
                    if (vehicle.RowdyFactor != null)
                    {
                        Console.WriteLine(String.Format("**Rowdy factor:**\nFrom:{0}\nTo:{1}", vehicle.RowdyFactor.From, vehicle.RowdyFactor.To));
                    }
                }
                Console.WriteLine("---------------------\n");
            }
            Console.WriteLine("Total valid vehicles:" + vehicles.Count);
            Console.WriteLine("// type 'edit' to edit  a single vehicle; type 'editall' to set values to all vehicles");
            string option = (Console.ReadLine()).ToLower();
            switch(option)
            {
                case "edit":
                    try
                    {
                        Console.WriteLine("// type vehicle number (the first is 0) //");
                        string vehicleIndexInput = Console.ReadLine();
                        int vehicleIndex = int.Parse(vehicleIndexInput);
                        Edit(new FileHandler().Process(vehiclesPaths[vehicleIndex]));
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Could not accept this input!");
                    }
                    break;
                case "editall":
                    EditAll(vehicles);
                    break;
            }

            Console.ReadLine();
        }

        static void EditAll(List<OmsiVehicle> vehicles)
        {
            Console.Clear();
            Console.WriteLine("!!! WARNING: This option will set same values to all vehicles !!!\n");

            try
            {
                Console.Write("Enter new from value:");
                double newFrom = double.Parse(Console.ReadLine());

                Console.Write("Enter new to value:");
                double newTo = double.Parse(Console.ReadLine());

                foreach (OmsiVehicle vehicle in vehicles)
                {
                    vehicle.RowdyFactor = (new ValueEditor().EditRowdyFactor(vehicle, newFrom, newTo));
                }
                Console.WriteLine("// type 'ok' to confirm; type 'exit' to abort");
                string confirm = Console.ReadLine();
                switch (confirm)
                    {
                        case "ok":
                            foreach (OmsiVehicle vehicle in vehicles)
                            {
                            new FileHandler().WriteRowdyFactor(vehicle);
                            }
                        Console.WriteLine("**Done**");
                        Console.ReadLine();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                    }
            }
            catch(Exception e)
            {
                Console.WriteLine("Could not set new values");
            }

        }

        static void Edit(OmsiVehicle vehicle)
        {
            Console.Clear();
            Console.WriteLine("----------Editor--------\n");
            Console.WriteLine(String.Format("Rowdy factor, current: {0} - {1}", vehicle.RowdyFactor.From, vehicle.RowdyFactor.To));

            string option = Console.ReadLine().ToLower();
            switch(option)
            {
                case "set":
                    try {
                        Console.Write("Enter new from value:");
                        double newFrom = double.Parse(Console.ReadLine());
                        Console.Write("Enter new to value:");
                        double newTo = double.Parse(Console.ReadLine());
                        vehicle.RowdyFactor = new ValueEditor().EditRowdyFactor(vehicle, newFrom, newTo);
                        Console.WriteLine("enter 'ok' to write changes");
                        switch(Console.ReadLine())
                        {
                            case "ok":
                                try
                                {
                                    new FileHandler().WriteRowdyFactor(vehicle);
                                    Console.WriteLine("The file has been updated!!");
                                }
                                catch(Exception e)
                                {
                                    Console.WriteLine("Could not edit the file :(");
                                }
                                break;
                        }

                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Could not accept those inputs! Try again!");
                        Edit(vehicle);
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
