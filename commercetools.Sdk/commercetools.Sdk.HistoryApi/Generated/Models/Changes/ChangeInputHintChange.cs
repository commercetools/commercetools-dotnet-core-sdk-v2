using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class ChangeInputHintChange : IChangeInputHintChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }

        public ITextInputHint NextValue { get; set; }

        public ITextInputHint PreviousValue { get; set; }
        public ChangeInputHintChange()
        {
            this.Type = "ChangeInputHintChange";
        }
    }
}
