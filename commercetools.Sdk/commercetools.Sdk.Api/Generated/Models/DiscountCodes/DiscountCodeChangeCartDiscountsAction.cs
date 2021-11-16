using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeChangeCartDiscountsAction : IDiscountCodeChangeCartDiscountsAction
    {
        public string Action { get; set;}
        
        public List<ICartDiscountResourceIdentifier> CartDiscounts { get; set;}
        public DiscountCodeChangeCartDiscountsAction()
        { 
           this.Action = "changeCartDiscounts";
        }
    }
}
