using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class ShoppingListStoreSetMessagePayload : IShoppingListStoreSetMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }
        public ShoppingListStoreSetMessagePayload()
        {
            this.Type = "ShoppingListStoreSet";
        }
    }
}
