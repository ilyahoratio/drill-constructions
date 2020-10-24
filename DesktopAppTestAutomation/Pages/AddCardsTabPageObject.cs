using DesktopAppTestAutomation.Models;
using OpenQA.Selenium.Appium.Windows;
using System.Collections.Generic;

namespace DesktopAppTestAutomation.Pages
{
    internal class AddCardsTabPageObject : BasePageObject
    {
        #region Buttons

        public AddCardsTabPageObject(WindowsDriver<WindowsElement> winDriver) : base(winDriver) { }

        public string ButtonCreateCard => "BtnCreateCard";
        public string ButtonClear => "BtnClear";

        #endregion

        #region Labels

        public string LabelDefaultStorage => "LabelAddingIntoStorageName";
        public string LabelCreateCardValidation => "LabelAddCardInformation";


        public LabelTextModel LabelAddingCardsInto => new LabelTextModel("LabelAddingCardsInto", "Adding Cards into Storage: ");
        public LabelTextModel LabelConstruction => new LabelTextModel("LabelConstruction", "Construction");
        public LabelTextModel LabelMeaning => new LabelTextModel("LabelMeaning", "Meaning");
        public LabelTextModel LabelExample => new LabelTextModel("LabelExample", "Example");
        public LabelTextModel LabelType => new LabelTextModel("LabelType", "Type");
        

        #endregion

        #region Text Fields 

        public string TextFieldConstruction => "TxtConstruction";
        public string TextFieldMeaning => "TxtMeaning";
        public string TextFieldExample => "TxtExample";
        public string DropDownMenuType => "ComboBoxType";

        #endregion

        #region Lists

        public List<string> ListOfTextFields => new List<string>()
        {
            TextFieldConstruction, TextFieldMeaning, TextFieldExample, DropDownMenuType
        };

        public List<string> ListOfClickableElements => new List<string>()
        {
            TextFieldConstruction, TextFieldMeaning, TextFieldExample, DropDownMenuType, ButtonCreateCard, ButtonClear
        };

        public List<LabelTextModel> ListOfLabels => new List<LabelTextModel>()
        {
            LabelAddingCardsInto, LabelConstruction, LabelMeaning, LabelExample, LabelType
        };

        #endregion

    }
}
