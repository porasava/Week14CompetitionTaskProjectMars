using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14CompetitionTaskProjectMars.Pages;
using Week14CompetitionTaskProjectMars.Utilities;

namespace Week14CompetitionTaskProjectMars.Steps
{
    public class StepEducation
    {
        private readonly IWebDriver driver1;
        private readonly AccountProfileEducation AccountProfileEducationObj;


        public StepEducation(IWebDriver driver)
        {
            driver1 = driver;
            AccountProfileEducationObj = new AccountProfileEducation(driver1);
        }

        public void StepAddANewEducation( string universityName, string country, string title, string degree, string yearOfGraduate)
        {
            AccountProfileEducationObj.AddANewEducation(universityName, country, title, degree, yearOfGraduate);
        }

        public void StepAddANewEducationCancel(string universityName, string country, string title, string degree, string yearOfGraduate)
        {
            AccountProfileEducationObj.AddANewEducationCancel(universityName, country, title, degree, yearOfGraduate);
        }

        //EducationShouldBeAddSuccessfully
        public void StepEducationShouldBeAddSuccessfully()
        {
            AccountProfileEducationObj.EducationShouldBeAddSuccessfully();
        }


        //DeleteAEducation
        public void StepDeleteAnEducation(string universityNameDelete)
        {
            AccountProfileEducationObj.DeleteAEducation(universityNameDelete);

        }

        // DeleteAEducationNoCheck
        public void StepDeleteAnEducationNoCheck()
        {
            AccountProfileEducationObj.DeleteAEducationNoCheck();

        }


        //EducationShouldDeleteSuccessfully
        public void StepEducationShouldDeleteSuccessfully()
        {
            AccountProfileEducationObj.EducationShouldDeleteSuccessfully();
        }

        //EducationErrorPleaseEnterAllTheFields
        public void StepEducationErrorPleaseEnterAllTheFields()
        {
            AccountProfileEducationObj.EducationErrorPleaseEnterAllTheFields();
        }
        //EducationErrorThisInformationIsAlreadyExist
        public void StepEducationErrorThisInformationIsAlreadyExist()
        {
            AccountProfileEducationObj.EducationErrorThisInformationIsAlreadyExist();
        }


        //EditEducation
        public void StepEditEducation(string universityNameEdit, string countryEdit, string titleEdit, string degreeEdit, string yearOfGraduateEdit)
        {
            AccountProfileEducationObj.EditEducation(universityNameEdit, countryEdit, titleEdit, degreeEdit,yearOfGraduateEdit);
        }
        //EditEducationDown
        public void StepEditEducationDown(string universityNameEdit, string countryEdit, string titleEdit, string degreeEdit, string yearOfGraduateEdit)
        {
            AccountProfileEducationObj.EditEducationDown(universityNameEdit, countryEdit, titleEdit, degreeEdit, yearOfGraduateEdit);
        }

        // CancelAEducation
        public void StepCancelAEducation()
        {
            AccountProfileEducationObj.CancelAEducation();
        }

        //ClearAEducationUniversity
        public void StepClearAEducationUniversity()
        {
            AccountProfileEducationObj.ClearAEducationUniversity();
        }

        public void CheckExistingEducation()
        {
            AccountProfileEducationObj.GotoEducationTab();
            AccountProfileEducationObj.CheckExistingEducation();
        }
    }
}
