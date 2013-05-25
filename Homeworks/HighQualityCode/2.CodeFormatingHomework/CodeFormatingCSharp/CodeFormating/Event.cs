using System;
using System.Text;

namespace CodeFormating
{
    public class Event : IComparable
    {
        //fields
        private DateTime date;
        private string title;
        private string location;

        //constructor
        public Event(DateTime date, String title, String location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        //properties
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        //method which compares objects
        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.date.CompareTo(other.date);
            int byTitle = this.title.CompareTo(other.title);
            int byLocation = this.location.CompareTo(other.location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        //overriding Tostring method
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            builder.Append(" | " + title);
            
            if (location != null && location != "")
            {
                builder.Append(" | " + location);
            }
            return builder.ToString();
        }
    }
}