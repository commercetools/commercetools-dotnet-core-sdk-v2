using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountChangeStackingModeAction : ICartDiscountChangeStackingModeAction
    {
        public string Action { get; set; }

        public IStackingMode StackingMode { get; set; }
        public CartDiscountChangeStackingModeAction()
        {
            this.Action = "changeStackingMode";
        }
    }
}
