using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeValueChange : IChangeValueChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IChangeValueChangeValue PreviousValue { get; set; }

        public IChangeValueChangeValue NextValue { get; set; }
        public ChangeValueChange()
        {
            this.Type = "ChangeValueChange";
        }
    }
}
