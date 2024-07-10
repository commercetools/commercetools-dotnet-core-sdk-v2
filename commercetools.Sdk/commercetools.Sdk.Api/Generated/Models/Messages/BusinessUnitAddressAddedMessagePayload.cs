using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressAddedMessagePayload : IBusinessUnitAddressAddedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public BusinessUnitAddressAddedMessagePayload()
        {
            this.Type = "BusinessUnitAddressAdded";
        }
    }
}
