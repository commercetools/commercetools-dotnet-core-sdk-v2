using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerAddressCustomFieldChangedMessagePayload : ICustomerAddressCustomFieldChangedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public Object PreviousValue { get; set; }

        public string AddressId { get; set; }
        public CustomerAddressCustomFieldChangedMessagePayload()
        {
            this.Type = "CustomerAddressCustomFieldChanged";
        }
    }
}
