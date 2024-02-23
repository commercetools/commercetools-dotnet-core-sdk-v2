namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountSetKeyAction : IProductDiscountSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ProductDiscountSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
