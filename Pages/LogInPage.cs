using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14CompetitionTaskProjectMars.Models;
using Week14CompetitionTaskProjectMars.Utilities;

namespace Week14CompetitionTaskProjectMars.Pages
{
    public class LogInPage
    {
        private readonly IWebDriver driver1;

        public LogInPage(IWebDriver driver)
        {
            driver1 = driver;
        }

        By loginButton1 => By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a");
        private IWebElement loginButton => driver1.FindElement(loginButton1);
        private IWebElement usernameTextbox => driver1.FindElement(By.XPath("//input[@placeholder='Email address']"));
        private IWebElement passwordTextbox => driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private IWebElement loginButtonPopUp => driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement AccountProfilePage => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/a"));
        public void NavigateToSkillsWeb()
        {
            driver1.Manage().Window.Maximize();
            //Lunch TurnUp Portal and navigate to the website login page
            driver1.Navigate().GoToUrl("http://localhost:5001/Home");
        }

        public void InputUsernameAndPassword(string username, string password)
        {
            Wait.WaitForElementPresent(driver1, loginButton1, 8);
            // click SIgnIn button
            loginButton.Click();
            usernameTextbox.SendKeys(username);
            passwordTextbox.SendKeys(password);
        }

        public void ClickOnLogin()
        {
            loginButtonPopUp.Click();
        }

        public void GoToAccountProfilePage()
        {
            Assert.That(AccountProfilePage.Text == "Mars Logo", "text is not show. It should show 'Mars Logo'");
        }


    }
}
