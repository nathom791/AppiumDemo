using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;

namespace Appium
{
    public class UtilityMethods : BaseClass
    {

        public AndroidElement FindById(string id)
        {
            AndroidElement element = (AndroidElement)new WebDriverWait(
            driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                MobileBy.Id(id))
            );
            return element;
        }

        public AndroidElement FindByXPath(string xpath)
        {
            AndroidElement element = (AndroidElement)new WebDriverWait(
            driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                MobileBy.XPath(xpath))
            );
            return element;
        }
    }
}