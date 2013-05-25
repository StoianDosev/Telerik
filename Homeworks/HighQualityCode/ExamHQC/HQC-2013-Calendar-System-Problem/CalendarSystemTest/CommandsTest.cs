using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarEvents;

namespace CalendarSystemTest
{
    [TestClass]
    public class CommandsTest
    {
        [TestMethod]
        public void ParseTestValidInputName()
        {
            Command com = new Command();
            com.CommandName = "AddEvent";
            com.CommandArgs = new string[] { "2012-01-21T20:00:00", "party Viki", "home" };

            string command = "AddEvent 2012-01-21T20:00:00 | party Viki | home";
            Command result = Command.Parse(command);
            string name = result.CommandName;

            Assert.AreEqual(com.CommandName, name);
        }

        [TestMethod]
        public void ParseTestValidInputArguments()
        {
            Command com = new Command();
            com.CommandName = "AddEvent";
            com.CommandArgs = new string[] { "2012-01-21T20:00:00", "party Viki", "home" };

            string command = "AddEvent 2012-01-21T20:00:00 | party Viki | home";
            Command result = Command.Parse(command);
            string name = result.CommandName;
            string[] resultArgs = result.CommandArgs;

            Assert.AreEqual(com.CommandArgs[0], resultArgs[0]);
            Assert.AreEqual(com.CommandArgs[1], resultArgs[1]);
            Assert.AreEqual(com.CommandArgs[2], resultArgs[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseTestInvalidInputWthoutEmptySpace()
        {
            string command = "AddEvent2012-01-21T20:00:00|partyViki|home";
            Command result = Command.Parse(command);
        }
    }
}
