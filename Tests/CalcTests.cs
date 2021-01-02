using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace Appium
{
    [TestFixture]
    public class CalcTests : CalcPageObjects
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        { 
            ClickOneTimeOKBtn();
        }

        [Test]
        public void AdditionTest()
        {
            ClickDigitOne();
            ClickPlusBtn();
            ClickDigitTwo();
            ClickEqualsBtn();
            Assert.AreEqual("3", Result().GetAttribute("Text"));
        }

        [Test]
        public void SubtractionTest()
        {
            ClickDigitOne();
            ClickMinusBtn();
            ClickDigitTwo();
            ClickEqualsBtn();
            Assert.AreEqual("-1", Result().GetAttribute("Text"));
        }

        [Test]
        public void MulitplicationTest()
        {
            ClickDigitOne();
            ClickTimesBtn();
            ClickDigitTwo();
            ClickEqualsBtn();
            Assert.AreEqual("2", Result().GetAttribute("Text"));
        }

        [Test]
        public void DivisionTest()
        {
            ClickDigitOne();
            ClickDivideBtn();
            ClickDigitTwo();
            ClickEqualsBtn();
            Assert.AreEqual("0.5", Result().GetAttribute("Text"));
        }

        [Test]
        public void PercentTest()
        {
            ClickDigitOne();
            ClickPercentBtn();
            Assert.AreEqual("0.01", Result().GetAttribute("Text"));
        }

        [Test]
        public void DoubleZeroTest()
        {
            ClickDigitOne();
            ClickDoubleZero();
            Assert.AreEqual("100", Result().GetAttribute("Text"));
        }

        [Test]
        public void ClearTest()
        {
            ClickDigitOne();
            ClickClearBtn();
            Assert.AreEqual("0", Result().GetAttribute("Text"));
        }



        [TearDown]
        public void TearDown()
        {
            ClickClearBtn();
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}