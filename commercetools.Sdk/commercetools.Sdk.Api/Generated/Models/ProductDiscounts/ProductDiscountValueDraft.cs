using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public abstract partial class ProductDiscountValueDraft : IProductDiscountValueDraft
    {
        public string Type { get; set;}
    }
}
