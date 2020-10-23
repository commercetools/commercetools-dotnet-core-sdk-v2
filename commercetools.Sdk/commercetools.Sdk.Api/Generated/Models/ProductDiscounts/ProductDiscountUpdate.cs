using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public  partial class ProductDiscountUpdate : IProductDiscountUpdate
    {
        public long Version { get; set;}
        
        public List<IProductDiscountUpdateAction> Actions { get; set;}
    }
}
