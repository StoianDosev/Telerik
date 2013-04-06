using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifineMobileDevice
{
    class GSM
    {
        // Defining fields with properties which cannot be modified after creating the instance
        public string manufacture { get; private set; } 
        public string model { get; private set; }
        public string owner { get; private set; }
        public double price { get; private set; }
        private static string iPhone4S;// static field 

        private List<Call> callHistory; // Creating field List to hold elements from class Call 

        public List<Call> CallHistory // public property for the List
        {
            get { return this.callHistory; }
        }

        public static string IPhone4S// static public property 
        {
            get { return iPhone4S; }
            set { IPhone4S = value; }
        }

        public GSM()
            : this("Samsung", "Galaxy S3", null, 0) // empty constructor 
        {
        }

        public GSM(string manufacture, string model, string owner, double price) // non-empty constructor
        {
            this.manufacture = manufacture;
            this.model = model;
            this.owner = owner;

            IsPriceCorrect(price);// Verifying the price.
            this.price = price;

            this.callHistory = new List<Call>();
        }

        public override string ToString() // Overriding ToString 
        {
            // This part contains the information for each GSM instances
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Manufactor: {0}, model: {1}, owner: {2}, price: ${3}.", manufacture, model, owner ?? "unknown", price);
            builder.AppendLine();

            // This part of the method manages the List of the Call instances: CallHistory
            int counter = 1;
            foreach (Call call in this.CallHistory)
            {
                builder.AppendFormat("Call number {0}: Call duration is {1} minutes, month is {2:00}, the date is {3:00} time is {4:F2}h, dialed phone: {5}.", counter, call.CallDuration, call.Date, call.Month, call.Time, call.DialedPhone);
                counter++;
                builder.AppendLine();
            }
            if (CallHistory.Count == 0)
            {
                builder.AppendFormat("Call history is empty.");
            }
                        
            return builder.ToString();
        }

        
        // These methods manage when we add, remove and clear the List of Call instances
        public void AddCalls(Call newCall)
        {
            this.CallHistory.Add(newCall);
        }

        public void RemoveCalls(Call newCall)
        {
            this.CallHistory.Remove(newCall);
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        // The method calculate the full price of all calls.
        public void TotalCallsPrice(GSM phone)
        {
            double price = 0;
            
            foreach (Call duration in CallHistory)
            {
                price += (double)duration.CallDuration * Call.PricePerMinute;
            }
            Console.WriteLine("The total price of all calls for phone {0} is ${1:F2}",phone.model,price);
        }

        // This method removes the Call instance with the biggest call duration.
        public void RemoveMaxDurationCall()
        {
            int current = 0;
            int maxDuration = 0;
            Call maxCall = new Call();
            for (int i = 0; i < CallHistory.Count; i++)
            {
                Call newCall = CallHistory[i];
                current = newCall.CallDuration;
                if (current >= maxDuration)
                {
                    maxDuration = current;
                    maxCall = newCall;
                }
            }
            CallHistory.Remove(maxCall);
            
        }

        // Method which verifies the price is not negative number.
        private void IsPriceCorrect(double price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("The price cannot be negative number!");
            }
        }
    }
}
