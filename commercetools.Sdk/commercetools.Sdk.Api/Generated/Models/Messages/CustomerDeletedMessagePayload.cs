namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerDeletedMessagePayload : ICustomerDeletedMessagePayload
    {
        public string Type { get; set; }
        public CustomerDeletedMessagePayload()
        {
            this.Type = "CustomerDeleted";
        }
    }
}
