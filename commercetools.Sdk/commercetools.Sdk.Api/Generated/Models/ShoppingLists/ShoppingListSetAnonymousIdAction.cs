namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    public partial class ShoppingListSetAnonymousIdAction : IShoppingListSetAnonymousIdAction
    {
        public string Action { get; set; }

        public string AnonymousId { get; set; }
        public ShoppingListSetAnonymousIdAction()
        {
            this.Action = "setAnonymousId";
        }
    }
}
