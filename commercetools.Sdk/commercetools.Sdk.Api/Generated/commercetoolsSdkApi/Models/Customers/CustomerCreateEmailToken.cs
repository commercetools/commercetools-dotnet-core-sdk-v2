

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerCreateEmailToken : ICustomerCreateEmailToken
    {
        public string Id { get; set; }

        public long? Version { get; set; }

        public long TtlMinutes { get; set; }

        public bool? InvalidateOlderTokens { get; set; }
    }
}
