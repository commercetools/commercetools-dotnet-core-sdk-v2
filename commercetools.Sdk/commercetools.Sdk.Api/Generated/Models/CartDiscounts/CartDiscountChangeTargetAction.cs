using commercetools.Sdk.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountChangeTargetAction : ICartDiscountChangeTargetAction
    {
        public string Action { get; set; }

        public ICartDiscountTarget Target { get; set; }
        public CartDiscountChangeTargetAction()
        {
            this.Action = "changeTarget";
        }
    }
}
