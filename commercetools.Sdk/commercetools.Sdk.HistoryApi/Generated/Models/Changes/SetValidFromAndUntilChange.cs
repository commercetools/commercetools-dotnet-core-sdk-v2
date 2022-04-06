using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetValidFromAndUntilChange : ISetValidFromAndUntilChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IValidFromAndUntilValue PreviousValue { get; set; }

        public IValidFromAndUntilValue NextValue { get; set; }
        public SetValidFromAndUntilChange()
        {
            this.Type = "SetValidFromAndUntilChange";
        }
    }
}
