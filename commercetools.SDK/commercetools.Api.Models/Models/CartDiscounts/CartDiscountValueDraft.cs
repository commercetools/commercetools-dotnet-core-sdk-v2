using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [Discriminator(nameof(Type))]
    public abstract partial class CartDiscountValueDraft 
    {
        public string Type { get; set;}
    }
}
