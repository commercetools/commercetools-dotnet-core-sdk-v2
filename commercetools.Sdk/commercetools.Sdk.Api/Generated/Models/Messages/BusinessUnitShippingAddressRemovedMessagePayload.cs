using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitShippingAddressRemovedMessagePayload : IBusinessUnitShippingAddressRemovedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public BusinessUnitShippingAddressRemovedMessagePayload()
        {
            this.Type = "BusinessUnitShippingAddressRemoved";
        }
    }
}
