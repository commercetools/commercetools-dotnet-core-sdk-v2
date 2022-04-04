namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class CustomerEmailVerify : ICustomerEmailVerify
    {
        public long? Version { get; set; }

        public string TokenValue { get; set; }
    }
}
