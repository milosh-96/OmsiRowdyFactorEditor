using Moq;
using RowdyFactor.Processing;
using RowdyFactor.Processing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RowdyFactor.Tests
{
    public class FileHandlerTests
    {
        [Theory]
        [InlineData("\n,[rowdy_factor],0,1,\n,[ai]",1)]
        [InlineData("\n,abc,0,1,[rowdy_factor],[ai]", 4)]
        public void GetRowdyFactorIndex_ReturnsCorrectLineWhenThereIsRowdyFactorAttribute(string data, int expected)
        {
            var lines = data.Split(",");

            var actual = new FileHandler().GetRowdyFactorIndex(lines);

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData("\n,[rowdy_factor],0,1,[rowdy_factor],[ai]", 1)]
        [InlineData("\n,abc,0,1,\n,[rowdy_factor],a,[rowdy_factor]", 5)]
        public void GetRowdyFactorIndex_ReturnsLineNumberOfTheFirstRowdyFactorAttribute(string data, int expected)
        {
            var lines = data.Split(",");
            FileHandler fileHandler = new FileHandler();
            var actual = fileHandler.GetRowdyFactorIndex(lines);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetRowdyFactorIndex_ReturnsNullIfThereIsNoRowdyFactorAttribute()
        {
            var lines = new string[]
            {
                "",
                "0",
                "1",
                "",
                "[ai]"
            };

            var actual = new FileHandler().GetRowdyFactorIndex(lines);

            Assert.Null(actual);
        }

        [Fact]
        public void CreateRowdyFactor_GeneratesCorrectOmsiRowdyFactorObject()
        {
            var lines = new string[]
           {
                "abc",
                "[rowdy_factor]",
                "0",
                "1",
                "",
                "[ai]"
           };
            FileHandler fileHandler = new FileHandler();
            var actual = fileHandler.CreateRowdyFactor(lines,1);
            OmsiRowdyFactor expected = new OmsiRowdyFactor() { From = 0, To = 1 };
            Assert.Equivalent(expected, actual);

        }

        [Fact]
        public void CreateRowdyFactor_ThrowsArgumentExceptionIfEmptyLinesArePassed()
        {
            var lines = new string[]
            {
               
            };
            FileHandler fileHandler = new FileHandler();

            Assert.Throws<ArgumentException>("lines", () =>
            {
                fileHandler.CreateRowdyFactor(lines, 1);
            });

        }

        [Fact]
        public void CreateRowdyFactor_ThrowsArgumentExceptionIfNotEnoughLinesAfterRowdyFactorArePassed()
        {
            var lines = new string[]
            {
                "ab",
                "bc",
                "cd",
                "ed",
                "[rowdy_factor]",
                "0aa"
            };
            FileHandler fileHandler = new FileHandler();

            Assert.Throws<ArgumentException>("lines", () =>
            {
                fileHandler.CreateRowdyFactor(lines, 4);
            });

        }
    }
}
