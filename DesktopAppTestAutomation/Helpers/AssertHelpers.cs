using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;

namespace DesktopAppTestAutomation.Helpers
{
    public static class AssertHelpers
    {
        public static void AreTextFieldsEmpty(WindowsDriver<WindowsElement> driver, List<string> listOfElements)
        {
            foreach (var textField in listOfElements)
            {
                Assert.IsTrue(driver.IsElementEmpty(textField));
            }
        }

        public static void AreElementsClickable(WindowsDriver<WindowsElement> driver, List<string> listOfElements)
        {
            foreach (var windowsElement in listOfElements)
            {
                Assert.IsTrue(driver.IsElementEnabled(windowsElement));
            }
        }

        public static void DoLabelsMatch<T>(WindowsDriver<WindowsElement> driver, List<T> listOfElements, string[] listOfExpectedLabels)
        {
            for (int i = 0; i < listOfElements.Count; i ++)
            {
                Assert.AreEqual(listOfExpectedLabels[i], listOfElements[i].ToString());
            }
        }

        public static void IsElementNotPresent(WindowsDriver<WindowsElement> driver, string elementAccessID)
        {
            try
            {
                ElementPropertiesHelpers.IsElementVisible(driver, elementAccessID);
            }
            catch (WebDriverException e)
            {
                Assert.AreEqual("An element could not be located on the page using the given search parameters.", e.Message);
            }
        }
    }
}
