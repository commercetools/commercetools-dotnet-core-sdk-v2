using commercetools.Sdk.Api.Models.Carts;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartApplyDeltaToLineItemShippingDetailsTargetsAction))]
    public partial interface IMyCartApplyDeltaToLineItemShippingDetailsTargetsAction : IMyCartUpdateAction
    {
        string LineItemId { get; set; }

        IList<IItemShippingTarget> TargetsDelta { get; set; }
        IEnumerable<IItemShippingTarget> TargetsDeltaEnumerable { set => TargetsDelta = value.ToList(); }


    }
}
