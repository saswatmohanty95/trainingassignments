using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Assessment
{

    [TestClass]
    public class UnitTest3
    {
       

        [TestMethod]
        public void TestMethod1()
        {


            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Selenium Jar", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            IWebDriver driver = new FirefoxDriver(service);
            //IWebDriver driver = new ChromeDriver("C:\\Selenium Jar");
            driver.Url = ("http://www.youcandealwithit.com/");
            Thread.Sleep(2000);
            IWebElement vBorrow = driver.FindElement(By.XPath("//a[text()='Borrowers']"));
            Actions act = new Actions(driver);
            act.MoveToElement(vBorrow).Build().Perform();
            Thread.Sleep(2000);
            String link1= driver.FindElement(By.LinkText("Calculators & Resources")).Text;
            driver.FindElement(By.LinkText("Calculators & Resources")).Click();
            string title1 = driver.Title;
            String link2 = driver.FindElement(By.LinkText("Calculators")).Text;
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Calculators")).Click();
            string title2 = driver.Title;
            String link3 = driver.FindElement(By.LinkText("Budget Calculator")).Text;
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Budget Calculator")).Click();
            string title3 = driver.Title;
            Thread.Sleep(2000);
            String foodmoney = "5000";
            String clothmoney = "1500";
            String sheltermoney = "1800";
            String monthpay = "20000";
            String monthothers = "6000";
            driver.FindElement(By.Id("food")).SendKeys(foodmoney);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("clothing")).SendKeys(clothmoney);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("shelter")).SendKeys(sheltermoney);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='monthlyPay']")).SendKeys(monthpay);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='monthlyOther']")).SendKeys(monthothers);
            Thread.Sleep(2000);
            String totalmonthlyexpenses= driver.FindElement(By.Id("totalMonthlyExpenses")).GetAttribute("value");
            Console.WriteLine("Your Monthly Pay= "+ monthpay);
            Console.WriteLine("Total Monthly Expenses= "+totalmonthlyexpenses);
            Thread.Sleep(2000);
            double totmonexp = Convert.ToDouble(totalmonthlyexpenses);
            double monpay = Convert.ToDouble(monthpay);
            if (totmonexp >= monpay)
            {
                Console.WriteLine("You are an Warren Buffet");
            }
            else
            {
                Console.WriteLine("You are an Vijay Mallya");
            }

            Thread.Sleep(2000);

            if (title1.Contains(link1))
            {
                Console.WriteLine(link1 +" Link Pass");
            }
            else
            {
                Console.WriteLine(link1 + " Link Fail");
            }


            if (title2.Contains(link2))
            {
                Console.WriteLine(link2 + " Link Pass");
            }
            else
            {
                Console.WriteLine(link2 + " Link Fail");
            }


            if (title3.Contains(link3))
            {
                Console.WriteLine(link3 + " Link Pass");
            }
            else
            {
                Console.WriteLine(link3 + " Link Fail");
            }

            Thread.Sleep(2000);
          

            driver.Close();




        }
    }
}
