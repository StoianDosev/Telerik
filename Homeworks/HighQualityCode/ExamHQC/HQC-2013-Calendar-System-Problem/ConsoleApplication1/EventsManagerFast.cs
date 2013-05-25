using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace CalendarEvents
{
    public class EventsManagerFast : IEventsManager
    {
        private readonly MultiDictionary<string, EventHolder> titleEventList = new MultiDictionary<string, EventHolder>(true);
        private readonly OrderedMultiDictionary<DateTime, EventHolder> dateEventList = new OrderedMultiDictionary<DateTime, EventHolder>(true);

        public void AddEvent(EventHolder e)
        {
            if (string.IsNullOrEmpty( e.Title)|| string.IsNullOrEmpty(e.Location))
            {
                throw new ArgumentNullException("The location and title cannot be null or empty.");
            }

            string eventTitle = e.Title.ToLowerInvariant();
            this.titleEventList.Add(eventTitle, e);
            this.dateEventList.Add(e.Date, e);
        }

        public int DeleteEventsByTitle(string title)
        {
            string searchedTitle = title.ToLowerInvariant();
            var listForDelete = this.titleEventList[searchedTitle];
            int deleteCount = listForDelete.Count;

            foreach (var item in listForDelete)
            {
                this.dateEventList.Remove(item.Date, item);
            }

            this.titleEventList.Remove(searchedTitle);

            return deleteCount;
        }

        public IEnumerable<EventHolder> ListEvents(DateTime date, int countEvents)
        {
            var listDateEvents =
                from e in this.dateEventList.RangeFrom(date, true).Values
                select e;
            var events = listDateEvents.Take(countEvents);

            return events;
        }

        public int Count
        {
            get
            {
                return this.titleEventList.KeyValuePairs.Count();
            }
        }
    }
}
