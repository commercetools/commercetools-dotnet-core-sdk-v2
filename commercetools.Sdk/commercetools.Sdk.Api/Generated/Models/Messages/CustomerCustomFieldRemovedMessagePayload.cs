namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerCustomFieldRemovedMessagePayload : ICustomerCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }
        public CustomerCustomFieldRemovedMessagePayload()
        {
            this.Type = "CustomerCustomFieldRemoved";
        }
    }
}
