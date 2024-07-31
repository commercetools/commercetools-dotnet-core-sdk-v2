using System;

namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountSetValidUntilAction : IProductDiscountSetValidUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidUntil { get; set; }
        public ProductDiscountSetValidUntilAction()
        {
            this.Action = "setValidUntil";
        }
    }
}
