using System;

namespace CalendarEvents
{
    class MainClass
    {
        public static void Main()
        {
            var eventManger = new EventsManager();
            var executor = new CommandExecutor(eventManger);

            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput == "End" || commandInput == null)
                {
                    return;
                }
                try
                {
                    // The sequence of commands is finished
                    Console.WriteLine(executor.ProcessCommand(Command.Parse(commandInput)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

    //public class Command
    //{
    //    public string CommandName { get; set; }
    //    public string[] CommandArgs { get; set; }

    //    public static Command ReadCommand(string inputCommand)
    //    {
    //        int j = inputCommand.IndexOf(' ');
    //        if (j == -1)
    //        {
    //            throw new Exception("Invalid command: " + inputCommand);
    //        }

    //        string commandName = inputCommand.Substring(0, j);
    //        string commandArgument = inputCommand.Substring(j + 1);

    //        var arguments = commandArgument.Split('|');
    //        for (int i = 0; i < arguments.Length; i++)
    //        {
    //            commandArgument = arguments[i];
    //            arguments[i] = commandArgument.Trim();
    //        }

    //        var command = new Command { CommandName = commandName, CommandArgs = arguments };
    //        return command;
    //    }
    //}

    //public class EventsManagerFast : IEventsManager
    //{
    //    private readonly MultiDictionary<string, EventHolder> titleEventList = new MultiDictionary<string, EventHolder>(true);
    //    private readonly OrderedMultiDictionary<DateTime, EventHolder> dateEventList = new OrderedMultiDictionary<DateTime, EventHolder>(true);

    //    public void AddEvent(EventHolder e)
    //    {
    //        string eventTitle = e.Title.ToLowerInvariant();
    //        this.titleEventList.Add(eventTitle, e);
    //        this.dateEventList.Add(e.date, e);
    //    }
    //    public int DeleteEventsByTitle(string title)
    //    {
    //        string searchedTitle = title.ToLowerInvariant();
    //        var listForDelete = this.titleEventList[searchedTitle];
    //        int deleteCount = listForDelete.Count;

    //        foreach (var item in listForDelete)
    //        {
    //            this.dateEventList.Remove(item.date, item);
    //        }

    //        this.titleEventList.Remove(searchedTitle);

    //        return deleteCount;
    //    }
    //    public IEnumerable<EventHolder> ListEvents(DateTime date, int countEvents)
    //    {
    //        var listDateEvents =
    //            from e in this.dateEventList.RangeFrom(date, true).Values
    //            select e;
    //        var events = listDateEvents.Take(countEvents);
    //        return events;
    //    }
    //}

    //public class EventsManager : IEventsManager
    //{
    //    private readonly List<EventHolder> list = new List<EventHolder>();
    //    public void AddEvent(EventHolder e)
    //    {
    //        this.list.Add(e);
    //    }

    //    public int DeleteEventsByTitle(string title)
    //    {
    //        return this.list.RemoveAll(e => e.Title.ToLowerInvariant() == title.ToLowerInvariant());
    //    }

    //    public IEnumerable<EventHolder> ListEvents(DateTime date, int countOfEvents)
    //    {
    //        var events = (from e in this.list
    //                           where e.date >= date
    //                           orderby e.date, e.Title, e.Location
    //                           select e).Take(countOfEvents);

    //        return events;
    //    }
    //}

    //public class EventHolder : IComparable<EventHolder>
    //{
    //    public DateTime date { get; set; }

    //    public string Title { get; set; }

    //    public string Location { get; set; }
    //    public override string ToString()
    //    {
    //        string form = "{0:yyyy-MM-ddTH:mm:ss} | {1}";
    //        if (this.Location != null)
    //        {
    //            form += " | {2}";
    //        }
    //        string eventAsString = string.Format(form, this.date, this.Title, this.Location);
    //        return eventAsString;
    //    }
    //    public int CompareTo(EventHolder otherEvent)
    //    {
    //        int result = DateTime.Compare(this.date, otherEvent.date);

    //        if (result == 0)
    //        {
    //            result = string.Compare(this.Title, otherEvent.Title, StringComparison.Ordinal);
    //            result = string.Compare(this.Location, otherEvent.Location, StringComparison.Ordinal);
    //        }

    //        return result;
    //    }
    //}

    //public class CommandExecutor
    //{
    //    private readonly IEventsManager eventManger;

    //    public CommandExecutor(IEventsManager eventManger)
    //    {
    //        this.eventManger = eventManger;
    //    }

    //    public IEventsManager EventsProcessor
    //    {
    //        get
    //        {
    //            return this.eventManger;
    //        }
    //    }

    //    public string ProcessCommand(Command command)
    //    {
    //        // First command
    //        if ((command.CommandName == "AddEvent") && (command.CommandArgs.Length == 2))
    //        {
    //            var date = DateTime.ParseExact(command.CommandArgs[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
    //            var newEvent = new EventHolder
    //                        {
    //                            date = date,
    //                            Title = command.CommandArgs[1],
    //                            Location = null,
    //                        };

    //            this.eventManger.AddEvent(newEvent);

    //            return "Event added";
    //        }
    //        if ((command.CommandName == "AddEvent") && (command.CommandArgs.Length == 3))
    //        {
    //            var date = DateTime.ParseExact(command.CommandArgs[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
    //            var newEvent = new EventHolder
    //                        {
    //                            date = date,
    //                            Title = command.CommandArgs[1],
    //                            Location = command.CommandArgs[2],
    //                        };

    //            this.eventManger.AddEvent(newEvent);

    //            return "Event added";

    //        }
    //        // Second command
    //        if ((command.CommandName == "DeleteEvents") && (command.CommandArgs.Length == 1))
    //        {
    //            int eventsCount = this.eventManger.DeleteEventsByTitle(command.CommandArgs[0]);

    //            if (eventsCount == 0)
    //            {
    //                return "No events found.";
    //            }

    //            return eventsCount + " events deleted";
    //        }
    //        // Third command
    //        if ((command.CommandName == "ListEvents") && (command.CommandArgs.Length == 2))
    //        {
    //            var date = DateTime.ParseExact(command.CommandArgs[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
    //            var eventsCount = int.Parse(command.CommandArgs[1]);
    //            var events = this.eventManger.ListEvents(date, eventsCount).ToList();
    //            var outputResult = new StringBuilder();

    //            if (!events.Any())
    //            {
    //                return "No events found";
    //            }

    //            foreach (var e in events)
    //            {
    //                outputResult.AppendLine(e.ToString());
    //            }

    //            return outputResult.ToString().Trim();
    //        }
    //        throw new Exception("Invalid command!");
    //    }
    //}
}





