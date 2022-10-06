using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitBillingAddressRemovedMessagePayload : IBusinessUnitBillingAddressRemovedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public BusinessUnitBillingAddressRemovedMessagePayload()
        {
            this.Type = "BusinessUnitBillingAddressRemoved";
        }
    }
}
