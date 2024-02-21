using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14CompetitionTaskProjectMars.Pages;

namespace Week14CompetitionTaskProjectMars.Steps
{
    public class StepCertification
    {
        private readonly IWebDriver driver1;
        private readonly AccountProfileCertification AccountProfileCertificationObj;


        public StepCertification(IWebDriver driver)
        {
            driver1 = driver;
            AccountProfileCertificationObj = new AccountProfileCertification(driver1);
        }

        public void StepAddANewCertification(string certificateOrAward, string from, string year)
        {

            AccountProfileCertificationObj.AddANewCertification(certificateOrAward, from, year);
        }

        public void StepPopupCertificationShouldBeAddSuccessfully()
        {
            AccountProfileCertificationObj.CertificationShouldBeAddSuccessfully();
        }

        public void StepDeleteCertification(string certificateDelete)
        {
            AccountProfileCertificationObj.DeleteCertification(certificateDelete);
        }

        //DeleteACertificationNoCheck
        public void StepDeleteCertificationNoCheck()
        {
            AccountProfileCertificationObj.DeleteACertificationNoCheck();
        }

        public void StepPopupCertificationShouldDeleteSuccessfully()
        {
            AccountProfileCertificationObj.CertificationShouldDeleteSuccessfully();
        }

        //CancelACertification
        public void StepCancel()
        {
            AccountProfileCertificationObj.CancelACertification();
        }

        public void StepPopupPleaseEnterCertificationNameCertificationFromAndCertificationYear()
        {
            AccountProfileCertificationObj.ErrorPleaseEnterCertificationNameCertificationFromAndCertificationYear();
        }

        public void StepEditACertification(string certificateOrAwardEdit, string fromEdit, string yearEdit)
        {
            AccountProfileCertificationObj.EditACertification(certificateOrAwardEdit, fromEdit, yearEdit);
        }

        public void StepPopupCertificationShouldBeEditSuccessfully()
        {
            AccountProfileCertificationObj.CertificationShouldBeEdit();
        }

        //ThisInformationIsAlreadyExist
        public void StepPopupThisInformationIsAlreadyExist()
        {
            AccountProfileCertificationObj.ThisInformationIsAlreadyExist();
        }

        public void CheckExistingCertification()
        {
            AccountProfileCertificationObj.GoToCertificationTab();
            AccountProfileCertificationObj.CheckExistingCertification();
        }
    }
}
