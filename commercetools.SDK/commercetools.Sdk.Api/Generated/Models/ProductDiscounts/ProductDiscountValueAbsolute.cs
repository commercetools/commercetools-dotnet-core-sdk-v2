using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("absolute")]
    public partial class ProductDiscountValueAbsolute : ProductDiscountValue
    {
        public List<TypedMoney> Money { get; set;}
        public ProductDiscountValueAbsolute()
        { 
           this.Type = "absolute";
        }
    }
}
