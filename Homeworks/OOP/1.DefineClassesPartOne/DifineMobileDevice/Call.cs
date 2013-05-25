using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifineMobileDevice
{
    class Call
    {
        public const double PricePerMinute = 0.34; // public constant field
        //private fields
        private int date;
        private int month;
        private double time;
        private double dialedPhone;
        private int callDuration;

        public Call()
            : this(1, 1, 0, 0, 0) // empty constructor
        {
        }

        // non-empty constructor with verification of the input format.
        public Call(int date, int month, double time, double dialedPhone, int callDuration) 
        {
            IsDateCorrect(date);
            this.date = date;

            IsMonthCorrect(month);
            this.month = month;

            IsTimeCorrect(time);
            this.time = time;

            this.dialedPhone = dialedPhone;
            this.callDuration = callDuration;

        }

        // public properties of the private fields which are changeable
        public int Date
        {
            get { return this.date; }
            set
            {
                this.date = value;
                IsDateCorrect(this.date);
            }
        }
        public double Time
        {
            get { return this.time; }
            set
            {
                this.time = value;
                IsTimeCorrect(this.time);
            }
        }
        public int Month
        {
            get { return this.month; }
            set
            {
                this.month = value;
                IsMonthCorrect(this.month);
            }
        }
        public double DialedPhone
        {
            get { return this.dialedPhone; }
            set { this.dialedPhone = value; }
        }
        public int CallDuration
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }
        

        // Overriding Tostring
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("The Call duration is {0} minutes,the month is {1:00} date is {2:00}, time is {3:F2}h, dialed phone: {4}.", CallDuration, Month, Date, Time, DialedPhone);

            return builder.ToString();
        }

        // Creating methods which checking the correct format of the date, month and time.
        private void IsDateCorrect(int date)
        {
            if (date < 0 || date > 31)
            {
                throw new IndexOutOfRangeException("The date format is not correct.");
            }
        }
        private void IsMonthCorrect(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new IndexOutOfRangeException("The month format is not correct.");
            }
        }
        private void IsTimeCorrect(double time)
        {
            if (time < 0 || time > 24)
            {
                throw new IndexOutOfRangeException("The time format is not correct.");
            }
        }
        

    }

}
