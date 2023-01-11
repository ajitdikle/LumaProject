using MagentoLuma.Base;
using MagentoLuma.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoLuma
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        public void ValidateLoginTest()
        {


            driver.FindElement(By.XPath("(//a[normalize-space()='Sign In'])[1]")).Click();
            driver.FindElement(By.XPath("//input[@name = 'login[username]']")).SendKeys("rahul1309@gmail.com");
            driver.FindElement(By.XPath("//input[@name='login[password]']")).SendKeys("Rahul@123");
            driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();

        }

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ValidLoginData))]
        
        public void ValidLoginData(string email,string password)
        {

            driver.FindElement(By.XPath("(//a[normalize-space()='Sign In'])[1]")).Click();
            driver.FindElement(By.XPath("//input[@name = 'login[username]']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@name='login[password]']")).SendKeys(password);
            driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();


        }
    }
}
