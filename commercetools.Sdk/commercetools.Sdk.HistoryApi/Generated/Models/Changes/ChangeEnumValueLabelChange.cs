namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeEnumValueLabelChange : IChangeEnumValueLabelChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string FieldName { get; set; }

        public string ValueKey { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public ChangeEnumValueLabelChange()
        {
            this.Type = "ChangeEnumValueLabelChange";
        }
    }
}
