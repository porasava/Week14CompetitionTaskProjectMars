using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14CompetitionTaskProjectMars.Models;
using Week14CompetitionTaskProjectMars.Utilities;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Week14CompetitionTaskProjectMars.Tests
{
  [TestFixture]
  public class TestCertification : Hooks
  {
        private List<LoginModel> _LoginModel;
        private List<EducationModel> _EducationModel;
        private List<CertificationModel> _CertificationModel;

     [SetUp]
     public new void Initialize()
     {
       string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
       _LoginModel = JsonReader.ReadLoginData(jsonFilePathLogin);
       string jsonFilePathEducation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataEducation.json");
       _EducationModel = JsonReader.ReadEducationData(jsonFilePathEducation);
       string jsonFilePathCertification = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataCertification.json");
       _CertificationModel = JsonReader.ReadCertificationData(jsonFilePathCertification);

        }


        [Test, Category("Certification")]
        //TS_401_TC_001 Verify that the user add an Certification on the account profile page with correct mandatory field
        public void TS_401_TC_001AddAnCertificatioWithCorrectMandatoryField()
     {

         // Ensure that _LoginModel is not empty and contains data
         if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
         {
             var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                   // Find the specific test data for this test case
             CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_401_TC_001");
             LoginPageObj.NavigateToSkillsWeb();
             LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
             LoginPageObj.ClickOnLogin();
             StepCertificationObj.CheckExistingCertification();
             StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
             StepCertificationObj.StepPopupCertificationShouldBeAddSuccessfully();
             StepCertificationObj.StepDeleteCertification(certificationModel.certificationName);
             StepCertificationObj.StepPopupCertificationShouldDeleteSuccessfully();

            }
         else
         {//Assertions to validate the login
         Assert.Fail("Login credentials not found in the test data");
         }
     }

        [Test, Category("Certification")]
        //TS_401_TC_002 Verify that the user add an Certification on the account profile page with incorrect mandatory field
        public void TS_401_TC_002AddAnCertificationWithIncorrectMandatoryField()
        {

            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_401_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepPopupPleaseEnterCertificationNameCertificationFromAndCertificationYear();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Certification")]
        //TS_401_TC_003 Verify that the user add an Certification on the account profile page with blank on certification field
        public void TS_401_TC_003AddAnCertificationWithBlankOnCertificationField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_401_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepPopupPleaseEnterCertificationNameCertificationFromAndCertificationYear();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Certification")]
        //TS_401_TC_004 Verify that the user add an Certification on the account profile page with blank on certified from field
        public void TS_401_TC_004AddAnCertificationWithBlankOnCertifiedFromField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_401_TC_004");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepPopupPleaseEnterCertificationNameCertificationFromAndCertificationYear();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Certification")]
        //TS_401_TC_005 Verify that the user add an Certification on the account profile page with blank on year field
        public void TS_401_TC_005AddAnCertificationWithBlankOnYearField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_401_TC_005");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepPopupPleaseEnterCertificationNameCertificationFromAndCertificationYear();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Certification")]
        //TS_401_TC_006 Verify that the user adds a certification to the account profile page with more than 50 letters in the certification field
        public void TS_401_TC_006AddACertificationWithMoreThan50LettersInTheCertificationField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_401_TC_006");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepDeleteCertificationNoCheck();
                StepCertificationObj.StepPopupCertificationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Certification")]
        //TS_401_TC_007 Verify that the user adds a certification to the account profile page with more than 50 letters in the certified from field
        public void TS_401_TC_007AddACertificationWithMoreThan50LettersInTheCertifiedFromField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_401_TC_007");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepDeleteCertificationNoCheck();
                StepCertificationObj.StepPopupCertificationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Certification")]
        //TS_402_TC_001 Verify that the user edits a certification to the account profile page with correct mandatory
        public void TS_402_TC_001EditACertificationWithCorrectMandatory()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_402_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepEditACertification(certificationModel.certificationNameEdit, certificationModel.certificationFromEdit, certificationModel.CertificationYearEdit);
                StepCertificationObj.StepDeleteCertificationNoCheck();
                StepCertificationObj.StepPopupCertificationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Certification")]
        //TS_402_TC_002 Verify that the user edits a certification to the account profile page with blank Certificate
        public void TS_402_TC_002EditACertificationWithBlankCertificate()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_402_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepEditACertification(certificationModel.certificationNameEdit, certificationModel.certificationFromEdit, certificationModel.CertificationYearEdit);
                StepCertificationObj.StepPopupPleaseEnterCertificationNameCertificationFromAndCertificationYear();
                StepCertificationObj.StepCancel();
                StepCertificationObj.StepDeleteCertificationNoCheck();
                StepCertificationObj.StepPopupCertificationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Certification")]
        //TS_402_TC_003 Verify that the user edits a certification to the account profile page with blank from field
        public void TS_402_TC_003EditACertificationWithBlankFromField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_402_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepEditACertification(certificationModel.certificationNameEdit, certificationModel.certificationFromEdit, certificationModel.CertificationYearEdit);
                StepCertificationObj.StepPopupPleaseEnterCertificationNameCertificationFromAndCertificationYear();
                StepCertificationObj.StepCancel();
                StepCertificationObj.StepDeleteCertificationNoCheck();
                StepCertificationObj.StepPopupCertificationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Certification")]
        //TS_402_TC_004 Verify that the user edits a certification to the account profile page with blank year field
        public void TS_402_TC_004EditACertificationWithBlankYearField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_402_TC_004");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepEditACertification(certificationModel.certificationNameEdit, certificationModel.certificationFromEdit, certificationModel.CertificationYearEdit);
                StepCertificationObj.StepPopupPleaseEnterCertificationNameCertificationFromAndCertificationYear();
                StepCertificationObj.StepCancel();
                StepCertificationObj.StepDeleteCertificationNoCheck();
                StepCertificationObj.StepPopupCertificationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Certification")]
        //TS_402_TC_005 Verify that the user edits a certification to the account profile page with duplicate data
        public void TS_402_TC_005EditACertificationWithDuplicateData()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_402_TC_005");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName2, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepEditACertification(certificationModel.certificationNameEdit, certificationModel.certificationFromEdit, certificationModel.CertificationYearEdit);
                StepCertificationObj.StepPopupThisInformationIsAlreadyExist();
                StepCertificationObj.StepCancel();
                StepCertificationObj.StepDeleteCertificationNoCheck();
                StepCertificationObj.StepPopupCertificationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Certification")]
        //TS_403_TC_001 Verify that the user delete an Certification on the account profile page
        public void TS_403_TC_001DeleteACertification()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_LoginModel.Count > 0 && _CertificationModel.Count > 0)
            {
                var loginModel = _LoginModel.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                CertificationModel certificationModel = _CertificationModel.FirstOrDefault(cer => cer.TestCaseId == "TS_403_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepCertificationObj.CheckExistingCertification();
                StepCertificationObj.StepAddANewCertification(certificationModel.certificationName, certificationModel.certificationFrom, certificationModel.CertificationYear);
                StepCertificationObj.StepDeleteCertification(certificationModel.certificationName);
                StepCertificationObj.StepPopupCertificationShouldDeleteSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }
    }
}
