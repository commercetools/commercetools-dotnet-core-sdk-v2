using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsAction))]
    public partial interface ICartApplyDeltaToLineItemShippingDetailsTargetsAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        List<IItemShippingTarget> TargetsDelta { get; set; }
    }
}
