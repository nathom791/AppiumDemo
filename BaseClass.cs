using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Collections;

namespace Appium
{
    public class BaseClass
    {
        public AppiumDriver<AndroidElement> driver;

        public BaseClass(){

            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            string root = Directory.GetCurrentDirectory();

            AppiumOptions cap = new AppiumOptions();
            cap.PlatformName = "Android";
            cap.AddAdditionalCapability("platformVersion", "11");
            cap.AddAdditionalCapability("udid", "emulator-5554");
            cap.AddAdditionalCapability("deviceType", "phone");
            cap.AddAdditionalCapability("device", "Android");
            cap.AddAdditionalCapability("app", root + @"\Calculator_v1.10.9.apk");
            Uri uri = new Uri("http://127.0.0.1:4723/wd/hub/");
            driver = new AndroidDriver<AndroidElement>(uri, cap);
            }
    }
}