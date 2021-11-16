using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListResourceIdentifier))]
    public partial interface IShoppingListResourceIdentifier : IResourceIdentifier
    {
    }
}
