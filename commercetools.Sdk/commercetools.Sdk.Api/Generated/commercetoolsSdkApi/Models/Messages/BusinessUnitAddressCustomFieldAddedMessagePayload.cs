using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressCustomFieldAddedMessagePayload : IBusinessUnitAddressCustomFieldAddedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public string AddressId { get; set; }
        public BusinessUnitAddressCustomFieldAddedMessagePayload()
        {
            this.Type = "BusinessUnitAddressCustomFieldAdded";
        }
    }
}
