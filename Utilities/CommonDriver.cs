using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14CompetitionTaskProjectMars.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver CreateNewDriver()
        {

            return new ChromeDriver();
        }

        public static void CloseDriver(IWebDriver driver1)
        {
            if (driver1 != null)
            {
                driver1.Quit();
                driver1 = null;
            }
        }
    }


}
