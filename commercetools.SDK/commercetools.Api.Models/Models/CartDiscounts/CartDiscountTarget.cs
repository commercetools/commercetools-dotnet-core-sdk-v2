using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [Discriminator(nameof(Type))]
    public abstract partial class CartDiscountTarget 
    {
        public string Type { get; set;}
    }
}
