using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsAction))]
    public partial interface ICartApplyDeltaToLineItemShippingDetailsTargetsAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        IList<IItemShippingTarget> TargetsDelta { get; set; }
        IEnumerable<IItemShippingTarget> TargetsDeltaEnumerable { set => TargetsDelta = value.ToList(); }


    }
}
