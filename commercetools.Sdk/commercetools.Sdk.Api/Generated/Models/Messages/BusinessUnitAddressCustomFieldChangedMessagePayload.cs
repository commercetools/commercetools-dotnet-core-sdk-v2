using System;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressCustomFieldChangedMessagePayload : IBusinessUnitAddressCustomFieldChangedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public Object OldValue { get; set; }
        public BusinessUnitAddressCustomFieldChangedMessagePayload()
        {
            this.Type = "BusinessUnitAddressCustomFieldChanged";
        }
    }
}
