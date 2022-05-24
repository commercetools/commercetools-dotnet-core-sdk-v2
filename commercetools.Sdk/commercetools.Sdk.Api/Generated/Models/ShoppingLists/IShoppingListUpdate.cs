using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListUpdate))]
    public partial interface IShoppingListUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IShoppingListUpdate, IShoppingListUpdateAction>
    {
        new long Version { get; set; }
        new List<IShoppingListUpdateAction> Actions { get; set; }
    }
}
