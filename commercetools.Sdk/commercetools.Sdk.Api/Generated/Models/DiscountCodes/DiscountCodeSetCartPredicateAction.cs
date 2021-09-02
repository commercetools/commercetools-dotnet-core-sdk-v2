using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetCartPredicateAction : IDiscountCodeSetCartPredicateAction
    {
        public string Action { get; set; }

        public string CartPredicate { get; set; }
        public DiscountCodeSetCartPredicateAction()
        {
            this.Action = "setCartPredicate";
        }
    }
}
