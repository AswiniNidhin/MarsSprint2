using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }


        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }
        #endregion

        internal void LoginSteps()
        {
            //Populate the excel data
              GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            GlobalDefinitions.driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

           
            //Finding the Sign Link
            SignIntab.Click();

            // Finding the Email Field
            Email.Clear();
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));


            //Finding the Password Field
            Password.Clear();
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));
           

            //Finding the Login Button
            LoginBtn.Click();


        }
    }
}