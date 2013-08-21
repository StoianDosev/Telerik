using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Controls.Xaml.Wpf;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Specflow
{
    [Binding]
    public class StepDefinition
    {
        private static WpfWindow calc { get; set; }

        [Given(@"clean calculator")]
        public void GivenCleanCalculator()
        {
            WpfApplication wpfApp = Manager.Current.LaunchNewApplication(@"C:\Users\Stoyan\Desktop\Calculator.exe");
            calc = wpfApp.WaitForWindow("WPF Calculator");
        }

        [When(@"I enter (.*)")]
        public void WhenIEnterDigit(int digit)
        {
            var buttonName = "Button" + digit.ToString();
            var b = calc.Find.ByName<Button>("Button1");
            calc.Find.ByName<Button>(buttonName).User.Click();
        }

        [When(@"I press plus")]
        public void WhenIPressAdd()
        {
            calc.Find.ByName<Button>("ButtonPlus").User.Click();
        }

        [When(@"I press equal")]
        public void WhenIPressEqual()
        {
            calc.Find.ByName<Button>("ButtonEqual").User.Click();
        }

        [Then(@"result should be (.*)")]
        public void ThenResultShouldBe(string result)
        {
            // Refresh 
            calc.RefreshVisualTrees();

            // Get result string
            var actual = calc.Find.ByName<TextBlock>("DisplayBox").TextLiteralContent;

            // Verify result is corrent
            Assert.AreEqual(result, actual, "Sum does not work correct!");
        }

        [Then(@"sum of two digits works like this:")]
        public void ThenSumOfTwoDigitsWorksLikeThis(Table table)
        {
            foreach (var row in table.Rows) 
            {
                WhenIEnterDigit(int.Parse(row[0]));
                WhenIPressAdd();
                WhenIEnterDigit(int.Parse(row[1]));
                WhenIPressEqual();

                ThenResultShouldBe((row[2]));
            }
        }

    }
}
