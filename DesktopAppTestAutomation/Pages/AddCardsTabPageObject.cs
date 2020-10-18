using DesktopAppTestAutomation.Models;
using System.Collections.Generic;

namespace DesktopAppTestAutomation.Pages
{
    public static class AddCardsTabPageObject
    {
        #region Buttons

        public static string buttonCreateCard = "BtnCreateCard";
        public static string buttonClear = "BtnClear";

        #endregion

        #region Labels

        public static string labelDefaultStorage = "LabelAddingIntoStorageName";
        public static string labelCreateCardValidation = "LabelAddCardInformation";


        public static LabelTextModel labelAddingCardsInto = new LabelTextModel("LabelAddingCardsInto", "Adding Cards into Storage: ");
        public static LabelTextModel labelConstruction = new LabelTextModel("LabelConstruction", "Construction");
        public static LabelTextModel labelMeaning = new LabelTextModel("LabelMeaning", "Meaning");
        public static LabelTextModel labelExample = new LabelTextModel("LabelExample", "Example");
        public static LabelTextModel labelType = new LabelTextModel("LabelType", "Type");
        

        #endregion

        #region Text Fields 

        public static string textFieldConstruction = "TxtConstruction";
        public static string textFieldMeaning = "TxtMeaning";
        public static string textFieldExample = "TxtExample";
        public static string dropDownMenuType = "ComboBoxType";

        #endregion

        #region Lists

        public static List<string> listOfTextFields = new List<string>()
        {
            textFieldConstruction, textFieldMeaning, textFieldExample, dropDownMenuType
        };

        public static List<string> listOfClickableElements = new List<string>()
        {
            textFieldConstruction, textFieldMeaning, textFieldExample, dropDownMenuType, buttonCreateCard, buttonClear
        };

        public static List<LabelTextModel> listOfLabels = new List<LabelTextModel>()
        {
            labelAddingCardsInto, labelConstruction, labelMeaning, labelExample, labelType
        };

        #endregion

    }
}
