

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressCustomFieldRemovedMessagePayload : IBusinessUnitAddressCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string AddressId { get; set; }
        public BusinessUnitAddressCustomFieldRemovedMessagePayload()
        {
            this.Type = "BusinessUnitAddressCustomFieldRemoved";
        }
    }
}
