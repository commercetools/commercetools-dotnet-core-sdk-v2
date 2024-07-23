using System;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerGroupCustomFieldAddedMessagePayload : ICustomerGroupCustomFieldAddedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CustomerGroupCustomFieldAddedMessagePayload()
        {
            this.Type = "CustomerGroupCustomFieldAdded";
        }
    }
}
