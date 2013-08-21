using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.TestTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SpecFlowHTML
{
    [Binding]
    public class StepDefinition
    {
        public Manager MyManager { get; set; }

        public StepDefinition()
        {
            MyManager = Hooks.MyManager;
        }

        [Given(@"Clean order configuration")]
        public void GivenCleanOrderConfiguration()
        {
            MyManager.LaunchNewBrowser();
            MyManager.ActiveBrowser.NavigateTo("http://demos.telerik.com/aspnet-ajax/combobox/examples/overview/defaultcs.aspx");
            MyManager.ActiveBrowser.ClearCache(BrowserCacheType.Cookies);
        }

        [When(@"I enter product (.*)")]
        public void WhenIEnterProduct(string product)
        {
            var input = MyManager.ActiveBrowser.Find.ByExpression<HtmlInputText>("name=ctl00$ContentPlaceHolder1$RadComboBoxProduct");
            input.Text = string.Empty;
            input.Focus();
            MyManager.ActiveBrowser.Manager.Desktop.KeyBoard.TypeText(product, 100);
            MyManager.ActiveBrowser.Manager.Desktop.KeyBoard.KeyPress(Keys.Enter);
            MyManager.ActiveBrowser.RefreshDomTree();
            
        }

        [When(@"I enter regoin (.*)")]
        public void WhenIEnterRegoin(string regoin)
        {
            var input = MyManager.ActiveBrowser.Find.ByExpression<HtmlInputText>("name=ctl00$ContentPlaceHolder1$RadComboBoxRegion");
            input.Text = string.Empty;
            input.Focus();
            MyManager.ActiveBrowser.Manager.Desktop.KeyBoard.TypeText(regoin, 1);
            MyManager.ActiveBrowser.Manager.Desktop.KeyBoard.KeyPress(Keys.Enter);
            MyManager.ActiveBrowser.RefreshDomTree();
        }

        [When(@"I enter Dealer (.*)")]
        public void WhenIEnterDealer(string dealer)
        {
            var input = MyManager.ActiveBrowser.Find.ByExpression<HtmlInputText>("name=ctl00$ContentPlaceHolder1$RadComboBoxDealer");
            input.Focus();
            input.Text = string.Empty;
            MyManager.ActiveBrowser.Manager.Desktop.KeyBoard.TypeText(dealer, 1);
            MyManager.ActiveBrowser.Manager.Desktop.KeyBoard.KeyPress(Keys.Enter);
            MyManager.ActiveBrowser.RefreshDomTree();
        }

        [When(@"I enter Checkout")]
        public void WhenIEnterSubmit()
        {
            MyManager.ActiveBrowser.Find.ById<HtmlInputSubmit>("ctl00_ContentPlaceHolder1_CheckoutButton").Click();
        }

        [Then(@"result should contains (.*), (.*), (.*)")]
        public void ThenResultShouldContains(string expectedProduct, string expectedRegion, string expectedDealer)
        {
            HtmlFindExpression exp = new HtmlFindExpression("class=order-summary");
            HtmlTable table = MyManager.ActiveBrowser.Find.ByExpression<HtmlTable>(exp);

            HtmlTableRow productRow = table.Rows[0];
            var productCells = productRow.Cells;
            string productName = productCells[1].InnerText;
            Assert.AreEqual(expectedProduct.Trim(), productName);

            HtmlTableRow regionRow = table.Rows[1];
            var regionCells = regionRow.Cells;
            string regionName = regionCells[1].InnerText;
            Assert.AreEqual(expectedRegion.Trim(), regionName);

            HtmlTableRow dealerRow = table.Rows[2];
            var dealerCells = dealerRow.Cells;
            string dealerName = dealerCells[1].InnerText;
            Assert.AreEqual(expectedDealer.Trim(), dealerName);
        }

        [Then(@"execution uses that table")]
        public void ThenExecutionUsesThatTable(Table table)
        {
            foreach (var row in table.Rows)
            {
                WhenIEnterProduct(row["Product"]);
                WhenIEnterRegoin(row["Region"]);
                WhenIEnterDealer(row["Dealer"]);
                WhenIEnterSubmit();
                ThenResultShouldBeLikeThis(row["Result"]);
            }
        }

        [Then(@"result should be like this (.*)")]
        public void ThenResultShouldBeLikeThis(string result)
        {
            string[] arr = new string[3];
            arr = result.Split(',');
            ThenResultShouldContains(arr[0], arr[1], arr[2]);
        }
    }
}
