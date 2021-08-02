using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Hourly basis service')]")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Online')]")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='End date']")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IWebElement Days { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div.two.wide.field > div > input[type=checkbox")]
        private IWebElement Sun { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(3) > div.two.wide.field > div > input[type=checkbox")]
        private IWebElement Mon { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(4) > div.two.wide.field > div > input[type=checkbox]")]
        private IWebElement Tue { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(5) > div.two.wide.field > div > input[type=checkbox]")]
        private IWebElement Wed { get; set; }





        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(6) > div.two.wide.field > div > input[type=checkbox]")]
        private IWebElement Thurs { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(7) > div.two.wide.field > div > input[type=checkbox]")]
        private IWebElement Fri { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(8) > div.two.wide.field > div > input[type=checkbox]")]
        private IWebElement Sat { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Start time']")]
        public IList<IWebElement> StartTime { get; set; }
        // private IWebElement StartTime { get; set; }
        //Storing start time


        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(2) > input[type=time]")]
        private IWebElement StartTimesun { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(3) > input[type=time]")]
        private IWebElement EndTimesun { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(3) > div:nth-child(2) > input[type=time]")]
        private IWebElement StartTimeMon { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(3) > div:nth-child(3) > input[type=time]")]
        private IWebElement EndTimeMon { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(4) > div:nth-child(2) > input[type=time]")]
        private IWebElement StartTimeTue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(4) > div:nth-child(3) > input[type=time]")]
        private IWebElement EndTimeTue { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(5) > div:nth-child(2) > input[type=time]")]
        private IWebElement StartTimeWed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(5) > div:nth-child(3) > input[type=time]")]
        private IWebElement EndTimeWed { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(6) > div:nth-child(2) > input[type=time]")]
        private IWebElement StartTimeThurs { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(6) > div:nth-child(3) > input[type=time]")]
        private IWebElement EndTimeThurs { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(7) > div:nth-child(2) > input[type=time]")]
        private IWebElement StartTimeFri { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(7) > div:nth-child(3) > input[type=time]")]
        private IWebElement EndTimeFri { get; set; }



        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(8) > div:nth-child(2) > input[type=time]")]
        private IWebElement StartTimeSat { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(8) > div:nth-child(3) > input[type=time]")]
        private IWebElement EndTimeSat { get; set; }





        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(2) > div > div:nth-child(1) > div > input[type=radio]")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }
        ////*[@id="service-listing-section"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input
        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }
          //Upload file
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(9) div.row div.twelve.wide.column div:nth-child(1) label.worksamples-file:nth-child(1) div.ui.grid span:nth-child(1) > i.huge.plus.circle.icon.padding-25")]
        private IWebElement workSampleupload { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement SaveShare { get; set; }


        internal void EnterShareSkill()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
          
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//a[contains(text(),'Share Skill')]"), 3);
            //Click on ShareSkill Button
            ShareSkillButton.Click();
            String Sskil = ShareSkillButton.Text;
            Console.WriteLine("Shareskill clicked"  +Sskil);
            Console.WriteLine("***************************************");

            //Enter the Title in textbox
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.Name("title"), 3);
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            String TitleIn = Title.Text;
            Console.WriteLine("Title printed" +TitleIn);
            Console.WriteLine("***************************************");


            //Enter the Description in textbox
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.Name("description"), 3);
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Description"));
            Assert.AreEqual(Description.GetAttribute("value"), "Selenuim expert with Java,csharp,python");
            String Descriptionentered = Description.Text;
            Console.WriteLine("Decription printed" +Descriptionentered);
            Console.WriteLine("***************************************");



            //Click on Category Dropdown
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.Name("categoryId"), 3);
            SelectElement Categorydd = new SelectElement(CategoryDropDown);
            Categorydd.SelectByText("Digital Marketing");


            Thread.Sleep(2000);
            //Click on SubCategory Dropdown
            SelectElement SubCategorydd = new SelectElement(SubCategoryDropDown);
            SubCategorydd.SelectByText("Video Marketing");



            //Enter Tag names in textbox
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"), 3);
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Tags"));
            Tags.Click();



            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver,By.XPath("//label[contains(text(),'Hourly basis service')]"),3);
            //Select the Service type
            ServiceTypeOptions.Click();

            Thread.Sleep(2000);
            //Select the Location Type
            LocationTypeOption.Click();


            //Click on Start Date dropdown
            Thread.Sleep(2000);
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Start date"));

            //Click on End date drop down
            Thread.Sleep(2000);
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));


            //Storing start time and end time
            Thread.Sleep(2000);
            StartTimesun.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            Thread.Sleep(2000);
            EndTimesun.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            Thread.Sleep(2000);
            StartTimeMon.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            Thread.Sleep(2000);
            EndTimeMon.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            Thread.Sleep(2000);

            StartTimeTue.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            Thread.Sleep(2000);
            EndTimeTue.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            Thread.Sleep(2000);

            StartTimeWed.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            Thread.Sleep(2000);
            EndTimeWed.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            Thread.Sleep(2000);

            StartTimeThurs.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            Thread.Sleep(2000);
            EndTimeThurs.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            Thread.Sleep(2000);

            StartTimeFri.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            Thread.Sleep(2000);
            EndTimeFri.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            Thread.Sleep(2000);

            StartTimeSat.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            Thread.Sleep(2000);
            EndTimeSat.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));


            //Storing the table of available days
            Console.WriteLine("***************************************");

            Thread.Sleep(2000);
            Sun.Click();
            Boolean S = Sun.Selected;
            Console.WriteLine("Sunday Select" + S);
            Thread.Sleep(2000);
            Mon.Click();
            Boolean M = Mon.Selected;
            Console.WriteLine("Monday Select" + M);
            Thread.Sleep(2000);
            Tue.Click();
            Boolean T = Tue.Selected;
            Console.WriteLine("Tueday Select" + T);
            Thread.Sleep(2000);
            Wed.Click();
            Boolean W = Wed.Selected;
            Console.WriteLine("Weday Select" + W);
            Thread.Sleep(4000);
            Thurs.Click();
            Boolean Thu = Thurs.Selected;
            Console.WriteLine("Thursday Select" + Thu);
            Thread.Sleep(2000);
            Fri.Click();
            Boolean F = Fri.Selected;
            Console.WriteLine("Friday Select" + F);
            Thread.Sleep(2000);
            Sat.Click();
            Boolean Sa = Sat.Selected;
            Console.WriteLine("Saturday Select" + Sa);
            Console.WriteLine("Successfully stored date");
            Console.WriteLine("**********************************");

            //Click on Skill Trade option
           // GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(2) > div > div:nth-child(1) > div > input[type=radio]"), 3);
            SkillTradeOption.Click();
            Boolean SkillTOption = SkillTradeOption.Enabled;
            Console.WriteLine("SKill trade sucessfully selected" + SkillTOption);
            Console.WriteLine("**********************************");
           
            //Enter Skill Exchange
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"), 2);
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchangetag"));
            SkillExchange.Click();
            Boolean SkillEX = SkillExchange.Displayed;
            Console.WriteLine("SKillExchange sucessfully displayed" + SkillEX);
            Console.WriteLine("**********************************");
            
              //upload file

            workSampleupload.Click();
            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("Open");
            autoit.Send(@"C:\Users\aswin\Desktop\interview preparation\tips.docx");
            Thread.Sleep(2000);
            autoit.Send("{ENTER }");
           
            //Click on Active/Hidden option
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']"), 2);
            ActiveOption.Click();
            Boolean ActOption = ActiveOption.Enabled;
            Console.WriteLine("Active option sucessfully selected" + ActOption);
            Console.WriteLine("**********************************");

            //Click on Save button
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//input[@value='Save']"), 2);
            SaveShare.Click();
            Thread.Sleep(1000);









        }

        internal void EditShareSkill()
        {
            
        }
    }
}
