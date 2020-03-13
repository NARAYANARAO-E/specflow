using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using SpecFlow_BDDFramework.PageObjectModel.Login;

namespace SpecFlow_BDDFramework.Step
{
    [Binding]
    public class LoginSteps
    {
       
        Login _login = new Login();

        [Given(@"User Navigate Loginpage url")]
        public void GivenUserNavigateLoginpageUrl()
        {
            _login.LaunchURL();
        }
        
        [Given(@"user gives username and passsword")]
        public void GivenUserGivesUsernameAndPasssword()
        {
            _login.Credentials();
        }
        
        [Given(@"user navigates admin and add page")]
        public void GivenUserNavigatesAdminAndAddPage()
        {
            _login.Buttons();
        }
        
        [Given(@"user gives userrole,empname,username,status,password,cnfpassword,")]
        public void GivenUserGivesUserroleEmpnameUsernameStatusPasswordCnfpassword()
        {
           _login.AdminUserDetails();           
          
        }

        [Given(@"user navigates admin and configration and Social Media Authentication and add page")]
        public void GivenUserNavigatesAdminAndConfigrationAndSocialMediaAuthenticationAndAddPage()
        {
            _login.addproviderbtns();
        }

        [Given(@"user gives type name,url,Redirecturl,clientid,clientScerect,DevelopementKey")]
        public void GivenUserGivesTypeNameUrlRedirecturlClientidClientScerectDevelopementKey()
        {
            _login.TypeOpenId();        
            
        }      

        [Given(@"user clicks adminbtn and configration and emailconfigration and editbtn and mail,sendmethod,sendtestmail,testEmailaddress")]
        public void GivenUserClicksAdminbtnAndConfigrationAndEmailconfigrationAndEditbtnAndMailSendmethodSendtestmailTestEmailaddress()
        {
            _login.emailconfigbtn();
            _login.mailconfigration();
        }


        [Given(@"user gives SMTPHost,SMTPPort,smtpauthenticationNO,smtpautYES,smtpuser,smtpPwd,RadiobtnNo,RadiobtnSSl,RadioTLS,sendTestMail,TestEmailAddress")]
        public void GivenUserGivesSMTPHostSMTPPortSmtpauthenticationNOSmtpautYESSmtpuserSmtpPwdRadiobtnNoRadiobtnSSlRadioTLSSendTestMailTestEmailAddress()
        {
           
        }

        [When(@"user clicks loginbtn")]
        public void WhenUserClicksLoginbtn()
        {
            _login.SubmitBtn();
        }
        
        [When(@"user clicks savebtn")]
        public void WhenUserClicksSavebtn()
        {
            _login.Savebtn();
        }

        [When(@"user clicks Save")]
        public void WhenUserClicksSave()
        {
            _login.providersave();
        }

        [When(@"user clicks EmailcongSavebtn")]
        public void WhenUserClicksEmailcongSavebtn()
        {
            _login.emailsavebtn();
        }

        [Then(@"user logged sucessfully")]
        public void ThenUserLoggedSucessfully()
        {
            _login.Loginresult();
        }
        
        [Then(@"user data save sucessfully")]
        public void ThenUserDataSaveSucessfully()
        {
            _login.Saveresult();
       }


        [Then(@"user data save sucessfull")]
        public void ThenUserDataSaveSucessfull()
        {
           
        }

        [Then(@"user EmailconfigData save sucessfully")]
        public void ThenUserEmailconfigDataSaveSucessfully()
        {
            
        }


    }
}
