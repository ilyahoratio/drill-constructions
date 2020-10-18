using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTestAutomation.Pages
{
    public static class AddCardsTabPageObject
    {
        #region Buttons

        public static string buttonCreateCard = "BtnCreateCard";
        public static string buttonClear = "BtnClear";

        #endregion

        #region Labels

        public static string labelCreateCardValidation = "LabelAddCardInformation";
        public static string labelDefaultStorage = "LabelAddingIntoStorageName";

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

        #endregion

    }
}
