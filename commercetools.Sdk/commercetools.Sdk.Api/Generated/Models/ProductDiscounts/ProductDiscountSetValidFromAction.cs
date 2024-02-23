using System;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountSetValidFromAction : IProductDiscountSetValidFromAction
    {
        public string Action { get; set; }

        public DateTime? ValidFrom { get; set; }
        public ProductDiscountSetValidFromAction()
        {
            this.Action = "setValidFrom";
        }
    }
}
