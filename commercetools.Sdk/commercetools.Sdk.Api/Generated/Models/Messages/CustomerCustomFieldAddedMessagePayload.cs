using System;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerCustomFieldAddedMessagePayload : ICustomerCustomFieldAddedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CustomerCustomFieldAddedMessagePayload()
        {
            this.Type = "CustomerCustomFieldAdded";
        }
    }
}
