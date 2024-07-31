

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerGroupCustomFieldRemovedMessagePayload : ICustomerGroupCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }
        public CustomerGroupCustomFieldRemovedMessagePayload()
        {
            this.Type = "CustomerGroupCustomFieldRemoved";
        }
    }
}
