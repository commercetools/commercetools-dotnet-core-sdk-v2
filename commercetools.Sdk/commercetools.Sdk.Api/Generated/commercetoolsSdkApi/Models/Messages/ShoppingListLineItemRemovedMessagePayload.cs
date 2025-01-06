using commercetools.Sdk.Api.Models.ShoppingLists;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ShoppingListLineItemRemovedMessagePayload : IShoppingListLineItemRemovedMessagePayload
    {
        public string Type { get; set; }

        public IShoppingListLineItem LineItem { get; set; }
        public ShoppingListLineItemRemovedMessagePayload()
        {
            this.Type = "ShoppingListLineItemRemoved";
        }
    }
}
