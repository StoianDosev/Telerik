using System;
using System.Collections.Generic;

namespace CalendarEvents
{
    public interface IEventsManager
    {
        /// <summary>
        /// The method adds new EventHolder instance to a ditionary
        /// </summary>
        /// <param name="eventHolder">EventHolder instance</param>
        void AddEvent(EventHolder eventHolder);

        /// <summary>
        /// The method deletes events by thier title. Can delete multuple events if they are with the same name.
        /// </summary>
        /// <param name="titleForDelete">title</param>
        /// <returns>Returns the deleted count of elements</returns>
        int DeleteEventsByTitle(string titleForDelete);

        /// <summary>
        /// The method returns list of events selected by date and count
        /// </summary>
        /// <param name="date">date</param>
        /// <param name="count">count</param>
        /// <returns>List of event elements</returns>
        IEnumerable<EventHolder> ListEvents(DateTime date, int count);
    }
}
