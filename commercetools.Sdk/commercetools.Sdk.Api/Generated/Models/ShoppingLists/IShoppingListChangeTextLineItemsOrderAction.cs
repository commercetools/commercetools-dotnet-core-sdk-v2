using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemsOrderAction))]
    public partial interface IShoppingListChangeTextLineItemsOrderAction : IShoppingListUpdateAction
    {
        IList<string> TextLineItemOrder { get; set; }
        IEnumerable<string> TextLineItemOrderEnumerable { set => TextLineItemOrder = value.ToList(); }


    }
}
