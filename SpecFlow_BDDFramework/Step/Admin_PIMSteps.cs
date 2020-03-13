using SpecFlow_BDDFramework.PageObjectModel.Login;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_BDDFramework.Step
{
    [Binding]
    public class Admin_PIMSteps
    {
        Admin_PIM _adminpim = new Admin_PIM();

        [Given(@"User Navigate Loginpage URL")]
        public void GivenUserNavigateLoginpageURL()
        {
            _adminpim.LaunchURL();
        }
        
        [Given(@"user gives userName and passsword")]
        public void GivenUserGivesUserNameAndPasssword()
        {
            _adminpim.Credentials();
        }
        
        [Given(@"user Navigates admin and add page")]
        public void GivenUserNavigatesAdminAndAddPage()
        {
            _adminpim.Buttons();
        }
        
        [Given(@"user gives userRole,empname,username,status,password,cnfpassword,")]
        public void GivenUserGivesUserRoleEmpnameUsernameStatusPasswordCnfpassword()
        {
            _adminpim.AdminUserDetails();
        }
        
        [Given(@"user Navigates PIM and Add page")]
        public void GivenUserNavigatesPIMAndAddPage()
        {
            _adminpim.PIMBtns();
        }

        [Given(@"user gives Fname,Mname,Lname,Empid,photograph,logindetail,username,pwd,cnfpwd,status")]
        public void GivenUserGivesFnameMnameLnameEmpidPhotographLogindetailUsernamePwdCnfpwdStatus()
        {
            _adminpim.PIM_AddEmployeDet();
        }


        [When(@"user clicks Loginbtn")]
        public void WhenUserClicksLoginbtn()
        {
            _adminpim.SubmitBtn();
        }
        
        [When(@"user clicks saveBtn")]
        public void WhenUserClicksSaveBtn()
        {
            _adminpim.Savebtn();
        }

        [When(@"user clicks PIMsaveBtn")]
        public void WhenUserClicksPIMsaveBtn()
        {
            _adminpim.pimsave();
        }

        [Then(@"user logged Sucessfully")]
        public void ThenUserLoggedSucessfully()
        {
            _adminpim.Loginresult();
        }
        
        [Then(@"user data save Sucessfully")]
        public void ThenUserDataSaveSucessfully()
        {
            _adminpim.Saveresult();
        }

        [Then(@"user PIMdata save Sucessfully")]
        public void ThenUserPIMdataSaveSucessfully()
        {
            _adminpim.Saveresult();
        }

    }
}
