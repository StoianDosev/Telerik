using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifineMobileDevice
{
    public enum BatteryType // Creating enum class to hold constants of the battery types
    {
        LiIon, LiAir, NiMH, NiCd, NiHydr, NiZinc, ZiBr, PolymerBased,
    }
    class Battery
    {
        //fields of the Battery class
        private BatteryType bateryType;
        private string model;
        private double idleHours;
        private double speakHours;

        public Battery(BatteryType battery) // constructor only for battery type
        {
            this.bateryType = battery;
        }
        public Battery()
            : this(null, 0, 0, 0) // empty constructor for other fields
        {
        }

        public Battery(string model, double idleHours, double speakHours, BatteryType battery) // non-empty constructor with verification of the data. 
        {
            this.model = model;

            IsHoursCorrect(idleHours);//Checking the input is not negative number.
            this.idleHours = idleHours;

            IsHoursCorrect(speakHours);//Checking the input is not negative number.
            this.speakHours = speakHours;
            this.bateryType = battery;
        }

        public BatteryType battery // public property for the battery type
        {
            get { return this.bateryType; }
        }

        // public properties for other fields which are changeable
        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public double IdleHours
        {
            get { return this.idleHours; }
            private set
            {
                this.idleHours = value;
                IsHoursCorrect(this.idleHours); //Checking the input is not negative number.
            }
        }
        public double SpeakHours
        {
            get { return this.speakHours; }
            private set
            {
                this.speakHours = value;
                IsHoursCorrect(this.speakHours); //Checking the input is not negative number.
            }
        }

        public override string ToString()//Overrriding Tostring.
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Battery type: {0}, model: {1}, standby hours: {2}, speaking hours: {3}", battery, model ?? "unknown", idleHours, speakHours);
            return builder.ToString();
        }

        private void IsHoursCorrect(double hours) // Creating method which confirms the input from the instnce.
        {
            if (hours < 0)
            {
                throw new ArgumentOutOfRangeException("The hours cannot be negative number.");
            }
        }
    }
}
