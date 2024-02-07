using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14CompetitionTaskProjectMars.Models;
using Week14CompetitionTaskProjectMars.Pages;
using Week14CompetitionTaskProjectMars.Steps;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;



[SetUpFixture]
public class GlobalReport
{
    public static ExtentReports extent;

    [OneTimeSetUp]
    public void Setup()
    {
        string workingDirectory = Environment.CurrentDirectory;
        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        string reportPath = projectDirectory + "//Reports/TestReport.html";
        // "TestData", "TestDataLogin.json"
        extent = new ExtentReports();
        var htmlReporter = new ExtentV3HtmlReporter(reportPath);
        extent.AttachReporter(htmlReporter);
        extent.AddSystemInfo("Host Name", "Local host");
        extent.AddSystemInfo("Website", "http://localhost:5001/Account/Profile");
        extent.AddSystemInfo("Environment", "QA");
        extent.AddSystemInfo("Username", "Tananya Asavaoran");

    }

    [OneTimeTearDown]
    public void Teardown()
    {
        extent.Flush();
    }
}



namespace Week14CompetitionTaskProjectMars.Utilities
{

    public class Hooks
    {

        protected IWebDriver driver1;
        protected LogInPage LoginPageObj;
        protected StepEducation StepEducationObj;
        protected StepCertification StepCertificationObj;
        protected ExtentReports extent;
        protected ExtentTest test;


        [SetUp]
        public void Initialize()
        {
           driver1 = CommonDriver.CreateNewDriver();
            LoginPageObj = new LogInPage(driver1);
            StepEducationObj = new StepEducation(driver1);
            StepCertificationObj = new StepCertification(driver1);
            test = GlobalReport.extent.CreateTest(TestContext.CurrentContext.Test.Name);
            // Initialize other common objects and test data as needed
        }

        [TearDown]
        public void TearDown()
        {
          
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            //generate log file
            var strackTrace = TestContext.CurrentContext.Result.StackTrace;

            DateTime time = DateTime.Now;
            String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
            if(status == TestStatus.Failed)
            {
                test.Fail("Test failed", CaptureScreenshot(driver1, fileName));
                test.Log(Status.Fail, "test failed with logtrace" + strackTrace);
            }
            else if (status == TestStatus.Passed)
            {
                test.Pass("Test passed");
                test.Pass("Test passed", CaptureScreenshot(driver1, fileName));
            }
            else
            {
                test.Skip("Test skipped");
            }
           
            CommonDriver.CloseDriver(driver1);

        }

 

        public MediaEntityModelProvider CaptureScreenshot(IWebDriver driver1, string screenshotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver1;
            var screenshot =ts.GetScreenshot().AsBase64EncodedString;
            
           return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot,screenshotName).Build();
        }
    }

}
