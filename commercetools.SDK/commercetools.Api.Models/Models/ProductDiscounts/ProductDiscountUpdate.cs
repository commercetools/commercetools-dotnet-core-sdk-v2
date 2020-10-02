using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountUpdate 
    {
        public long Version { get; set;}
        
        public List<ProductDiscountUpdateAction> Actions { get; set;}
    }
}
