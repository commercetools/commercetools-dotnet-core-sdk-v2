using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitCustomFieldAddedMessagePayload : IBusinessUnitCustomFieldAddedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public BusinessUnitCustomFieldAddedMessagePayload()
        {
            this.Type = "BusinessUnitCustomFieldAdded";
        }
    }
}
