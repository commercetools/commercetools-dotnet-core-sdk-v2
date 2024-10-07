using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportLineItemStateAction))]
    public partial interface IStagedOrderImportLineItemStateAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        IList<IItemState> State { get; set; }

        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }

    }
}
