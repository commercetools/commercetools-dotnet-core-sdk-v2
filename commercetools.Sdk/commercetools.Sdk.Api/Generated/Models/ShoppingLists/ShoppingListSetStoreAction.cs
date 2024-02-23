using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetStoreAction : IShoppingListSetStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public ShoppingListSetStoreAction()
        {
            this.Action = "setStore";
        }
    }
}
