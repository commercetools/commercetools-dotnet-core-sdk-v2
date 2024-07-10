using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitDefaultBillingAddressSetMessagePayload : IBusinessUnitDefaultBillingAddressSetMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public BusinessUnitDefaultBillingAddressSetMessagePayload()
        {
            this.Type = "BusinessUnitDefaultBillingAddressSet";
        }
    }
}
