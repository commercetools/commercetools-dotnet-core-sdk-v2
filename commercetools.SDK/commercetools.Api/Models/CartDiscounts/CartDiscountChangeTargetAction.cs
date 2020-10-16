using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeTarget")]
    public partial class CartDiscountChangeTargetAction : CartDiscountUpdateAction
    {
        public CartDiscountTarget Target { get; set;}
        public CartDiscountChangeTargetAction()
        { 
           this.Action = "changeTarget";
        }
    }
}
