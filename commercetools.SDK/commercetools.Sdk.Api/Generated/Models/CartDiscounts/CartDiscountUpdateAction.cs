using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [Discriminator(nameof(Action))]
    public abstract partial class CartDiscountUpdateAction 
    {
        public string Action { get; set;}
    }
}
