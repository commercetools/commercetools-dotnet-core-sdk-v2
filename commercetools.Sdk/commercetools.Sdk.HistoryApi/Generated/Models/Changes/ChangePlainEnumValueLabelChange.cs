namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class ChangePlainEnumValueLabelChange : IChangePlainEnumValueLabelChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string AttributeName { get; set; }

        public string ValueKey { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public ChangePlainEnumValueLabelChange()
        {
            this.Type = "ChangePlainEnumValueLabelChange";
        }
    }
}
