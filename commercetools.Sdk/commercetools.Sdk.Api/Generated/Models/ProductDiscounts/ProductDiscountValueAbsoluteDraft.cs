using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountValueAbsoluteDraft : IProductDiscountValueAbsoluteDraft
    {
        public string Type { get; set; }

        public List<IMoney> Money { get; set; }
        public ProductDiscountValueAbsoluteDraft()
        {
            this.Type = "absolute";
        }
    }
}
