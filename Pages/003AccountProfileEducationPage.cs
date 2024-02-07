using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14CompetitionTaskProjectMars.Utilities;

namespace Week14CompetitionTaskProjectMars.Pages
{
    public class AccountProfileEducation
    {
        private readonly IWebDriver driver1;


        public AccountProfileEducation(IWebDriver driver)
        {
            driver1 = driver;
        }
        By educationTab1 => By.XPath("//a[normalize-space()='Education']");
        private IWebElement educationTab => driver1.FindElement(educationTab1);
        By addNewEducation1 => By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']");
        private IWebElement addNewEducation => driver1.FindElement(addNewEducation1);
        private IWebElement university => driver1.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
        private IWebElement countryDropdown => driver1.FindElement(By.XPath("//select[@name='country']"));
        private IWebElement titleDropdown => driver1.FindElement(By.XPath("//select[@name='title']"));
        private IWebElement degreeText => driver1.FindElement(By.XPath("//input[@name='degree']"));
        private IWebElement yearDropdown => driver1.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
        private IWebElement addEducation => driver1.FindElement(By.XPath("//div[@class='sixteen wide field']//input[@value='Add']"));
        By PopUp1 => By.XPath("/html/body/div[1]/div");
        private IWebElement PopUp => driver1.FindElement(PopUp1);
        private IWebElement editEducation => driver1.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
        private IWebElement educationUpdate => driver1.FindElement(By.XPath("//input[@value = 'Update']"));
        private IWebElement educationCancel => driver1.FindElement(By.XPath("//input[@value='Cancel']"));
        private IWebElement removeIcon => driver1.FindElement(By.XPath("//i[@class='remove icon']"));
        private IWebElement cancel => driver1.FindElement(By.XPath("//input[@value='Cancel']"));




        //AddANewEducation
        public void AddANewEducation(string universityName, string country, string title, string degree, string yearOfGraduate)
        {

            Wait.WaitForElementPresent(driver1, educationTab1, 8);
            educationTab.Click();
            Thread.Sleep(1000);
            Wait.WaitForElementPresent(driver1, addNewEducation1, 8);
            addNewEducation.Click();
            university.Clear();
            university.SendKeys(universityName);
            countryDropdown.Click();
            countryDropdown.SendKeys(country);
            titleDropdown.Click();
            titleDropdown.SendKeys(title);
            degreeText.Clear();
            degreeText.SendKeys(degree);
            yearDropdown.Click();
            yearDropdown.SendKeys(yearOfGraduate);
            addEducation.Click();
        }

        //EducationShouldBeAddSuccessfully
        public void EducationShouldBeAddSuccessfully()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, PopUp1, 8);
            string actualMessage = PopUp.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "Education has been added";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }


        //DeleteAEducation
        public void DeleteAEducation(string universityNameDelete)
        {
            Thread.Sleep(500);
            string educationToRemove = universityNameDelete; // Replace with the language name based on user input

            // Find the table row that contains the specified 
            IWebElement rowContainingEducation = driver1.FindElement(By.XPath($"//table/tbody/tr[td[contains(text(), '{educationToRemove}')]]"));
            Thread.Sleep(500);
            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingEducation.FindElement(By.XPath("//i[@class='remove icon']"));

            // Click the "Remove" icon
            removeIcon.Click();

        }

        //DeleteAEducation
        public void DeleteAEducationNoCheck()
        {
            Thread.Sleep(500);
            removeIcon.Click();

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
            removeIcon.Click();
        }

        //CheckExistingdata
        public void CheckExistingEducation()
        {
            Thread.Sleep(1000);
            // Loop until no more data is present
            while (IsDataPresent())
            {
                DeleteData();
            }
        }

        //CancelAEducation
        public void CancelAEducation()
        {

            cancel.Click();

        }

        //ClearAEducationUniversity
        public void ClearAEducationUniversity()
        {

            university.Clear();

        }

        //EducationShouldDeleteSuccessfully
        public void EducationShouldDeleteSuccessfully()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, PopUp1, 8);
            string actualMessage = PopUp.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "Education entry successfully removed";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //EducationErrorPleaseEnterAllTheFields
        public void EducationErrorPleaseEnterAllTheFields()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, PopUp1, 8);
            string actualMessage = PopUp.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "Please enter all the fields";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //EducationErrorThisInformationIsAlreadyExist.
        public void EducationErrorThisInformationIsAlreadyExist()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, PopUp1, 8);
            string actualMessage = PopUp.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "This information is already exist";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //EditEducation
        public void EditEducation(string universityNameEdit, string countryEdit, string titleEdit, string degreeEdit, string yearOfGraduateEdit)
        {
            Wait.ElementIsVisible(driver1, educationTab1, 8);
            educationTab.Click();
            Thread.Sleep(500);
            editEducation.Click();
            AddANewEducation(universityNameEdit, countryEdit, titleEdit, degreeEdit, yearOfGraduateEdit);
            educationUpdate.Click();
        }

        //EditEducationDown
        public void EditEducationDown(string universityNameEdit, string countryEdit, string titleEdit, string degreeEdit, string yearOfGraduateEdit)
        {
            Wait.ElementIsVisible(driver1, educationTab1, 8);
            educationTab.Click();
            Thread.Sleep(500);
            editEducation.Click();
            university.Clear();
            university.SendKeys(universityNameEdit);
            countryDropdown.Click();
            countryDropdown.SendKeys(countryEdit);
            titleDropdown.Click();
            titleDropdown.SendKeys(titleEdit);
            degreeText.Clear();
            degreeText.SendKeys(degreeEdit);
            yearDropdown.Click();
            yearDropdown.SendKeys(yearOfGraduateEdit);
            educationUpdate.Click();
        }

        //AddANewEducationCancel
        public void AddANewEducationCancel(string universityName, string country, string title, string degree, string yearOfGraduate)
        {

            Wait.WaitForElementPresent(driver1, educationTab1, 8);
            educationTab.Click();
            Thread.Sleep(500);
            Wait.WaitForElementPresent(driver1, addNewEducation1, 8);
            addNewEducation.Click();
            university.Clear();
            university.SendKeys(universityName);
            countryDropdown.Click();
            countryDropdown.SendKeys(country);
            titleDropdown.Click();
            titleDropdown.SendKeys(title);
            degreeText.Clear();
            degreeText.SendKeys(degree);
            yearDropdown.Click();
            yearDropdown.SendKeys(yearOfGraduate);
            educationCancel.Click();
        }

        //GoToEducationPage
        public void GotoEducationTab()
        {
            Wait.WaitForElementPresent(driver1, educationTab1, 8);
            educationTab.Click();
        }

}
}
