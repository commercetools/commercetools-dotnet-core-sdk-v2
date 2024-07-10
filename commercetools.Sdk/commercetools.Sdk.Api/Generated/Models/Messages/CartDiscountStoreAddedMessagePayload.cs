using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartDiscountStoreAddedMessagePayload : ICartDiscountStoreAddedMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }
        public CartDiscountStoreAddedMessagePayload()
        {
            this.Type = "CartDiscountStoreAdded";
        }
    }
}
