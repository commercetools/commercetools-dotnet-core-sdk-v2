using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetLineItemCustomTypeAction : IShoppingListSetLineItemCustomTypeAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ShoppingListSetLineItemCustomTypeAction()
        {
            this.Action = "setLineItemCustomType";
        }
    }
}
