using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Selenuim')]")]
        private IWebElement viewpgeTitle { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(5) > td:nth-child(8) > div > button:nth-child(2) > i")]
        private IWebElement edit { get; set; }
        //
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]")]
        private IWebElement editTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[11]/div[1]/input[1]")]
        private IWebElement editnameSave { get; set; }


        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        internal ManageListings ListingsView()
        {
            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//a[contains(text(),'Manage Listings')]"), 3);
            manageListingsLink.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("(//i[@class='eye icon'])[1]"), 3);
            view.Click();
            String Titletext = viewpgeTitle.Text;
            Assert.That(Titletext, Is.EqualTo("Selenuim"), "Test passed");
            Console.WriteLine("Listing view Text Passed=" + Titletext);
            Thread.Sleep(1000);
            return new ManageListings();
        }

        internal void ListingsDelete()
        {
          
        
        }

        internal void Edit()
        {
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//a[contains(text(),'Manage Listings')]"), 3);
            manageListingsLink.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(5) > td:nth-child(8) > div > button:nth-child(2) > i"), 3);
            edit.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]"), 3);
            editTitle.Clear();
            editTitle.SendKeys("Codingclass");
            String uptitle = editTitle.Text;
            Console.WriteLine("update title printed" + uptitle);
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[11]/div[1]/input[1]"), 3);
            editnameSave.Click();

        }

    }
}
