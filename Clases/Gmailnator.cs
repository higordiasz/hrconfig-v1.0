using HRConfig.Controller;
using HRConfig.Helpers;
using HRConfig.Model;
using InstagramApiSharp.Classes;
using MongoDB.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRConfig.Clases
{
    class Class_Gmailnator
    {
        public async Task<string> CreatAccount(string email, string username, string password, string name)
        {
            string resposta = "";
            var checkEmail = await HelpersInstaApi.InstaApi.CheckEmailAsync(email);
            if (checkEmail.Succeeded && checkEmail.Value.Available)
            {
                var create = await HelpersInstaApi.InstaApi.CreateNewAccountAsync(username, password, email, name);
                if (create.Succeeded && create.Value.AccountCreated)
                {
                    resposta = $"[+] Create Account | Status: Success | Username: {username} | Password: {password}";
                }
                else
                {
                    resposta = $"[+] Create Account | Status: Failed | Error: {create.Info.Message}";
                }
            }
            else
            {
                resposta = $"[+] Create Account | Status: Failed | Error: {checkEmail.Info.Message}";
            }

            return resposta;
        }

        public async Task<GmailNator> CriarGmailnator(string usuario, string senha, string nome)
        {
            GmailNator retorno = new GmailNator
            {
                Status = 0,
                Email = "",
                Codigo = "",
                Response = ""
            };

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless");
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                driver.Navigate().GoToUrl("https://gmailnator.com/");
                Thread.Sleep(3000);
                wait.Until(d => d.FindElement(By.Id("option-2")));
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("document.getElementById('option-1').click()");
                js.ExecuteScript("document.getElementById('option-2').click()");
                //driver.FindElement(By.CssSelector("label[for='option-2']")).Click();
                //driver.FindElement(By.CssSelector("label[for='option-1']")).Click();
                Thread.Sleep(3000);
                js.ExecuteScript("document.getElementById('generate_button').click()");
                //driver.FindElement(By.Id("generate_button")).Click();
                Thread.Sleep(3000);
                js.ExecuteScript("document.getElementById('button_go').click()");
                //driver.FindElement(By.Id("button_go")).Click();
                IWebElement element =  wait.Until(d => d.FindElement(By.Id("email_address")));
                Thread.Sleep(3000);
                retorno.Email = (string)js.ExecuteScript("return document.getElementById('email_address').innerText");
                //retorno.Email = element.Text;
                MessageBox.Show(retorno.Email, "Teste", MessageBoxButtons.OK);
                string create = await CreatAccount(retorno.Email, usuario, senha, nome);
                retorno.Response = create;
                MessageBox.Show(retorno.Email, "Email:", MessageBoxButtons.OK);
                if (retorno.Response.Contains("Success"))
                {
                    retorno.Status = 1;
                }
            }
            catch (Exception ex)
            {
                retorno.Response = ex.Message;
            }
            driver.Quit();
            return retorno;
        }
    }
}
