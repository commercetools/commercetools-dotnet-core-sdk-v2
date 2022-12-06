using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemsOrderAction))]
    public partial interface IShoppingListChangeLineItemsOrderAction : IShoppingListUpdateAction
    {
        IList<string> LineItemOrder { get; set; }
        IEnumerable<string> LineItemOrderEnumerable { set => LineItemOrder = value.ToList(); }


    }
}
