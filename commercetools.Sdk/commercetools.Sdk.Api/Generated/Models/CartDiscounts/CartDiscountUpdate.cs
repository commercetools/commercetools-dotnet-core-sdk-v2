using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountUpdate : ICartDiscountUpdate
    {
        public long Version { get; set;}
        
        public List<ICartDiscountUpdateAction> Actions { get; set;}
    }
}
