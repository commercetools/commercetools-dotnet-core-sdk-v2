using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListUpdate))]
    public partial interface IShoppingListUpdate
    {
        long Version { get; set; }

        List<IShoppingListUpdateAction> Actions { get; set; }
    }
}
