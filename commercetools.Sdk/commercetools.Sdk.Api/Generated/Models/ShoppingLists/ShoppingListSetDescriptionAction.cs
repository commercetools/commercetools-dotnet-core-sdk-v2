using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetDescriptionAction : IShoppingListSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public ShoppingListSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
