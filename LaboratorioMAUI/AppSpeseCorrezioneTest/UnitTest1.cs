using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System.ComponentModel.DataAnnotations;

namespace AppSpeseCorrezioneTest
{
    public class Tests
    {
        private WindowsDriver _driver;
        [SetUp]
        public void Setup()
        {
            var option = new AppiumOptions();
            option.PlatformName = "Windows";
            option.AutomationName = "Windows";
            option.DeviceName = "WindowsPC";
            option.App = "com.companyname.appspesecorrezione_9zz4h110yvjzm!App";

            option.AddAdditionalAppiumOption("ms:experimental-webdriver", true);
            option.AddAdditionalAppiumOption("ms:waitForAppLaunch", "10");

            var serverUri = new Uri("http://127.0.0.1:4723/");
            _driver = new WindowsDriver(serverUri, option);
        }

        [Test]
        public void Test_verificaTitoloApp()
        {
            Assert.That(_driver.Title, Is.EqualTo("AppSpeseCorrezione").Or.Contain("LE MIE SPESE"));
        }

        [Test]
        public void Test_Inserimento()
        {
            //Aspettiamo 3 secondi che l'app sia caricata
            System.Threading.Thread.Sleep(3000);

            //Nella variabile inserisco l'elemento che ha l'automationID = EntNomeLista
            var inputNomeLista = _driver.FindElement(MobileBy.AccessibilityId("EntNomeLista"));
            //Mettiamo il focus sul entry interessato
            inputNomeLista.Click();
            //Puliamo l'entry
            inputNomeLista.Clear();
            //Scriviamo Nel controllo
            inputNomeLista.SendKeys("Spesa Aprile");
            Assert.That(inputNomeLista.Text, Is.EqualTo("Spesa Aprile"));
            

            var inputDescrizione = _driver.FindElement(MobileBy.AccessibilityId("EntDescrizione"));
            inputDescrizione.Click();
            inputDescrizione.Clear();
            inputDescrizione.SendKeys("Supermercato");
            Assert.That(inputDescrizione.Text, Is.EqualTo("Supermercato"));

            var inputImporto = _driver.FindElement(MobileBy.AccessibilityId("EntImporto"));
            inputImporto.Click();
            inputImporto.Clear();
            inputImporto.SendKeys("20");
            Assert.That(inputImporto.Text, Is.EqualTo("20"));
        }
        [Test]
        public void Test_Click()
        {
            var inputButton = _driver.FindElement(MobileBy.AccessibilityId("EntImporto"));
            inputButton.Click();
            Assert.That(inputButton.Text, Is.EqualTo("SalvaBtn"));
        }


        [TearDown]

        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}