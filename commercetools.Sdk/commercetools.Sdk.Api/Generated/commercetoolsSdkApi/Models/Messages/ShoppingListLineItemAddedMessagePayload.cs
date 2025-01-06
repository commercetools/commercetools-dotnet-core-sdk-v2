using commercetools.Sdk.Api.Models.ShoppingLists;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ShoppingListLineItemAddedMessagePayload : IShoppingListLineItemAddedMessagePayload
    {
        public string Type { get; set; }

        public IShoppingListLineItem LineItem { get; set; }
        public ShoppingListLineItemAddedMessagePayload()
        {
            this.Type = "ShoppingListLineItemAdded";
        }
    }
}
