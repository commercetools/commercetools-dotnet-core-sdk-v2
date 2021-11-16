namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountChangeValueAction : IProductDiscountChangeValueAction
    {
        public string Action { get; set; }

        public IProductDiscountValueDraft Value { get; set; }
        public ProductDiscountChangeValueAction()
        {
            this.Action = "changeValue";
        }
    }
}
