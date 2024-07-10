using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetDirectDiscountsAction : IStagedOrderSetDirectDiscountsAction
    {
        public string Action { get; set; }

        public IList<IDirectDiscountDraft> Discounts { get; set; }
        public IEnumerable<IDirectDiscountDraft> DiscountsEnumerable { set => Discounts = value.ToList(); }

        public StagedOrderSetDirectDiscountsAction()
        {
            this.Action = "setDirectDiscounts";
        }
    }
}
