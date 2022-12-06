using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemsOrderAction))]
    public partial interface IMyShoppingListChangeTextLineItemsOrderAction : IMyShoppingListUpdateAction
    {
        IList<string> TextLineItemOrder { get; set; }
        IEnumerable<string> TextLineItemOrderEnumerable { set => TextLineItemOrder = value.ToList(); }


    }
}
