using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Specflow
{
    [Binding]
    public class Hooks
    {

        private static string path = @"C:\Users\Stoyan\Desktop\Calculator.exe";

        [BeforeScenario]
        public void BeforeScenario()
        {
            Manager myManager = new Manager(false);

            // Set some delay just to see what is tested, otherwise it is too fast
            myManager.Settings.ExecutionDelay = 1000;
            myManager.Start();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (Manager.Current != null) 
            {
                Manager.Current.Dispose();
            }
        }
    }
}
