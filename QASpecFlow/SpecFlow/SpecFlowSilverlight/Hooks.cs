using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpeckFlow
{
    [Binding]
    public class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Manager myManager = new Manager(false);
            myManager.Settings.Web.EnableSilverlight = true;
            myManager.Settings.AnnotateExecution = true;
            myManager.Settings.ExecutionDelay = 500;
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
