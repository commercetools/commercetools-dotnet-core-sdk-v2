namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerGroupCustomTypeRemovedMessagePayload : ICustomerGroupCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string OldTypeId { get; set; }
        public CustomerGroupCustomTypeRemovedMessagePayload()
        {
            this.Type = "CustomerGroupCustomTypeRemoved";
        }
    }
}
