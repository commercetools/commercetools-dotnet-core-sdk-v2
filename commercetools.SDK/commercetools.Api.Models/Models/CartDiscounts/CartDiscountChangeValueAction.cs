using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeValue")]
    public partial class CartDiscountChangeValueAction : CartDiscountUpdateAction
    {
        public CartDiscountValueDraft Value { get; set;}
        public CartDiscountChangeValueAction()
        { 
           this.Action = "changeValue";
        }
    }
}
