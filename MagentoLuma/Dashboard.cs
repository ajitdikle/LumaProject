using MagentoLuma.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoLuma
{
    public class Dashboard : AutomationWrapper
    {
        [Test]

        public void Mouseover()
        {
            Actions actions = new Actions(driver);

            actions.MoveToElement(driver.FindElement(By.XPath("//span[text()='Women']"))).MoveToElement(driver.FindElement(By.XPath("//span[text()='Tops']"))).Click();

            //actions.MoveToElement(driver.FindElement(By.XPath("//span[text()='Tops']"))).Perform();

            driver.FindElement(By.XPath("//span[text()='Hoodies & Sweatshirts']")).Click(); 
        }

    }
}
