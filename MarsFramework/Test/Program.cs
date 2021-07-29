using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MarsFramework
{
    public class Program
    {

       
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            SignIn Sign;

            [Test]
            public void LoginintoMars()
            {



                Sign = new SignIn();
                Sign.LoginSteps();
               

            }

            [Test]
            public void ShareSkillPage()
            {
                Sign = new SignIn();
                Sign.LoginSteps();
                ShareSkill shareskillobj = new ShareSkill();
                shareskillobj.EnterShareSkill();

            }

            [Test]
            public void ManageListingView()
            {
                Sign = new SignIn();
                Sign.LoginSteps();
                ManageListings ManageListingsobj = new ManageListings();
                ManageListingsobj.ListingsView();
                ManageListingsobj.Edit();

            }
           


        }
    }
}