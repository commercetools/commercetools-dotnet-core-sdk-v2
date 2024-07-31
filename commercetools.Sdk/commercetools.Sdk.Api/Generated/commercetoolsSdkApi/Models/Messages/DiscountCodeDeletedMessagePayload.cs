

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DiscountCodeDeletedMessagePayload : IDiscountCodeDeletedMessagePayload
    {
        public string Type { get; set; }
        public DiscountCodeDeletedMessagePayload()
        {
            this.Type = "DiscountCodeDeleted";
        }
    }
}
