using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetShippingCustomTypeChange : ISetShippingCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string ShippingKey { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }
        public SetShippingCustomTypeChange()
        {
            this.Type = "SetShippingCustomTypeChange";
        }
    }
}
