using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using static DesktopAppTestAutomation.Helpers.ClickerHelpers;
using static DesktopAppTestAutomation.Pages.AddCardsTabPageObject;
using static DesktopAppTestAutomation.Pages.BasePageObject;
using DesktopAppTestAutomation.Helpers;
using DesktopAppTestAutomation.Configuration;
using DesktopAppTestAutomation.Interfaces;
using DesktopAppTestAutomation.Driver;

namespace DesktopAppTestAutomation
{
    [TestClass]
    public class AddCardsTab
    {
        private WindowsDriver<WindowsElement> Driver { get; set; }
        readonly IConfig config = new AppConfigReader();
        private readonly WinAppDriver appDriver = new WinAppDriver();

        [ClassInitialize]
        public static void InitializeBeforeAllTestCases(TestContext context)
        {
            WinAppDriver winAppDriver = new WinAppDriver();
            winAppDriver.LaunchWinAppDriverProcess();
        }

        [TestInitialize]
        public void InitializeForEachTestCase()
        {
            Driver = appDriver.GetWinAppDriver();
        }

        [TestCleanup]
        public void CleanUpForTestCase()
        {
            Driver.CloseApp();
        }

        [ClassCleanup]
        public static void CleanUpAfterAllTestCases()
        {
            WinAppDriver winAppDriver = new WinAppDriver();
            winAppDriver.CloseAppiumProcesses();
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void EmptyCardCreationValidation()
        {
            Driver.ClickElementByName(tabNameAddCards);
            Driver.ClickElementByAccessID(buttonCreateCard);
            Assert.AreEqual("'Construction, Meaning, Example, Type' fields cannot be empty!", Driver.GetElementPropertiesByAccessID(labelCreateCardValidation).Text);
        }

        [TestMethod]
        public void DefaultValuesOnAddCardsTab()
        {
            Driver.ClickElementByName(tabNameAddCards);
            var defaultStorage = Driver.GetElementPropertiesByAccessID(labelDefaultStorage).Text;
            Assert.AreEqual(config.GetDefaultStorageName(), defaultStorage);

            AssertHelpers.AreTextFieldsEmpty(Driver, listOfTextFields);
            AssertHelpers.IsElementNotPresent(Driver, labelCreateCardValidation);
            AssertHelpers.AreElementsClickable(Driver, listOfClickableElements);
        }

        [TestMethod]
        public void ClearButtonClearsPopulatedFields()
        {
            Driver.ClickElementByName(tabNameAddCards);
            Driver.PopulateTextField(textFieldConstruction, "cons1");
            Driver.PopulateTextField(textFieldMeaning, "mean1");
            Driver.PopulateTextField(textFieldExample, "exam1");
            Driver.PopulateTextField(dropDownMenuType, "Question");

            Driver.ClickElementByAccessID(buttonClear);

            AssertHelpers.AreTextFieldsEmpty(Driver, listOfTextFields);
            AssertHelpers.IsElementNotPresent(Driver, labelCreateCardValidation);
        }

        [TestMethod]
        public void ClearPopulatedFieldsBySwitchingToADifferentTab()
        {
            Driver.ClickElementByName(tabNameAddCards);
            Driver.PopulateTextField(textFieldConstruction, "cons1");
            Driver.PopulateTextField(textFieldMeaning, "mean1");
            Driver.PopulateTextField(textFieldExample, "exam1");
            Driver.PopulateTextField(dropDownMenuType, "Question");

            Driver.ClickElementByName(tabNameBrowseCards);
            Driver.ClickElementByName(tabNameAddCards);

            AssertHelpers.AreTextFieldsEmpty(Driver, listOfTextFields);
            AssertHelpers.IsElementNotPresent(Driver, labelCreateCardValidation);
        }

        [TestMethod]
        public void DefaultLabelValuesOnAddCardsTab()
        {
            Driver.ClickElementByName(tabNameAddCards);
            var arrayOfExpectedLabels = new string[] { "Adding Cards into Storage: ", "Construction", "Meaning", "Example", "Type" };
            AssertHelpers.DoLabelsMatch(Driver, listOfLabels, arrayOfExpectedLabels);
        }
    }
}
