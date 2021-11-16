using System;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountSetValidFromAndUntilAction : IProductDiscountSetValidFromAndUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }
        public ProductDiscountSetValidFromAndUntilAction()
        {
            this.Action = "setValidFromAndUntil";
        }
    }
}
