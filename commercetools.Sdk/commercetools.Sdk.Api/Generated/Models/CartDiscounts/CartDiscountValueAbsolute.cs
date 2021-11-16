using commercetools.Api.Models.Common;
using System.Collections.Generic;


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
