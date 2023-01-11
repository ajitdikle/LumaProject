using MagentoLuma.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoLuma
{
    public class AddAdress : AutomationWrapper
    {
        [Test]
        public void AddingAdress()
        {
            driver.FindElement(By.XPath("(//a[normalize-space()='Sign In'])[1]")).Click();
            driver.FindElement(By.XPath("//input[@name = 'login[username]']")).SendKeys("rahul1309@gmail.com");
            driver.FindElement(By.XPath("//input[@name='login[password]']")).SendKeys("Rahul@123");
            driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();
            driver.FindElement(By.XPath("//button[@class='action switch']")).Click();
            driver.FindElement(By.XPath("//a[text()='My Account']")).Click();
            driver.FindElement(By.XPath("//a[text()='Address Book']")).Click();
            driver.FindElement(By.Id("telephone")).SendKeys("9876543210");
            driver.FindElement(By.Id("street_1")).SendKeys("pune");
            driver.FindElement(By.Id("city")).SendKeys("deccan");

            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("region_id")));
            dropdown.SelectByText("Alaska");

            driver.FindElement(By.Id("zip")).SendKeys("413507");


            SelectElement country = new SelectElement(driver.FindElement(By.Id("country")));
            country.SelectByText("India");

            driver.FindElement(By.XPath("//span[text()='Save Address']")).Click();




        }
    }
}