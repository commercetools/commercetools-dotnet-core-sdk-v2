using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitCustomFieldChangedMessagePayload : IBusinessUnitCustomFieldChangedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public Object OldValue { get; set; }
        public BusinessUnitCustomFieldChangedMessagePayload()
        {
            this.Type = "BusinessUnitCustomFieldChanged";
        }
    }
}
