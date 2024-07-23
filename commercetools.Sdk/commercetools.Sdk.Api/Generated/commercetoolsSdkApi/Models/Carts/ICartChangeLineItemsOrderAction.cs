using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangeLineItemsOrderAction))]
    public partial interface ICartChangeLineItemsOrderAction : ICartUpdateAction
    {
        IList<string> LineItemOrder { get; set; }
        IEnumerable<string> LineItemOrderEnumerable { set => LineItemOrder = value.ToList(); }


    }
}
