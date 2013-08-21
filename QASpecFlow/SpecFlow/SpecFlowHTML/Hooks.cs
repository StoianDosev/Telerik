using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowHTML
{
    [Binding]
    public static class Hooks
    {
        public static Manager MyManager { get; set; }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Settings mySettings = new Settings();
            mySettings.Web.DefaultBrowser = BrowserType.InternetExplorer;
            mySettings.AnnotateExecution = true;
            mySettings.ExecutionDelay = 0;
            MyManager = new Manager(mySettings);
            MyManager.Start();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            if (Manager.Current != null)
            {
                Manager.Current.Dispose();
            }
        }
    }
}
