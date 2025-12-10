

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerExternalIdSetMessagePayload : ICustomerExternalIdSetMessagePayload
    {
        public string Type { get; set; }

        public string ExternalId { get; set; }
        public CustomerExternalIdSetMessagePayload()
        {
            this.Type = "CustomerExternalIdSet";
        }
    }
}
