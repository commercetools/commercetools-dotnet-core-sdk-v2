using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public abstract partial class ProductDiscountUpdateAction : IProductDiscountUpdateAction
    {
        public string Action { get; set;}
    }
}
