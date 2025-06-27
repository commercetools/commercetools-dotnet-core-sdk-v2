

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DiscountGroupDeletedMessagePayload : IDiscountGroupDeletedMessagePayload
    {
        public string Type { get; set; }
        public DiscountGroupDeletedMessagePayload()
        {
            this.Type = "DiscountGroupDeleted";
        }
    }
}
