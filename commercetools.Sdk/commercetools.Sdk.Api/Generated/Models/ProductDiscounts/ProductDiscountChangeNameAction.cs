using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductDiscounts
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
