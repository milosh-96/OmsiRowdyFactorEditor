using RowdyFactor.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
namespace RowdyFactor.Tests
{
    public class AiListsParserTests
    {
        private string[] fileContents = new[]
        {
             "[aigroup_2]",
            "NormalCars",
            "",
            @"Vehicles\WH_UK_AI_WC\_Road\EClass_W212_Facelift.ovh 10",
            @"Vehicles\WH_UK_AI_WC\_Road\Focus_Mk1_Facelift.ovh 16",
            @"Vehicles\WH_UK_AI_WC\_Road\Mini_F56.ovh 14",
            @"Vehicles\WH_UK_AI_WC\_Road\Range_Rover_L405.ovh 10",
            @"Vehicles\BotW_BMW_520_F11\BMW_520_F11.ovh 10",
            @"Vehicles\BotW_VW_Golf_5\VW_Golf_5.txt 16",
            @"Vehicles\BotW_VW_Golf_5\VW_Golf_5.js 16",
            @"Vehicles\BotW_VW_Golf_5\VW_Golf_5.ovh 16",
            "",
            "[end]",
            "",
            "[aigroup_2]",
            "Taxi",
            "",
            @"Vehicles\BotW_VW_Passat_B7_taxi\VW_Passat_B7.ovh 20",
            @"Vehicles\WH_UK_AI_WC\_Road\TX4.ovh 4",
            @"Vehicles\WH_UK_AI_WC\_Road\TX4.cs 4",
            @"Vehicles\WH_UK_AI_WC\_Road\Transit_Mk4_Facelift_swb_taxi.ovh 8",
            "[end]"
        };
        [Fact]
        public void ExtractAiGroup_AddsCorrectLinesToArrayOfVehicles()
        {
            // Arrange


            // Act
            List<string> returnedVehicles = new List<string>();
            returnedVehicles = AiListsParser.ExtractAiGroup("NormalCars", fileContents);

            // Assert
            Assert.Equal(6,returnedVehicles.Count);
            Assert.True(returnedVehicles.Any(x => x.Contains(".ovh") || x.Contains(".bus")), "Vehicles are only those with .ovh or .bus extensions.");
        }

        [Fact]
        public void ExtractAllVehicles_AddsCorrectLinesToArrayOfVehicles()
        {
            // Arrange


            // Act
            List<string> returnedVehicles = new List<string>();
            returnedVehicles = AiListsParser.ExtractAllVehicles(fileContents);

            // Assert
            Assert.Equal(9, returnedVehicles.Count);
            Assert.True(returnedVehicles.Any(x => x.Contains(".ovh") || x.Contains(".bus")), "Vehicles are only those with .ovh or .bus extensions.");
        }

    }
}
