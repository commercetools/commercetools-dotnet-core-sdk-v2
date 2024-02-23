using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressRemovedMessagePayload : IBusinessUnitAddressRemovedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public BusinessUnitAddressRemovedMessagePayload()
        {
            this.Type = "BusinessUnitAddressRemoved";
        }
    }
}
