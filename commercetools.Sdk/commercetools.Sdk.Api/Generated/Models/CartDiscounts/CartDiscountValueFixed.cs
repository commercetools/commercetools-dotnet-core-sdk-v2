using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public partial class CartDiscountValueFixed : ICartDiscountValueFixed
    {
        public string Type { get; set; }

        public List<ICentPrecisionMoney> Money { get; set; }
        public CartDiscountValueFixed()
        {
            this.Type = "fixed";
        }
    }
}
