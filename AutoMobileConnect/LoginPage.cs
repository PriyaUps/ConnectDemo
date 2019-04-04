using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoMobileConnect
{
    class LoginPage
    {
       public AndroidDriver<AppiumWebElement> driver;
        public WebDriverWait wait;
        public LoginPage()
        {
            this.driver = driver;
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("deviceName", "009f5afb3866b693");
            cap.SetCapability("platformVersion", "8.1.0");
            cap.SetCapability("platformName", "Android");
            cap.SetCapability("appPackage", "com.fsresidential.connect");
            cap.SetCapability("appActivity", "com.fsresidential.connect.activity.SplashActivity");
            cap.SetCapability("newCommandTimeout", "1000");
            cap.SetCapability("autoGrantPermissions", true);
            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           // driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"I AGREE\")").Click();
           
        }
        public void Wait()
        {
            Thread.Sleep(10000);
        }
      public void Agree()
        {
            Thread.Sleep(10000);
            driver.FindElementByXPath("//*[@text='I AGREE']").Click();
            //driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"I AGREE\")").Click();
        }

        public void market()
        {
             Thread.Sleep(10000);
            // driver.FindElementByXPath("//*[@text='Market']").Click();
            // driver.FindElementById("com.fsresidential.connect:id/marketLabel").Click();
            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"Market\")").Click();

        }
        public void selectMarket()
        {
            driver.FindElementByXPath("//*[@text='Florida']").Click();
            //driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"Florida\")").Click();
        }
        public void username()
        {
            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"Username\")").SendKeys("C4admin");
        }
        public void password()
        {
            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"Password\")").SendKeys("N4Et4wem@5+=V");
        }
        public void login()
        {
            driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"LOG IN\")").Click();
        }
       
    }
}
