using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListChangeLineItemsOrderAction))]
    public partial interface IMyShoppingListChangeLineItemsOrderAction : IMyShoppingListUpdateAction
    {
        List<string> LineItemOrder { get; set; }
    }
}
