using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifineMobileDevice
{
    class GSMTest
    {
        // non-static method of the GSMTest class.
        public void GSMMethod()
        {
            //Creating instances of the GSM calss.
            GSM samsung = new GSM("Samsung", "Galaxy S4", "Sam", 100);
            GSM nokia = new GSM("Nokia", "Lumia 920", "Steven", 200);
            GSM HTC = new GSM("HTC", "One", "Bill", 300);

            //Creating array of elements from the instaces of the GSM class.
            GSM[] array = { samsung, nokia, HTC };

            //Method which prints the array.
            PrintArray(array);

            //Static instance of the GSM class.
            string iphnone = GSM.IPhone4S;
            Console.WriteLine(iphnone);

            //Creating instances of the Battery class.
            Battery bat = new Battery();
            Battery bat2 = new Battery(BatteryType.NiMH);
            Console.WriteLine(bat2);
            Console.WriteLine(bat);
            Console.WriteLine();
            
        }

        //Creatig method which can print the array of instances of GSM class.
        private void PrintArray(GSM[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
