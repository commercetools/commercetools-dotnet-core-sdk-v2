using System;

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerToken : ICustomerToken
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }

        public string Value { get; set; }

        public DateTime ExpiresAt { get; set; }

        public bool InvalidateOlderTokens { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? LastModifiedAt { get; set; }
    }
}
