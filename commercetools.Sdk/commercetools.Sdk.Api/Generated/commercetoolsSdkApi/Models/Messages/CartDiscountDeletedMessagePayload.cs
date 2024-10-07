

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartDiscountDeletedMessagePayload : ICartDiscountDeletedMessagePayload
    {
        public string Type { get; set; }
        public CartDiscountDeletedMessagePayload()
        {
            this.Type = "CartDiscountDeleted";
        }
    }
}
