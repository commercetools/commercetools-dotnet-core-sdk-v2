using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
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
