using MagentoLuma.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoLuma
{
    public class EditAccountInformation : AutomationWrapper
    {
        [Test]
        
        public void EditAccount()
        {

            driver.FindElement(By.XPath("(//a[normalize-space()='Sign In'])[1]")).Click();
            driver.FindElement(By.XPath("//input[@name = 'login[username]']")).SendKeys("rahul1309@gmail.com");
            driver.FindElement(By.XPath("//input[@name='login[password]']")).SendKeys("Rahul@123");
            driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();
            driver.FindElement(By.XPath("//button[@class='action switch']")).Click();
            driver.FindElement(By.XPath("//a[text()='My Account']")).Click();
            driver.FindElement(By.XPath("//a[text()='Account Information']")).Click();
            driver.FindElement(By.Id("firstname")).Clear();
            driver.FindElement(By.Id("firstname")).SendKeys("balaji");
            driver.FindElement(By.Id("lastname")).Clear();
            driver.FindElement(By.Id("lastname")).SendKeys("pawar");
            driver.FindElement(By.Id("change-password")).Click();
            driver.FindElement(By.Id("current-password")).SendKeys("Rahul@123");
            driver.FindElement(By.Id("password")).SendKeys("Balaji@123");
            driver.FindElement(By.Id("password-confirmation")).SendKeys("Balaji@123");
            driver.FindElement(By.XPath("//span[text()='Save']")).Click();

        }


        }

    }

