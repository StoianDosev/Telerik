using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifineMobileDevice
{
    class DifineMobileDevice
    {
        static void Main()
        {

            GSMTest test = new GSMTest();// Creating instance in for the test slass
            test.GSMMethod();// Calling the  non-static test method in the test class GSMTest
            GSMCallHistoryTest.TestCalls();// Calling static method in the test class GSMCallHistoryTest 

        }
    }
}
