using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [Discriminator(nameof(Type))]
    public abstract partial class ProductDiscountValueDraft 
    {
        public string Type { get; set;}
    }
}
