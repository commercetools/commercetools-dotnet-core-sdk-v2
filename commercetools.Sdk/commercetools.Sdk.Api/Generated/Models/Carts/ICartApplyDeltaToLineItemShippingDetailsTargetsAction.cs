using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsAction))]
    public partial interface ICartApplyDeltaToLineItemShippingDetailsTargetsAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        List<IItemShippingTarget> TargetsDelta { get; set; }
    }
}
