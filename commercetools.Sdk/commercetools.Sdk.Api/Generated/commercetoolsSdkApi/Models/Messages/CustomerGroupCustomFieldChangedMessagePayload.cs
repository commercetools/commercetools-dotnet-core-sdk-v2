using System;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerGroupCustomFieldChangedMessagePayload : ICustomerGroupCustomFieldChangedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public Object OldValue { get; set; }
        public CustomerGroupCustomFieldChangedMessagePayload()
        {
            this.Type = "CustomerGroupCustomFieldChanged";
        }
    }
}
