using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

[TestClass]
public class MainPageTests
{
    private static WindowsDriver driver;

    [ClassInitialize]
    public static void Setup(TestContext context)
    {
        var options = new AppiumOptions();
        options.PlatformName = "Windows"; // proprietà dedicata
        options.DeviceName = "WindowsPC"; // proprietà dedicata
        options.AddAdditionalAppiumOption(
                    "app",
                    @"C:\DatiAllievo\Laboratorio-MAUI\LaboratorioMAUI\AppConvertitore\bin\Debug\net8.0-windows10.0.19041.0\win10-x64\AppConvertitore.exe"
                );
        driver = new WindowsDriver(
            new Uri("http://127.0.0.1:4723"),
            options
        );
    }

    [TestMethod]
    public void EnterText_Franchi()
    {
        // Inserisce testo nell'entry con Id "franchi"
        driver.FindElement(By.Id("franchi")).SendKeys("123");
    }

    [TestMethod]
    public void Click_CounterBtn()
    {
        // Clicca sul pulsante con Id "CouterBtn"
        driver.FindElement(By.Id("CouterBtn")).Click();
    }

    [TestMethod]
    public void Click_BtnReset()
    {
        // Clicca sul pulsante con Id "BtnReset"
        driver.FindElement(By.Id("BtnReset")).Click();
    }

    [ClassCleanup]
    public static void TearDown()
    {
        // Chiude il driver alla fine di tutti i test
        if (driver != null)
        {
            driver.Quit();
            driver = null;
        }
    }
}
