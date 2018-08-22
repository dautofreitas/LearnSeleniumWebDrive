using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;



namespace SelecniumTestes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          //  System.setProperty("webdriver.gecko.driver","D:\\Firefox\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://172.26.254.13/ITGPortal/";
            driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_txtChaveUsuario']")).SendKeys("*Usuário*");       

            driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_txtSenhaUsuario']")).SendKeys("*Senha*");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_btLogin']")).Click();

            driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_BtnNovaSolicitacao']")).Click();           

            SelectElement tipoRequest = new SelectElement(driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_ddlServicos']")));

            tipoRequest.SelectByText("Deployment");

            Thread.Sleep(10000);

            
            /* driver.Navigate().Back();
             driver.Navigate().Forward();
             driver.Navigate().Back();
             driver.Navigate().Refresh();*/
            driver.Close();
            
        }
    }
}
