using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction))]
    public partial interface ICartApplyDeltaToCustomLineItemShippingDetailsTargetsAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        IList<IItemShippingTarget> TargetsDelta { get; set; }

        IEnumerable<IItemShippingTarget> TargetsDeltaEnumerable { set => TargetsDelta = value.ToList(); }

    }
}
