using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressChangedMessagePayload : IBusinessUnitAddressChangedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public BusinessUnitAddressChangedMessagePayload()
        {
            this.Type = "BusinessUnitAddressChanged";
        }
    }
}
