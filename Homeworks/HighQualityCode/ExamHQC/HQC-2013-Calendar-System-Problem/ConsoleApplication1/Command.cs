using System;

namespace CalendarEvents
{
    public class Command
    {
        public string CommandName { get; set; }
        public string[] CommandArgs { get; set; }

        public static Command Parse(string inputCommand)
        {
            int commandEmeptySeparatorIndex = inputCommand.IndexOf(' ');
            if (commandEmeptySeparatorIndex == -1)
            {
                throw new ArgumentException("Invalid command: " + inputCommand + 
                    ". There must be an empty space between the command name and command arguments.");
            }

            string commandName = inputCommand.Substring(0, commandEmeptySeparatorIndex);
            string commandArgument = inputCommand.Substring(commandEmeptySeparatorIndex + 1);
            string[] arguments = commandArgument.Split('|');

            for (int i = 0; i < arguments.Length; i++)
            {
                commandArgument = arguments[i];
                arguments[i] = commandArgument.Trim();
            }

            var command = new Command { CommandName = commandName, CommandArgs = arguments };
            return command;
        }
    }
}
