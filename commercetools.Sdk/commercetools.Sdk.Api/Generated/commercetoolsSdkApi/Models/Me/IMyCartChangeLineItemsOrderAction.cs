using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartChangeLineItemsOrderAction))]
    public partial interface IMyCartChangeLineItemsOrderAction : IMyCartUpdateAction
    {
        IList<string> LineItemOrder { get; set; }

        IEnumerable<string> LineItemOrderEnumerable { set => LineItemOrder = value.ToList(); }

    }
}
