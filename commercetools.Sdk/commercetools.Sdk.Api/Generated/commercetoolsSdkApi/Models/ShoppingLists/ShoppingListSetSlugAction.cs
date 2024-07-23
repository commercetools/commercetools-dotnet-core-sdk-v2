using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetSlugAction : IShoppingListSetSlugAction
    {
        public string Action { get; set; }

        public ILocalizedString Slug { get; set; }
        public ShoppingListSetSlugAction()
        {
            this.Action = "setSlug";
        }
    }
}
