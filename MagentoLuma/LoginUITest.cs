using DocumentFormat.OpenXml.Bibliography;
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

    
        public class LoginUITest : AutomationWrapper
        {
            [Test]
            public void ValidateLogoTest()
            {
            Boolean Logo = driver.FindElement(By.XPath("//a[@class=\"logo\"]")).Displayed;
            Assert.IsTrue(Logo);
            }
        [Test]
        public void ValidateDefaultWelcomeMsgLogo()
        {
            Boolean msg = driver.FindElement(By.XPath("//span[text()='Default welcome msg!']")).Displayed;
            Assert.IsTrue(msg);
        }
        [Test]
        public void ValidateSearchBox()
        {
            Boolean search = driver.FindElement(By.Id("search")).Displayed;
            Assert.IsTrue(search);
        }

        [Test]
        public void ValidateCartLogo()
        {
            Boolean cart = driver.FindElement(By.XPath("//a[@class = 'action showcart']")).Displayed;
            Assert.IsTrue(cart);
        
        
        }
    }
}
