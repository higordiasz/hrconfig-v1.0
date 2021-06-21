using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using HRConfig.Model;

namespace HRConfig.Clases
{
    class Gmail
    {
        public GmailModel CriarGmail (string email, string senha, string nome ,string criar, int numeric)
        {
            string e_criar = criar + ".hrmoney" + numeric.ToString();
            GmailModel retorno = new GmailModel
            {
                Status = 0,
                Email = e_criar,
                Senha = senha,
                Response = ""
            };

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless");
            IWebDriver driver = new ChromeDriver(options);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                driver.Navigate().GoToUrl("");
                wait.Until(d => d.FindElement(By.Id("firstName")));
                driver.FindElement(By.Id("firstName")).SendKeys(nome);
                driver.FindElement(By.Id("lastName")).SendKeys("HRMoney");
                driver.FindElement(By.Id("username")).SendKeys(e_criar);
                driver.FindElement(By.Name("Passwd")).SendKeys(senha);
                driver.FindElement(By.Name("ConfirmPasswd")).SendKeys(senha);
                driver.FindElement(By.Id("accountDetailsNext")).Click();
                wait.Until(d => d.FindElement(By.Id("day")));
                driver.FindElement(By.Id("day")).SendKeys(DateTime.Today.Day.ToString());
                var select = driver.FindElement(By.Id("month"));
                var selectElement = new SelectElement(select);
                selectElement.SelectByValue(DateTime.Today.Month.ToString());
                driver.FindElement(By.Id("year")).SendKeys(DateTime.Today.AddYears(-11).Year.ToString());
                select = driver.FindElement(By.Id("gender"));
                selectElement = new SelectElement(select);
                selectElement.SelectByValue("3");
                
            } catch (Exception ex)
            {
                retorno.Response = ex.Message;
            }

            return retorno;
        }
    }
}
