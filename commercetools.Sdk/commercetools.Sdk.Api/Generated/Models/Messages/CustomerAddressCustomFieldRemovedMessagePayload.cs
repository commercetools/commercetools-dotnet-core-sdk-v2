namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerAddressCustomFieldRemovedMessagePayload : ICustomerAddressCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string AddressId { get; set; }
        public CustomerAddressCustomFieldRemovedMessagePayload()
        {
            this.Type = "CustomerAddressCustomFieldRemoved";
        }
    }
}
