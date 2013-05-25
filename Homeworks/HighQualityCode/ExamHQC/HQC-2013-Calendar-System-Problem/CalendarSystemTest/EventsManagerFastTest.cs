using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarEvents;
using System.Globalization;
using System.Collections.Generic;

namespace CalendarSystemTest
{
    [TestClass]
    public class EventsManagerFastTest
    {
        //Add method tests
        [TestMethod]
        public void AddSingleEventTest()
        {
            EventHolder evHolder = new EventHolder();
            evHolder.Title = "party";
            evHolder.Location = "BIAD";
            DateTime date = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolder.Date = date;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolder);

            int expectedCount = 1;
            Assert.AreEqual(expectedCount, evManager.Count);
        }

        [TestMethod]
        public void AddTwoEventsTest()
        {
            EventHolder evHolderFirst = new EventHolder();
            evHolderFirst.Title = "party";
            evHolderFirst.Location = "BIAD";
            DateTime dateFirst = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderFirst.Date = dateFirst;

            EventHolder evHolderSecond = new EventHolder();
            evHolderSecond.Title = "Mega party";
            evHolderSecond.Location = "Coco Bongo";
            DateTime dateSecond = DateTime.ParseExact("2013-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderSecond.Date = dateSecond;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolderFirst);
            evManager.AddEvent(evHolderSecond);

            int expectedCount = 2;
            Assert.AreEqual(expectedCount, evManager.Count);
        }

        [TestMethod]
        public void Add100EventsTest()
        {
            EventHolder evHolder = new EventHolder();
            evHolder.Title = "party";
            evHolder.Location = "BIAD";
            DateTime date = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolder.Date = date;

            EventsManagerFast evManager = new EventsManagerFast();
            int length = 100;
            for (int i = 0; i < length; i++)
            {
                evManager.AddEvent(evHolder);
            }

            int expectedCount = 100;
            Assert.AreEqual(expectedCount, evManager.Count);
        }

        [TestMethod]
        [ExpectedException ( typeof(ArgumentNullException))]
        public void AddIncorrectEventTest()
        {
            EventHolder evHolder = new EventHolder();
            evHolder.Title = null;
            evHolder.Location = null;
            DateTime date = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolder.Date = date;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolder);

            int expectedCount = 1;
            Assert.AreEqual(expectedCount, evManager.Count);
        }

        //DeleteEventByTitle method tests
        [TestMethod]
        public void DeleteEventByTitleOneItemTest()
        {
            EventHolder evHolderFirst = new EventHolder();
            evHolderFirst.Title = "party";
            evHolderFirst.Location = "BIAD";
            DateTime dateFirst = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderFirst.Date = dateFirst;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolderFirst);
            string title = "party";
            evManager.DeleteEventsByTitle(title);

            int expectedCount = 0;
            Assert.AreEqual(expectedCount, evManager.Count);
        }

        [TestMethod]
        public void DeleteEventByTitleMultipleDifferentTitleItemsTest()
        {
            EventHolder evHolderFirst = new EventHolder();
            evHolderFirst.Title = "party";
            evHolderFirst.Location = "BIAD";
            DateTime dateFirst = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderFirst.Date = dateFirst;

            EventHolder evHolderSecond = new EventHolder();
            evHolderSecond.Title = "Mega party";
            evHolderSecond.Location = "Coco Bongo";
            DateTime dateSecond = DateTime.ParseExact("2013-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderSecond.Date = dateSecond;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolderFirst);
            evManager.AddEvent(evHolderSecond);
            string titleFirst = "party";
            string titleSecond = "Mega party";
            evManager.DeleteEventsByTitle(titleFirst);
            evManager.DeleteEventsByTitle(titleSecond);

            int expectedCount = 0;
            Assert.AreEqual(expectedCount, evManager.Count);
        }

        [TestMethod]
        public void DeleteEventsByTitleMultipleEqualTitleItemsTest()
        {
            EventHolder evHolderFirst = new EventHolder();
            evHolderFirst.Title = "Mega party";
            evHolderFirst.Location = "BIAD";
            DateTime dateFirst = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderFirst.Date = dateFirst;

            EventHolder evHolderSecond = new EventHolder();
            evHolderSecond.Title = "Mega party";
            evHolderSecond.Location = "Coco Bongo";
            DateTime dateSecond = DateTime.ParseExact("2013-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderSecond.Date = dateSecond;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolderFirst);
            evManager.AddEvent(evHolderSecond);
            
            string title = "Mega party";
            evManager.DeleteEventsByTitle(title);

            int expectedCount = 0;
            Assert.AreEqual(expectedCount, evManager.Count);
        }

        [TestMethod]
        public void DeleteEventByTitleNoneExistingItemTest()
        {
            EventHolder evHolderFirst = new EventHolder();
            evHolderFirst.Title = "party";
            evHolderFirst.Location = "BIAD";
            DateTime dateFirst = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderFirst.Date = dateFirst;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolderFirst);
            string title = "Mage party";
            evManager.DeleteEventsByTitle(title);

            int expected = 1;
            Assert.AreEqual(expected, evManager.Count);
        }

        //ListItem method test
        [TestMethod]
        public void ListEventsWithOneItemTest()
        {
            EventHolder evHolderFirst = new EventHolder();
            evHolderFirst.Title = "party";
            evHolderFirst.Location = "BIAD";
            DateTime dateFirst = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderFirst.Date = dateFirst;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolderFirst);
            var result = evManager.ListEvents(dateFirst, 1);

            string expected = "2012-01-21T20:00:00 | party | BIAD";

            List<string> resultEvManager = new List<string>();

            foreach (var item in result)
            {
               resultEvManager.Add(item.ToString());
            }

            Assert.AreEqual(expected,resultEvManager[0] );
        }

        [TestMethod]
        public void ListEventsWithMultipleDifferentDatesTest()
        {
            EventHolder evHolderFirst = new EventHolder();
            evHolderFirst.Title = "party";
            evHolderFirst.Location = "BIAD";
            DateTime dateFirst = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderFirst.Date = dateFirst;

            EventHolder evHolderSecond = new EventHolder();
            evHolderSecond.Title = "Mega party";
            evHolderSecond.Location = "Coco bongo";
            DateTime dateSecond = DateTime.ParseExact("2012-11-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderSecond.Date = dateSecond;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolderFirst);
            evManager.AddEvent(evHolderSecond);
            var result = evManager.ListEvents(dateFirst, 2);

            string expected1 = "2012-01-21T20:00:00 | party | BIAD";
            string expected2 = "2012-11-21T20:00:00 | Mega party | Coco bongo";

            List<string> resultEvManager = new List<string>();

            foreach (var item in result)
            {
                resultEvManager.Add(item.ToString());
            }

            Assert.AreEqual(expected1, resultEvManager[0]);
            Assert.AreEqual(expected2, resultEvManager[1]);
        }

        [TestMethod]
        public void ListEventsWithMultipleEqualDatesTest()
        {
            EventHolder evHolderFirst = new EventHolder();
            evHolderFirst.Title = "party";
            evHolderFirst.Location = "BIAD";
            DateTime dateFirst = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderFirst.Date = dateFirst;

            EventHolder evHolderSecond = new EventHolder();
            evHolderSecond.Title = "Mega party";
            evHolderSecond.Location = "Coco bongo";
            DateTime dateSecond = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderSecond.Date = dateSecond;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolderFirst);
            evManager.AddEvent(evHolderSecond);
            var result = evManager.ListEvents(dateFirst, 2);

            string expected1 = "2012-01-21T20:00:00 | party | BIAD";
            string expected2 = "2012-01-21T20:00:00 | Mega party | Coco bongo";

            List<string> resultEvManager = new List<string>();

            foreach (var item in result)
            {
                resultEvManager.Add(item.ToString());
            }

            Assert.AreEqual(expected1, resultEvManager[0]);
            Assert.AreEqual(expected2, resultEvManager[1]);
        }

        [TestMethod]
        public void ListEventsInvalidCountTest()
        {
            EventHolder evHolderFirst = new EventHolder();
            evHolderFirst.Title = "party";
            evHolderFirst.Location = "BIAD";
            DateTime dateFirst = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderFirst.Date = dateFirst;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolderFirst);
            
            var result = evManager.ListEvents(dateFirst, 2);

            string expected1 = "2012-01-21T20:00:00 | party | BIAD";
           

            List<string> resultEvManager = new List<string>();

            foreach (var item in result)
            {
                resultEvManager.Add(item.ToString());
            }

            int expectedCount = 1;

            Assert.AreEqual(expected1, resultEvManager[0]);
            Assert.AreEqual(expectedCount, resultEvManager.Count);
        }

       
        public void ListEventsSortedTest()
        {
            EventHolder evHolderFirst = new EventHolder();
            evHolderFirst.Title = "party";
            evHolderFirst.Location = "BIAD";
            DateTime dateFirst = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderFirst.Date = dateFirst;

            EventHolder evHolderSecond = new EventHolder();
            evHolderSecond.Title = "Mega party";
            evHolderSecond.Location = "Coco bongo";
            DateTime dateSecond = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            evHolderSecond.Date = dateSecond;

            EventsManagerFast evManager = new EventsManagerFast();
            evManager.AddEvent(evHolderFirst);
            evManager.AddEvent(evHolderSecond);
            var result = evManager.ListEvents(dateFirst, 2);

            string expected1 = "2012-01-21T20:00:00 | party | BIAD";
            string expected2 = "2012-01-21T20:00:00 | Mega party | Coco bongo";

            List<string> resultEvManager = new List<string>();

            foreach (var item in result)
            {
                resultEvManager.Add(item.ToString());
            }

            Assert.AreEqual(expected1, resultEvManager[1]);
            Assert.AreEqual(expected2, resultEvManager[0]);
        }
    }
}
