namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerEmailVerifiedMessagePayload : ICustomerEmailVerifiedMessagePayload
    {
        public string Type { get; set; }
        public CustomerEmailVerifiedMessagePayload()
        {
            this.Type = "CustomerEmailVerified";
        }
    }
}
