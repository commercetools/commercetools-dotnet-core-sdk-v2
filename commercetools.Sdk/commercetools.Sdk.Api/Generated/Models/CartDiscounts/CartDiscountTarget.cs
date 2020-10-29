using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public abstract partial class CartDiscountTarget : ICartDiscountTarget
    {
        public string Type { get; set;}
    }
}
