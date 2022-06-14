using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public partial class CartDiscountValueAbsolute : ICartDiscountValueAbsolute
    {
        public string Type { get; set; }

        public List<ICentPrecisionMoney> Money { get; set; }
        public CartDiscountValueAbsolute()
        {
            this.Type = "absolute";
        }
    }
}
