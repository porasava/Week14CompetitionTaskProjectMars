using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Week14CompetitionTaskProjectMars.Models;
using Week14CompetitionTaskProjectMars.Pages;
using Week14CompetitionTaskProjectMars.Utilities;

namespace Week14CompetitionTaskProjectMars.Steps
{
    public class StepLogin
    {
        private readonly IWebDriver driver1;
        private readonly LogInPage loginPageObj;

        public StepLogin(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new LogInPage(driver1);
        }

            public void Login(string username, string password)
        {
                loginPageObj.NavigateToSkillsWeb();
                loginPageObj.InputUsernameAndPassword(username,password);
                loginPageObj.ClickOnLogin();
           
        }
    }
}
