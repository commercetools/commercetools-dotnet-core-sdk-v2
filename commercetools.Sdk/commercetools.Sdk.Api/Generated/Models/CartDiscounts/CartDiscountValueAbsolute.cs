using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountValueAbsolute : ICartDiscountValueAbsolute
    {
        public string Type { get; set;}
        
        public List<ITypedMoney> Money { get; set;}
        public CartDiscountValueAbsolute()
        { 
           this.Type = "absolute";
        }
    }
}
