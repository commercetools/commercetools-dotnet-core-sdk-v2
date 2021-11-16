using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListSetSlugAction : IShoppingListSetSlugAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Slug { get; set;}
        public ShoppingListSetSlugAction()
        { 
           this.Action = "setSlug";
        }
    }
}
