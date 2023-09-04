namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerAddressCustomTypeRemovedMessagePayload : ICustomerAddressCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string PreviousTypeId { get; set; }
        public CustomerAddressCustomTypeRemovedMessagePayload()
        {
            this.Type = "CustomerAddressCustomTypeRemoved";
        }
    }
}
