using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace AutoMobileConnect
{
    [TestClass]
    public class TestApp
    {
        //AndroidDriver<AppiumWebElement> driver;
        WebDriverWait wait;

        public object I { get; private set; }
        public object Market { get; private set; }
        public object Username { get; private set; }



        [TestMethod]
        public void Demo()
        {

           /* DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("deviceName", "009f5afb3866b693");
            cap.SetCapability("platformVersion", "8.1.0");
            cap.SetCapability("platformName", "Android");
            cap.SetCapability("appPackage", "com.fsresidential.connect");
            cap.SetCapability("appActivity", "com.fsresidential.connect.activity.SplashActivity");
            cap.SetCapability("newCommandTimeout", "1000");
            cap.SetCapability("autoGrantPermissions", true);
            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
             wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));*/
            LoginPage lp = new LoginPage();
            lp.Wait();
            lp.Agree();
            lp.market();
           lp.selectMarket();
            lp.username();
            lp.password();
            lp.login();
        } } }
            /*
            Thread.Sleep(10000);
            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"I AGREE\")").Click();
            Thread.Sleep(10000);

            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"Market\")").Click();
            Thread.Sleep(10000);
            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"Florida\")").Click();

            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"Username\")").SendKeys("C4admin");
            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"Password\")").SendKeys("N4Et4wem@5+=V");
            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"LOG IN\")").Click();

            Thread.Sleep(30000);
            /////////////////////////////
            driver.FindElementByAndroidUIAutomator("new UiSelector().resourceId(\"com.fsresidential.connect:id/ctv\")").Click();
            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"CONTINUE\")").Click();

            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"OK\")").Click();
            Thread.Sleep(200000);

            driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.support.v4.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.GridView/android.widget.RelativeLayout[2]/android.widget.ImageView").Click();
            driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.support.v4.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.GridView/android.widget.RelativeLayout[2] ").Click();

            driver.FindElementByAndroidUIAutomator("new UiSelector().resourceId(\"android:id/home\")").Click();
            driver.FindElementByAndroidUIAutomator("new UiSelector().resourceId(\"android:id/up\")").Click();

            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"LOG OUT\")").Click();
            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"Yes\")").Click(); 

        }
    }
}*/
