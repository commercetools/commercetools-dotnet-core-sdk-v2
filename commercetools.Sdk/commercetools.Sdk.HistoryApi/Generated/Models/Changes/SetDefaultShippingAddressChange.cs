using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDefaultShippingAddressChange : ISetDefaultShippingAddressChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAddress PreviousValue { get; set; }

        public IAddress NextValue { get; set; }
        public SetDefaultShippingAddressChange()
        {
            this.Type = "SetDefaultShippingAddressChange";
        }
    }
}
