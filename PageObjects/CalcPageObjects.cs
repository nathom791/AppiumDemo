using OpenQA.Selenium.Appium.Android;

namespace Appium
{
    public class CalcPageObjects : UtilityMethods
    {
        public void ClickOneTimeOKBtn()
        {
            FindById("com.tricolorcat.calculator:id/btOK").Click();
        }

        #region Digits

        public void ClickDigitOne()
        {
            FindById("com.tricolorcat.calculator:id/one").Click();
        }

        public void ClickDigitTwo()
        {
            FindById("com.tricolorcat.calculator:id/two").Click();
        }

        public void ClickDigitThree()
        {
            FindById("com.tricolorcat.calculator:id/three").Click();
        }

        public void ClickDoubleZero()
        {
            FindById("com.tricolorcat.calculator:id/doublezero").Click();
        }

        #endregion digits

        #region Operations

        public void ClickPlusBtn()
        {
            FindById("com.tricolorcat.calculator:id/plus").Click();
        }

        public void ClickMinusBtn()
        {
            FindById("com.tricolorcat.calculator:id/minus").Click();
        }

        public void ClickTimesBtn()
        {
            FindById("com.tricolorcat.calculator:id/times").Click();
        }

        public void ClickDivideBtn()
        {
            FindById("com.tricolorcat.calculator:id/divide").Click();
        }

        public void ClickPercentBtn()
        {
            FindById("com.tricolorcat.calculator:id/percent").Click();
        }

        public void ClickSignBtn()
        {
            FindById("com.tricolorcat.calculator:id/sign").Click();
        }
        public void ClickEqualsBtn()
        {
            FindById("com.tricolorcat.calculator:id/equal").Click();
        }
        public void ClickClearBtn()
        {
            FindById("com.tricolorcat.calculator:id/allclear").Click();
        }

        public AndroidElement Result()
        {
            return FindById("com.tricolorcat.calculator:id/display");
        }

        #endregion
    }
}