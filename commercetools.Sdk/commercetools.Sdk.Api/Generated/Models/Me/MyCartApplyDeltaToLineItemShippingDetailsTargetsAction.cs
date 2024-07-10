using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartApplyDeltaToLineItemShippingDetailsTargetsAction : IMyCartApplyDeltaToLineItemShippingDetailsTargetsAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IList<IItemShippingTarget> TargetsDelta { get; set; }
        public IEnumerable<IItemShippingTarget> TargetsDeltaEnumerable { set => TargetsDelta = value.ToList(); }

        public MyCartApplyDeltaToLineItemShippingDetailsTargetsAction()
        {
            this.Action = "applyDeltaToLineItemShippingDetailsTargets";
        }
    }
}
