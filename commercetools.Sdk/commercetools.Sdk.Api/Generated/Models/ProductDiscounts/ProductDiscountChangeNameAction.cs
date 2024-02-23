using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountChangeNameAction : IProductDiscountChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public ProductDiscountChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
