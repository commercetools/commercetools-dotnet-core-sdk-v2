using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountMatchQuery : IProductDiscountMatchQuery
    {
        public string ProductId { get; set;}
        
        public int VariantId { get; set;}
        
        public bool Staged { get; set;}
        
        public IQueryPrice Price { get; set;}
    }
}
