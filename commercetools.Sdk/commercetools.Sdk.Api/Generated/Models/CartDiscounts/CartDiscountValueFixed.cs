using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountValueFixed : ICartDiscountValueFixed
    {
        public string Type { get; set;}
        
        public List<ITypedMoney> Money { get; set;}
        public CartDiscountValueFixed()
        { 
           this.Type = "fixed";
        }
    }
}
