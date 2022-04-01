using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemsOrderAction))]
    public partial interface IMyShoppingListChangeTextLineItemsOrderAction : IMyShoppingListUpdateAction
    {
        List<string> TextLineItemOrder { get; set; }
    }
}
