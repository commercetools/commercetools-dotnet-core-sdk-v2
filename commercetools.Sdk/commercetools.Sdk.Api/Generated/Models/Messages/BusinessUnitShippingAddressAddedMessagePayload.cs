using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitShippingAddressAddedMessagePayload : IBusinessUnitShippingAddressAddedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public BusinessUnitShippingAddressAddedMessagePayload()
        {
            this.Type = "BusinessUnitShippingAddressAdded";
        }
    }
}
