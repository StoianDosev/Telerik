using System;
using System.Text;

namespace CodeFormating
{
    public static class Messages
    {
        //field
        private static readonly StringBuilder output = new StringBuilder();

        //constructor
        public Messages()
        {
        }

        //property
        public static string Output
        {
            get
            {
                return output.ToString();
            }
        }

        public static void EventAdded()
        {
            output.Append("Event added" + Environment.NewLine);
        }

        public static void EventDeleted(int param)
        {
            if (param == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted{1}", param, Environment.NewLine);
            }
        }

        public static void NoEventsFound()
        {
            output.Append("No events found" + Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + Environment.NewLine);
            }
        }
    }
}