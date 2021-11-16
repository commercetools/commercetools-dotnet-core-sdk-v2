using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountValueAbsolute : IProductDiscountValueAbsolute
    {
        public string Type { get; set; }

        public List<ITypedMoney> Money { get; set; }
        public ProductDiscountValueAbsolute()
        {
            this.Type = "absolute";
        }
    }
}
