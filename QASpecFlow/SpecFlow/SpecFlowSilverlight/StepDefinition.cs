
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.WebAii.Controls.Xaml;

namespace SpeckFlow
{
    [Binding]
    public class StepDefinition
    {
        public SilverlightApp slApp { get; set; }

        [Given(@"clean calculator")]
        public void GivenCleanCalculator()
        {
            Manager.Current.LaunchNewBrowser(BrowserType.InternetExplorer);
            Manager.Current.ActiveBrowser.NavigateTo("http://demos.telerik.com/silverlight/#Calculator/FirstLook");
            slApp = Manager.Current.ActiveBrowser.SilverlightApps()[0];
        }

        [When(@"I enter (.*)")]
        public void WhenIEnter(string digit)
        {
            //if the number is more than one digit we traverse the the string by char
            foreach (var symbol in digit)
            {
                string buttonName = "input" + symbol + "_Button";
                slApp.Find.ByName(buttonName).User.Click();
            }         
        }

        [When(@"I press multiplication")]
        public void WhenIPressMultiplication()
        {
            slApp.Find.ByName("Multiply_Button").User.Click();
        }

        [When(@"I press equal")]
        public void WhenIPressEqual()
        {
            slApp.Find.ByName("Equals_Button").User.Click();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string text)
        {
            var result = slApp.Find.ByName<TextBlock>("DisplayTextBox").Text;
            Assert.AreEqual(text, result.ToString());
        }

        [Then(@"multiplication works like this")]
        public void ThenMultiplicationWorksLikeThis(Table table)
        {
            foreach (var row in table.Rows)
            {
                WhenIEnter(row[0]);
                WhenIPressMultiplication();
                WhenIEnter(row[1]);
                WhenIPressEqual();
                ThenTheResultShouldBe(row[2]);
            }
        }

    }
}
