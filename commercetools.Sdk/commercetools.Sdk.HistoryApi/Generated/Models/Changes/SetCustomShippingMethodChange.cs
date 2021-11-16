using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetCustomShippingMethodChange : ISetCustomShippingMethodChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomShippingMethodChangeValue NextValue { get; set; }

        public ICustomShippingMethodChangeValue PreviousValue { get; set; }
        public SetCustomShippingMethodChange()
        {
            this.Type = "SetCustomShippingMethodChange";
        }
    }
}
