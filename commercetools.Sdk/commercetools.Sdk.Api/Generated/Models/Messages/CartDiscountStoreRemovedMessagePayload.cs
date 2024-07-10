using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartDiscountStoreRemovedMessagePayload : ICartDiscountStoreRemovedMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }
        public CartDiscountStoreRemovedMessagePayload()
        {
            this.Type = "CartDiscountStoreRemoved";
        }
    }
}
