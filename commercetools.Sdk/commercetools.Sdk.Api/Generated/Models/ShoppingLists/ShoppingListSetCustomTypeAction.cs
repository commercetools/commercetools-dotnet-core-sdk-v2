using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListSetCustomTypeAction : IShoppingListSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ShoppingListSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
