using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlow_BDDFramework.PageObjectModel.Login
{
   public class Login
    {
        IWebDriver driver;
        public void LaunchURL()
        {
            try
            {            
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");              
            }
            catch(Exception e)
            {
                e.ToString(); 
            }
        }

        public void Credentials()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='txtUsername']")).SendKeys("Admin");
                driver.FindElement(By.XPath("//*[@id='txtPassword']")).SendKeys("admin123");
            }
            catch(Exception e)
            {
              //  e.ToString();
            }
        }

        public void SubmitBtn()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='btnLogin']")).Click();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }


        public void Loginresult()
        {
            try
            {
                IWebElement result = driver.FindElement(By.XPath("//*[@id='welcome']"));
                String strmsg = result.Text;
                Assert.AreEqual(strmsg, "Welcome Admin");
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        //AdminPage
        public void Buttons()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='menu_admin_viewAdminModule']")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id='btnAdd']")).Click();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public void AdminUserDetails()
        {
            try
            {
                SelectElement usrole = new SelectElement(driver.FindElement(By.XPath("//*[@id='systemUser_userType']")));
                usrole.SelectByText("ESS");
                driver.FindElement(By.XPath("//*[@id='systemUser_employeeName_empName']")).SendKeys("Jasmine Morgan");
                driver.FindElement(By.XPath("//*[@id='systemUser_userName']")).SendKeys("Admin456");
                SelectElement oSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id='systemUser_status']")));
                oSelect.SelectByText("Enabled");
                driver.FindElement(By.XPath("//*[@id='systemUser_password']")).SendKeys("admin123");
                driver.FindElement(By.XPath("//*[@id='systemUser_confirmPassword']")).SendKeys("admin123");
            }
            catch(Exception e)
            {
                e.ToString();
            }
        }
      

        public void Savebtn()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='btnSave']")).Click();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public void Saveresult()
        {
            try
            {
                IWebElement result = driver.FindElement(By.XPath("//*[@id='welcome']"));
                String strmsg = result.Text;
                Assert.AreEqual(strmsg, "Welcome Admin");
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        //AddproviderPage

        public void addproviderbtns()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='menu_admin_viewAdminModule']")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id='menu_admin_Configuration']")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id='menu_admin_openIdProvider']")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id='btnAdd']")).Click();
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public void TypeOpenId()
        {
            try
                {
                IWebElement type =driver.FindElement(By.XPath("//*[@id='openIdProvider_type']"));
                 SelectElement msg = new SelectElement(type);
                 msg.SelectByText("OpenId");
                
                if (msg.SelectedOption.Text=="OpenId")
                {
                    driver.FindElement(By.XPath("//*[@id='openIdProvider_name']")).SendKeys("ramarao");
                    driver.FindElement(By.XPath("//*[@id='openIdProvider_url']")).SendKeys("https://www.google.com");
                   
                }
                else if(msg.SelectedOption.Text=="Google+")
                    {                   
                    driver.FindElement(By.XPath("//*[@id='openIdProvider_name']")).SendKeys("ramarao457");
                    driver.FindElement(By.XPath("//*[@id='openIdProvider_url']")).SendKeys("https://www.google.com");
                    driver.FindElement(By.XPath("//*[@id='openIdProvider_clientId']")).SendKeys("orngehrm0002");
                    driver.FindElement(By.XPath("//*[@id='openIdProvider_clientSecret']")).SendKeys("C++");
                    driver.FindElement(By.XPath("//*[@id='openIdProvider_developerKey']")).SendKeys(".net ");
                }
                else
                {
                    Console.WriteLine("error msg displayed");
                }                  
                 
              
                 }
            catch (Exception e)
            {
                e.ToString();
            }
            
        }      
        public void providersave()
        {
            driver.FindElement(By.XPath("//*[@id='btnSave']")).Click();
        }

        public void emailconfigbtn()
        {
            driver.FindElement(By.XPath("//*[@id='menu_admin_viewAdminModule']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='menu_admin_Configuration']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='menu_admin_listMailConfiguration']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='editBtn']")).Click();
        }
        public void mailconfigration()
        {
            driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_txtMailAddress']")).Clear();
            driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_txtMailAddress']")).SendKeys("xyz@gmail.com");
            IWebElement method = driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_cmbMailSendingMethod']"));
            SelectElement sendmthd = new SelectElement(method);
            sendmthd.SelectByText("SMTP");
            if (sendmthd.SelectedOption.Text == "Sendmail")
            {
               IWebElement checkbox= driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_chkSendTestEmail']"));
                if (!checkbox.Selected)
                {
                    checkbox.Click();
                    driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_txtTestEmail']")).SendKeys("abcd@gmail.com");
                }
                else
                {

                }

             }
            else
            {             
              
                if (sendmthd.SelectedOption.Text == "SMTP")
                {
                    driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_txtSmtpHost']")).Clear();
                    driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_txtSmtpHost']")).SendKeys("Smtp@gmail.com");
                    driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_txtSmtpPort']")).SendKeys("12345");
                   IWebElement btnradioNo=  driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_optAuth_none']"));
                    IWebElement btnradioYES = driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_optAuth_login']"));

                    //use SMTP Athentication Yes
                    if (!btnradioYES.Selected)
                    {
                        btnradioYES.Click();
                        driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_txtSmtpUser']")).SendKeys("qwerty");
                        driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_txtSmtpPass']")).SendKeys("asdfg");
                        driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_optSecurity_none']")).Click(); 
                        driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_chkSendTestEmail']")).Click();
                        driver.FindElement(By.XPath("//*[@id='emailConfigurationForm_txtTestEmail']")).SendKeys("abcd@gmail.com");

                    }
                    else if(!btnradioNo.Selected)
                    {
                        btnradioNo.Click();

                    }
                    else
                    {

                    }

                   }
                else
                {

                }

            }
        }
        public void emailsavebtn()
        {
            driver.FindElement(By.XPath("//*[@id='editBtn']")).Click();
        }
    }
}
