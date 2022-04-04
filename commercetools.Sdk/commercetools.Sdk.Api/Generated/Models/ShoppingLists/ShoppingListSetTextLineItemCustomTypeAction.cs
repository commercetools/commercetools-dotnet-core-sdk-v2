using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    public partial class ShoppingListSetTextLineItemCustomTypeAction : IShoppingListSetTextLineItemCustomTypeAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ShoppingListSetTextLineItemCustomTypeAction()
        {
            this.Action = "setTextLineItemCustomType";
        }
    }
}
