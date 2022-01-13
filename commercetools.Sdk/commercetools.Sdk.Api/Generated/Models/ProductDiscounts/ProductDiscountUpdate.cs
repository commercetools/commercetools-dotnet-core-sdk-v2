using System.Collections.Generic;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountUpdate : IProductDiscountUpdate
    {
        public long Version { get; set; }

        public List<IProductDiscountUpdateAction> Actions { get; set; }
    }
}
