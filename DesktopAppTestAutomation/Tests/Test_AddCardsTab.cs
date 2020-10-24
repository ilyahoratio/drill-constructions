using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using static DesktopAppTestAutomation.Helpers.ClickerHelpers;
using static DesktopAppTestAutomation.Pages.BasePageObject;
using DesktopAppTestAutomation.Helpers;
using DesktopAppTestAutomation.Configuration;
using DesktopAppTestAutomation.Interfaces;
using DesktopAppTestAutomation.Driver;
using DesktopAppTestAutomation.Pages;

namespace DesktopAppTestAutomation
{
    [TestClass]
    public class AddCardsTab
    {
        private WindowsDriver<WindowsElement> Driver { get; set; }
        readonly IConfig config = new AppConfigReader();
        private readonly WinAppDriver appDriver = new WinAppDriver();
        private AddCardsTabPageObject addCardsTab;

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
            addCardsTab = new AddCardsTabPageObject(Driver);
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
            Driver.ClickElementByAccessID(addCardsTab.ButtonCreateCard);
            Assert.AreEqual("'Construction, Meaning, Example, Type' fields cannot be empty!", Driver.GetElementPropertiesByAccessID(addCardsTab.LabelCreateCardValidation).Text);
        }

        [TestMethod]
        public void DefaultValuesOnAddCardsTab()
        {
            Driver.ClickElementByName(tabNameAddCards);
            var defaultStorage = Driver.GetElementPropertiesByAccessID(addCardsTab.LabelDefaultStorage).Text;
            Assert.AreEqual(config.GetDefaultStorageName(), defaultStorage);

            AssertHelpers.AreTextFieldsEmpty(Driver, addCardsTab.ListOfTextFields);
            AssertHelpers.IsElementNotPresent(Driver, addCardsTab.LabelCreateCardValidation);
            AssertHelpers.AreElementsClickable(Driver, addCardsTab.ListOfClickableElements);
        }

        [TestMethod]
        public void ClearButtonClearsPopulatedFields()
        {
            Driver.ClickElementByName(tabNameAddCards);
            Driver.PopulateTextField(addCardsTab.TextFieldConstruction, "cons1");
            Driver.PopulateTextField(addCardsTab.TextFieldMeaning, "mean1");
            Driver.PopulateTextField(addCardsTab.TextFieldExample, "exam1");
            Driver.PopulateTextField(addCardsTab.DropDownMenuType, "Question");

            Driver.ClickElementByAccessID(addCardsTab.ButtonClear);

            AssertHelpers.AreTextFieldsEmpty(Driver, addCardsTab.ListOfTextFields);
            AssertHelpers.IsElementNotPresent(Driver, addCardsTab.LabelCreateCardValidation);
        }

        [TestMethod]
        public void ClearPopulatedFieldsBySwitchingToADifferentTab()
        {
            Driver.ClickElementByName(tabNameAddCards);
            Driver.PopulateTextField(addCardsTab.TextFieldConstruction, "cons1");
            Driver.PopulateTextField(addCardsTab.TextFieldMeaning, "mean1");
            Driver.PopulateTextField(addCardsTab.TextFieldExample, "exam1");
            Driver.PopulateTextField(addCardsTab.DropDownMenuType, "Question");

            Driver.ClickElementByName(tabNameBrowseCards);
            Driver.ClickElementByName(tabNameAddCards);

            AssertHelpers.AreTextFieldsEmpty(Driver, addCardsTab.ListOfTextFields);
            AssertHelpers.IsElementNotPresent(Driver, addCardsTab.LabelCreateCardValidation);
        }

        [TestMethod]
        public void DefaultLabelValuesOnAddCardsTab()
        {
            Driver.ClickElementByName(tabNameAddCards);
            var arrayOfExpectedLabels = new string[] { "Adding Cards into Storage: ", "Construction", "Meaning", "Example", "Type" };
            AssertHelpers.DoLabelsMatch(Driver, addCardsTab.ListOfLabels, arrayOfExpectedLabels);
        }
    }
}
