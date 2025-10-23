using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeInputHintChange : IChangeInputHintChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITypeTextInputHint PreviousValue { get; set; }

        public ITypeTextInputHint NextValue { get; set; }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }
        public ChangeInputHintChange()
        {
            this.Type = "ChangeInputHintChange";
        }
    }
}
