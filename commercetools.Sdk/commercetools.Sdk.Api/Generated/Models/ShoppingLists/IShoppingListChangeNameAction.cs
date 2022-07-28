using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeNameAction))]
    public partial interface IShoppingListChangeNameAction : IShoppingListUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
