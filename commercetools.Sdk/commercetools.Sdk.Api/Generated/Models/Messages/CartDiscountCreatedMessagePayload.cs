using commercetools.Sdk.Api.Models.CartDiscounts;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartDiscountCreatedMessagePayload : ICartDiscountCreatedMessagePayload
    {
        public string Type { get; set; }

        public ICartDiscount CartDiscount { get; set; }
        public CartDiscountCreatedMessagePayload()
        {
            this.Type = "CartDiscountCreated";
        }
    }
}
