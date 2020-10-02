using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("changeCartDiscounts")]
    public partial class DiscountCodeChangeCartDiscountsAction : DiscountCodeUpdateAction
    {
        public List<CartDiscountResourceIdentifier> CartDiscounts { get; set;}
        public DiscountCodeChangeCartDiscountsAction()
        { 
           this.Action = "changeCartDiscounts";
        }
    }
}
