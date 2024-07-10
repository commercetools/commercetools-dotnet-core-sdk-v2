using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitDefaultShippingAddressSetMessagePayload : IBusinessUnitDefaultShippingAddressSetMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public BusinessUnitDefaultShippingAddressSetMessagePayload()
        {
            this.Type = "BusinessUnitDefaultShippingAddressSet";
        }
    }
}
