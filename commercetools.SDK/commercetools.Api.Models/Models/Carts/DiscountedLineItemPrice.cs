using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class DiscountedLineItemPrice 
    {
        public TypedMoney Value { get; set;}
        
        public List<DiscountedLineItemPortion> IncludedDiscounts { get; set;}
    }
}
