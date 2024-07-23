using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountSetDescriptionAction : IProductDiscountSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public ProductDiscountSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
