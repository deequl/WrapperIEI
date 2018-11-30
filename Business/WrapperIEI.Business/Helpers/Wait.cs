using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WrapperIEI.Business.Helpers
{
    public static class Wait
    {
        //this will search for the element until a timeout is reached
        public static IWebElement WaitUntilElementExists(By elementLocator, IWebDriver driver,  int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }

            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Time exceded! Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
    }
}
