using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifineMobileDevice
{
    class GSMCallHistoryTest
    {
        public static void TestCalls() // Static method of the test class GSMCallHistoryTest.
        {
            //Instances of the GSM class.
            GSM HTC = new GSM("HTC", "DNA", "Dobri", 1099);
            GSM Nokia = new GSM("Nokia", "Lumia 808", "Mariika", 1500);

            //instances of the Call class.
            Call firstCall = new Call(12,02, 15.30, 09898893898, 25);
            Call secondCall = new Call(7,11, 20.55, 09855889898, 45);
            Call thirdCall = new Call(5,1, 12.20, 09854562355, 305);
            

            HTC.AddCalls(firstCall); //Adding some calls to GSM instance HTC
            HTC.AddCalls(secondCall);
            HTC.AddCalls(thirdCall);
            HTC.TotalCallsPrice(HTC);// Calculating and printing the total prize.
            HTC.RemoveMaxDurationCall();// Removing the max-lenght call.
            HTC.TotalCallsPrice(HTC);
            Console.WriteLine(HTC);

            Nokia.AddCalls(firstCall); //Adding some calls to GSM Nokia
            Nokia.AddCalls(thirdCall);
            Nokia.TotalCallsPrice(Nokia);// Calculating and printing the total prize.
            Nokia.RemoveMaxDurationCall(); // Removing the max-lenght call.
            Nokia.TotalCallsPrice(Nokia);
            Console.WriteLine(Nokia);

            //Clearing the history 
            HTC.ClearHistory();
            Nokia.ClearHistory();
            Console.WriteLine(HTC);
            Console.WriteLine(Nokia);


            
        }

    }
}
