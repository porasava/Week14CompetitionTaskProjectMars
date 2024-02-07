using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14CompetitionTaskProjectMars.Utilities;
using OpenQA.Selenium.DevTools;

namespace Week14CompetitionTaskProjectMars.Pages
{
    public class AccountProfileCertification
    {
        private readonly IWebDriver driver1;

        public AccountProfileCertification(IWebDriver driver)
        {
            driver1 = driver;
        }
        By certificationTab1 => By.XPath("//a[normalize-space()='Certifications']");
        private IWebElement certificationTab => driver1.FindElement(certificationTab1);
        By addNewcertification1 => By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']");
        private IWebElement addNewcertification => driver1.FindElement(addNewcertification1);
        private IWebElement certificationText => driver1.FindElement(By.XPath("//input[@name='certificationName']"));
        private IWebElement fromText => driver1.FindElement(By.XPath("//input[@name='certificationFrom']"));
        private IWebElement yearDropdown => driver1.FindElement(By.XPath("//select[@name='certificationYear']"));
        private IWebElement addCertification => driver1.FindElement(By.XPath("//input[@value='Add']"));
        By PopUp1 => By.XPath("/html/body/div[1]/div");
        private IWebElement PopUp => driver1.FindElement(PopUp1);
        private IWebElement editcertification =>driver1.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
        private IWebElement editCertificationUpdate => driver1.FindElement(By.XPath("//input[@value='Update']"));
        private IWebElement removeIcon11 => driver1.FindElement(By.XPath("//i[@class='remove icon']"));
        private IWebElement cancel => driver1.FindElement(By.XPath("//input[@value='Cancel']"));

        //AddANewCertification
        public void AddANewCertification(string certificateOrAward, string from, string year)
        {
            Wait.WaitForElementPresent(driver1, certificationTab1, 8);
            certificationTab.Click();
            // Thread.Sleep(1000);
            Wait.WaitForElementPresent(driver1, addNewcertification1, 8);
            addNewcertification.Click();
            certificationText.Clear();
            certificationText.SendKeys(certificateOrAward);
            fromText.Clear();
            fromText.SendKeys(from);
            yearDropdown.Click();
            yearDropdown.SendKeys(year);
            addCertification.Click();
        }

        //CertificationShouldBeAddSuccessfully
        public void CertificationShouldBeAddSuccessfully()
        {
            Thread.Sleep(500);
            Wait.WaitForElementPresent(driver1, PopUp1, 8);
            IWebElement Popup = driver1.FindElement(PopUp1);
            string actualMessage = Popup.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "has been added to your certification";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
            $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //DeleteCertification
        public void DeleteCertification(string certificationDelete)
        {
            Thread.Sleep(500);
            string certificationToRemove = certificationDelete;
            // Find the table row that contains the specified 
            IWebElement rowContainingCertification = driver1.FindElement(By.XPath($"//td[normalize-space()='{certificationToRemove}']"));
            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingCertification.FindElement(By.XPath("//i[@class='remove icon']"));
            // Click the "Remove" icon
            removeIcon.Click();

        }

        //DeleteAEducation
        public void DeleteACertificationNoCheck()
        {
            Thread.Sleep(500);
            removeIcon11.Click();

        }

        //CancelUpdate
        public void CancelACertification()
        {
            Thread.Sleep(500);
            cancel.Click();

        }

        //CertificationShouldDeleteSuccessfully
        public void CertificationShouldDeleteSuccessfully()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, PopUp1, 8);
            IWebElement deleteError = driver1.FindElement(PopUp1);
            string actualMessage = deleteError.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "has been deleted from your certification";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
            $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }


        //ErrorPleaseEnterCertificationNameCertificationFromAndCertificationYear
        public void ErrorPleaseEnterCertificationNameCertificationFromAndCertificationYear()
        {
            Wait.ElementIsVisible(driver1, PopUp1, 8);
            IWebElement PopupError = driver1.FindElement(PopUp1);
            string actualMessage = PopupError.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "Please enter Certification Name, Certification From and Certification Year";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //EditACertification
        public void EditACertification( string certificateOrAwardEdit, string fromEdit, string yearEdit)
        {
            Wait.WaitForElementPresent(driver1, certificationTab1, 8);
            certificationTab.Click();
            Thread.Sleep(500);
            editcertification.Click();
            certificationText.Clear();
            certificationText.SendKeys(certificateOrAwardEdit);
            fromText.Clear();
            fromText.SendKeys(fromEdit);           
            yearDropdown.Click();
            yearDropdown.SendKeys(yearEdit);
            editCertificationUpdate.Click();
        }

        //CertificationShouldBeEdit
        public void CertificationShouldBeEdit()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, PopUp1, 8);
            IWebElement PopupError = driver1.FindElement(PopUp1);
            string actualMessage = PopupError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "has been updated to your certification";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //This information is already exist.
        public void ThisInformationIsAlreadyExist()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, PopUp1, 8);
            IWebElement PopupError = driver1.FindElement(PopUp1);
            string actualMessage = PopupError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "This information is already exist";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }


        public bool IsDataPresent()
        {
            // Implement logic to check if data is present
            // For example, checking if a specific element or row exists
            try
            {
                Thread.Sleep(1000);
                driver1.FindElement(By.XPath("//i[@class='remove icon']"));
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public void DeleteData()
        {
            // Implement the logic to delete the data
            // For example, clicking a delete button
            removeIcon11.Click();
            // Add any additional waits or logic needed after deletion
        }

        //CheckExistingdata
        public void CheckExistingCertification()
        {
            Thread.Sleep(1000);
            // Loop until no more data is present
            while (IsDataPresent())
            {
                DeleteData();
            }
        }

        //GoToCertificationTab
        public void GoToCertificationTab()
        {
            Wait.WaitForElementPresent(driver1, certificationTab1, 8);
            certificationTab.Click();
            Thread.Sleep(500);
        }
    }
}
