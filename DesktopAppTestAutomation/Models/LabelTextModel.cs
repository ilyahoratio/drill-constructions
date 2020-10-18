namespace DesktopAppTestAutomation.Models
{
    public class LabelTextModel
    {
        public string LabelLocatorAccessID {get; set;}
        public string LabelText {get; set;}
        public LabelTextModel(string labelLocatorAccessID, string labelText)
        {
            LabelLocatorAccessID = labelLocatorAccessID;
            LabelText = labelText;
        }

        public override string ToString()
        {
            return LabelText;
        }
    }
}
