namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountChangeSortOrderAction : IProductDiscountChangeSortOrderAction
    {
        public string Action { get; set; }

        public string SortOrder { get; set; }
        public ProductDiscountChangeSortOrderAction()
        {
            this.Action = "changeSortOrder";
        }
    }
}
