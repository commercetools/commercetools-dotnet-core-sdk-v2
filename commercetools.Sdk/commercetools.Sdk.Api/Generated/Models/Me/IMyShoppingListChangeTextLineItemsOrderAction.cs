using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListChangeTextLineItemsOrderAction))]
    public partial interface IMyShoppingListChangeTextLineItemsOrderAction : IMyShoppingListUpdateAction
    {
        List<string> TextLineItemOrder { get; set;}
    }
}
