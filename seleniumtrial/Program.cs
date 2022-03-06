using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumtrial
{
    internal class Program
    {
        static void Main()
        {
            //create a reference
            IWebDriver driver = new ChromeDriver();

            //Navigate to google
            driver.Navigate().GoToUrl("http://www.google.com");

            //finding the search bar
            IWebElement element = driver.FindElement(By.Name("q"));

            //typing the search element
            element.SendKeys("Softinbit");

            //clicking to search
            element.Submit();

            //finding the page
            IWebElement page = driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div[1]/div/a/h3"));

            page.Click();


            driver.Close();



        }
    }
}
