using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Assessment
{
 
    [TestClass]
    public class UnitTest2
    {

        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new ChromeDriver("C:\\Selenium Jar");
            driver.Url = ("https://www.google.com/");
            String givenname = "dxc technology";
            driver.FindElement(By.Name("q")).SendKeys(givenname);
            Thread.Sleep(2000);
            driver.FindElement(By.Name("btnK")).Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            
            Console.WriteLine(title);
            Thread.Sleep(2000);
            string resultsStats = driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div[7]/div[1]/div/div/div/div")).Text;
            Console.WriteLine(resultsStats);


            if (title.Contains(givenname))
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            driver.Close();
        }
    }
}
