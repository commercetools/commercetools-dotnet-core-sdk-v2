using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerEmailTokenCreatedMessagePayload : ICustomerEmailTokenCreatedMessagePayload
    {
        public string Type { get; set; }

        public string CustomerId { get; set; }

        public DateTime ExpiresAt { get; set; }

        public string Value { get; set; }

        public bool InvalidateOlderTokens { get; set; }
        public CustomerEmailTokenCreatedMessagePayload()
        {
            this.Type = "CustomerEmailTokenCreated";
        }
    }
}
