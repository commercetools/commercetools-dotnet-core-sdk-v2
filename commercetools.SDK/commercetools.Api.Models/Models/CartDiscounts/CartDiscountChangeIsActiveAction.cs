using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeIsActive")]
    public partial class CartDiscountChangeIsActiveAction : CartDiscountUpdateAction
    {
        public bool IsActive { get; set;}
        public CartDiscountChangeIsActiveAction()
        { 
           this.Action = "changeIsActive";
        }
    }
}
