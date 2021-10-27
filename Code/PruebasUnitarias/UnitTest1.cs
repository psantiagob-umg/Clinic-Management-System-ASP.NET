using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PruebasUnitarias
{
    public class LoginIncorrecto
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://localhost:1972/SignUp.aspx");
            driver.FindElement(By.Id("loginEmail")).Clear();
            driver.FindElement(By.Id("loginEmail")).SendKeys("ABC@gmail.com");
            driver.FindElement(By.Id("loginPassword")).Clear();
            driver.FindElement(By.Id("loginPassword")).SendKeys("abc123");
            driver.FindElement(By.Id("loginUserName")).Click();
            Assert.AreEqual("Incorrect Password. Try Again !", this.CloseAlertAndGetItsText());

        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }



    public class LoginCorrecto
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://localhost:1972/SignUp.aspx");
            driver.FindElement(By.Id("loginEmail")).Clear();
            driver.FindElement(By.Id("loginEmail")).SendKeys("ABC@gmail.com");
            driver.FindElement(By.Id("loginPassword")).Clear();
            driver.FindElement(By.Id("loginPassword")).SendKeys("abc");
            driver.FindElement(By.Id("loginUserName")).Click();
            Assert.AreEqual("ABC", driver.FindElement(By.Id("ContentPlaceHolder1_PName")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }


    public class PacienteConCitaYaAgendada
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://localhost:1972/SignUp.aspx");
            driver.FindElement(By.Id("loginEmail")).Click();
            driver.FindElement(By.Id("loginEmail")).Clear();
            driver.FindElement(By.Id("loginEmail")).SendKeys("ABC@gmail.com");
            driver.FindElement(By.Id("loginPassword")).Click();
            driver.FindElement(By.Id("loginPassword")).Clear();
            driver.FindElement(By.Id("loginPassword")).SendKeys("abc");
            driver.FindElement(By.Id("loginUserName")).Click();
            driver.FindElement(By.LinkText("Current Appointment")).Click();
            Assert.IsTrue(driver.PageSource.Contains("You have sent an appointment request") ||
                driver.PageSource.Contains("you have an appointment"));


            driver.FindElement(By.LinkText("Take Appointment")).Click();
            driver.FindElement(By.LinkText("Select")).Click();
            driver.FindElement(By.LinkText("Select")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_AppointmentB")).Click();
            driver.FindElement(By.LinkText("Select")).Click();
            driver.FindElement(By.Name("ctl00$ContentPlaceHolder1$ctl00")).Click();
            Assert.AreEqual("You have already requested for an Appointment. You cannot request for one more!", driver.FindElement(By.Id("ContentPlaceHolder1_Message")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }


    public class DoctorGeneraRecibo
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://localhost:1972/signup.aspx");
            driver.FindElement(By.Id("loginEmail")).Click();
            driver.FindElement(By.Id("loginEmail")).Clear();
            driver.FindElement(By.Id("loginEmail")).SendKeys("farhan@gmail.com");
            driver.FindElement(By.Id("loginPassword")).Click();
            driver.FindElement(By.Id("loginPassword")).Clear();
            driver.FindElement(By.Id("loginPassword")).SendKeys("abc");
            driver.FindElement(By.Id("loginUserName")).Click();
            driver.FindElement(By.LinkText("Todays Appointments")).Click();
            driver.FindElement(By.LinkText("Select")).Click();
            driver.FindElement(By.Id("Cp1_Disease")).Click();
            driver.FindElement(By.Id("Cp1_Disease")).Clear();
            driver.FindElement(By.Id("Cp1_Disease")).SendKeys("gripe");
            driver.FindElement(By.Id("Cp1_progress")).Clear();
            driver.FindElement(By.Id("Cp1_progress")).SendKeys("no");
            driver.FindElement(By.Id("Cp1_Prescription")).Clear();
            driver.FindElement(By.Id("Cp1_Prescription")).SendKeys("acetaminofen");
            driver.FindElement(By.Id("Cp1_Bill")).Click();
            Assert.IsTrue(IsElementPresent(By.Id("Cp3_Label1")));
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }

    public class AdminBorraDoctor
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://localhost:1972/SignUp.aspx");
            driver.FindElement(By.Id("loginEmail")).Click();
            driver.FindElement(By.Id("loginEmail")).Clear();
            driver.FindElement(By.Id("loginEmail")).SendKeys("admin@clinic.com");
            driver.FindElement(By.Id("loginPassword")).Click();
            driver.FindElement(By.Id("loginPassword")).Clear();
            driver.FindElement(By.Id("loginPassword")).SendKeys("admin");
            driver.FindElement(By.Id("loginUserName")).Click();
            driver.FindElement(By.LinkText("Manage Clinic")).Click();
            driver.FindElement(By.XPath("//table[@id='ContentPlaceHolder1_Manage']/tbody/tr[6]/td/a")).Click();
            // Warning: assertTextPresent may require manual changes
            Assert.IsTrue(driver.PageSource.Contains("Doctor Deleted"));
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }

}
