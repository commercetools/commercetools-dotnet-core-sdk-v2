using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("setValidUntil")]
    public partial class CartDiscountSetValidUntilAction : CartDiscountUpdateAction
    {
        public DateTime ValidUntil { get; set;}
        public CartDiscountSetValidUntilAction()
        { 
           this.Action = "setValidUntil";
        }
    }
}
