using System;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerPasswordTokenCreatedMessagePayload : ICustomerPasswordTokenCreatedMessagePayload
    {
        public string Type { get; set; }

        public string CustomerId { get; set; }

        public DateTime ExpiresAt { get; set; }
        public CustomerPasswordTokenCreatedMessagePayload()
        {
            this.Type = "CustomerPasswordTokenCreated";
        }
    }
}
