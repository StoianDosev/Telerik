using System;

namespace CalendarEvents
{
    public class EventHolder : IComparable<EventHolder>
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            string form = "{0:yyyy-MM-ddTH:mm:ss} | {1}";
            if (this.Location != null)
            {
                form += " | {2}";
            }
            string eventAsString = string.Format(form, this.Date, this.Title, this.Location);
            return eventAsString;
        }

        public int CompareTo(EventHolder otherEvent)
        {
            int result = DateTime.Compare(this.Date, otherEvent.Date);

            if (result == 0)
            {
                result = string.Compare(this.Title, otherEvent.Title, StringComparison.InvariantCultureIgnoreCase);
                result = string.Compare(this.Location, otherEvent.Location, StringComparison.InvariantCultureIgnoreCase);
            }

            return result;
        }
    }
}
