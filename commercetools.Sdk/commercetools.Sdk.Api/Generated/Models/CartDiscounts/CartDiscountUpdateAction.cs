using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public abstract partial class CartDiscountUpdateAction : ICartDiscountUpdateAction
    {
        public string Action { get; set;}
    }
}
