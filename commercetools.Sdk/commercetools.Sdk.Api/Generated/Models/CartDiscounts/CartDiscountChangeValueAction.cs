using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountChangeValueAction : ICartDiscountChangeValueAction
    {
        public string Action { get; set; }

        public ICartDiscountValueDraft Value { get; set; }
        public CartDiscountChangeValueAction()
        {
            this.Action = "changeValue";
        }
    }
}
