using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarEvents
{
    public class EventsManager : IEventsManager
    {
        private readonly List<EventHolder> list = new List<EventHolder>();

        public void AddEvent(EventHolder e)
        {
            this.list.Add(e);
        }

        public int DeleteEventsByTitle(string title)
        {
            return this.list.RemoveAll(e => e.Title.ToLowerInvariant() == title.ToLowerInvariant());
        }

        public IEnumerable<EventHolder> ListEvents(DateTime date, int countOfEvents)
        {
            var events = (from e in this.list
                          where e.Date >= date
                          orderby e.Date, e.Title, e.Location
                          select e).Take(countOfEvents);

            return events;
        }
    }
}
