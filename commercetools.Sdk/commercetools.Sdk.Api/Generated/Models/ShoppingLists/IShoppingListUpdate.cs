using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListUpdate))]
    public partial interface IShoppingListUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IShoppingListUpdate, IShoppingListUpdateAction>
    {
        new long Version { get; set; }
        new IList<IShoppingListUpdateAction> Actions { get; set; }
        IEnumerable<IShoppingListUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
