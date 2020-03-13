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
   public class Admin_PIM
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
            catch (Exception e)
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
            catch (Exception e)
            {
                e.ToString();
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
                driver.FindElement(By.XPath("//*[@id='systemUser_userName']")).SendKeys("Admin123");
                SelectElement oSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id='systemUser_status']")));
                oSelect.SelectByText("Enabled");
                driver.FindElement(By.XPath("//*[@id='systemUser_password']")).SendKeys("admin123");
                driver.FindElement(By.XPath("//*[@id='systemUser_confirmPassword']")).SendKeys("admin123");
            }
            catch (Exception e)
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

        //PIMPage
        public void PIMBtns()
        {
            try
            {
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id='btnAdd']")).Click();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public void PIM_AddEmployeDet()
        {
            driver.FindElement(By.XPath("//*[@id='firstName']")).SendKeys("Edubilli");
            driver.FindElement(By.XPath("//*[@id='middleName']")).SendKeys("Narayana");
            driver.FindElement(By.XPath("//*[@id='lastName']")).SendKeys("Rao");
            driver.FindElement(By.XPath("//*[@id='employeeId']")).Clear();
            driver.FindElement(By.XPath("//*[@id='employeeId']")).SendKeys("vpt0007");
           // driver.FindElement(By.XPath("//*[@id='photofile']")).SendKeys("C: \\Users\\40009702\\Desktop\\1234.jpg");
            IWebElement checkbox = driver.FindElement(By.XPath("//*[@id='chkLogin']"));
            if (!checkbox.Selected)
            {
                checkbox.Click();
                driver.FindElement(By.XPath("//*[@id='user_name']")).SendKeys("Edubilli");
                driver.FindElement(By.XPath("//*[@id='user_password']")).SendKeys("Siddu#456");
                driver.FindElement(By.XPath("//*[@id='re_password']")).SendKeys("Siddu#456");              
                SelectElement pimstatus= new SelectElement(driver.FindElement(By.XPath("//*[@id='status']")));
                pimstatus.SelectByText("Enabled");
            }
            else
            {
                Console.WriteLine("check box is not checked");
            }
        }
        public void pimsave()
        {
            driver.FindElement(By.XPath("//*[@id='btnSave']")).Click();
        }
    }
}
