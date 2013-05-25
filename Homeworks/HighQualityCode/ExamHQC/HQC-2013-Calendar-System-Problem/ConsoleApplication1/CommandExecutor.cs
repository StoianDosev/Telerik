using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CalendarEvents
{
    public class CommandExecutor
    {
        private readonly IEventsManager eventManager;

        public CommandExecutor(IEventsManager eventManger)
        {
            this.eventManager = eventManger;
        }

        public IEventsManager EventsProcessor
        {
            get
            {
                return this.eventManager;
            }
        }

        public string ProcessCommand(Command command)
        {
            var date = new DateTime();
            try
            {
                date = DateTime.ParseExact(command.CommandArgs[0], "yyyy-MM-ddTHH:mm:ss",
                    CultureInfo.InvariantCulture);
            }
            catch (FormatException e)
            {
                throw new FormatException("Invalid date format!");
            }
            

            // First command
            if ((command.CommandName == "AddEvent") && (command.CommandArgs.Length == 2))
            { 
                 date = DateTime.ParseExact(command.CommandArgs[0], "yyyy-MM-ddTHH:mm:ss",
                    CultureInfo.InvariantCulture);

                var newEvent = new EventHolder
                {
                    Date = date,
                    Title = command.CommandArgs[1],
                    Location = null,
                };

                this.eventManager.AddEvent(newEvent);

                return "Event added";
            }
            if ((command.CommandName == "AddEvent") && (command.CommandArgs.Length == 3))
            {
                date = DateTime.ParseExact(command.CommandArgs[0], "yyyy-MM-ddTHH:mm:ss",
                    CultureInfo.InvariantCulture);

                var newEvent = new EventHolder
                {
                    Date = date,
                    Title = command.CommandArgs[1],
                    Location = command.CommandArgs[2],
                };

                this.eventManager.AddEvent(newEvent);

                return "Event added";

            }
            // Second command
            if ((command.CommandName == "DeleteEvents") && (command.CommandArgs.Length == 1))
            {
                int eventsCount = this.eventManager.DeleteEventsByTitle(command.CommandArgs[0]);

                if (eventsCount == 0)
                {
                    return "No events found.";
                }

                return eventsCount + " events deleted";
            }
            // Third command
            if ((command.CommandName == "ListEvents") && (command.CommandArgs.Length == 2))
            {
                date = DateTime.ParseExact(command.CommandArgs[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var eventsCount = int.Parse(command.CommandArgs[1]);
                var events = this.eventManager.ListEvents(date, eventsCount).ToList();
                var outputResult = new StringBuilder();

                if (!events.Any())
                {
                    return "No events found";
                }

                foreach (var e in events)
                {
                    outputResult.AppendLine(e.ToString());
                }

                return outputResult.ToString().Trim();
            }

            throw new Exception("Invalid command!");
        }
    }
}
