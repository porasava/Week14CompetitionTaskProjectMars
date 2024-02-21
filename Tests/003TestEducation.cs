using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14CompetitionTaskProjectMars.Pages;
using Week14CompetitionTaskProjectMars.Steps;
using Week14CompetitionTaskProjectMars.Utilities;
using Week14CompetitionTaskProjectMars.Models;
using System.Text.Json;
using System.Diagnostics.Metrics;
using NUnit.Framework.Interfaces;
using System.Xml.Linq;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace Week14CompetitionTaskProjectMars.Tests
{
    [TestFixture]

    public class TestEducation: Hooks
    {
        private List<LoginModel> _LoginModel; 
        private List<EducationModel> _EducationModel;

        [SetUp]
        public new void Initialize()
        {
           // driver1 = CommonDriver.CreateNewDriver();
          //  base.Initialize();
          //  test = GlobalReport.extent.CreateTest(TestContext.CurrentContext.Test.Name);
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _LoginModel = JsonReader.ReadLoginData(jsonFilePathLogin);
            string jsonFilePathEducation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataEducation.json");
            _EducationModel = JsonReader.ReadEducationData(jsonFilePathEducation);

        }


        [Test, Category("Education")]
        //TS_301_TC_001 Verify that the user add an Education on the account profile page with blank on college field
        public void TS_301_TC_001AddAnEducationWithBlankOnCollegeField()
            {

            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count>0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationErrorPleaseEnterAllTheFields();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
            }


        [Test, Category("Education")]
        //TS_301_TC_002 Verify that the user add an Education on the account profile page with blank on country field
        public void TS_301_TC_002AddAnEducationWithBlankOnCountryField()
        {

            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationErrorPleaseEnterAllTheFields();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Education")]
        //TS_301_TC_003 Verify that the user add an Education on the account profile page with blank on title field
        public void TS_301_TC_003AddAnEducatiOnWithBlankOnTitleField()
        {

            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationErrorPleaseEnterAllTheFields();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Education")]
        //TS_301_TC_004 Verify that the user add an Education on the account profile page with blank on Degree field
        public void TS_301_TC_004AddAnEducationWithBblankOnDegreeField()
        {

            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_004");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationErrorPleaseEnterAllTheFields();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Education")]
        //TS_301_TC_005 Verify that the user add an Education on the account profile page with blank on Year of graduation field
        public void TS_301_TC_005AddAnEducationWithBlankOnYearOfGraduationField()
        {

            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_005");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationErrorPleaseEnterAllTheFields();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Education")]
        //TS_301_TC_006 Verify that the user add an Education on the account profile page then click on cancel
        public void TS_301_TC_006AddAnEducationThenClickOnCancel()
        {

            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_006");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducationCancel(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Education")]
        //TS_301_TC_007 Verify that the user add an Education on the account profile page with special character on college field
        public void TS_301_TC_007AddAnEducationWithSpecialCharacterOnCollegeField()
        {

            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_007");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepDeleteAnEducation(educationModel.universityNameDelete);
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }



        [Test, Category("Education")]
        //TS_301_TC_008 Verify that the user add an Education on the account profile page with special character on Degree field
        public void TS_301_TC_008AddAnEducationWithSpecialCharacterOnDegreeField()
        {

            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_008");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepDeleteAnEducation(educationModel.universityNameDelete);
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Education")]
        //TS_301_TC_009 Verify that the user add an Education on the account profile page with more than 50 letters on college field
        public void TS_301_TC_009AddAnEducationWithMoreThan50LettersOnCollegeField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_009");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepDeleteAnEducationNoCheck();
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Education")]
        //TS_301_TC_010 Verify that the user add an Education on the account profile page with more than 50 letters on degree field
        public void TS_301_TC_010AddAnEducationWithMoreThan50LettersOnDegreeField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_010");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepDeleteAnEducationNoCheck();
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Education")]
        //TS_301_TC_011 Verify that the user add an Education on the account profile page with the same education detail
        public void TS_301_TC_011AddAnEducationWithTheSameEducationDetail()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_011");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationErrorThisInformationIsAlreadyExist();
                StepEducationObj.StepDeleteAnEducationNoCheck();
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Education")]
        //TS_302_TC_001 Verify that the user edit an Education on the account profile page with correct mandatory
        public void TS_302_TC_001EditAnEducationWithCorrectMandatory()
            {
                // Ensure that _LoginModel is not empty and contains data
                if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
                {
                    var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                          // Find the specific test data for this test case
                    EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_302_TC_001");
                    LoginPageObj.NavigateToSkillsWeb();
                    LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                    LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                    StepEducationObj.StepEducationShouldBeAddSuccessfully();
                    StepEducationObj.StepEditEducation(educationModel.universityNameEdit, educationModel.countryEdit, educationModel.titleEdit, educationModel.degreeEdit, educationModel.yearOfGraduateEdit);
                    StepEducationObj.StepCancelAEducation();
                    StepEducationObj.StepDeleteAnEducationNoCheck();
                    StepEducationObj.StepDeleteAnEducationNoCheck();
                    StepEducationObj.StepEducationShouldDeleteSuccessfully();
                }
                else
                {//Assertions to validate the login
                    Assert.Fail("Login credentials not found in the test data");
                }
            }



        [Test, Category("Education")]
        //TS_302_TC_002 Verify that the user edit an Education on the account profile page with duplicate data
        public void TS_302_TC_002EditAnEducationWithDuplicateData()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_302_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepAddANewEducation(educationModel.universityName2, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEditEducationDown(educationModel.universityNameEdit, educationModel.countryEdit, educationModel.titleEdit, educationModel.degreeEdit, educationModel.yearOfGraduateEdit);
                StepEducationObj.StepEducationErrorThisInformationIsAlreadyExist();
                StepEducationObj.StepCancelAEducation();
                StepEducationObj.StepDeleteAnEducationNoCheck();
                StepEducationObj.StepDeleteAnEducationNoCheck();
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }



        [Test, Category("Education")]
        //TS_302_TC_003 Verify that the user edit an Education on the account profile page with blank on Country field
        public void TS_302_TC_003EditAnEducationWithBlankOnCountryField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_302_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepEditEducationDown(educationModel.universityNameEdit, educationModel.countryEdit, educationModel.titleEdit, educationModel.degreeEdit, educationModel.yearOfGraduateEdit);
                StepEducationObj.StepEducationErrorPleaseEnterAllTheFields();
                StepEducationObj.StepCancelAEducation();
                StepEducationObj.StepDeleteAnEducationNoCheck();
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Education")]
        //TS_302_TC_004 Verify that the user edit an Education on the account profile page with blank on Title field
        public void TS_302_TC_004EditAnEducationWithBlankOnTitleField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_302_TC_004");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepEditEducationDown(educationModel.universityNameEdit, educationModel.countryEdit, educationModel.titleEdit, educationModel.degreeEdit, educationModel.yearOfGraduateEdit);
                StepEducationObj.StepEducationErrorPleaseEnterAllTheFields();
                StepEducationObj.StepCancelAEducation();
                StepEducationObj.StepDeleteAnEducationNoCheck();
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Education")]
        //TS_302_TC_005 Verify that the user edit an Education on the account profile page with blank on University name field
        public void TS_302_TC_005EditAnEducationWithBlankOnUniversityNameField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_302_TC_005");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepEditEducationDown(educationModel.universityNameEdit, educationModel.countryEdit, educationModel.titleEdit, educationModel.degreeEdit, educationModel.yearOfGraduateEdit);
                StepEducationObj.StepEducationErrorThisInformationIsAlreadyExist();
                StepEducationObj.StepCancelAEducation();
                StepEducationObj.StepDeleteAnEducationNoCheck();
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Education")]
        //TS_302_TC_006 Verify that the user edit an Education on the account profile page with blank on Degree field
        public void TS_302_TC_006EditAnEducationWithBlankOnDegreeField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_302_TC_006");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepEditEducationDown(educationModel.universityNameEdit, educationModel.countryEdit, educationModel.titleEdit, educationModel.degreeEdit, educationModel.yearOfGraduateEdit);
                StepEducationObj.StepEducationErrorPleaseEnterAllTheFields();
                StepEducationObj.StepCancelAEducation();
                StepEducationObj.StepDeleteAnEducationNoCheck();
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Education")]
        //TS_302_TC_007 Verify that the user edit an Education on the account profile page with blank on Graduation Year field
        public void TS_302_TC_007EditAnEducationWithBlankOnGraduationYearField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_302_TC_007");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepEditEducationDown(educationModel.universityNameEdit, educationModel.countryEdit, educationModel.titleEdit, educationModel.degreeEdit, educationModel.yearOfGraduateEdit);
                StepEducationObj.StepEducationErrorPleaseEnterAllTheFields();
                StepEducationObj.StepCancelAEducation();
                StepEducationObj.StepDeleteAnEducationNoCheck();
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Education")]
        //TS_303_TC_001 Verify that the user delete an Education on the account profile page
        public void TS_303_TC_001DeleteAnEducation()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _EducationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed                           
                                                      // Find the specific test data for this test case
                EducationModel educationModel = _EducationModel.FirstOrDefault(edu => edu.TestCaseId == "TS_303_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepEducationObj.CheckExistingEducation();
                StepEducationObj.StepAddANewEducation(educationModel.universityName, educationModel.country, educationModel.title, educationModel.degree, educationModel.yearOfGraduate);
                StepEducationObj.StepEducationShouldBeAddSuccessfully();
                StepEducationObj.StepDeleteAnEducation(educationModel.universityNameDelete);
                StepEducationObj.StepEducationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }
    }

}
